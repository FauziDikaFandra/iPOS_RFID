Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Data.SqlClient
Imports System.IO
Public Class frmPaymentSelf
    Inherits System.Windows.Forms.Form
    Dim lokasi As String
    Dim VTukar_Point As String
    Dim TotPay As Integer
    Dim RoundOfPay As Integer
    Dim Tdata1 As New DataSet
    Dim Tdata2 As New DataSet
    Dim t_load As Boolean = False
    Dim cnt As Integer = 0
    Dim Response As String
    Dim DCC As String = ""
    Dim CodePayType As Integer

    Sub ClosePayment()
        Dim RsHapus As New DataSet
        Dim RsAmbil As New DataSet
        getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnLocal)
        'tanpa cek PING
        If VPing = "ONLINE" Then
            getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnServer)
        End If
        Call SaveLog(Me.Name & " " & "Close Payment " & vno_trans.Text & " " & Format(Now, "HH:mm:ss"))
        GotoPayment = False
        txtno_kartu.Clear()
        VNomor = vno_trans.Text
        frmSalesSelf.Enabled = True
        VDiscBySTAR = 0
        Me.Close()
    End Sub
    Private Function Gen_Seq() As String
        Dim RsCari As New DataSet

        RsCari = getSqldb("select ISNULL(MAX(seq),0) as urut from paid where Transaction_Number = '" & vno_trans.Text & "'", ConnLocal)
        Gen_Seq = RsCari.Tables(0).Rows(0).Item("urut") + 1
        RsCari.Clear()
        RsCari = Nothing
    End Function




    Private Function Simpan_Detail(ByRef bayar As Double, ByRef card_no As String, ByRef card_num As String) As Boolean
        Try
            Dim dsCek As New DataSet
            Simpan_Detail = False
            'Menghindari Bug Duplicate Payment
            dsCek = getSqldb("select sum(Paid_Amount) as Paid_Amount from paid where transaction_number = '" & vno_trans.Text & "' and payment_types <> '31' having sum(Paid_Amount) is not null", ConnLocal)
            If dsCek.Tables(0).Rows.Count > 0 Then
                If CDbl(lbltotal.Text) <= CDbl(dsCek.Tables(0).Rows(0).Item("Paid_Amount")) Then
                    GoTo 1
                End If
            End If
            'selesai
            getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, " &
                     "Credit_Card_Name, Paid_Amount, Shift) VALUES ('" & vno_trans.Text & "','" & CodePayType & "','" & Gen_Seq() & "','IDR','1','" & card_no & "','" & UbahChar(card_num) & "'," & bayar & ",'" & VShift & "')", ConnLocal)
            Call SaveLog(Me.Name & " " & "Simpan_Paid " & vno_trans.Text & " " & bayar & " " & Format(Now, "HH:mm:ss"))
1:

            vpay.Text = vpay.Text - (bayar + RoundOfPay)
            Simpan_Detail = True
            Exit Function
        Catch ex As Exception
            MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "Simpan_Paid " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try

    End Function
    Private Sub Cek_Lunas()
        Try
            Dim l As Integer
            Dim RsCari As New DataSet
            Dim strRf As String = ""
            If vpay.Text <= 0 And vstatus.Text.Trim = "SALES" Then 'jika lunas
                If RoundOfPay <> 0 Then
                    getSqldb("Insert Into Paid select top 1 '" & vno_trans.Text & "','36',(Select top 1 seq + 1 from paid where transaction_number = '" & vno_trans.Text & "' Order By Seq desc),'IDR','1','','ROUNDING'," & RoundOfPay & ",Shift from paid where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
                End If

                Call Paid_To_Sales(vno_trans.Text, CDbl(lbltotal.Text) + RoundOfPay, 0)
                GoTo lanjut
            End If

            If vpay.Text >= 0 And vstatus.Text.Trim = "REFUND" Then 'jika lunas
                If RoundOfPay <> 0 Then
                    getSqldb("Insert Into Paid select top 1 '" & vno_trans.Text & "','36',(Select top 1 seq + 1 from paid where transaction_number = '" & vno_trans.Text & "' Order By Seq desc),'IDR','1','','ROUNDING'," & RoundOfPay & ",Shift from paid where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
                End If
                Call Paid_To_Sales(vno_trans.Text, CInt(lbltotal.Text), 0)
                GoTo lanjut
            End If
            RoundOfPay = vpay.Text - (Int(vpay.Text / 100)) * 100
            If vpay.Text < 0 Then
                If vpay.Text <> Int(vpay.Text / 100) * 100 Then
                    RoundOfPay = vpay.Text - (Int(vpay.Text / 100) + 1) * 100
                Else
                    RoundOfPay = 0
                End If
            End If
            'karena tidak ada pembayaran cash
            RoundOfPay = 0
            '------
            lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
            Exit Sub
lanjut:
            If vstatus.Text.Trim = "SALES" Then
                strRf = "update a set a.flag = 1 from Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
                         "where b.transaction_number = '" & vno_trans.Text & "'"
            Else
                strRf = "update a set a.flag = 0 from Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
                         "where b.transaction_number = '" & vno_trans.Text & "'"
            End If
            getSqldb(strRf, ConnLocal)


            If VPing = "ONLINE" Then
                Call Upload_to_Server(vno_trans.Text)
                getSqldb(strRf, ConnServer)
                'getSqldb("Update newvoc Set v_flag = 'R',V_REC = CONVERT(VARCHAR(10), GETDATE(), 120)  where V_NO in (Select credit_card_no from paid " &
                '         "where payment_types = 8 And transaction_number = '" & vno_trans.Text & "')", ConnServer)
            End If
            Call CetakStruk(vstatus.Text, vno_trans.Text)
            'Call CetakStruk(vstatus.Text, vno_trans.Text)
            'If txtcard_no.Text.Trim <> "CM000-00000" Then Call Save_Point(vno_trans.Text, txtcard_no.Text)
            'Call OpenLaci(0) ' buka drawer tanpa print



            l = 0

            If l = 0 Then
                If vstatus.Text.Trim = "SALES" Then Call CetakPromo(vno_trans.Text)
            End If

            'If Linked() Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)

            'tanpa cek PING
            'If VPing = "ONLINE" Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)



            If vstatus.Text.Trim = "SALES" Then
                frmSalesSelf.lblgrand_total.Text = 0
            Else
                frmSalesSelf.lblgrand_total.Text = 0
            End If
            frmSalesSelf.DataGridView1.DataSource = Nothing
            frmSalesSelf.vno_trans.Text = Gen_No()
            frmSalesSelf.Enabled = True
            frmSalesSelf.txtkode.Text = ""
            frmSalesSelf.txtkode.Focus()
            Call CDisplay("CHANGE :", "Rp. " & frmSalesSelf.lblgrand_total.Text)
            vpay.Text = 0
            Kosong()
            VNomor = ""

            'Star_Pt = 0
            'Star_Nm = "ONE TIME CUSTOMER"
            'Star_Id = "10000000"
            'Star_Freq = ""
            'Star_Omz = ""
            'Star_Phone = ""
            'Star_Email = ""
            'Star_updsts = 9
            'Exp_Point = ""
            'Expired_Date = ""

            'frmSales.txtcard_no.Text = txtcard_no.Text
            'frmSales.txtcust_name.Text = "ONE TIME CUSTOMER"
            'frmSales.txtcust_id.Text = "10000000"

            'frmSales.Update_MySTAR()

            'frmSales.lblqty.Text = "0 Pcs"
            'frmSales.txtkode.Text = ""
            'frmSales.txtkode.Focus()
            'frmSales.txtkode.Select()
            'frmSales.txtkode.SelectionStart = 0


            frmSalesSelf.Close()
            frmLogin.Show()
            Me.Close()
            Exit Sub
        Catch ex As Exception
            MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "Cek Lunas " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try

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

    Private Sub Paid_To_Sales(ByRef nomor As String, ByRef total As Integer, ByRef kembali As Integer)
        Dim RsHitung As New DataSet
        On Error GoTo ErrH

        RsHitung = getSqldb("select sum(discount_amount+extradisc_amt) as hemat " & "from sales_transaction_details where transaction_number='" & nomor & "'", ConnLocal)

        StrSQL = "update sales_transactions set total_paid =" & total + kembali & ", change_amount=" & kembali & ", total_discount=" & RsHitung.Tables(0).Rows(0).Item("hemat") & ", status='00' , net_price=net_amount , transaction_time='" & Format(GetSrvDate, "HH:mm") & "' where transaction_number = '" & nomor & "'"

        getSqldb(StrSQL, ConnLocal)

        RsHitung.Clear()
        RsHitung = Nothing
        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Paid_To_Sales " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub
    Private Sub Upload_to_Server(ByRef nomor As String)
        On Error GoTo ErrH
        'On Error Resume Next
        Dim Dbs, Svr As String

        Svr = "[" & VSvr & "]"
        Dbs = ReadIni("Server", "DatabaseName")

        StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.Sales_Transactions (Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " &
            "Transaction_Date, Total_Discount, Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " &
            "Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, " &
            "Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " &
            "Last_Point, Get_Point, Status, Upload_Status, Transaction_Time, Store_Type) " &
            "(SELECT  Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, Transaction_Date, Total_Discount, Points_Of_Spending_Program, " &
            "Point_Of_Item_Program, Point_Of_Card_Program, Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, " &
            "Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, Last_Point, Get_Point, Status, Upload_Status, " &
            "Transaction_Time , Store_Type " &
            "FROM Sales_Transactions where Transaction_Number='" & nomor & "')"

        getSqldb(StrSQL, ConnLocal)

        StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.Sales_Transaction_details (Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " &
            "Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, " & "Flag_Status, Flag_Paket_Discount,Epc_Code) " &
            "(select Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " &
            "Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, " &
            "Flag_Status , Flag_Paket_Discount, Epc_Code " &
            "FROM Sales_Transaction_details where Transaction_Number='" & nomor & "')"

        getSqldb(StrSQL, ConnLocal)

        StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, " &
            "Credit_Card_No, Credit_Card_Name, Paid_Amount, Shift) " & "(select Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, " &
            "Credit_Card_Name , Paid_Amount, Shift " &
            "FROM paid where Transaction_Number='" & nomor & "')"

        getSqldb(StrSQL, ConnLocal)

        getSqldb("Update sales_transactions set upload_status='99' where transaction_number='" & nomor & "'", ConnLocal)
        Call SaveLog(Me.Name & " " & "Upload_to_Server " & VSuper_Nm & " " & " " & Format(Now, "HH:mm:ss"))
        Exit Sub

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Upload_to_Server " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub




    Private Sub txtno_kartu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno_kartu.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtno_kartu_TextChanged(sender As Object, e As EventArgs) Handles txtno_kartu.TextChanged
        If Len(txtno_kartu.Text) > 16 Then
            txtno_kartu.Text = VB.Left(txtno_kartu.Text, 16)
        End If
    End Sub


    Sub Kosong()
        txtno_kartu.Clear()
        VDiscBySTAR = 0
        GotoPayment = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If t_load = False Then
            Exit Sub
        End If
        lokasi = ""
        RoundOfPay = 0
        lbltotal.Text = CDec(TotPay).ToString("N0")
        txtno_kartu.Select()
        txtno_kartu.Focus()
        txtno_kartu.SelectionStart = 0
        txtno_kartu.SelectionLength = txtno_kartu.Text.Length
    End Sub

    Private Sub txtno_kartu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtno_kartu.KeyDown
        Select Case e.KeyCode
            Case 13
                If (vstatus.Text.Trim = "SALES" And lbltotal.Text <= vpay.Text) Or (vstatus.Text.Trim = "REFUND" And lbltotal.Text >= vpay.Text) Then
                    Cek_ECR()
                    If isECR = 1 Then
                        Exit Sub
                    End If
                    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
                        txtno_kartu.Text = ""
                        Call Cek_Lunas()
                    End If
                Else
                    MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " & vbNewLine & "melebihi sisa yang harus dibayar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    txtno_kartu.Focus()
                End If
        End Select

    End Sub

    Private Sub _btnNum_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnNum_0.Click, _btnNum_1.Click,
    _btnNum_2.Click, _btnNum_3.Click, _btnNum_4.Click, _btnNum_5.Click, _btnNum_6.Click, _btnNum_7.Click, _btnNum_8.Click,
    _btnNum_9.Click, _btnNum_11.Click, _btnNum_12.Click, _btnNum_13.Click
        Dim btn As Button = sender
        txtno_kartu.Focus()
        If CInt(btn.Tag) < 11 Then
            If txtno_kartu.SelectionLength = txtno_kartu.Text.Length Then
                txtno_kartu.Clear()
            End If
            txtno_kartu.Text = txtno_kartu.Text & btn.Text
        End If
        txtno_kartu.SelectionStart = txtno_kartu.Text.Length
        Select Case CInt(btn.Tag)
            Case 11
                If (vstatus.Text.Trim = "SALES" And lbltotal.Text <= vpay.Text) Or (vstatus.Text.Trim = "REFUND" And lbltotal.Text >= vpay.Text) Then
                    'Cek_ECR()
                    'If isECR = 1 Then
                    '    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
                    '        txtno_kartu.Text = ""
                    '        Call Cek_Lunas()
                    '    End If
                    'End If
                    'If isECR = 2 And txtno_kartu.Enabled = False And txtno_kartu.Text.Length > 10 Then
                    '    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
                    '        txtno_kartu.Text = ""
                    '        Call Cek_Lunas()
                    '    End If
                    '    isECR = 1
                    '    Exit Sub
                    'Else
                    '    If isECR = 1 Then
                    '        If CodePayType <> 6 Then
                    '            MsgBox("ECR Connections Failed !!!")
                    '            txtno_kartu.Enabled = True
                    '            txtno_kartu.Clear()
                    '            txtno_kartu.Select()
                    '            txtno_kartu.Focus()
                    '            ClosePayment()
                    '            Exit Sub
                    '        End If
                    '    End If

                    'End If
                    If txtno_kartu.Text.Length = 0 Then
                        MsgBox("Please Insert Card No !!")
                        txtno_kartu.Focus()
                        Exit Sub
                    End If

                    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
                        txtno_kartu.Text = ""
                        Call Cek_Lunas()
                    End If
                Else
                    MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " & vbNewLine & "melebihi sisa yang harus dibayar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    If isECR = 2 Then
                        isECR = 1
                    End If
                    txtno_kartu.Focus()
                End If
            Case 12
                System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
            Case 13
                txtno_kartu.Text = ""
        End Select
    End Sub

    Private Sub _cmdpay_0_Click(sender As Object, e As EventArgs) Handles _cmdpay_0.Click
        ClosePayment()
    End Sub

    Sub Cek_ECR()
        If isECR = 1 Then
            Try
                lblPleaseWait.Visible = True
                lblCancel.Visible = True
                Frame2.Enabled = False
                _cmdpay_0.Enabled = False
                SerialPort1.Encoding = System.Text.Encoding.GetEncoding(28591)
                'Dim input As String = "0150013031" &
                '    ConvertHex(CDec(lbltotal.Text & "00").ToString.PadLeft(12, "0"c)) &
                '    "303030303030303030303030" &
                '    "31363838373030363237323031383932202020" &
                '    "32313130" &
                '    "30303030303030302020202020204E4E4E202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202003"
                'input = "02" & input & LRC(input)
                'input tanpa kartu
                Dim input As String = "0150013031" &
                    ConvertHex(CDec(lbltotal.Text & "00").ToString.PadLeft(12, "0"c)) &
                    "303030303030303030303030" &
                    "20202020202020202020202020202020202020" &
                    "20202020" &
                    "30303030303030302020202020204E4E4E202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202003"
                input = "02" & input & LRC(input)

                Dim bytes As New List(Of Byte)()
                Dim cc As String
                For i As Integer = 0 To input.Length - 2 Step 2
                    Try
                        cc = Convert.ToByte(input.Substring(i, 2), 16)
                        bytes.Add(Convert.ToByte(input.Substring(i, 2), 16))
                    Catch ex As Exception

                    End Try
                Next
                Dim process_CMD() As Byte = bytes.ToArray()
                SerialPort1.PortName = "COM" & ECRComm
                Try
                    If SerialPort1.IsOpen = True Then
                        SerialPort1.Close()
                    End If
                    SerialPort1.Open()
                    SerialPort1.Write(process_CMD, 0, process_CMD.Length)
                    SerialPort1.Close()

                    Timer1.Enabled = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    'If MsgBox("Don't Use ECR BCA ??", MsgBoxStyle.YesNo, "Informations") = vbYes Then
                    '    isECR = 0
                    'End If
                    Timer1.Enabled = False
                    Timer1.Stop()
                    txtno_kartu.Enabled = True
                    Frame2.Enabled = True
                    _cmdpay_0.Enabled = True
                    lblPleaseWait.Visible = False
                    lblCancel.Visible = False
                    If CodePayType <> 6 Then
                        ClosePayment()
                    End If
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Timer1.Enabled = False
                Timer1.Stop()
                txtno_kartu.Enabled = True
                Frame2.Enabled = True
                _cmdpay_0.Enabled = True
                lblPleaseWait.Visible = False
                lblCancel.Visible = False
                If CodePayType <> 6 Then
                    ClosePayment()
                End If
            End Try

        Else
            txtno_kartu.Enabled = True
        End If
    End Sub

    Private Function ConvertHex(ByVal data As String) As String
        Dim Hasil As String = ""
        For x As Integer = 0 To Len(data) - 1
            Hasil = Hasil & "3" & data.Substring(x, 1)
        Next
        data = Hasil
        Return data
    End Function

    Private Function LRC(ByVal data As String) As String
        Dim binStr As String
        Dim bin(8) As Integer
        Dim Decimals As Integer
        Dim Hexadecimal As String
        For x As Integer = 0 To data.Length - 2 Step 2
            binStr = Convert.ToString(Convert.ToInt32(data.Substring(x, 2), 16), 2).PadLeft(8, "0"c)
            For i As Integer = 0 To 7
                bin(i + 1) += binStr.Substring(i, 1)
            Next
        Next
        Decimals = Convert.ToInt32(bin(1) Mod 2 & bin(2) Mod 2 & bin(3) Mod 2 & bin(4) Mod 2 & bin(5) Mod 2 & bin(6) Mod 2 & bin(7) Mod 2 & bin(8) Mod 2, 2)
        Hexadecimal = Convert.ToString(Decimals, 16).ToUpper
        LRC = Hexadecimal
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cnt += 1
        If cnt > 2000 Then
            Timer1.Stop()
            lblPleaseWait.Visible = False
            lblCancel.Visible = False
            If MsgBox("Connections Time Out !!! Try Again??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cnt = 11
                lblPleaseWait.Visible = True
                lblCancel.Visible = True
                Timer1.Start()
            Else
                Timer1.Enabled = False
                Timer1.Stop()
                Frame2.Enabled = True
                lblPleaseWait.Visible = False
                lblCancel.Visible = False
                _cmdpay_0.Enabled = True
                txtno_kartu.Enabled = True
                txtno_kartu.Focus()
                If CodePayType <> 6 Then
                    ClosePayment()
                End If
                Exit Sub
            End If
        End If

        If cnt > 10 Then
            If SerialPort1.IsOpen = False Then
                SerialPort1.Open()
            End If
            Dim buff As String
            Dim i As Short
            Dim d As String
            Dim count As Integer
            count = SerialPort1.BytesToRead

            Response = ""
            buff = SerialPort1.ReadExisting

            For i = 1 To Len(buff)
                d = Hex(Asc(Mid(buff, i, 1)))
                Response = Response & d
            Next i

            If Response = "6" Then
                Response = ""
            End If

            If Response <> "" Then
                SerialPort1.Close()
                Dim ResponseASCII As String
                ResponseASCII = HexToString(Mid(Response, 9, Len(Response) - 12))
                If Mid(ResponseASCII, 48, 2) <> "00" Then
                    Timer1.Enabled = False
                    Timer1.Stop()
                    Me.TopMost = False
                    MsgBox("Respon Failed From EDC Device !!!")
                    Me.TopMost = True
                    Frame2.Enabled = True
                    lblPleaseWait.Visible = False
                    lblCancel.Visible = False
                    _cmdpay_0.Enabled = True
                    txtno_kartu.Enabled = True
                    txtno_kartu.Focus()
                        If CodePayType <> 6 Then
                            ClosePayment()
                        End If

                        Exit Sub
                    End If
                Timer1.Enabled = False
                Timer1.Stop()
                If Mid(ResponseASCII, 163, 1) = "Y" Then
                    DCC = "*" & Mid(ResponseASCII, 178, 3) & "*"
                Else
                    DCC = ""
                End If
                txtno_kartu.Text = VB.Left(Mid(ResponseASCII, 25, 19), 16)
                txtno_kartu.Enabled = False
                'Frame2.Enabled = True
                'lblPleaseWait.Visible = False
                'lblCancel.Visible = False
                isECR = 2

                'tambahan langsung print setelah dapat respon dari EDC
                If (vstatus.Text.Trim = "SALES" And lbltotal.Text <= vpay.Text) Or (vstatus.Text.Trim = "REFUND" And lbltotal.Text >= vpay.Text) Then
                    'Cek_ECR()
                    'If isECR = 1 Then
                    '    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
                    '        txtno_kartu.Text = ""
                    '        Call Cek_Lunas()
                    '    End If
                    'End If
                    If isECR = 2 And txtno_kartu.Enabled = False And txtno_kartu.Text.Length > 10 Then
                        If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), DCC) Then
                            txtno_kartu.Text = ""
                            Call Cek_Lunas()
                        End If
                        isECR = 1
                        Frame2.Enabled = True
                        lblPleaseWait.Visible = False
                        lblCancel.Visible = False
                        Exit Sub
                    Else
                        If isECR = 1 Then
                            MsgBox("ECR Connections Failed !!!")
                            txtno_kartu.Enabled = True
                            txtno_kartu.Clear()
                            txtno_kartu.Select()
                            txtno_kartu.Focus()
                            If CodePayType <> 6 Then
                                ClosePayment()
                            End If
                            Exit Sub
                        End If
                    End If
                    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
                        txtno_kartu.Text = ""
                        Call Cek_Lunas()
                        Frame2.Enabled = True
                        lblPleaseWait.Visible = False
                        lblCancel.Visible = False
                    End If
                Else
                    MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " & vbNewLine & "melebihi sisa yang harus dibayar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    If isECR = 2 Then
                        isECR = 1
                    End If
                    txtno_kartu.Focus()
                End If
            End If
        End If
    End Sub

    Function HexToString(ByVal hex As String) As String
        Dim text As New System.Text.StringBuilder(hex.Length \ 2)
        For i As Integer = 0 To hex.Length - 2 Step 2
            text.Append(Chr(Convert.ToByte(hex.Substring(i, 2), 16)))
        Next
        Return text.ToString
    End Function

    Private Sub CetakPromo(ByRef No_trans As String)
        Dim RsPromo As New DataSet
        Dim RsBayar As New DataSet
        Dim JmlKupon As Short
        Dim NilaiOK, ByrNonVoc As Integer
        Dim Msg As String
        Dim min_belanja As Integer

        StrSQL = "SELECT promo_hdr.promo_id, promo_name, min_purchase, min_member, disc, tipe, voucher, lipat, ismsg, isprn , " &
                 "SUM(Sales_Transaction_Details.Net_Price) As Belanja, islimit, qtylimit, qtyout, isnull(txt1,'') as txt1, " &
                 "isnull(txt2,'') as txt2, isnull(txt3,'') as txt3, isnull(txt4,'') as txt4 FROM Promo_Hdr INNER JOIN " &
                 "Promo_Dtl ON Promo_Hdr.promo_id = Promo_Dtl.promo_id INNER JOIN Sales_Transaction_Details ON Promo_Dtl.PLU = " &
                 "Sales_Transaction_Details.PLU WHERE (Sales_Transaction_Details.Transaction_Number = '" & No_trans & "') " &
                 "AND getdate() Between Start_Date And End_Date And aktif=1 GROUP BY promo_hdr.promo_id, promo_name, " &
                 "min_purchase, min_member, disc, tipe, voucher, lipat, ismsg, isprn, islimit, qtylimit, qtyout, txt1, " &
                 "txt2, txt3, txt4 Having (promo_hdr.tipe > 30) And SUM(Sales_Transaction_Details.Net_Price)>0 order " &
                 "by promo_hdr.promo_id"

        'If Linked() Then
        '    RsPromo = getSqldb(StrSQL, ConnServer)
        'Else
        '    RsPromo = getSqldb(StrSQL, ConnLocal)
        'End If
        'tanpa cek PING
        If VPing = "ONLINE" Then
            RsPromo = getSqldb(StrSQL, ConnServer)
        Else
            RsPromo = getSqldb(StrSQL, ConnLocal)
        End If

        If RsPromo.Tables(0).Rows.Count = 0 Then
            RsPromo.Clear()
            RsPromo = Nothing
            Exit Sub
        End If

        RsBayar = getSqldb("SELECT Transaction_Number, SUM(Paid_Amount) AS Bayar From Paid where(Payment_Types Not in " &
                           "('8','5')) " & "GROUP BY Transaction_Number " & "HAVING (Transaction_Number = '" & No_trans & "')", ConnLocal)

        If RsBayar.Tables(0).Rows.Count > 0 Then
            ByrNonVoc = RsBayar.Tables(0).Rows(0).Item("bayar")
        Else
            ByrNonVoc = 0
        End If
        RsBayar.Clear()
        RsBayar = Nothing

        Dim RsLagi1 As New DataSet
        Dim RsBayarAll As New DataSet
        Dim RsLagi As New DataSet
        Dim NilaiTransx(10) As String
        Dim NilaiInfox(10) As String
        For Each ro As DataRow In RsPromo.Tables(0).Rows
            If VB.Left(Star_Id, 6) = "100000" Or Star_Id = "" Then
                min_belanja = ro("min_purchase")
            Else
                min_belanja = ro("min_member")
            End If

            Msg = ""
            Select Case ro("tipe")
                Case 31 'GWP
                    JmlKupon = 0
                    If ro("voucher") = 0 And ro("lipat") = 0 Then
                        If ByrNonVoc < ro("Belanja") Then
                            NilaiOK = ByrNonVoc
                        Else
                            NilaiOK = ro("Belanja")
                        End If

                        If NilaiOK >= min_belanja Then
                            JmlKupon = 1
                        End If
                    ElseIf ro("voucher") = 1 And ro("lipat") = 0 Then
                        If ro("Belanja") >= min_belanja Then
                            NilaiOK = ro("Belanja")
                            JmlKupon = 1
                        End If
                    ElseIf ro("voucher") = 0 And ro("lipat") = 1 Then
                        If ByrNonVoc < ro("Belanja") Then
                            NilaiOK = ByrNonVoc
                        Else
                            NilaiOK = ro("Belanja")
                        End If

                        If NilaiOK >= min_belanja Then
                            JmlKupon = roundDown(NilaiOK / min_belanja)
                        End If
                    ElseIf ro("voucher") = 1 And ro("lipat") = 1 Then
                        If ro("Belanja") >= min_belanja Then
                            NilaiOK = ro("Belanja")
                            JmlKupon = roundDown(NilaiOK / min_belanja)
                        End If
                    End If

                    If JmlKupon > 0 Then
                        If ro("islimit") = 1 Then
                            If ro("QtyLimit") < ro("QtyOut") + JmlKupon Then
                                MsgBox("Hadiah " & ro("promo_name") & " sudah habis", MsgBoxStyle.Information, "Oops..")
                                GoTo lanjut
                            End If

                            StrSQL = "insert into promo_sales(promo_id,transaction_number,nilai,qty_promo,status) values ('" & ro("promo_id") & "', '" & No_trans & "', " & NilaiOK & ", " & JmlKupon & ", '00')"

                            getSqldb(StrSQL, ConnLocal)
                            'If Linked() Then
                            '    getSqldb(StrSQL, ConnServer)
                            '    getSqldb("Update promo_sales set status='99' where promo_id = '" & ro("promo_id").Value & "' and transaction_number='" & No_trans & "'", ConnLocal)
                            'End If

                            'tanpa cek PING
                            If VPing = "ONLINE" Then
                                getSqldb(StrSQL, ConnServer)
                                getSqldb("Update promo_sales set status='99' where promo_id = '" & ro("promo_id") & "' and transaction_number='" & No_trans & "'", ConnLocal)
                            End If

                            StrSQL = "update promo_hdr set qtyout=qtyout+ " & JmlKupon & " where promo_id='" & ro("promo_id") & "'"

                            getSqldb(StrSQL, ConnLocal)
                            'If Linked() Then getSqldb(StrSQL, ConnServer)

                            'tanpa cek PING
                            If VPing = "ONLINE" Then getSqldb(StrSQL, ConnServer)
                        End If

                        If ro("tipe") = 31 Then 'GWP Normal                    
                            If ro("txt1") <> "" Then Msg = ro("txt1") + vbNewLine
                            If ro("txt2") <> "" Then Msg = Msg + ro("txt2") & " = " & JmlKupon & " pcs"
                            If ro("txt3") <> "" Then Msg = Msg & vbNewLine + ro("txt3")
                            If ro("txt4") <> "" Then Msg = Msg & vbNewLine + ro("txt4")
                            Msg = Msg & vbNewLine & vbNewLine & "Nilai Transaksi : Rp." & CDec(NilaiOK).ToString("N0")
                            Msg = Msg & vbNewLine & "Struk ini hanya berlaku tgl " & Format(GetSrvDate, "dd MMM yy")
                        End If

                        If VB.Left(Star_No, 3) <> "LM-" Then Msg = Msg & vbNewLine & "MyLAKON Card : " & Star_No
                        If ro("isprn") = 1 Then Call CetakStruk_Promo(ro("promo_id"), No_trans, Msg)
                        If ro("ismsg") = 1 Then MsgBox(Msg, MsgBoxStyle.Information, "Oops..")
                        If ro("islimit") = 1 Then MsgBox("Sisa Stok Hadiah " & ro("promo_name") & " " & ro("QtyLimit") - ro("QtyOut") - 1 & " pcs", MsgBoxStyle.Information, "Oops..")
                    End If
            End Select
lanjut:
        Next
        Call SaveLog(Me.Name & " " & "Cetak Promo " & VSuper_Nm & " " & " " & Format(Now, "HH:mm:ss"))
        RsPromo.Clear()
        RsPromo = Nothing
        Exit Sub
ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Cetak Promo " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.TopMost = False
        If Not Super(2) Then Exit Sub
        Me.TopMost = True
        Frame2.Enabled = True
        lblPleaseWait.Visible = False
        lblCancel.Visible = False
        _cmdpay_0.Enabled = True
        txtno_kartu.Enabled = True
    End Sub

    Private Sub frmPaymentSelf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vno_trans.Text = VNomor
        lblPleaseWait.Visible = False
        lblCancel.Visible = False
        t_load = False
        rbBcaCard.Checked = True
        CodePayType = 3
        Dim c As New ArrayList
        m_con = New SqlConnection(ConnLocal)
        Try
            Dim strsql As String
            strsql = "SELECT Payment_Types, Description From Payment_Types where Seq<30 And Types in ('DC','CC','OV')  ORDER BY Description"

            If m_con.State = ConnectionState.Closed Then m_con.Open()
            Dim cmd2 As New SqlCommand(strsql, m_con)

            Dim objreader2 As SqlDataReader = cmd2.ExecuteReader()
            Do While objreader2.Read()
                c.Add(New CCombo(Trim(objreader2("Payment_Types")), Trim(objreader2("Description").ToString)))
            Loop
            m_con.Close()
            With ComboBox1
                .DataSource = c
                .DisplayMember = "Number_Name"
                .ValueMember = "ID"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        TotPay = vpay.Text
        lbltotal.Text = CDec(vpay.Text).ToString("N0")
        'Tambahan Harga Point Variable
        RoundOfPay = 0
        t_load = True
        RoundOfPay = vpay.Text - (Int(vpay.Text / 100)) * 100
        If vpay.Text < 0 Then
            If vpay.Text <> Int(vpay.Text / 100) * 100 Then
                RoundOfPay = vpay.Text - (Int(vpay.Text / 100) + 1) * 100
            Else
                RoundOfPay = 0
            End If
        End If
        'karena tidak ada pembayaran cash
        RoundOfPay = 0
        '------
        lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
        lbltotal.Text = CDec(TotPay).ToString("N0")
        txtno_kartu.Enabled = False
        If TotPay > 0 Then
            Cek_ECR()
        End If

        txtno_kartu.Select()
        txtno_kartu.Focus()
    End Sub

    Private Sub rbBcaCard_CheckedChanged(sender As Object, e As EventArgs) Handles rbBcaCard.CheckedChanged
        lblPayTypes.Text = "BCA CARD"
        CodePayType = 3
        txtno_kartu.Focus()
    End Sub

    Private Sub rbDebitBCA_CheckedChanged(sender As Object, e As EventArgs) Handles rbDebitBCA.CheckedChanged
        lblPayTypes.Text = "BCA DEBIT"
        CodePayType = 4
        txtno_kartu.Focus()
    End Sub

    Private Sub rbGopay_CheckedChanged(sender As Object, e As EventArgs) Handles rbGopay.CheckedChanged
        lblPayTypes.Text = "GO PAY"
        CodePayType = 6
        txtno_kartu.Focus()
    End Sub

    Private Sub rbVisa_CheckedChanged(sender As Object, e As EventArgs) Handles rbVisa.CheckedChanged
        lblPayTypes.Text = "VISA"
        CodePayType = 2
        txtno_kartu.Focus()
    End Sub

    Private Sub rbMaster_CheckedChanged(sender As Object, e As EventArgs) Handles rbMaster.CheckedChanged
        lblPayTypes.Text = "MASTER"
        CodePayType = 2
        txtno_kartu.Focus()
    End Sub

    Private Sub rbAnother_CheckedChanged(sender As Object, e As EventArgs) Handles rbAnother.CheckedChanged
        lblPayTypes.Text = "OTHER BANK"
        CodePayType = 10
        txtno_kartu.Focus()
    End Sub

End Class