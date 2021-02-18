Option Strict Off
Option Explicit On
Module Point
    Public Function MySTAR(ByRef no_kartu As String) As Object
        Dim RsMySTAR As New DataSet

        StrSQL = "select * from Members where Member_Code = '" & no_kartu & "' and Status='A'"

        If VPing = "ONLINE" Then
            RsMySTAR = getSqldb(StrSQL, ConnServer)
        Else
            RsMySTAR = getSqldb(StrSQL, ConnLocal)
        End If

        If RsMySTAR.Tables(0).Rows.Count > 0 Then
            Star_Pt = 0
            Star_Nm = RsMySTAR.Tables(0).Rows(0).Item("Member_Name").ToString
            If RsMySTAR.Tables(0).Rows(0).Item("Member_Code").ToString = "LM-00000000" Then
                Star_Id = "10000000"
            Else
                Star_Id = Replace(RsMySTAR.Tables(0).Rows(0).Item("Member_Code").ToString, "LM-", "")
            End If

            Star_Freq = 0
            Star_Ext1 = 0
            Star_Omz = 0
            Star_Phone = RsMySTAR.Tables(0).Rows(0).Item("Phone").ToString
            Star_Email = RsMySTAR.Tables(0).Rows(0).Item("Email").ToString
            Star_updsts = 0
            Exp_Point = 0
            Expired_Date = 0
        Else
            Star_Pt = 0
            Star_Nm = "ONE TIME CUSTOMER"
            Star_Id = "10000000"
            Star_Freq = ""
            Star_Omz = ""
            Star_Phone = ""
            Star_Email = ""
            Star_updsts = 9
            Exp_Point = ""
            Expired_Date = ""
            MsgBox("No Kartu tidak terdaftar / expired" & vbNewLine & "Mohon hubungi information counter", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
        End If
        Return no_kartu
    End Function

    Public Function Get_Point(ByRef NoTrans As String) As Short
        Dim RsPoint As New DataSet
        Dim RsPointBank As New DataSet
        Dim RsKartuKredit As New DataSet
        Dim Npoin, Belanja, NVoc As Integer
        Dim Hari, Kali_Point As Byte

        Hari = IIf(Weekday(GetSrvDate) = 1, 7, Weekday(GetSrvDate) - 1)



        RsPoint = getSqldb("SELECT isnull(Amount,0) as amount, substring(active_day," & Hari & ",1) as act_day FROM Cust_Option WHERE (Card_Type = 'CM') ", ConnLocal)
        If RsPoint.Tables(0).Rows.Count > 0 Then
            Npoin = IIf(RsPoint.Tables(0).Rows(0).Item("act_day") = "1", RsPoint.Tables(0).Rows(0).Item("Amount"), 0)
        Else
            Npoin = 0
        End If
        RsPoint.Clear()

        RsPoint = getSqldb("select card_number, net_price, Point_Of_Card_Program from sales_transactions where transaction_number = '" & NoTrans & "'", ConnLocal)
        Belanja = RsPoint.Tables(0).Rows(0).Item("Net_Price")
        Kali_Point = RsPoint.Tables(0).Rows(0).Item("Point_Of_Card_Program")
        If Left(RsPoint.Tables(0).Rows(0).Item("card_number"), 5) = "CM999" Then Npoin = 0
        RsPoint.Clear()

        RsPoint = getSqldb("select isnull(SUM(net_price),0) as rvoc from sales_transaction_details sd inner join item_master im on sd.PLU=im.PLU " & "where Burui ='NMD92ZZZ9' and Transaction_Number ='" & NoTrans & "'", ConnLocal)
        NVoc = RsPoint.Tables(0).Rows(0).Item("RVoc")
        RsPoint.Clear()
        RsPoint = Nothing

        If Npoin > 0 Then
            Get_Point = roundDown((Belanja - NVoc) / Npoin) * Kali_Point
        Else
            Get_Point = 0
        End If
    End Function

    Public Function roundDown(ByRef dblValue As Double) As Double
        On Error GoTo ErrH
        Dim myDec As Integer

        myDec = InStr(1, CStr(dblValue), ".", CompareMethod.Text)
        If myDec > 0 Then
            roundDown = CDbl(Left(CStr(dblValue), myDec))
        Else
            roundDown = dblValue
        End If
        Exit Function

ErrH:
        MsgBox(Err.Description, MsgBoxStyle.Information, "Round Down")
    End Function

    Public Function Pay_Point(ByRef JmlPoint As Short, ByRef NoCard As String, ByRef NoTrx As String, ByRef rupiah As Integer) As String
        On Error GoTo ErrH
        Dim urut As String

        urut = Gen_Kode("TW")

        'ConnLocal.BeginTrans()
        'ConnServer.BeginTrans()

        getSqldb("insert into Cust_Point_Trans(Transaction_number, trans_nr, card_nr, current_point, Claim_Point, Claim_Rp, Date_Trans, User_ID, " & "Data_Status) values ('" & NoTrx & "', '" & urut & "', '" & NoCard & "', " & Star_Pt & ", " & JmlPoint & ", " & rupiah & ", getdate(), '" & VKasir_ID & "', '99') ", ConnLocal)

        getSqldb("insert into Cust_Point_Trans(Transaction_number, trans_nr, card_nr, current_point, Claim_Point, Claim_Rp, Date_Trans, User_ID, " & "Data_Status) values ('" & NoTrx & "', '" & urut & "', '" & NoCard & "', " & Star_Pt & ", " & JmlPoint & ", " & rupiah & ", getdate(), '" & VKasir_ID & "', '99') ", ConnServer)

        getSqldb("Update card set card_point=card_point - " & JmlPoint & "where card_nr = '" & NoCard & "'", ConnLocal)
        getSqldb("Update card set card_point=card_point - " & JmlPoint & "where card_nr = '" & NoCard & "'", ConnServer)

        StrSQL = ""

        'ConnLocal.CommitTrans()
        'ConnServer.CommitTrans()

        Pay_Point = urut
        Call MySTAR(NoCard)
        Exit Function

ErrH:
        'ConnLocal.RollbackTrans()
        'ConnServer.RollbackTrans()
        Pay_Point = "GAGAL"
    End Function

    Private Function Gen_Kode(ByRef kode As String) As String
        Dim RsCari As New DataSet
        Dim Depan As String = ""

        Select Case kode
            Case "TM"
                Depan = "TM" & Right(VBranch_ID, 3) & VReg_ID & Format(GetSrvDate, "YYMMDD")

                StrSQL = "SELECT  max (CAST(RIGHT(custtrans_nr, 4) AS int)) AS nomor " & "FROM Customer_Transaction_H_MemberCard where left(custtrans_nr,14)='" & Depan & "'"
            Case "TW"
                Depan = "TW" & Right(VBranch_ID, 3) & VReg_ID & Format(GetSrvDate, "YYYYMMDD")

                StrSQL = "SELECT  max (CAST(RIGHT(trans_nr, 4) AS int)) AS nomor " & "FROM Cust_Point_Trans where left(trans_nr,16)='" & Depan & "'"
        End Select


        RsCari = getSqldb(StrSQL, ConnLocal)

        If IsDBNull(RsCari.Tables(0).Rows(0).Item("nomor")) Then
            Gen_Kode = Depan & "0001"
        Else
            Gen_Kode = Depan & Right("000" & CStr(RsCari.Tables(0).Rows(0).Item("nomor") + 1), 4)
        End If

        RsCari.Clear()
        RsCari = Nothing
    End Function

    Public Sub Save_Point(ByRef NoTrans As String, ByRef NoCard As String)
        On Error GoTo ErrH
        Dim zz As Short
        Dim urut As String

        zz = Get_Point(NoTrans)
        urut = Gen_Kode("TM")
        'If Linked() Then
        '    getSqldb("update card set card_point=card_point+" & zz & " where card_nr = '" & NoCard & "'", ConnServer)
        'Else
        '    getSqldb("update card set card_point=card_point+" & zz & " where card_nr = '" & NoCard & "'", ConnLocal)
        'End If
        'tanpa cek PING
        If VPing = "ONLINE" Then
            getSqldb("update card set card_point=card_point+" & zz & " where card_nr = '" & NoCard & "'", ConnServer)
        Else
            getSqldb("update card set card_point=card_point+" & zz & " where card_nr = '" & NoCard & "'", ConnLocal)
        End If
        StrSQL = "insert into Customer_Transaction_H_MemberCard(CustTrans_Nr, CustTrans_Date, Card_Nr, CustTrans_TotAmount," & "CustTrans_Point, User_ID, Trans_Time, Data_Status) " & "(select '" & urut & "', transaction_date, card_number, net_price, " & zz & ", cashier_id, transaction_time, '00' " & "from Sales_Transactions where Transaction_Number = '" & NoTrans & "')"
        getSqldb(StrSQL, ConnLocal)

        If Linked Then
            getSqldb(StrSQL, ConnServer)
            getSqldb("Update Customer_Transaction_H_MemberCard set data_status='99' where custtrans_nr = '" & urut & "'", ConnLocal)
        End If

        StrSQL = "insert into Customer_Transaction_D_MemberCard(CustTrans_Nr, CustTrans_Struk, CustTrans_Amount, Data_Status)" & "select '" & urut & "', Transaction_Number, net_price, '00'" & "from Sales_Transactions where Transaction_Number = '" & NoTrans & "'"
        getSqldb(StrSQL, ConnLocal)

        If Linked Then
            getSqldb(StrSQL, ConnServer)
            getSqldb("Update Customer_Transaction_d_MemberCard set data_status='99' where custtrans_nr = '" & urut & "'", ConnLocal)
        End If


        StrSQL = ""
        Call MySTAR(NoCard)
        MsgBox("Point bertambah : " & zz & vbNewLine & "Saldo Akhir Point : " & Star_Pt, MsgBoxStyle.Information, "Oops..")
        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Oops..")
        Call SaveLog("Save_Point " & Err.Description & " " & Err.Number)
    End Sub
End Module
