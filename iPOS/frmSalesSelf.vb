Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
'Imports RACReaderAPI
'Imports RACReaderAPI.MyInterface
'Imports RACReaderAPI.Models
Imports Symbol.RFID3
Imports Symbol.RFID3.TagAccess.Sequence
Imports Symbol.RFID3.Events
Imports System.ComponentModel

Public Class frmSalesSelf
    Inherits System.Windows.Forms.Form
    'Implements IAsynchronousMessage
    Dim Qty() As String
    Dim dsSales As New DataSet
    Dim PLU_SPG As String
    Dim VTukar_Point As String
    Dim TxtNom As Short
    Dim xdisc_value As Integer
    'Shared param_Set As Param_Set = New Param_Set()
    Friend m_ReaderAPI As RFIDReader
    'Shared rfid_Option As RFID_Option = New RFID_Option()
    Public m_TagTable As Hashtable
    Private m_UpdateStatusHandler As UpdateStatus = Nothing
    Private m_UpdateReadHandler As UpdateRead = Nothing
    Dim RFIDStatus As Boolean
    Private rowIndex As Integer = 0
    Dim awal As Boolean = True
    Public Sub Update_MySTAR()
        Dim RsMem As New DataSet

        RsMem = getSqldb("select card_number, point_of_card_program from sales_transactions where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
        If RsMem.Tables(0).Rows.Count > 0 Then Call MySTAR(Trim(RsMem.Tables(0).Rows(0).Item("card_number")))
        txtcard_no.Text = UCase(RsMem.Tables(0).Rows(0).Item("card_number"))
        Star_No = UCase(RsMem.Tables(0).Rows(0).Item("card_number"))

        txtcust_name.Text = Star_Nm
        txtcust_id.Text = Star_Id
        'txtpoint.Text = CStr(Star_Pt)
        VBonus_Point = RsMem.Tables(0).Rows(0).Item("Point_Of_Card_Program")
        RsMem.Clear()
        RsMem = Nothing
    End Sub



    Private Function Gen_No() As String
        Dim RsCari As New DataSet

        RsCari = getSqldb("SELECT  max (CAST(RIGHT(Transaction_Number, 4) AS int)) AS nomor " & "FROM Sales_Transactions where LEFT(transaction_number,16)='" & VBranch_ID & VReg_ID & "-" & Format(GetSrvDate, "ddMMyyyy") & "' ", ConnLocal)

        If IsDBNull(RsCari.Tables(0).Rows(0).Item("nomor")) Then
            Gen_No = VBranch_ID & VReg_ID & "-" & Format(GetSrvDate, "ddMMyyyy") & "-0001"
        Else
            Gen_No = VBranch_ID & VReg_ID & "-" & Format(GetSrvDate, "ddMMyyyy") & "-" & VB.Right("000" & CStr(RsCari.Tables(0).Rows(0).Item("nomor") + 1), 4)
        End If
        RsCari.Clear()
        RsCari = Nothing
    End Function


    'no1
    'Private Sub Bayar_Point()

    '    Dim RsByrPoint As New DataSet

    '    RsByrPoint = getSqldb("select SUM(qty*points_received) as byr_pt, SUM(qty*flag_void) as byr_rp from Sales_Transaction_Details where transaction_number='" & vno_trans.Text & "'", ConnLocal)

    '    If RsByrPoint.Tables(0).Rows.Count > 0 And RsByrPoint.Tables(0).Rows(0).Item("byr_pt") > 0 Then
    '        If RsByrPoint.Tables(0).Rows(0).Item("byr_pt") < Star_Pt Then
    '            VTukar_Point = Pay_Point(RsByrPoint.Tables(0).Rows(0).Item("byr_pt"), Star_No, vno_trans.Text, RsByrPoint.Tables(0).Rows(0).Item("byr_rp"))
    '            If VTukar_Point <> "GAGAL" Then
    '                getSqldb("Delete from paid where transaction_number='" & vno_trans.Text & "'", ConnLocal)

    '                getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, " & "Currency_Rate, Credit_Card_No, Credit_Card_Name, Paid_Amount, Shift) VALUES ('" & vno_trans.Text & "','5','1','IDR','1','" & Star_No & "','" & VTukar_Point & "'," & RsByrPoint.Tables(0).Rows(0).Item("byr_rp") & ",'" & VShift & "')", ConnLocal)

    '                VDiscBySTAR = RsByrPoint.Tables(0).Rows(0).Item("byr_rp")
    '            Else
    '                MsgBox("Pembayaran dengan point reward GAGAL", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
    '            End If
    '        Else
    '            MsgBox("Point reward tidak mencukupi untuk pembayaran", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
    '        End If
    '    End If
    '    RsByrPoint.Clear()
    '    RsByrPoint = Nothing
    'End Sub

    'no1
    'Private Function Cari_Item_Rewards(ByRef kode As Object) As String
    '    Dim RsCari As New DataSet

    '    RsCari = getSqldb("select plu, point, rupiah from item_rewards where plu = '" & Trim(kode) & "' and getdate() Between Start_Date And End_Date and aktif=1 ", ConnServer)

    '    If RsCari.Tables(0).Rows.Count > 0 Then
    '        If MsgBox("Apakah item ini akan dibayar dengan point rewards?", MsgBoxStyle.YesNo + MsgBoxStyle.OkOnly, "Oops..") = MsgBoxResult.Yes Then

    '            getSqldb("update sales_transaction_details set points_received='" & RsCari.Tables(0).Rows(0).Item("Point") & "' , flag_void='" & RsCari.Tables(0).Rows(0).Item("rupiah") & "' where plu='" & kode & "' and transaction_number='" & vno_trans.Text & "'", ConnLocal)
    '        End If
    '    End If

    '    RsCari.Clear()
    '    RsCari = Nothing
    '    Return kode
    'End Function
    Private Sub txtkode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkode.KeyDown
        Dim Cmd As String

        Dim CekPLU() As String
        Dim RealPLU As String
        Select Case e.KeyCode
            Case 13
                CekPLU = Split(txtkode.Text, "*")
                On Error GoTo ErrH
                If Len(CekPLU(0)) > 10 Then
                    RealPLU = CekPLU(0)
                Else
                    RealPLU = CekPLU(1)
                End If
                If Len(Trim(RealPLU)) > 14 Then

                Else
                    If Cari_PLU(VB.Right(Trim(RealPLU), 14)) = True Then
                        Dim dsCekPaid As New DataSet
                        Qty = Split(txtkode.Text, "*")
                        vqty.Text = IIf(Len(Qty(0)) > 10, 1, Qty(0))
                        If vqty.Text = "" Then vqty.Text = CStr(1)
                        If Me.Text = "REFUND" Then vqty.Text = CStr(CDbl(vqty.Text) * -1)

                        'vflag = 0 Barang Direct, vflag = 1 Barang Konsinyasi
                        'If CDbl(vflag.Text) = 0 And CDbl(vdisc1.Text) <> 0 And vpromo.Text <> "disc" Then
                        '    If Not Super(1) Then Exit Sub
                        'End If

                        VOK = False
                        If CDbl(vflag.Text) = 1 Then
                            Me.TopMost = False
                            frmHarga.ShowDialog()
                            frmHarga.TopMost = True
                        End If

                        'vdiscrp1.Text = CDec(CDbl(vqty.Text) * CDbl(vharga.Text) * CDbl(vdisc1.Text) / 100).ToString("N0")
                        'vdiscrp2.Text = CDec((CDbl(vqty.Text) * CDbl(vharga.Text) - CDbl(vdiscrp1.Text)) * CDbl(vdisc2.Text) / 100).ToString("N0")
                        vtotal.Text = CStr(CDbl(vqty.Text) * CDbl(vharga.Text))

                        If VOK = True Or CDbl(vflag.Text) = 0 Then
                            vgtotal.Text = CStr(Val(vgtotal.Text) + Val(vtotal.Text))
                            lblqty.Text = CStr(Val(Replace(lblqty.Text, " Pcs", "")) + CDbl(vqty.Text))
                            lblqty.Text = lblqty.Text & " pcs"
                            lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
                            dsCekPaid = getSqldb("SELECT * from paid where transaction_number = '" & vno_trans.Text & "' And Payment_types <> '31'", ConnLocal)
                            If dsCekPaid.Tables(0).Rows.Count > 0 Then
                                txtkode.Focus()
                                Exit Sub
                            End If
                            Call Simpan_Header()
                            Call Simpan_Detail()
                            Call CDisplay(VB.Left(vdesc.Text, 20), VB.Left(CStr(vqty.Text) & " pcs Rp. " & CDec(vgtotal.Text).ToString("N0"), 20))
                            'PEMBAYARAN DENGAN POINT REWARDS
                            'no1
                            'If Star_No <> "CM000-00000" Then
                            '    If Linked() Then Call Cari_Item_Rewards((txtkode.Text))
                            'End If
                        End If
                        ViewRelease(vno_trans.Text)

                    End If
                End If
                System.Windows.Forms.SendKeys.Send("{home}+{end}")
                txtkode.Focus()
                GoTo 1
ErrH:
                MsgBox("PLU tidak terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                System.Windows.Forms.SendKeys.Send("{home}+{end}")
                txtkode.Focus()
            Case 27
                Call Kosong()
            Case 38
                'Grid1.MovePrevious()
            Case 40
                'Grid1.MoveNext()
            Case Else
                On Error Resume Next
                Cmd = KeyStroke(e.KeyCode)
        End Select
1:
        If e.KeyCode = Keys.Enter Then
            'Menghilangkan Bunyi Beep
            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub
    Public Sub ViewRelease(ByVal no As String)

        dsSales.Clear()
        dsSales = getSqldb("SELECT Seq, Flag_Paket_Discount, RTRIM(PLU) As PLU, Item_Description, Price, Qty, Discount_Percentage, " &
                           "Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, flag_void,RTRIM(Epc_Code) as Epc_Code FROM Sales_Transaction_Details " &
                           "where transaction_number='" & no & "'", ConnLocal)
        If dsSales.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = dsSales.Tables(0)
            DataGridView1.Columns(0).HeaderText = "No"
            DataGridView1.Columns(0).Width = 30
            DataGridView1.Columns(1).HeaderText = "SPG"
            DataGridView1.Columns(1).Width = 40
            'DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).HeaderText = "PLU"
            DataGridView1.Columns(2).Width = 90
            DataGridView1.Columns(3).HeaderText = "Deskripsi"
            DataGridView1.Columns(3).Width = 130
            DataGridView1.Columns(4).HeaderText = "Harga"
            DataGridView1.Columns(4).Width = 60
            DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
            DataGridView1.Columns(5).HeaderText = "Qty"
            DataGridView1.Columns(5).Width = 30
            DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"
            DataGridView1.Columns(6).HeaderText = "Disc1"
            DataGridView1.Columns(6).Width = 40
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(6).DefaultCellStyle.Format = "N0"
            DataGridView1.Columns(7).HeaderText = "Disc"
            DataGridView1.Columns(7).Width = 50
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(7).DefaultCellStyle.Format = "N0"
            DataGridView1.Columns(8).HeaderText = "Disc2"
            DataGridView1.Columns(8).Width = 40
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(8).DefaultCellStyle.Format = "N0"
            DataGridView1.Columns(9).HeaderText = "Disc2 Rp"
            DataGridView1.Columns(9).Width = 80
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(9).DefaultCellStyle.Format = "N0"
            DataGridView1.Columns(10).HeaderText = "Jumlah"
            DataGridView1.Columns(10).Width = 70
            DataGridView1.Columns(10).DefaultCellStyle.Format = "N0"
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            Call Kosong()
            vgtotal.Text = CStr(0)
            lblqty.Text = CStr(0)
            If dsSales.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In dsSales.Tables(0).Rows
                    vgtotal.Text = vgtotal.Text + ro("Net_Price")
                    lblqty.Text = Val(Replace(lblqty.Text, " pcs", "")) + ro("Qty")
                Next
            End If
            lblqty.Text = lblqty.Text & " pcs"
            lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
            txtkode.Select()
            txtkode.Focus()
        End If
    End Sub
    Public Sub Simpan_Header()
        On Error GoTo ErrH
        Dim RsCari As New DataSet

        RsCari = getSqldb("SELECT Transaction_Number FROM Sales_Transactions where transaction_number='" & vno_trans.Text & "' ", ConnLocal)

        If RsCari.Tables(0).Rows.Count = 0 Then
            StrSQL = "INSERT INTO Sales_Transactions(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " &
            "Transaction_Date, Total_Discount, " & "Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " &
            "Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, " & "Net_Amount, Change_Amount, " &
            "Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " &
            "Last_Point, " & "Get_Point, Status, Upload_Status, Transaction_Time, Store_Type)" & "" &
            "VALUES ('" & vno_trans.Text & "','" & VKasir_ID & "','" & txtcust_id.Text & "','" & txtcard_no.Text & "'," &
            "'0','" & GetSrvDate.Date & "',0,0,0," & VBonus_Point & ",'','" & VBranch_ID & "','" & VReg_ID & "'," &
            "0,0,0," & vgtotal.Text & ",0,0,0,'" & IIf(Me.Text.Trim = "SALES", 0, 1) & "','',NULL,'',0,0,'01','00'," &
            "'" & Format(GetSrvDate, "HH:mm") & "','1')"
        Else
            StrSQL = "update sales_transactions set net_amount=" & vgtotal.Text & ", card_number='" & txtcard_no.Text & "'," &
            "customer_id='" & txtcust_id.Text & "', Point_Of_Card_Program=" & VBonus_Point & " where " &
            "transaction_number='" & vno_trans.Text & "' "
        End If
        Call SaveLog(Me.Name & " " & "Simpan_Header " & vno_trans.Text & " " & " " & Format(Now, "HH:mm:ss"))
0:
        getSqldb(StrSQL, ConnLocal)
        RsCari.Clear()
        RsCari = Nothing
        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Simpan_Header " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub

    Public Sub Simpan_HeaderRFID()
        On Error GoTo ErrH
        Dim RsCari As New DataSet
        vqty.Text = vqtyRFID
        vdiscrp1.Text = vdiscrp1RFID
        vdiscrp2.Text = vdiscrp2RFID
        vtotal.Text = vtotalRFID
        vgtotal.Text = vgtotalRFID
        txtcust_id.Text = txtcust_idRFID
        RsCari = getSqldb("SELECT Transaction_Number FROM Sales_Transactions where transaction_number='" & vno_transRFID & "' ", ConnLocal)

        If RsCari.Tables(0).Rows.Count = 0 Then
            StrSQL = "INSERT INTO Sales_Transactions(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " &
            "Transaction_Date, Total_Discount, " & "Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " &
            "Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, " & "Net_Amount, Change_Amount, " &
            "Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " &
            "Last_Point, " & "Get_Point, Status, Upload_Status, Transaction_Time, Store_Type)" & "" &
            "VALUES ('" & vno_transRFID & "','" & VKasir_ID & "','" & txtcust_id.Text & "','" & txtcard_no.Text & "'," &
            "'0','" & GetSrvDate.Date & "',0,0,0," & VBonus_Point & ",'','" & VBranch_ID & "','" & VReg_ID & "'," &
            "0,0,0," & vgtotal.Text & ",0,0,0,'" & IIf(Me.Text.Trim = "SALES", 0, 1) & "','',NULL,'',0,0,'01','00'," &
            "'" & Format(GetSrvDate, "HH:mm") & "','1')"
        Else
            StrSQL = "update sales_transactions set net_amount=" & vgtotal.Text & ", card_number='" & txtcard_no.Text & "'," &
            "customer_id='" & txtcust_id.Text & "', Point_Of_Card_Program=" & VBonus_Point & " where " &
            "transaction_number='" & vno_transRFID & "' "
        End If
0:
        getSqldb(StrSQL, ConnLocal)
        Call SaveLog(Me.Name & " " & "Simpan_Header_Rapid " & vno_trans.Text & " " & " " & Format(Now, "HH:mm:ss"))
        RsCari.Clear()
        RsCari = Nothing
        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Simpan_Header_Rapid " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub

    Public Sub Simpan_HeaderRFIDZebra()
        On Error GoTo ErrH
        Dim RsCari As New DataSet
        vqty.Text = vqtyRFID
        vdiscrp1.Text = vdiscrp1RFID
        vdiscrp2.Text = vdiscrp2RFID
        vtotal.Text = vtotalRFID
        vgtotal.Text = vgtotalRFID
        RsCari = getSqldb("SELECT Transaction_Number FROM Sales_Transactions where transaction_number='" & vno_trans.Text & "' ", ConnLocal)

        If RsCari.Tables(0).Rows.Count = 0 Then
            StrSQL = "INSERT INTO Sales_Transactions(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " &
            "Transaction_Date, Total_Discount, " & "Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " &
            "Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, " & "Net_Amount, Change_Amount, " &
            "Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " &
            "Last_Point, " & "Get_Point, Status, Upload_Status, Transaction_Time, Store_Type)" & "" &
            "VALUES ('" & vno_trans.Text & "','" & VKasir_ID & "','" & txtcust_id.Text & "','" & txtcard_no.Text & "'," &
            "'0','" & GetSrvDate.Date & "',0,0,0," & VBonus_Point & ",'','" & VBranch_ID & "','" & VReg_ID & "'," &
            "0,0,0," & vgtotal.Text & ",0,0,0,'" & IIf(Me.Text.Trim = "SALES", 0, 1) & "','',NULL,'',0,0,'01','00'," &
            "'" & Format(GetSrvDate, "HH:mm") & "','1')"
        Else
            StrSQL = "update sales_transactions set net_amount=" & vgtotal.Text & ", card_number='" & txtcard_no.Text & "'," &
            "customer_id='" & txtcust_id.Text & "', Point_Of_Card_Program=" & VBonus_Point & " where " &
            "transaction_number='" & vno_trans.Text & "' "
        End If
0:
        getSqldb(StrSQL, ConnLocal)
        Call SaveLog(Me.Name & " " & "Simpan_Header_Zebra " & vno_trans.Text & " " & " " & Format(Now, "HH:mm:ss"))
        RsCari.Clear()
        RsCari = Nothing
        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Simpan_Header_Zebra " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub

    Private Function Gen_Seq(ByVal no As String) As String
        Dim RsCari As New DataSet

        RsCari = getSqldb("select ISNULL(MAX(seq),0) as urut from Sales_Transaction_Details where Transaction_Number = '" & no & "'", ConnLocal)
        Gen_Seq = RsCari.Tables(0).Rows(0).Item("urut") + 1
        RsCari.Clear()
        RsCari = Nothing
    End Function
    Private Function Siapa_SPG(ByRef kode As Object) As String
        Dim RsCari As New DataSet

        RsCari = getSqldb("select spg_id, spg_name from spg where spg_id = '" & Trim(kode) & "'", ConnLocal)

        Siapa_SPG = IIf(RsCari.Tables(0).Rows.Count > 0, RsCari.Tables(0).Rows(0).Item("spg_name"), "")

        RsCari.Clear()
        RsCari = Nothing
    End Function


    Private Sub Cek_Promo()
        Dim RsPromo As New DataSet
        Dim RsAmbil As New DataSet
        Dim RsKaryawan As New DataSet
        Dim xqty As Short
        Dim xharga, xdisc1_amt As Integer
        Dim xdisc1 As Byte
        Dim Pro_tipe, Pro_Disc As Byte
        Dim Pro_Nm As String = ""
        Dim Nama_Promo As String = ""
        Dim DsSales2 As New DataSet
        Dim m_con As SqlConnection
        m_con = New System.Data.SqlClient.SqlConnection(ConnLocal)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim cmd As New System.Data.SqlClient.SqlCommand
        DsSales2.Clear()
        cmd = m_con.CreateCommand
        cmd.CommandText = "SELECT * FROM Sales_Transaction_Details " &
            "where transaction_number='" & vno_trans.Text & "'"
        cmd.CommandTimeout = 120
        da.SelectCommand = cmd
        If m_con.State = ConnectionState.Open Then
            m_con.Close()
        End If
        m_con.Open()
1:
        Try
            Dim ObjCmdBuil As New System.Data.SqlClient.SqlCommandBuilder(da)
            da.Fill(DsSales2)
            vgtotal.Text = CStr(0)
            If DsSales2.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In DsSales2.Tables(0).Rows
                    xqty = ro("Qty")
                    xharga = ro("price")

                    Call Cari_Promo(ro("plu"), vno_trans.Text, Pro_tipe, Pro_Nm, Pro_Disc, ro("Seq"), " and tipe not in (5,6)")

                    Select Case Pro_tipe
                        Case 0 'tidak ada promo
                            xdisc1 = ro("Discount_Percentage")
                        Case 2, 17, 18
                            xdisc1 = Pro_Disc
                            ro("ExtraDisc_pct") = 0
                            ro("ExtraDisc_amt") = 0
                        Case 7
                            xdisc1 = Pro_Disc
                        Case Else
                            xdisc1 = 0
                    End Select
loncat:

                    xdisc1_amt = xqty * xharga * (xdisc1 / 100)
                    ro("Discount_Percentage") = xdisc1
                    ro("Discount_Amount") = xdisc1_amt
                    ro("Net_Price") = xqty * xharga - xdisc1_amt - ro("ExtraDisc_amt")
                    vgtotal.Text = vgtotal.Text + ro("Net_Price")
                Next
                da.Update(DsSales2)
            End If

        Catch ex As Exception
            'GoTo 1
            MsgBox(ex.Message)
        End Try
        m_con.Close()
        lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")

    End Sub

    Private Sub Cek_Promo2()
        Dim RsPromo As New DataSet
        Dim RsAmbil As New DataSet
        Dim RsKaryawan As New DataSet
        Dim xqty As Short
        Dim xharga, xdisc1_amt As Integer
        Dim xdisc1 As Byte
        Dim Pro_tipe, Pro_Disc As Byte
        Dim Pro_Nm As String = ""
        Dim Nama_Promo As String = ""
        Dim DsSales2 As New DataSet
        Dim m_con As SqlConnection
        m_con = New System.Data.SqlClient.SqlConnection(ConnLocal)
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim cmd As New System.Data.SqlClient.SqlCommand
        DsSales2.Clear()
        cmd = m_con.CreateCommand
        cmd.CommandText = "SELECT * FROM Sales_Transaction_Details " &
            "where transaction_number='" & vno_trans.Text & "'"
        cmd.CommandTimeout = 120
        da.SelectCommand = cmd
        If m_con.State = ConnectionState.Open Then
            m_con.Close()
        End If
        m_con.Open()
1:
        Try
            Dim ObjCmdBuil As New System.Data.SqlClient.SqlCommandBuilder(da)
            da.Fill(DsSales2)
            vgtotal.Text = CStr(0)
            If DsSales2.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In DsSales2.Tables(0).Rows
                    xdisc1 = ro("Discount_Percentage")
                    xqty = ro("Qty")
                    xharga = ro("price")

                    Call Cari_Promo(ro("plu"), vno_trans.Text, Pro_tipe, Pro_Nm, Pro_Disc, ro("Seq"), " and tipe in (5,6)")

                    Select Case Pro_tipe
                        Case 5, 6
                            VDiscBySTAR += ((xqty * xharga - ro("Discount_Amount") - ro("ExtraDisc_amt")) * Pro_Disc / 100)
                            Nama_Promo = Pro_Nm
                    End Select
loncat:

                    xdisc1_amt = xqty * xharga * (xdisc1 / 100)
                    ro("Discount_Percentage") = xdisc1
                    ro("Discount_Amount") = xdisc1_amt
                    ro("Net_Price") = xqty * xharga - xdisc1_amt - ro("ExtraDisc_amt")
                    vgtotal.Text = vgtotal.Text + ro("Net_Price")
                Next
                da.Update(DsSales2)
            End If

        Catch ex As Exception
            'GoTo 1
            MsgBox(ex.Message)
        End Try
        m_con.Close()

        If VDiscBySTAR <> 0 Then
            getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, Credit_Card_Name, Paid_Amount, Shift) " &
                     " VALUES ('" & vno_trans.Text & "','31','1','IDR','1','','" & Nama_Promo & "'," & VDiscBySTAR & ",'" & VShift & "')", ConnLocal)
        End If
        lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
        ViewRelease(vno_trans.Text)
    End Sub

    Private Function Cari_SPG(ByRef kode As Object) As Boolean
        Dim RsCari As New DataSet

        Cari_SPG = False

        RsCari = getSqldb("select spg_id, spg_name from spg where spg_id = '" & Trim(kode) & "'", ConnLocal)

        If RsCari.Tables(0).Rows.Count > 0 Then
            vspg.Text = RsCari.Tables(0).Rows(0).Item("spg_id")
            Cari_SPG = True
        Else
            vspg.Text = ""
            MsgBox("ID SPG tidak terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
        End If
        RsCari.Clear()
        RsCari = Nothing
    End Function
    Private Function Cari_PLU(ByRef kode As Object) As Boolean
        Dim RsCari, RsCari2 As New DataSet
        Dim StrSQLPLU As String
        Cari_PLU = False
        vpromo.Text = ""
        If Me.Text = "SALES" Then
            StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" & kode & "' and a.description <> 'TIDAK AKTIF' And b.flag = 0 And b.Status = 1 And LTRIM(RTRIM(TID)) <> ''"
        Else
            StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" & kode & "' and a.description <> 'TIDAK AKTIF' And b.flag = 1 And b.Status = 1  And LTRIM(RTRIM(TID)) <> ''"
        End If
        StrSQLPLU = "select Plu,Description,Normal_Price,Current_Price,Flag, disc_percent from item_master where plu = '" & kode & "' and description <> 'TIDAK AKTIF'"

        'If Linked() Then
        '    RsCari = getSqldb(StrSQL, ConnServer)
        'Else
        '    RsCari = getSqldb(StrSQL, ConnLocal)
        'End If

        'tanpa cek PING
        If VPing = "ONLINE" Then
            RsCari = getSqldb(StrSQL, ConnServer)
            RsCari2 = getSqldb(StrSQLPLU, ConnServer)
        Else
            RsCari = getSqldb(StrSQL, ConnLocal)
            RsCari2 = getSqldb(StrSQLPLU, ConnLocal)
        End If

        If RsCari.Tables(0).Rows.Count > 0 Then
            vplu.Text = RsCari.Tables(0).Rows(0).Item("plu")
            vdesc.Text = RsCari.Tables(0).Rows(0).Item("Description")
            vharga.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag") = 0, RsCari.Tables(0).Rows(0).Item("current_Price"), 0)
            vflag.Text = RsCari.Tables(0).Rows(0).Item("flag")
            vrfid.Text = RsCari.Tables(0).Rows(0).Item("TID")
            If RsCari.Tables(0).Rows(0).Item("disc_percent") > 0 Then
                vpromo.Text = "disc"
                vdisc1.Text = RsCari.Tables(0).Rows(0).Item("disc_percent")
            End If
            Cari_PLU = True
        Else
            If RsCari2.Tables(0).Rows.Count > 0 Then
                vplu.Text = RsCari2.Tables(0).Rows(0).Item("plu")
                vdesc.Text = RsCari2.Tables(0).Rows(0).Item("Description")
                vharga.Text = IIf(RsCari2.Tables(0).Rows(0).Item("flag") = 0, RsCari2.Tables(0).Rows(0).Item("current_Price"), 0)
                vflag.Text = RsCari2.Tables(0).Rows(0).Item("flag")
                'vrfid.Text = RsCari2.Tables(0).Rows(0).Item("TID")
                If RsCari2.Tables(0).Rows(0).Item("disc_percent") > 0 Then
                    vpromo.Text = "disc"
                    vdisc1.Text = RsCari2.Tables(0).Rows(0).Item("disc_percent")
                End If
                Cari_PLU = True
            Else
                vplu.Text = ""
                vdesc.Text = ""
                vharga.Text = CStr(0)
                vflag.Text = ""
                MsgBox("PLU tidak terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
            End If
        End If
        RsCari.Clear()
        RsCari = Nothing
    End Function

    Public Sub Simpan_Detail()
        On Error GoTo ErrH
        getSqldb("INSERT INTO Sales_Transaction_Details(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " &
                 "Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " &
                 "VALUES ('" & vno_trans.Text & "','" & Gen_Seq(vno_trans.Text) & "','" & vplu.Text & "','" & UbahChar(vdesc.Text) & "','" & vharga.Text & "','" & vqty.Text & "','" & CDbl(vqty.Text) * CDbl(vharga.Text) & "','0','0','0','0','" & vtotal.Text & "','0','0','0','" & VKasir_ID & "','" & vrfid.Text & "')", ConnLocal)
        Call SaveLog(Me.Name & " " & "Simpan_Detail" & vno_trans.Text & " " & vplu.Text & " " & Format(Now, "HH:mm:ss"))

        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Simpan_Detail " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub

    Public Sub Simpan_DetailRFID()
        On Error GoTo ErrH
        getSqldb("INSERT INTO Sales_Transaction_Details(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " &
                 "Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " &
                 "VALUES ('" & vno_transRFID & "','" & Gen_Seq(vno_transRFID) & "','" & vplu.Text.Trim & "','" & UbahChar(vdesc.Text) & "','" & vharga.Text & "','" & vqty.Text & "','" & CDbl(vqty.Text) * CDbl(vharga.Text) & "','" & vdisc1.Text & "','" & vdiscrp1.Text & "','" & vdisc2.Text & "','" & vdiscrp2.Text & "','" & vtotal.Text & "','0','0','0','" & VKasir_ID & "','" & vrfid.Text.Trim & "')", ConnLocal)
        Call SaveLog(Me.Name & " " & "Simpan_Detail_Rapid " & vno_trans.Text & " " & vplu.Text & " " & Format(Now, "HH:mm:ss"))
        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Simpan_Detail_Rapid " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub

    Public Sub Simpan_DetailRFIDZebra()
        On Error GoTo ErrH
        Dim dsR As New DataSet
        dsR = getSqldb("select * from Sales_Transaction_Details where Transaction_Number = '" & vno_trans.Text & "' and Epc_Code = '" & vrfid.Text.Trim & "'", ConnLocal)
        If dsR.Tables(0).Rows.Count = 0 Then
            getSqldb("INSERT INTO Sales_Transaction_Details(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " &
                            "Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " &
                            "VALUES ('" & vno_trans.Text & "','" & Gen_Seq(vno_trans.Text) & "','" & vplu.Text.Trim & "','" & UbahChar(vdesc.Text) & "','" & vharga.Text & "','" & vqty.Text & "','" & CDbl(vqty.Text) * CDbl(vharga.Text) & "','0','0','0','0','" & vtotal.Text & "','0','0','0','" & VKasir_ID & "','" & vrfid.Text.Trim & "')", ConnLocal)
            Call SaveLog(Me.Name & " " & "Simpan_Detail_Zebra " & vno_trans.Text & " " & vplu.Text & " " & Format(Now, "HH:mm:ss"))
            Exit Sub
        End If
ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Simpan_Detail_Zebra " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub

    Private Sub Cari_Promo(ByRef codebar As String, ByRef No_trans As String, ByRef Promo_Tipe As Byte, ByRef Promo_Nm As String, ByRef Promo_Disc As Byte, ByRef Seq As Byte, ByRef ExPromo As String)
        Dim RsPromo As New DataSet
        Dim RsHitung, RsHitung2 As New DataSet
        Dim diskon As Byte
        Dim min_belanja, jml As Integer

        diskon = 0
        Promo_Tipe = 0
        Promo_Nm = ""
        Promo_Disc = 0
        RsPromo = getSqldb("select ph.promo_id, promo_name, min_purchase, min_member, disc, tipe, txt1, txt2 from promo_hdr ph inner join " & "promo_dtl pd on ph.promo_id=pd.promo_id where getdate() Between Start_Date And End_Date and aktif=1 " & "and tipe <30 " & ExPromo & " and  PLU ='" & codebar & "' order by tipe desc", ConnLocal)

        If RsPromo.Tables(0).Rows.Count = 0 Then
            RsPromo.Clear()
            RsPromo = Nothing
            Exit Sub
        End If

        Dim rshitmin As New DataSet
        For Each ro As DataRow In RsPromo.Tables(0).Rows
            If VB.Left(Star_Id, 6) = "10000000" Or Star_Id = "" Then
                min_belanja = RsPromo.Tables(0).Rows(0).Item("min_purchase")
            Else
                min_belanja = RsPromo.Tables(0).Rows(0).Item("min_member")
            End If
            Select Case RsPromo.Tables(0).Rows(0).Item("tipe")
                Case 2
                    If RsPromo.Tables(0).Rows(0).Item("disc") > diskon Then
                        If min_belanja > 0 Then
                            RsHitung = getSqldb("select SUM(qty*price) as berapa from Sales_Transaction_Details sd inner join " &
                                                "PROMO_DTL pd on sd.PLU = pd.PLU " & "where Transaction_Number='" & No_trans & "' " &
                                                "and promo_id='" & RsPromo.Tables(0).Rows(0).Item("promo_id") & "'", ConnLocal)
                            If RsHitung.Tables(0).Rows(0).Item("Berapa") > 0 Then 'sales
                                If RsHitung.Tables(0).Rows(0).Item("Berapa") >= min_belanja Then
                                    diskon = RsPromo.Tables(0).Rows(0).Item("disc")
                                End If
                            Else 'refund
                                If RsHitung.Tables(0).Rows(0).Item("Berapa") <= (-1 * min_belanja) Then
                                    diskon = RsPromo.Tables(0).Rows(0).Item("disc")
                                End If
                            End If
                            Promo_Nm = RsPromo.Tables(0).Rows(0).Item("promo_name")
                            Promo_Tipe = RsPromo.Tables(0).Rows(0).Item("tipe")
                            RsHitung.Clear()
                            RsHitung = Nothing
                        Else
                            diskon = RsPromo.Tables(0).Rows(0).Item("disc")
                            Promo_Tipe = RsPromo.Tables(0).Rows(0).Item("tipe")
                            Promo_Nm = RsPromo.Tables(0).Rows(0).Item("promo_name")
                        End If
                    End If
                    Promo_Disc = diskon
                Case 5
                    RsHitung = getSqldb("select SUM(qty*price-Discount_Amount-ExtraDisc_Amt) as berapa from Sales_Transaction_Details sd inner join " &
                                                "PROMO_DTL pd on sd.PLU = pd.PLU " & "where Transaction_Number='" & No_trans & "' " &
                                                "and promo_id='" & ro("promo_id") & "'", ConnLocal)
                    If RsHitung.Tables(0).Rows(0).Item("Berapa") > 0 Then 'sales
                        If RsHitung.Tables(0).Rows(0).Item("Berapa") >= min_belanja Then
                            Promo_Tipe = ro("Tipe")
                            Promo_Nm = ro("promo_name")
                            Promo_Disc = ro("disc")
                        End If
                    Else 'refund
                        If RsHitung.Tables(0).Rows(0).Item("Berapa") <= (-1 * min_belanja) Then
                            Promo_Tipe = ro("Tipe")
                            Promo_Nm = ro("promo_name")
                            Promo_Disc = ro("disc")
                        End If
                    End If
                    RsHitung.Clear()
                    RsHitung = Nothing
                Case 6, 7
                    RsHitung = getSqldb("select SUM(qty*price-Discount_Amount-ExtraDisc_Amt) as berapa from Sales_Transaction_Details sd inner join " &
                                                "PROMO_DTL pd on sd.PLU = pd.PLU " & "where Transaction_Number='" & No_trans & "' " &
                                                "and promo_id='" & ro("promo_id") & "'", ConnLocal)
                    If RsHitung.Tables(0).Rows(0).Item("Berapa") > 0 Then 'sales
                        If RsHitung.Tables(0).Rows(0).Item("Berapa") >= min_belanja Then
                            RsHitung2 = getSqldb("select * from Sales_Transaction_Details sd inner join PROMO_DTL pd on sd.PLU = pd.PLU " &
                                                 "where Transaction_Number='" & No_trans & "' and flag_void=0 and qty=1 and promo_id='" & ro("promo_id") & "'", ConnLocal)

                            jml = roundDown(RsHitung2.Tables(0).Rows.Count / 2)

                            RsHitung2.Clear()
                            RsHitung2 = getSqldb("select * from(select top " & jml & " sd.seq, sd.plu from  Sales_Transaction_Details sd inner join PROMO_DTL pd " &
                                                 "on sd.PLU = pd.PLU where Transaction_Number='" & No_trans & "' and flag_void=0 and qty=1 and promo_id='" & ro("promo_id") & "' order by amount, net_price ) aa " &
                                                 "where PLU = '" & codebar & "' and seq='" & Seq & "'", ConnLocal)
                            Promo_Tipe = ro("Tipe")
                            Promo_Nm = ro("promo_name")
                            If RsHitung2.Tables(0).Rows.Count > 0 Then
                                Promo_Disc = ro("disc")
                            Else
                                Promo_Disc = 0
                            End If

                        End If
                    Else 'refund
                        If RsHitung.Tables(0).Rows(0).Item("Berapa") <= (-1 * min_belanja) Then
                            RsHitung2 = getSqldb("select * from Sales_Transaction_Details sd inner join PROMO_DTL pd on sd.PLU = pd.PLU " &
                                                 "where Transaction_Number='" & No_trans & "' and flag_void=0 and qty=-1 and promo_id='" & ro("promo_id") & "'", ConnLocal)

                            jml = roundDown(RsHitung2.Tables(0).Rows.Count / 2)

                            RsHitung2.Clear()
                            RsHitung2 = getSqldb("select * from(select top " & jml & " sd.seq, sd.plu from  Sales_Transaction_Details sd inner join PROMO_DTL pd " &
                                                 "on sd.PLU = pd.PLU where Transaction_Number='" & No_trans & "' and flag_void=0 and qty=-1 and promo_id='" & ro("promo_id") & "' order by amount desc, net_price desc) aa " &
                                                 "where PLU = '" & codebar & "' and seq='" & Seq & "'", ConnLocal)
                            Promo_Tipe = ro("Tipe")
                            Promo_Nm = ro("promo_name")
                            If RsHitung2.Tables(0).Rows.Count > 0 Then
                                Promo_Disc = ro("disc")
                            Else
                                Promo_Disc = 0
                            End If
                        End If
                    End If
                    RsHitung.Clear()
                    RsHitung = Nothing
            End Select
        Next
        RsPromo.Clear()
        RsPromo = Nothing
    End Sub
    Sub Kosong()
        'lblkode.Text = "ID SPG"
        vspg.Text = ""
        vplu.Text = ""
        vdesc.Text = ""
        vqty.Text = "0"
        vharga.Text = "0"
        vtotal.Text = "0"
        vflag.Text = ""
        txtkode.Text = ""
        vrfid.Text = ""
        'lblgrand_total.Text = "0"
        'lblqty.Text = "0 Pcs"
    End Sub
    Private Sub Cek_Harga()
        Dim dsCheck As New DataSet
        dsCheck = getSqldb("select distinct list_id from Item_Master_Listing where getdate() Between Start_Date And End_Date and active=1", ConnLocal)
        For Each ro As DataRow In dsCheck.Tables(0).Rows
            If (Me.Text = "SALES") Then
                getSqldb("spp_Price_Check '" & vno_trans.Text & "','" & ro("list_id") & "','1'", ConnLocal)
            Else
                getSqldb("spp_Price_Check '" & vno_trans.Text & "','" & ro("list_id") & "','0'", ConnLocal)
            End If
        Next
        ViewRelease(vno_trans.Text)
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    vflag.Text = 0
    '    vqty.Text = 1
    '    If Me.Text = "REFUND" Then vqty.Text = CStr(CDbl(vqty.Text) * -1)
    '    If CDbl(vflag.Text) = 0 And CDbl(vdisc1.Text) <> 0 Then
    '        If Not Super(1) Then Exit Sub
    '    End If
    '    RFIDOKE = False
    '    Timer1.Enabled = True
    '    'Exec(vno_trans.Text, txtcust_id.Text, txtcard_no.Text)
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RFIDOKE = True Then
            If RFIDType = "zebra" Then
            Else
                vno_trans.Text = vno_transRFID
            End If

            'vqty.Text = vqtyRFID
            'vdiscrp1.Text = vdiscrp1RFID
            'vdiscrp2.Text = vdiscrp2RFID
            'vtotal.Text = vtotalRFID
            'vgtotal.Text = vgtotalRFID
            'txtcust_id.Text = txtcust_idRFID
            'txtcard_no.Text = txtcard_noRFID
            'lblqty.Text = lblqtyRFID
            'lblgrand_total.Text = CDec(lblgrand_totalRFID).ToString("N0")

            ViewRelease(vno_trans.Text)
            Call CDisplay(VB.Left(vdesc.Text, 20), VB.Left(CStr(vqty.Text) & " pcs Rp. " & CDec(vgtotal.Text).ToString("N0"), 20))
            Timer1.Enabled = False
            RFIDOKE = False
        End If

    End Sub


    Private Delegate Sub UpdateStatus(ByVal eventData As StatusEventData)
    Private Delegate Sub UpdateRead(ByVal eventData As ReadEventData)



    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If File.Exists(Application.StartupPath & "\POS.txt") Then
    '        Using sr As New StreamReader(Application.StartupPath & "\POS.txt")
    '            vflag.Text = 0
    '            vqty.Text = 1
    '            If Me.Text = "REFUND" Then vqty.Text = CStr(CDbl(vqty.Text) * -1)
    '            If CDbl(vflag.Text) = 0 And CDbl(vdisc1.Text) <> 0 Then
    '                If Not Super(1) Then Exit Sub
    '            End If
    '            Do While sr.Peek() >= 0
    '                If Cari_PLU_RFID(Trim(sr.ReadLine().Trim)) = True Then
    '                    vdiscrp1.Text = CDec(CDbl(vqty.Text) * CDbl(vharga.Text) * CDbl(vdisc1.Text) / 100).ToString("N0")
    '                    vdiscrp2.Text = CDec((CDbl(vqty.Text) * CDbl(vharga.Text) - CDbl(vdiscrp1.Text)) * CDbl(vdisc2.Text) / 100).ToString("N0")
    '                    vtotal.Text = CStr(CDbl(vqty.Text) * CDbl(vharga.Text) - CDbl(vdiscrp1.Text) - CDbl(vdiscrp2.Text))
    '                    vgtotal.Text = CStr(Val(vgtotal.Text) + Val(vtotal.Text))
    '                    lblqty.Text = CStr(Val(lblqty.Text) + CDbl(vqty.Text))
    '                    lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
    '                    Call Simpan_Header()
    '                    Call Simpan_Detail()
    '                End If
    '            Loop
    '        End Using
    '    End If
    '    ViewRelease(vno_trans.Text)
    '    Call CDisplay(VB.Left(vdesc.Text, 20), VB.Left(CStr(vqty.Text) & " pcs Rp. " & CDec(vgtotal.Text).ToString("N0"), 20))
    '    txtkode.Focus()
    'End Sub
    'Private Sub GPIControlMsg(ByVal gpiIndex As Integer, ByVal gpiState As Integer, ByVal startOrStop As Integer) Implements IAsynchronousMessage.GPIControlMsg

    'End Sub
    'Private Sub WriteDebugMsg(ByVal msg As String) Implements IAsynchronousMessage.WriteDebugMsg

    'End Sub

    'Public Shared Sub CheckCon()
    '    If (MyReader.CreateTcpConn(conID, example)) Then
    '        MsgBox("Connected!!!")
    '    End If
    'End Sub

    Public Sub CheckConZebra()
        m_ReaderAPI = New RFIDReader(IPReader, UInt32.Parse(PortReader), 0)
        Try
            If m_ReaderAPI.IsConnected = False Then
                m_ReaderAPI.Connect()
                'MsgBox("Connect Succeed", MsgBoxStyle.Information, "Information")
                RFIDStatus = True
                AddHandler Me.m_ReaderAPI.Events.ReadNotify, New ReadNotifyHandler(AddressOf Me.Events_ReadNotify)
                Me.m_ReaderAPI.Events.AttachTagDataWithReadEvent = False
                AddHandler Me.m_ReaderAPI.Events.StatusNotify, New StatusNotifyHandler(AddressOf Me.Events_StatusNotify)
                Me.m_ReaderAPI.Events.NotifyGPIEvent = True
                Me.m_ReaderAPI.Events.NotifyReaderDisconnectEvent = True
                Me.m_ReaderAPI.Events.NotifyAccessStartEvent = True
                Me.m_ReaderAPI.Events.NotifyAccessStopEvent = True
                Me.m_ReaderAPI.Events.NotifyInventoryStartEvent = True
                Me.m_ReaderAPI.Events.NotifyInventoryStopEvent = True

                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.DeleteAll()
                If OneReadAll = True Then
                    Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
                End If
                RFIDOKE = False
                'Timer1.Enabled = True
                Dim op As New Operation
                op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ
                op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_EPC
                op.ReadAccessParams.ByteCount = 0
                op.ReadAccessParams.ByteOffset = 0
                op.ReadAccessParams.AccessPassword = 0
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op)
                OneReadAll = True
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(Nothing, Nothing, Nothing)

                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.DataSource = Nothing
                End If
            End If
        Catch operationException As OperationFailureException
            'MsgBox(operationException.Result)
            MsgBox("Connect RFID Failed!!", MsgBoxStyle.Critical, "Attention")
            RFIDStatus = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DisConZebra()

        m_ReaderAPI = New RFIDReader(IPReader, UInt32.Parse(PortReader), 0)
        Try
            If m_ReaderAPI.IsConnected = True Then
                m_ReaderAPI.Disconnect()
                MsgBox("Disconnect Successfull")
            End If
        Catch operationException As OperationFailureException
            MsgBox(operationException.Result)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Events_ReadNotify(ByVal sender As Object, ByVal readEventArgs As ReadEventArgs)
        Try
            MyBase.Invoke(Me.m_UpdateReadHandler, New Object() {Nothing})
        Catch exception1 As Exception
        End Try
    End Sub

    Public Sub Events_StatusNotify(ByVal sender As Object, ByVal statusEventArgs As StatusEventArgs)
        Try
            MyBase.Invoke(Me.m_UpdateStatusHandler, New Object() {statusEventArgs.StatusEventData})
        Catch exception1 As Exception
        End Try
    End Sub
    'Public Shared Sub Exec(ByVal no As String, ByVal cust_id As String, ByVal card_no As String)
    '    Try
    '        vno_transRFID = no
    '        txtcust_idRFID = cust_id
    '        txtcard_noRFID = card_no
    '        Dim antNum As New eAntennaNo()
    '        'no antena
    '        antNum = eAntennaNo._1
    '        Dim readType As New eReadType()
    '        readType = eReadType.Single
    '        If MyReader._Tag6C.GetEPC_TID_UserData(conID, antNum, readType, 0, 2) = 0 Then

    '        End If
    '    Catch ex As Exception
    '        MsgBox("Gagal " + ex.ToString())
    '    End Try
    'End Sub


    'Private Sub OutPutTags(ByVal tag As Tag_Model) Implements IAsynchronousMessage.OutPutTags
    '    If Cari_PLU_RFID(Trim(tag.EPC.ToString)) = True Then
    '        vqtyRFID = 1
    '        vdiscrp1RFID = CDec(CDbl(vqtyRFID) * CDbl(vharga.Text) * CDbl(vdisc1.Text) / 100).ToString("N0")
    '        vdiscrp2RFID = CDec((CDbl(vqtyRFID) * CDbl(vharga.Text) - CDbl(vdiscrp1RFID)) * CDbl(vdisc2.Text) / 100).ToString("N0")
    '        vtotalRFID = CStr(CDbl(vqtyRFID) * CDbl(vharga.Text) - CDbl(vdiscrp1RFID) - CDbl(vdiscrp2RFID))
    '        vgtotalRFID = CStr(Val(vgtotal.Text) + Val(vtotalRFID))
    '        lblqtyRFID = lblqtyRFID + CDbl(vqtyRFID)
    '        'lblqty.Text = CStr(Val(lblqty.Text) + CDbl(vqtyRFID))
    '        lblgrand_totalRFID = CDec(vgtotalRFID).ToString("N0")
    '        'lblgrand_total.Text = CDec(vgtotalRFID).ToString("N0")

    '        Call Simpan_HeaderRFID()
    '        Call Simpan_DetailRFID()



    '    End If
    'End Sub

    Private Function getTagEvent(ByVal tag As TagData) As String
        Dim eventString As String = "None"
        Select Case tag.TagEvent
            Case TAG_EVENT.NEW_TAG_VISIBLE
                Return "New"
            Case TAG_EVENT.TAG_NOT_VISIBLE
                Return "Gone"
            Case TAG_EVENT.TAG_BACK_TO_VISIBILITY
                Return "Back"
            Case TAG_EVENT.NONE
                Return eventString
        End Select
        Return "None"
    End Function

    Function HexToString(ByVal hex As String) As String
        Dim text As New System.Text.StringBuilder(hex.Length \ 2)
        For i As Integer = 0 To hex.Length - 2 Step 2
            text.Append(Chr(Convert.ToByte(hex.Substring(i, 2), 16)))
        Next
        Return text.ToString
    End Function



    Private Function Cari_PLU_RFID(ByRef kode As Object) As Boolean
        Dim RsCari As New DataSet
        Cari_PLU_RFID = False
        vpromo.Text = ""
        If Me.Text = "SALES" Then
            StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" & HexToString(Microsoft.VisualBasic.Left(kode, 26)) & "' and a.description <> 'TIDAK AKTIF' And b.flag = 0 And b.Status = 1  And LTRIM(RTRIM(TID)) <> ''"
        Else
            StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" & HexToString(Microsoft.VisualBasic.Left(kode, 26)) & "' and a.description <> 'TIDAK AKTIF' And b.flag = 1 And b.Status = 1  And LTRIM(RTRIM(TID)) <> ''"
        End If
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(12).Value.ToString.Trim = kode Then
                Exit Function
            End If
        Next

        'If Linked() Then
        '    RsCari = getSqldb(StrSQL, ConnServer)
        'Else
        '    RsCari = getSqldb(StrSQL, ConnLocal)
        'End If

        'tanpa cek PING
        If VPing = "ONLINE" Then
            RsCari = getSqldb(StrSQL, ConnServer)
        Else
            RsCari = getSqldb(StrSQL, ConnLocal)
        End If

        If RsCari.Tables(0).Rows.Count > 0 Then
            vplu.Text = RsCari.Tables(0).Rows(0).Item("plu")
            vdesc.Text = RsCari.Tables(0).Rows(0).Item("Description")
            vharga.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag") = 0, RsCari.Tables(0).Rows(0).Item("current_Price"), 0)
            vflag.Text = RsCari.Tables(0).Rows(0).Item("flag")
            vrfid.Text = RsCari.Tables(0).Rows(0).Item("TID")
            If RsCari.Tables(0).Rows(0).Item("disc_percent") > 0 Then
                vpromo.Text = "disc"
                vdisc1.Text = RsCari.Tables(0).Rows(0).Item("disc_percent")
            End If
            Cari_PLU_RFID = True
        Else
            vplu.Text = ""
            vdesc.Text = ""
            vharga.Text = CStr(0)
            vflag.Text = ""
            vrfid.Text = ""
            'MsgBox("PLU tidak terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
        End If
        RsCari.Clear()
        RsCari = Nothing
    End Function

    'Private Sub OutPutTagsOver() Implements IAsynchronousMessage.OutPutTagsOver
    '    'VNomor = vno_transRFID

    '    RFIDOKE = True
    'End Sub

    'Private Sub PortClosing(ByVal connID As String) Implements IAsynchronousMessage.PortClosing
    'End Sub

    'Private Sub PortConnecting(ByVal connID As String) Implements IAsynchronousMessage.PortConnecting
    'End Sub

    'Private Sub WriteLog(ByVal msg As String) Implements IAsynchronousMessage.WriteLog
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        vflag.Text = 0
        vqty.Text = 1
        If Me.Text = "REFUND" Then vqty.Text = CStr(CDbl(vqty.Text) * -1)
        If CDbl(vflag.Text) = 0 And CDbl(vdisc1.Text) <> 0 Then
            If Not Super(1) Then Exit Sub
        End If
        RFIDOKE = False
        Timer1.Enabled = True
        'Exec(vno_trans.Text, txtcust_id.Text, txtcard_no.Text)
    End Sub

    Private Sub RfidScan2_Click(sender As Object, e As EventArgs) Handles RfidScan2.Click
        If RFIDStatus = False Then
            If RFIDType = "zebra" Then
                CheckConZebra()
            End If
            txtkode.Focus()
            Exit Sub
        End If
        'Call Kosong()
        Try
            If RFIDStatus = False Then
                Dim op As New Operation
                op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ
                op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_EPC
                op.ReadAccessParams.ByteCount = 0
                op.ReadAccessParams.ByteOffset = 0
                op.ReadAccessParams.AccessPassword = 0
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op)
                OneReadAll = True
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(Nothing, Nothing, Nothing)
                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.DataSource = Nothing
                End If

                'RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(24, 24, Nothing, IntPtr.Zero)
                'RfidScan2.Text = "RFID ON"
                RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_Refresh.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
                RfidScan2.Text = "REFRESH"
                RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
                RfidScan2.TextAlign = ContentAlignment.BottomCenter
                RfidScan2.TextImageRelation = TextImageRelation.Overlay
                RfidScan2.ForeColor = Color.Green
                RFIDStatus = True
                getSqldb("delete from sales_transaction_details where transaction_number = '" & vno_trans.Text & "' and ISNULL(Epc_Code,'') <> ''", ConnLocal)
                getSqldb("delete from sales_transaction_details where transaction_number = '" & vno_trans.Text & "' and plu in (select PLU from Bag)", ConnLocal)
                m_TagTable.Clear()
            Else
                If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
                    Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
                    Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.DeleteAll()
                Else
                    Me.m_ReaderAPI.Actions.Inventory.Stop()
                End If
                RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_DEACTIVE.ico").GetThumbnailImage(20, 20, Nothing, IntPtr.Zero)
                RfidScan2.Text = "RFID OFF"
                RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
                RfidScan2.TextAlign = ContentAlignment.BottomCenter
                RfidScan2.TextImageRelation = TextImageRelation.Overlay
                RfidScan2.ForeColor = Color.Red
                RFIDStatus = False
                OneReadAll = False

                Dim op As New Operation
                op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ
                op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_EPC
                op.ReadAccessParams.ByteCount = 0
                op.ReadAccessParams.ByteOffset = 0
                op.ReadAccessParams.AccessPassword = 0
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op)
                OneReadAll = True
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(Nothing, Nothing, Nothing)
                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.DataSource = Nothing
                End If

                'RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(24, 24, Nothing, IntPtr.Zero)
                'RfidScan2.Text = "RFID ON"
                RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_Refresh.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
                RfidScan2.Text = "REFRESH"
                RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
                RfidScan2.TextAlign = ContentAlignment.BottomCenter
                RfidScan2.TextImageRelation = TextImageRelation.Overlay
                RfidScan2.ForeColor = Color.Green
                RFIDStatus = True
                getSqldb("delete from sales_transaction_details where transaction_number = '" & vno_trans.Text & "' and ISNULL(Epc_Code,'') <> ''", ConnLocal)
                getSqldb("delete from sales_transaction_details where transaction_number = '" & vno_trans.Text & "' and plu in (select PLU from Bag)", ConnLocal)
                m_TagTable.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Try
        '    If RfidScan2.Text = "RFID ON" Then
        '        If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
        '            Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
        '        Else
        '            Me.m_ReaderAPI.Actions.Inventory.Stop()
        '        End If
        '        RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_DEACTIVE.ico").GetThumbnailImage(20, 20, Nothing, IntPtr.Zero)
        '        RfidScan2.Text = "RFID OFF"
        '        RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
        '        RfidScan2.TextAlign = ContentAlignment.BottomCenter
        '        RfidScan2.TextImageRelation = TextImageRelation.Overlay
        '        RfidScan2.ForeColor = Color.Red
        '        RFIDStatus = False
        '        OneReadAll = False
        '    Else

        '        Dim op As New Operation
        '        op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ
        '        op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_EPC
        '        op.ReadAccessParams.ByteCount = 0
        '        op.ReadAccessParams.ByteOffset = 0
        '        op.ReadAccessParams.AccessPassword = 0
        '        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op)
        '        OneReadAll = True
        '        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(Nothing, Nothing, Nothing)
        '        If DataGridView1.Rows.Count > 0 Then
        '            DataGridView1.DataSource = Nothing
        '        End If

        '        RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(24, 24, Nothing, IntPtr.Zero)
        '        RfidScan2.Text = "RFID ON"
        '        RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
        '        RfidScan2.TextAlign = ContentAlignment.BottomCenter
        '        RfidScan2.TextImageRelation = TextImageRelation.Overlay
        '        RfidScan2.ForeColor = Color.Green
        '        RFIDStatus = True
        '        getSqldb("delete from sales_transaction_details where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
        '        m_TagTable.Clear()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Dim dsReload As New DataSet
        Dim cnt As Integer = 1
        dsReload = getSqldb("select * from sales_transaction_details where transaction_number = '" & vno_trans.Text & "' Order BY Seq", ConnLocal)
        If dsReload.Tables(0).Rows.Count > 0 Then
            For Each ro As DataRow In dsReload.Tables(0).Rows
                getSqldb("update sales_transaction_details set seq = '" & cnt & "' where transaction_number = '" & ro("transaction_number") & "' " &
                         " and Seq = '" & ro("Seq") & "'", ConnLocal)
                cnt += 1
            Next
        End If

        vspg.Text = VKasir_ID

        '------------
        Call SaveLog(Me.Name & " " & "Refresh_Transaction_Zebra " & vno_trans.Text & " " & VSuper_Nm & " " & Format(Now, "HH:mm:ss"))

        dsSales = getSqldb("SELECT Seq, Flag_Paket_Discount, PLU, Item_Description, Price, Qty, Discount_Percentage, " & "Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, flag_void FROM Sales_Transaction_Details " & "where transaction_number='" & vno_trans.Text & "'", ConnLocal)
        If RFIDType = "zebra" Then
            RfidScan2.Visible = True
        Else
            RfidScan2.Visible = False
        End If

        vgtotal.Text = CStr(0)
        lblqty.Text = CStr(0)
        If dsSales.Tables(0).Rows.Count > 0 Then
            For Each ro As DataRow In dsSales.Tables(0).Rows
                vgtotal.Text = vgtotal.Text + ro("Net_Price")
                lblqty.Text = Val(lblqty.Text) + ro("Qty")
            Next
        End If
        lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
        Call Simpan_Header()
        ViewRelease(vno_trans.Text)
        txtkode.Select()
        txtkode.Focus()

    End Sub

    Private Sub myUpdateStatus(ByVal eventData As Events.StatusEventData)
        Select Case eventData.StatusEventType
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_START_EVENT
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_STOP_EVENT
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_START_EVENT
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_STOP_EVENT
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_WARNING_EVENT
                myUpdateRead(Nothing)
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_EVENT
                myUpdateRead(Nothing)
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.DISCONNECTION_EVENT
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ANTENNA_EVENT
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.READER_EXCEPTION_EVENT
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub myUpdateRead(ByVal eventData As ReadEventData)
        If GotoPayment = True Then
            Exit Sub
        End If
        Dim index As Integer = 0
        Dim isFoundIndex As Integer = 0
        Dim tagData As Symbol.RFID3.TagData() = m_ReaderAPI.Actions.GetReadTags(1000)
        If tagData IsNot Nothing Then
            For nIndex As Integer = 0 To tagData.Length - 1
                If tagData(nIndex).OpCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_NONE OrElse (tagData(nIndex).OpCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ AndAlso tagData(nIndex).OpStatus = ACCESS_OPERATION_STATUS.ACCESS_SUCCESS) Then
                    Dim tag As Symbol.RFID3.TagData = tagData(nIndex)
                    'Dim tagID As String = tag.MemoryBankData
                    Dim tagID As String = tag.TagID
                    Dim isFound As Boolean = False
                    SyncLock m_TagTable.SyncRoot
                        isFound = m_TagTable.ContainsKey(tagID)
                        If Not isFound Then
                            isFound = m_TagTable.ContainsKey(tagID)
                        End If
                    End SyncLock
                    If isFound Then
                        RFIDOKE = True
                        'vqty.Text = lblqtyRFID
                        'Me.m_ReaderAPI.Actions.Inventory.Stop()
                    Else
                        'Dim memoryBank As String = tag.MemoryBank.ToString()
                        'index = memoryBank.LastIndexOf("_"c)
                        'If index <> -1 Then
                        '    memoryBank = memoryBank.Substring(index + 1)
                        'End If
                        If tag.MemoryBankData.Length > 0 Then
                            If Cari_PLU_RFID(Trim(tag.TagID)) = True Then
                                Dim dsCekPaid As New DataSet
                                vqtyRFID = 1
                                If Me.Text = "REFUND" Then
                                    vqtyRFID *= -1
                                End If
                                If CDbl(vflag.Text) = 1 Then
                                    Me.TopMost = False
                                    frmHarga.ShowDialog()
                                    frmHarga.TopMost = True
                                Else
                                    If Me.Text = "REFUND" Then
                                        Me.TopMost = False
                                        frmHarga.ShowDialog()
                                        frmHarga.TopMost = True
                                    End If
                                End If
                                vtotalRFID = CStr(CDbl(vqtyRFID) * CDbl(vharga.Text) - CDbl(vdiscrp1RFID) - CDbl(vdiscrp2RFID))
                                vgtotalRFID = CStr(Val(vgtotal.Text) + Val(vtotalRFID))
                                lblqtyRFID = lblqtyRFID + CDbl(vqtyRFID)
                                'lblqty.Text = CStr(Val(lblqty.Text) + CDbl(vqtyRFID))
                                lblgrand_totalRFID = CDec(vgtotalRFID).ToString("N0")
                                'lblgrand_total.Text = CDec(vgtotalRFID).ToString("N0")
                                dsCekPaid = getSqldb("SELECT * from paid where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
                                If dsCekPaid.Tables(0).Rows.Count > 0 Then
                                    txtkode.Focus()
                                    Exit Sub
                                End If
                                Call Simpan_HeaderRFIDZebra()
                                Call Simpan_DetailRFIDZebra()

                                'vno_trans.Text = vno_transRFID


                                ViewRelease(vno_trans.Text)
                                My.Computer.Audio.Play(Application.StartupPath & "/Beep.wav", AudioPlayMode.Background)
                                Call CDisplay(VB.Left(vdesc.Text, 20), VB.Left(CStr(vqty.Text) & " pcs Rp. " & CDec(vgtotal.Text).ToString("N0"), 20))
                            End If
                        End If

                        SyncLock m_TagTable.SyncRoot
                            m_TagTable.Add(tagID, tag.MemoryBankData)
                        End SyncLock
                    End If
                End If
            Next
        End If
    End Sub

    'Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
    '    If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
    '        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
    '    Else
    '        Me.m_ReaderAPI.Actions.Inventory.Stop()
    '    End If

    '    'Me.m_ReaderAPI.Disconnect()

    'End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try
            If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
                Me.m_ReaderAPI.Actions.Inventory.Stop()
            Else
                Me.m_ReaderAPI.Actions.Inventory.Stop()
            End If
            Me.m_ReaderAPI.Disconnect()
            RFIDStatus = False
            OneReadAll = False
            'Me.m_IsConnected = False
            'workEventArgs.Result = "Disconnect Succeed"
        Catch ofe As OperationFailureException
            'workEventArgs.Result = ofe.Result
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Close()
        If SecLev = "9" Then
            frmMain.Show()
        Else
            frmLogin.Show()
        End If

        Exit Sub
    End Sub

    Private Sub vno_trans_TextChanged(sender As Object, e As EventArgs) Handles vno_trans.TextChanged
        lblno.Text = "TRANS# " & VB.Right(vno_trans.Text, 4)
    End Sub

    Private Sub _btnNum_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnNum_0.Click, _btnNum_1.Click,
    _btnNum_2.Click, _btnNum_3.Click, _btnNum_4.Click, _btnNum_5.Click, _btnNum_6.Click, _btnNum_7.Click, _btnNum_8.Click,
    _btnNum_9.Click, _btnNum_10.Click, _btnNum_11.Click, _btnNum_12.Click, _btnNum_13.Click
        Dim btn As Button = sender
        txtkode.Focus()
        If CInt(btn.Tag) < 11 Then
            If txtkode.SelectionLength = txtkode.Text.Length Then
                txtkode.Clear()
            End If
            txtkode.Text = txtkode.Text & btn.Text
        End If
        txtkode.SelectionStart = txtkode.Text.Length
        Select Case CInt(btn.Tag)
            Case 11
                Dim Cmd As String

                Dim CekPLU() As String
                Dim RealPLU As String

                CekPLU = Split(txtkode.Text, "*")
                On Error GoTo ErrH
                If Len(CekPLU(0)) > 10 Then
                    RealPLU = CekPLU(0)
                Else
                    RealPLU = CekPLU(1)
                End If
                If Len(Trim(RealPLU)) > 14 Then

                Else
                    If Cari_PLU(VB.Right(Trim(RealPLU), 14)) = True Then
                        Dim dsCekPaid As New DataSet
                        Qty = Split(txtkode.Text, "*")
                        vqty.Text = IIf(Len(Qty(0)) > 10, 1, Qty(0))
                        If vqty.Text = "" Then vqty.Text = CStr(1)
                        If Me.Text = "REFUND" Then vqty.Text = CStr(CDbl(vqty.Text) * -1)

                        'vflag = 0 Barang Direct, vflag = 1 Barang Konsinyasi
                        'If CDbl(vflag.Text) = 0 And vpromo.Text <> "disc" Then
                        '    If Not Super(1) Then Exit Sub
                        'End If

                        VOK = False
                        If CDbl(vflag.Text) = 1 Then frmHarga.ShowDialog()


                        vtotal.Text = CStr(CDbl(vqty.Text) * CDbl(vharga.Text))

                        If VOK = True Or CDbl(vflag.Text) = 0 Then
                            vgtotal.Text = CStr(Val(vgtotal.Text) + Val(vtotal.Text))
                            lblqty.Text = CStr(Val(Replace(lblqty.Text, " Pcs", "")) + CDbl(vqty.Text))
                            lblqty.Text = lblqty.Text & " pcs"
                            lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
                            dsCekPaid = getSqldb("SELECT * from paid where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
                            If dsCekPaid.Tables(0).Rows.Count > 0 Then
                                txtkode.Focus()
                                Exit Sub
                            End If
                            Call Simpan_Header()
                            Call Simpan_Detail()
                            Call CDisplay(VB.Left(vdesc.Text, 20), VB.Left(CStr(vqty.Text) & " pcs Rp. " & CDec(vgtotal.Text).ToString("N0"), 20))
                            'PEMBAYARAN DENGAN POINT REWARDS
                            'no1
                            'If Star_No <> "CM000-00000" Then
                            '    If Linked() Then Call Cari_Item_Rewards((txtkode.Text))
                            'End If
                        End If
                        ViewRelease(vno_trans.Text)

                    End If
                End If
                System.Windows.Forms.SendKeys.Send("{home}+{end}")
                txtkode.Focus()
                GoTo 1
ErrH:
                MsgBox("PLU tidak terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                System.Windows.Forms.SendKeys.Send("{home}+{end}")
                txtkode.Focus()
1:

            Case 12
                System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
            Case 13
                txtkode.Text = ""
            Case 14
                Me.Close()
                'Me.BackgroundWorker1.RunWorkerAsync()
                'BackgroundWorker1.WorkerReportsProgress = True
                'BackgroundWorker1.WorkerSupportsCancellation = True
                'BackgroundWorker1.RunWorkerAsync()

        End Select
    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles txtkode.TextChanged
        If txtkode.TextLength > 16 Then
            txtkode.Text = VB.Left(txtkode.Text, 14)
        End If
    End Sub

    Private Sub _CmdNav_1_Click(sender As Object, e As EventArgs) Handles _CmdNav_1.Click
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If
        DataGridView1.ClearSelection()
        If DataGridView1.CurrentRow.Index = 0 Then
            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2)
            DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
            DataGridView1.Focus()
        Else
            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.CurrentRow.Index - 1).Cells(2)
            DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
            DataGridView1.Focus()
        End If
        txtkode.Focus()
    End Sub

    Private Sub _CmdNav_2_Click(sender As Object, e As EventArgs) Handles _CmdNav_2.Click
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If
        DataGridView1.ClearSelection()
        If DataGridView1.CurrentRow.Index = DataGridView1.RowCount - 1 Then
            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2)
            DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
            DataGridView1.Focus()
        Else
            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.CurrentRow.Index + 1).Cells(2)
            DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
            DataGridView1.Focus()
        End If
        txtkode.Focus()
    End Sub

    Private Sub _cmdsales_3_Click(sender As Object, e As EventArgs)
        If DataGridView1.RowCount > 0 Then
            For Each ro As DataGridViewRow In DataGridView1.SelectedRows
                If Not Me.DataGridView1.Rows(ro.Index).IsNewRow Then
                    'If Not Super(2) Then Exit Sub
                    With DataGridView1
                        getSqldb("delete from Sales_Transaction_Details where transaction_number='" & vno_trans.Text & "' and seq='" & .Item(0, ro.Index).Value & "'", ConnLocal)
                        SyncLock m_TagTable.SyncRoot
                            m_TagTable.Remove(.Item(12, ro.Index).Value.ToString.Trim)
                        End SyncLock
                        vgtotal.Text = CStr(CDbl(vgtotal.Text) - Val(.Item(10, ro.Index).Value))
                        lblqty.Text = CStr(Val(Replace(lblqty.Text, " Pcs", "")) - Val(.Item(5, ro.Index).Value))
                        lblqty.Text = lblqty.Text & " pcs"
                        lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
                        Call Simpan_Header()
                    End With
                    txtkode.Focus()
                End If
            Next
        End If
        ViewRelease(vno_trans.Text)

    End Sub

    Private Sub _cmdsales_0_Click(sender As Object, e As EventArgs) Handles _cmdsales_0.Click
        If dsSales.Tables(0).Rows.Count = 0 Then Exit Sub
        VDiscBySTAR = 0
        If cmdsales(9).Enabled Then
            If dsSales.Tables(0).Rows.Count = 0 Then Exit Sub
            Call Cek_Harga()
            Call Cek_Promo()
            Call Cek_Promo2()
            Call Simpan_Header()
            Call CDisplay("TOTAL :", "Rp. " & CDec(CDbl(vgtotal.Text) - VDiscBySTAR).ToString("N0"))
        End If
        VNomor = vno_trans.Text
        Call CDisplay("TOTAL :", "Rp. " & CDec(CDbl(vgtotal.Text) - VDiscBySTAR).ToString("N0"))
        If VDiscBySTAR > 0 Then
            MsgBox("Anda Mendapat Potongan Senilai Rp. " & VDiscBySTAR.ToString("N0"), MsgBoxStyle.Information, "Information")
        End If
        Me.Enabled = False
        GotoPayment = True
        frmPaymentSelf.vpay.Text = CDbl(vgtotal.Text) - VDiscBySTAR
        frmPaymentSelf.vstatus.Text = Me.Text
        frmPaymentSelf.ShowDialog()
        txtkode.Text = ""
        txtkode.Focus()
    End Sub

    Private Sub _cmdsales_9_Click(sender As Object, e As EventArgs) Handles _cmdsales_9.Click
        If dsSales.Tables(0).Rows.Count = 0 Then Exit Sub
        VDiscBySTAR = 0
        getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnLocal)
        If VPing = "ONLINE" Then
            getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnServer)
        End If
        Call Cek_Harga()
        Call Cek_Promo()
        Call Cek_Promo2()
        Call Simpan_Header()
        Call CDisplay("TOTAL :", "Rp. " & CDec(CDbl(vgtotal.Text) - VDiscBySTAR).ToString("N0"))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        InputMember.ShowDialog()
        getSqldb("UPDATE Sales_Transactions set customer_id = '" & txtcust_id.Text & "', card_number = '" & txtcard_no.Text & "' where Transaction_Number='" & vno_trans.Text & "'", ConnLocal)
        txtkode.Focus()
    End Sub

    Private Sub DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = MouseButtons.Right Then
            'Me.DataGridView1.Rows(e.RowIndex).Selected = True
            Me.rowIndex = e.RowIndex
            'Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(e.RowIndex).Cells(2)
            Me.ContextMenuStrip1.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click
        If DataGridView1.RowCount > 0 Then
            For Each ro As DataGridViewRow In DataGridView1.SelectedRows
                If Not Me.DataGridView1.Rows(ro.Index).IsNewRow Then
                    'If Not Super(2) Then Exit Sub
                    With DataGridView1
                        getSqldb("delete from Sales_Transaction_Details where transaction_number='" & vno_trans.Text & "' and seq='" & .Item(0, ro.Index).Value & "'", ConnLocal)
                        SyncLock m_TagTable.SyncRoot
                            m_TagTable.Remove(.Item(12, ro.Index).Value.ToString.Trim)
                        End SyncLock
                        vgtotal.Text = CStr(CDbl(vgtotal.Text) - Val(.Item(10, ro.Index).Value))
                        lblqty.Text = CStr(Val(Replace(lblqty.Text, " Pcs", "")) - Val(.Item(5, ro.Index).Value))
                        lblqty.Text = lblqty.Text & " pcs"
                        lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
                        Call Simpan_Header()
                    End With
                    txtkode.Focus()
                End If
            Next
        End If
        ViewRelease(vno_trans.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtkode.Text = "ID SPG" Then
            MsgBox("Isi dahulu ID SPG", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
            txtkode.Focus()
            Exit Sub
        End If
        Me.TopMost = False
        frmView2.ShowDialog()
        frmView2.TopMost = True
        txtkode.Focus()
        If txtkode.Text <> "" Then System.Windows.Forms.SendKeys.Send("{Enter}")
    End Sub

    Private Sub frmSales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If RFIDStatus = True Then
            BackgroundWorker1.WorkerReportsProgress = True
            BackgroundWorker1.WorkerSupportsCancellation = True
            BackgroundWorker1.RunWorkerAsync()
        Else
            If SecLev = "9" Then
                frmMain.Show()
            Else
                frmLogin.Show()
            End If

            Exit Sub
        End If
    End Sub

    Private Sub frmSalesSelf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VNomor = ""
        Me.Show()

        Call Kosong()
        RFIDStatus = False
        cmdsales(9).Enabled = VAda_Promo
        vno_trans.Text = VNomor
        If vno_trans.Text <> "" Then
            Update_MySTAR()
        Else
            vno_trans.Text = Gen_No()
        End If
        'Tanpa SPG
        vspg.Text = VKasir_ID

        '------------
        dsSales = getSqldb("SELECT Seq, Flag_Paket_Discount, PLU, Item_Description, Price, Qty, Discount_Percentage, " & "Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, flag_void FROM Sales_Transaction_Details " & "where transaction_number='" & vno_trans.Text & "'", ConnLocal)
        If RFIDType = "zebra" Then
            'RfidScan2.Visible = True
        Else
            RFIDStatus = False
            'RfidScan2.Visible = False
        End If
        Me.m_UpdateStatusHandler = New UpdateStatus(AddressOf Me.myUpdateStatus)
        Me.m_UpdateReadHandler = New UpdateRead(AddressOf Me.myUpdateRead)
        Me.m_TagTable = New Hashtable
        vgtotal.Text = CStr(0)
        lblqty.Text = CStr(0)
        If dsSales.Tables(0).Rows.Count > 0 Then
            For Each ro As DataRow In dsSales.Tables(0).Rows
                vgtotal.Text = vgtotal.Text + ro("Net_Price")
                lblqty.Text = Val(Replace(lblqty.Text, " pcs", "")) + ro("Qty")
            Next
        End If
        lblqty.Text = lblqty.Text & " pcs"
        If RFIDType = "zebra" Then
            CheckConZebra()
        End If
        If RFIDStatus = False Then
            RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_DEACTIVE.ico").GetThumbnailImage(22, 22, Nothing, IntPtr.Zero)
            RfidScan2.Text = "RFID OFF"
            RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
            RfidScan2.TextAlign = ContentAlignment.BottomCenter
            RfidScan2.TextImageRelation = TextImageRelation.Overlay
            RfidScan2.ForeColor = Color.Red
        Else
            'RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
            'RfidScan2.Text = "RFID ON"
            RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_Refresh.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
            RfidScan2.Text = "REFRESH"
            RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
            RfidScan2.TextAlign = ContentAlignment.BottomCenter
            RfidScan2.TextImageRelation = TextImageRelation.Overlay
            RfidScan2.ForeColor = Color.Green
        End If
        awal = False
        OneReadAll = False
        lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
        txtkode.Select()
        txtkode.Focus()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dsBag As New DataSet
        If VPing = "ONLINE" Then
            dsBag = getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", ConnServer)
        Else
            dsBag = getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", ConnLocal)
        End If

        If dsBag.Tables(0).Rows.Count > 0 Then
            txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
        Else
            txtkode.Text = ""
        End If
        txtkode.Focus()
        If txtkode.Text <> "" Then System.Windows.Forms.SendKeys.Send("{Enter}")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TopMost = False
        frmSizeBag.Text = "PLASTIC"
        frmSizeBag.ShowDialog()
        frmSizeBag.Tag = ""
        frmSizeBag.TopMost = True
        txtkode.Focus()
        If txtkode.Text <> "" Then System.Windows.Forms.SendKeys.Send("{Enter}")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TopMost = False
        frmSizeBag.Text = "TOTE BAG"
        frmSizeBag.ShowDialog()
        frmSizeBag.Tag = ""
        frmSizeBag.TopMost = True
        txtkode.Focus()
        If txtkode.Text <> "" Then System.Windows.Forms.SendKeys.Send("{Enter}")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim rwindex As Integer
        If e.ColumnIndex = 1 Then
            rwindex = e.RowIndex
            spg_btn = DataGridView1.Item(e.ColumnIndex, rwindex).Value
            Me.TopMost = False
            frmSPG.ShowDialog()
            frmSPG.TopMost = True
            getSqldb("Update sales_transaction_details set flag_paket_discount = '" & spg_btn & "' where transaction_number = '" & vno_trans.Text & "' and Seq = '" & DataGridView1.Item(0, e.RowIndex).Value & "'", ConnLocal)
            DataGridView1.Item(e.ColumnIndex, rwindex).Value = spg_btn
        End If
    End Sub
End Class

