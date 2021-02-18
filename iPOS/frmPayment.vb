Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Public Class frmPayment
    Inherits System.Windows.Forms.Form
    Dim lokasi As String
    Dim VTukar_Point, UniqueCode As String
    Dim TotPay As Integer
    Dim RoundOfPay As Integer
    Dim Tdata1 As New DataSet
    Dim Tdata2 As New DataSet
    Dim t_load As Boolean = False
    Dim cnt As Integer = 0
    Dim Response As String
    Private Sub cmdvoc_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdvoc.Click
        frmDisc.lblmsg.Text = "VOUCHER"
        frmDisc.ShowDialog()
        txtno_voc.Focus()
        System.Windows.Forms.SendKeys.Send("{end}")
    End Sub
    Private Sub frmPayment_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'TotPay = vpay.Text
        'lbltotal.Text = CDec(vpay.Text).ToString("N0")
        'lblbayar.Text = CStr(0)
        'lblsisa.Text = CDec(vpay.Text).ToString("N0")
        ''Tambahan Harga Point Variable
        'txtharga_point.Text = VHargaPoint
    End Sub
    Sub KeyDownEnterDgv()
        RoundOfPay = 0
        lbltotal.Text = CDec(TotPay).ToString("N0")
        lblsisa.Text = CDec(vpay.Text).ToString("N0")
        Select Case DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            Case "CS"
                _frmpay_0.Visible = True
                RoundOfPay = vpay.Text - (Int(vpay.Text / 100)) * 100
                If vpay.Text < 0 Then
                    If vpay.Text <> Int(vpay.Text / 100) * 100 Then
                        RoundOfPay = vpay.Text - (Int(vpay.Text / 100) + 1) * 100
                    Else
                        RoundOfPay = 0
                    End If
                End If
                'RoundOfPay = 0
                lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
                lblsisa.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                'txtcash.Text = CDec(vpay.Text).ToString("N0")
                txtcash.Select()
                txtcash.Focus()
                txtcash.SelectionStart = 0
                txtcash.SelectionLength = txtcash.Text.Length
            Case "CC", "DC"
                _frmpay_1.Visible = True

                If txtnama.Enabled = True Then
                    txtno_kartu.Select()
                    txtno_kartu.Focus()
                    txtno_kartu.SelectionStart = 0
                    txtno_kartu.SelectionLength = txtno_kartu.Text.Length
                Else
                    txtcredit.Select()
                    txtcredit.Focus()
                    txtcredit.SelectionStart = 0
                    txtcredit.SelectionLength = txtno_kartu.Text.Length
                End If
            Case "SV", "OV"
                _frmpay_2.Visible = True
                txtno_voc.Select()
                txtno_voc.Focus()
                txtno_voc.SelectionStart = 0
                txtno_voc.SelectionLength = txtno_voc.Text.Length
            Case "PR"
                Call tampil_point()
                _frmpay_3.Visible = True
                txtpoint.Select()
                txtpoint.Focus()
                txtpoint.SelectionStart = 0
                txtpoint.SelectionLength = txtpoint.Text.Length
        End Select
    End Sub
    Private Sub frmPayment_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        DataGridView2.DataSource = Nothing
        UniqueCode = ""
        Tdata2.Clear()
        vno_trans.Text = VNomor
        t_load = False
        Tdata1 = getSqldb("SELECT Payment_Types, Description, Types, Seq From Payment_Types where Seq<30 ORDER BY Seq", ConnLocal)
        If Tdata1.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = Tdata1.Tables(0)
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(1).HeaderText = "TIPE PEMBAYARAN"
            DataGridView1.Refresh()
        End If
        TotPay = vpay.Text
        lbltotal.Text = CDec(vpay.Text).ToString("N0")
        lblbayar.Text = CStr(0)
        lblsisa.Text = CDec(vpay.Text).ToString("N0")
        'Tambahan Harga Point Variable
        txtharga_point.Text = VHargaPoint
        Tdata2 = getSqldb("SELECT aa.Seq, bb.Description, Paid_Amount, Credit_Card_No, Credit_Card_Name " & "FROM Paid aa INNER JOIN Payment_Types bb ON aa.Payment_Types = bb.Payment_Types" & " where transaction_number = '" & vno_trans.Text & "' order by aa.seq", ConnLocal)
        If Tdata2.Tables(0).Rows.Count > 0 Then
            DataGridView2.DataSource = Nothing
            DataGridView2.DataSource = Tdata2.Tables(0)
            DataGridView2.Columns(0).HeaderText = "No"
            DataGridView2.Columns(0).Width = 30
            DataGridView2.Columns(1).HeaderText = "Tipe"
            DataGridView2.Columns(1).Width = 150
            DataGridView2.Columns(2).HeaderText = "Nilai"
            DataGridView2.Columns(2).Width = 90
            DataGridView2.Columns(3).HeaderText = "No Kartu"
            DataGridView2.Columns(3).Width = 100
            DataGridView2.Columns(4).HeaderText = "Nama Kartu"
            DataGridView2.Columns(4).Width = 170
            DataGridView2.Columns("Paid_Amount").DefaultCellStyle.Format = "N0"
        End If
        DataGridView1.Select()
        DataGridView1.Focus()
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(1)
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
        'DataGridView1_CellClick(Me.DataGridView1, New DataGridViewCellEventArgs(2, 0))
        'DataGridView1.Focus()
        'Cash Di Awal
        _frmpay_0.Visible = True
        _frmpay_0.Visible = True
        _frmpay_1.Visible = False
        _frmpay_2.Visible = False
        _frmpay_3.Visible = False
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
        'RoundOfPay = 0
        lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
        lblsisa.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
        'txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")

        lokasi = "txtcash"
        txtkembali.Text = 0
        lbltotal.Text = CDec(TotPay).ToString("N0")
        lblsisa.Text = CDec(vpay.Text).ToString("N0")
        no_kartuECR = ""
        _cmdpay_0.Enabled = True
        If TotPay > 0 Then
            Cek_ECR()
        End If
        'txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
        txtcash.Select()
        txtcash.Focus()
        txtcash.SelectionStart = 0
        txtcash.SelectionLength = txtcash.Text.Length
    End Sub

    Sub Cek_ECR()
        If isECR = 1 Then
            txtno_kartu.Enabled = False
            txtnama.Enabled = False
            txtcredit.Enabled = False
            If MsgBox("Use ECR BCA??", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.No Then
                Frame2.Enabled = True
                _cmdpay_0.Enabled = True
                Label3.Visible = False
                txtno_kartu.Enabled = True
                txtnama.Enabled = True
                txtcredit.Enabled = True
                Exit Sub
            End If
            Label3.Visible = True
            Frame2.Enabled = False
            '_cmdpay_0.Enabled = False
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
                SerialPort1.Open()
                SerialPort1.Write(process_CMD, 0, process_CMD.Length)
                SerialPort1.Close()

                Timer1.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Frame2.Enabled = True
                _cmdpay_0.Enabled = True
                Label3.Visible = False
                txtno_kartu.Enabled = True
                txtnama.Enabled = True
                txtcredit.Enabled = True
            End Try

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
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If t_load = False Then
            Exit Sub
        End If
        lokasi = ""
        lblmsg.Text = DataGridView1.Item(1, e.RowIndex).Value.ToString.Trim
        _frmpay_0.Visible = False
        _frmpay_1.Visible = False
        _frmpay_2.Visible = False
        _frmpay_3.Visible = False
        RoundOfPay = 0
        lbltotal.Text = CDec(TotPay).ToString("N0")
        lblsisa.Text = CDec(vpay.Text).ToString("N0")
        txtkembali.Text = 0
        Select Case DataGridView1.Item(2, e.RowIndex).Value
            Case "CS"
                _frmpay_0.Visible = True
                RoundOfPay = vpay.Text - (Int(vpay.Text / 100)) * 100
                If vpay.Text < 0 Then
                    If vpay.Text <> Int(vpay.Text / 100) * 100 Then
                        RoundOfPay = vpay.Text - (Int(vpay.Text / 100) + 1) * 100
                    Else
                        RoundOfPay = 0
                    End If
                End If
                'RoundOfPay = 0
                lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
                lblsisa.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                'txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                txtcash.Select()
                txtcash.Focus()
                txtcash.SelectionStart = 0
                txtcash.SelectionLength = txtcash.Text.Length
            Case "CC", "DC"
                _frmpay_1.Visible = True
                txtno_kartu.Text = ""
                txtno_kartu.Text = no_kartuECR
                If txtnama.Text.Contains("*") Then
                Else
                    txtnama.Text = ""
                End If
                If txtnama.Enabled = True Then
                    txtno_kartu.Select()
                    txtno_kartu.Focus()
                    txtcredit.Text = CDec(vpay.Text).ToString("N0")
                    txtno_kartu.SelectionStart = 0
                    txtno_kartu.SelectionLength = txtno_kartu.Text.Length
                Else
                    txtcredit.Text = CDec(vpay.Text).ToString("N0")
                    txtcredit.Select()
                    txtcredit.Focus()
                    txtcredit.SelectionStart = 0
                    txtcredit.SelectionLength = txtno_kartu.Text.Length
                    btnNum(11).Select()
                    btnNum(11).Focus()
                End If
            Case "SV", "OV"
                _frmpay_2.Visible = True
                txtno_voc.Text = ""
                txtvoucher.Text = ""
                txtno_voc.Select()
                txtno_voc.Focus()
                txtno_voc.SelectionStart = 0
                txtno_voc.SelectionLength = txtno_voc.Text.Length
            Case "PR"
                Call tampil_point()
                _frmpay_3.Visible = True
                txtpoint.Select()
                txtpoint.Focus()
                txtpoint.SelectionStart = 0
                txtpoint.SelectionLength = txtpoint.Text.Length
        End Select
    End Sub
    Private Function Cari_Point(ByRef No_trans As String) As Short
        Dim RsCari As New DataSet

        RsCari = getSqldb("select claim_point from cust_point_trans where Trans_nr = '" & No_trans & "'", ConnLocal)
        Cari_Point = IIf(Not IsDBNull(RsCari.Tables(0).Rows(0).Item("claim_point").Value), RsCari.Tables(0).Rows(0).Item("claim_point").Value, 0)
        RsCari.Clear()
        RsCari = Nothing
    End Function
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        Select Case e.KeyCode
            Case 13
                _frmpay_0.Visible = False
                _frmpay_1.Visible = False
                _frmpay_2.Visible = False
                _frmpay_3.Visible = False
                RoundOfPay = 0
                lbltotal.Text = CDec(TotPay).ToString("N0")
                lblsisa.Text = CDec(vpay.Text).ToString("N0")
                Select Case DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
                    Case "CS"
                        _frmpay_0.Visible = True
                        RoundOfPay = vpay.Text - (Int(vpay.Text / 100)) * 100
                        If vpay.Text < 0 Then
                            If vpay.Text <> Int(vpay.Text / 100) * 100 Then
                                RoundOfPay = vpay.Text - (Int(vpay.Text / 100) + 1) * 100
                            Else
                                RoundOfPay = 0
                            End If
                        End If
                        'RoundOfPay = 0
                        lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
                        lblsisa.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                        txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                        txtcash.Select()
                        txtcash.Focus()
                        txtcash.SelectionStart = 0
                        txtcash.SelectionLength = txtcash.Text.Length
                    Case "CC", "DC"
                        _frmpay_1.Visible = True
                        txtno_kartu.Text = ""
                        txtno_kartu.Text = no_kartuECR
                        If txtnama.Text.Contains("*") Then
                        Else
                            txtnama.Text = ""
                        End If
                        If txtnama.Enabled = True Then
                            txtno_kartu.Select()
                            txtno_kartu.Focus()
                            txtcredit.Text = CDec(vpay.Text).ToString("N0")
                            txtno_kartu.SelectionStart = 0
                            txtno_kartu.SelectionLength = txtno_kartu.Text.Length
                        Else
                            txtcredit.Text = CDec(vpay.Text).ToString("N0")
                            txtcredit.Select()
                            txtcredit.Focus()
                            txtcredit.SelectionStart = 0
                            txtcredit.SelectionLength = txtno_kartu.Text.Length
                            btnNum(11).Select()
                            btnNum(11).Focus()
                        End If

                    Case "SV", "OV"
                        _frmpay_2.Visible = True
                        txtno_voc.Text = ""
                        txtvoucher.Text = ""
                        txtno_voc.Select()
                        txtno_voc.Focus()
                        txtno_voc.SelectionStart = 0
                        txtno_voc.SelectionLength = txtno_voc.Text.Length
                    Case "PR"
                        Call tampil_point()
                        _frmpay_3.Visible = True
                        txtpoint.Select()
                        txtpoint.Focus()
                        txtpoint.SelectionStart = 0
                        txtpoint.SelectionLength = txtpoint.Text.Length
                End Select
                e.Handled = True
            Case 27
                'ClosePayment()
        End Select
    End Sub
    Sub ClosePayment()
        Dim RsHapus As New DataSet
        Dim RsAmbil As New DataSet

        Call MySTAR(txtcard_no.Text)
        Call tampil_point()
        getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnLocal)

        'If Linked() Then
        '    getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnServer)
        'End If

        'tanpa cek PING
        If VPing = "ONLINE" Then
            getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnServer)
        End If
        Call SaveLog(Me.Name & " " & "Close Payment " & vno_trans.Text & " " & Format(Now, "HH:mm:ss"))
        'RoundOfPay = 0
        txtcash.Clear()
        txtno_kartu.Clear()
        txtnama.Clear()
        txtcredit.Clear()
        txtno_voc.Clear()
        txtvoucher.Clear()
        VNomor = vno_trans.Text
        GotoPayment = False
        'If RFIDType = "zebra" Then
        '    frmSales.CheckConZebra()
        'End If
        VDiscBySTAR = 0
        Me.Close()
    End Sub
    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If t_load = False Then
            Exit Sub
        End If
        lokasi = ""
        Dim rowx As Integer = 0

        Try
            lblmsg.Text = DataGridView1.Item(1, rowx).Value.ToString.Trim
            rowx = DataGridView1.CurrentRow.Index
        Catch ex As Exception
            rowx = 0
        End Try

        _frmpay_0.Visible = False
        _frmpay_1.Visible = False
        _frmpay_2.Visible = False
        _frmpay_3.Visible = False
        RoundOfPay = 0
        lbltotal.Text = CDec(TotPay).ToString("N0")
        lblsisa.Text = CDec(vpay.Text).ToString("N0")
        txtkembali.Text = 0
        Select Case DataGridView1.Item(2, rowx).Value
            Case "CS"
                _frmpay_0.Visible = True
                RoundOfPay = vpay.Text - (Int(vpay.Text / 100)) * 100
                If vpay.Text < 0 Then
                    If vpay.Text <> Int(vpay.Text / 100) * 100 Then
                        RoundOfPay = vpay.Text - (Int(vpay.Text / 100) + 1) * 100
                    Else
                        RoundOfPay = 0
                    End If
                End If
                'RoundOfPay = 0
                lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
                lblsisa.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                'txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                txtcash.Select()
                txtcash.Focus()
                txtcash.SelectionStart = 0
                txtcash.SelectionLength = txtcash.Text.Length
            Case "CC", "DC"
                _frmpay_1.Visible = True
                txtno_kartu.Text = ""
                txtno_kartu.Text = no_kartuECR
                If txtnama.Text.Contains("*") Then
                Else
                    txtnama.Text = ""
                End If
                If txtnama.Enabled = True Then
                    txtno_kartu.Select()
                    txtno_kartu.Focus()
                    txtcredit.Text = CDec(vpay.Text).ToString("N0")
                    txtno_kartu.SelectionStart = 0
                    txtno_kartu.SelectionLength = txtno_kartu.Text.Length
                Else
                    txtcredit.Text = CDec(vpay.Text).ToString("N0")
                    txtcredit.Select()
                    txtcredit.Focus()
                    txtcredit.SelectionStart = 0
                    txtcredit.SelectionLength = txtno_kartu.Text.Length
                    btnNum(11).Select()
                    btnNum(11).Focus()
                End If
            Case "SV", "OV"
                _frmpay_2.Visible = True
                txtno_voc.Text = ""
                txtvoucher.Text = ""
                txtno_voc.Select()
                txtno_voc.Focus()
                txtno_voc.SelectionStart = 0
                txtno_voc.SelectionLength = txtno_voc.Text.Length
            Case "PR"
                Call tampil_point()
                _frmpay_3.Visible = True
                txtpoint.Select()
                txtpoint.Focus()
                txtpoint.SelectionStart = 0
                txtpoint.SelectionLength = txtpoint.Text.Length
        End Select
    End Sub
    Private Sub txtcash_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcash.Enter
        lokasi = "txtcash"
    End Sub
    Private Sub txtcash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcash.KeyDown
        Select Case e.KeyCode
            Case 13
                If txtcash.Text = "" Or txtcash.Text = "0" Then
                    'KeyDownEnterDgv()
                    lokasi = "txtcash"
                    lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
                    lblsisa.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                    txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                    'txtcash.Text = CDec(vpay.Text).ToString("N0")
                    txtcash.Select()
                    txtcash.Focus()
                    txtcash.SelectionStart = 0
                    txtcash.SelectionLength = txtcash.Text.Length
                    Exit Sub
                End If
                DataGridView1.Focus()
                If vstatus.Text.Trim = "SALES" And txtcash.Text >= 0 Then
                    If Simpan_Detail(IIf(txtkembali.Text >= 0, txtcash.Text - txtkembali.Text, txtcash.Text), "", "") Then
                        Call Cek_Lunas()
                    End If
                ElseIf vstatus.Text.Trim = "REFUND" And txtcash.Text <= 0 Then
                    If Simpan_Detail(IIf(txtkembali.Text <= 0, txtcash.Text - txtkembali.Text, txtcash.Text), "", "") Then
                        Call Cek_Lunas()
                    End If
                End If
            Case 27
                DataGridView1.Focus()
        End Select
    End Sub
    Private Sub txtcash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcash.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtcash_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcash.TextChanged
        If txtcash.Text <> "" Then
            txtkembali.Text = Val(txtcash.Text + RoundOfPay) - vpay.Text
            txtcash.Text = CDec(txtcash.Text).ToString("N0")
            txtcash.SelectionStart = txtcash.TextLength
        End If
    End Sub
    Private Sub txtcredit_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcredit.Enter
        lokasi = "txtcredit"
    End Sub
    Private Sub txtno_kartu_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtno_kartu.Enter
        lokasi = "txtno_kartu"
    End Sub
    Private Sub txtno_kartu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtno_kartu.KeyDown
        Dim Kartu As String
        Select Case e.KeyCode
            Case 13
                Select Case DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
                    Case "CC", "DC"
                        If txtno_kartu.Text = "" Or Mid(txtno_kartu.Text, 3, 1) = "-" Or Len(txtno_kartu.Text) <> 16 Then
                            MsgBox("Nomor kartu tidak valid", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                            txtno_kartu.Focus()
                            System.Windows.Forms.SendKeys.Send("{home}+{end}")
                            Exit Sub
                        End If

                        Kartu = LTrim(VB.Left(txtno_kartu.Text, 79))

                        '            If Mid(Kartu, 4, 1) = "B" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 5, 16))
                        '                txtnama = LTrim(Mid(Kartu, 22, 20))
                        '            ElseIf Mid(Kartu, 2, 1) = "B" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 3, 16))
                        '            ElseIf Left(Kartu, 1) = ";" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 2, 16))
                        '            ElseIf Mid(Kartu, 4, 1) <> "B" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 8, 16))
                        '            End If
                        '---------------------- normal ----------------
                        If Mid(Kartu, 4, 1) <> "B" Then
                            If Len(Kartu) = 16 Then
                                txtno_kartu.Text = Kartu
                            Else
                                If VB.Left(Kartu, 1) <> "c" Then Call SaveLog(Kartu & " - KARTU BARU")
                                If Mid(Kartu, 8, 1) = "B" Then
                                    txtno_kartu.Text = LTrim(Mid(Kartu, 9, 16))
                                Else
                                    txtno_kartu.Text = LTrim(Mid(Kartu, 8, 16))
                                End If
                            End If
                        ElseIf Mid(Kartu, 4, 1) = "B" Then
                            txtno_kartu.Text = LTrim(Mid(Kartu, 5, 16))
                            txtnama.Text = LTrim(Mid(Kartu, 22, 20))
                        End If
                        '---------------POSIFLEX------------------------
                        '           If Left(Kartu, 1) = ";" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 2, 16))
                        '           ElseIf Mid(Kartu, 2, 1) <> "B" Then
                        '                'Call SaveLog(Kartu & " - KARTU BARU")
                        '                txtno_kartu = LTrim(Mid(Kartu, 8, 16))
                        '           ElseIf Mid(Kartu, 2, 1) = "B" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 3, 16))
                        '                txtnama = LTrim(Mid(Kartu, 20, 26))
                        '           End If

                        '       ---------------NEC------------------------
                        '           If Mid(Kartu, 2, 1) = "B" Then
                        '                'Call SaveLog(Kartu & " - KARTU BARU")
                        '                txtno_kartu = LTrim(Mid(Kartu, 3, 16))
                        '                txtnama = LTrim(Mid(Kartu, 20, 26))
                        '           ElseIf Left(Kartu, 1) = ";" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 2, 16))
                        '           ElseIf Mid(Kartu, 2, 1) <> "B" Then
                        '                txtno_kartu = LTrim(Mid(Kartu, 8, 16))
                        '           End If

                        If Len(txtno_kartu.Text) <> 16 Then Call SaveLog(Kartu & " - TIDAK16")
                End Select

                txtcredit.Focus()
                'System.Windows.Forms.Application.DoEvents()
                'System.Windows.Forms.SendKeys.Send("{home}+{end}")
            Case 27
                DataGridView1.Focus()
        End Select
    End Sub
    Private Sub txtcredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcredit.KeyDown
        Select Case e.KeyCode
            Case 13
                If (vstatus.Text.Trim = "SALES" And CDec(txtcredit.Text) <= CDec(vpay.Text)) Or (vstatus.Text.Trim = "REFUND" And CDec(txtcredit.Text) >= CDec(vpay.Text)) Then
                    DataGridView1.Focus()
                    If Simpan_Detail(txtcredit.Text, VB.Left(txtno_kartu.Text, 16), VB.Left(txtnama.Text, 50)) Then
                        txtno_kartu.Text = ""
                        txtno_kartu.Text = no_kartuECR
                        txtnama.Text = ""
                        txtcredit.Text = 0
                        Call Cek_Lunas()
                    End If
                Else
                    MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " & vbNewLine & "melebihi sisa yang harus dibayar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    txtcredit.Focus()
                End If
        End Select
    End Sub
    Private Sub txtno_voc_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtno_voc.Enter
        lokasi = "txtno_voc"
    End Sub
    Private Sub txtno_voc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtno_voc.KeyDown
        Dim RsDobel As New DataSet

        Dim RsZB As New DataSet
        Select Case e.KeyCode
            Case 13
                'If txtno_voc.Text = "" Then Exit Sub
                Select Case DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
                    Case "SV"

                        'If txtno_voc.Text = "50" Then
                        '    txtvoucher.Text = "50000"
                        '    txtvoucher.Focus()
                        '    Exit Sub
                        'End If

                        'If txtno_voc.Text = "75" Then
                        '    txtvoucher.Text = "75000"
                        '    txtvoucher.Focus()
                        '    Exit Sub
                        'End If


                        'If Linked() Then
                        '    txtvoucher.Text = UCase(CStr(Cek_Voc(txtno_voc.Text)))
                        '    If txtvoucher.Text = 0 Then
                        '        txtno_voc.Focus()
                        '        System.Windows.Forms.Application.DoEvents()
                        '        System.Windows.Forms.SendKeys.Send("{home}+{end}")
                        '        Exit Sub
                        '    Else
                        '        txtvoucher.ReadOnly = True
                        '        txtvoucher.Focus()
                        '    End If
                        'Else
                        '    txtvoucher.ReadOnly = False
                        '    txtvoucher.Focus()
                        'End If

                        'tanpa cek PING
                        If VPing = "ONLINE" Then
                            txtvoucher.Text = UCase(CStr(Cek_Voc2(txtno_voc.Text)))
                            If txtvoucher.Text = 0 Then
                                txtno_voc.Focus()
                                'System.Windows.Forms.Application.DoEvents()
                                'System.Windows.Forms.SendKeys.Send("{home}+{end}")
                                Exit Sub
                            Else
                                txtvoucher.ReadOnly = True
                                txtvoucher.Focus()
                                If Simpan_Detail(txtvoucher.Text, txtno_voc.Text, "") Then
                                    txtno_voc.Text = ""
                                    txtvoucher.Text = 0
                                    Call Cek_Lunas()
                                End If
                            End If
                        Else
                            txtvoucher.ReadOnly = False
                            txtvoucher.Focus()
                        End If

                    Case "OV"



                        txtvoucher.ReadOnly = False
                        txtvoucher.SelectionStart = 0
                        txtvoucher.SelectionLength = txtcash.Text.Length
                        txtvoucher.Focus()
                        'System.Windows.Forms.Application.DoEvents()
                        'System.Windows.Forms.SendKeys.Send("{home}+{end}")
                End Select
            Case 27
                DataGridView1.Focus()
        End Select
    End Sub
    Private Function Gen_Seq() As String
        Dim RsCari As New DataSet

        RsCari = getSqldb("select ISNULL(MAX(seq),0) as urut from paid where Transaction_Number = '" & vno_trans.Text & "'", ConnLocal)
        Gen_Seq = RsCari.Tables(0).Rows(0).Item("urut") + 1
        RsCari.Clear()
        RsCari = Nothing
    End Function
    Private Function Cek_Voc(ByRef nomor As String) As Integer
        Dim RsCari As New DataSet
        Dim RsDobel As New DataSet

        Cek_Voc = 0
        RsCari = getSqldb("select v_amt from newvoc where v_no = '" & nomor & "' AND (V_FLAG IS NULL) AND (V_SELL IS NOT NULL)", ConnServer)
        If RsCari.Tables(0).Rows.Count > 0 Then
            Cek_Voc = RsCari.Tables(0).Rows(0).Item("v_amt").Value
        Else
            Cek_Voc = 0
        End If
        If Cek_Voc = 0 Then
            MsgBox("Nomor Voucher tidak valid", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
            RsCari.Clear()
            RsCari = Nothing
            txtno_voc.Text = ""
            Exit Function
        End If
        RsCari.Clear()
        RsCari = Nothing

        RsDobel = getSqldb("select credit_card_no from paid where credit_card_no = '" & nomor & "'", ConnServer)
        If RsDobel.Tables(0).Rows.Count > 0 Then
            MsgBox("Nomor Voucher Sudah Pernah Dipakai", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
            Cek_Voc = 0
            txtno_voc.Text = ""
        End If
        RsDobel.Clear()
        RsDobel = Nothing
    End Function

    Private Function Cek_Voc2(ByRef nomor As String) As Integer

        Dim dsUnique, RsDobel As New DataSet
        Cek_Voc2 = 0
        dsUnique = getSqldb("select * from UniqueCode where UniqueCode = '" & nomor.Trim & "'  And End_Date >= getdate()", ConnServer)
        If dsUnique.Tables(0).Rows.Count > 0 Then
            If dsUnique.Tables(0).Rows(0).Item("Flag").ToString.Trim <> "0" Then
                MsgBox("Kode Voucher Sudah Pernah Digunakan !!!")
                Cek_Voc2 = 0
                UniqueCode = ""
                txtno_voc.Focus()
                Exit Function
            End If
            UniqueCode = dsUnique.Tables(0).Rows(0).Item("UniqueCode").ToString.Trim
                If dsUnique.Tables(0).Rows(0).Item("PromoDisc").ToString.Trim <> "0" Then
                    txtvoucher.Text = (dsUnique.Tables(0).Rows(0).Item("PromoDisc") / 100) * vpay.Text
                    Cek_Voc2 = (dsUnique.Tables(0).Rows(0).Item("PromoDisc") / 100) * vpay.Text
                Else
                    txtvoucher.Text = dsUnique.Tables(0).Rows(0).Item("PromoValue")
                    Cek_Voc2 = dsUnique.Tables(0).Rows(0).Item("PromoValue")
                End If
                txtvoucher.ReadOnly = False
                txtvoucher.SelectionStart = 0
                txtvoucher.SelectionLength = txtcash.Text.Length
                txtvoucher.Focus()
            Else
                MsgBox("Kode Voucher Tidak Terdaftar !!!")
            Cek_Voc2 = 0
            UniqueCode = ""
            txtno_voc.Focus()
            Exit Function
        End If

        RsDobel = getSqldb("select credit_card_no from paid where credit_card_no = '" & nomor & "'", ConnServer)
        If RsDobel.Tables(0).Rows.Count > 0 Then
            MsgBox("Nomor Voucher Sudah Pernah Dipakai", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
            Cek_Voc2 = 0
            txtno_voc.Text = ""
        End If
        RsDobel.Clear()
        RsDobel = Nothing
    End Function
    Private Function Simpan_Detail(ByRef bayar As Double, ByRef card_no As String, ByRef card_num As String) As Boolean
        On Error GoTo ErrH
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
        getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, " & "Credit_Card_Name, Paid_Amount, Shift) VALUES ('" & vno_trans.Text & "','" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "','" & Gen_Seq() & "','IDR','1','" & card_no & "','" & UbahChar(card_num) & "'," & bayar & ",'" & VShift & "')", ConnLocal)
        Call SaveLog(Me.Name & " " & "Simpan_Paid " & vno_trans.Text & " " & bayar & " " & Format(Now, "HH:mm:ss"))
1:
        Tdata2.Clear()
        Tdata2 = getSqldb("SELECT aa.Seq, bb.Description, Paid_Amount, Credit_Card_No, Credit_Card_Name " & "FROM Paid aa INNER JOIN Payment_Types bb ON aa.Payment_Types = bb.Payment_Types" & " where transaction_number = '" & vno_trans.Text & "' order by seq", ConnLocal)
        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = Tdata2.Tables(0)
        DataGridView2.Columns(0).HeaderText = "No"
        DataGridView2.Columns(0).Width = 30
        DataGridView2.Columns(1).HeaderText = "Tipe"
        DataGridView2.Columns(1).Width = 100
        DataGridView2.Columns(2).HeaderText = "Nilai"
        DataGridView2.Columns(2).Width = 90
        DataGridView2.Columns(3).HeaderText = "No Kartu"
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(4).HeaderText = "Nama Kartu"
        DataGridView2.Columns(4).Width = 120
        DataGridView2.Columns("Paid_Amount").DefaultCellStyle.Format = "N0"
        'vpay = vpay - (bayar + TotPay)
        If RoundOfPay <> 0 And (bayar + CDbl(lblbayar.Text) + RoundOfPay) < TotPay Then
            vpay.Text = vpay.Text - (bayar)
            lblbayar.Text = CDec(CDbl(lblbayar.Text) + bayar).ToString("N0")
            lblsisa.Text = CDec(CDbl(lbltotal.Text) - CDbl(lblbayar.Text)).ToString("N0")
        Else
            vpay.Text = vpay.Text - (bayar + RoundOfPay)
            lblbayar.Text = CDec(CDbl(lbltotal.Text) - vpay.Text).ToString("N0")
            lblsisa.Text = CDec(vpay.Text).ToString("N0")
        End If

        Simpan_Detail = True
        Exit Function

ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Simpan_Detail " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Function
    Private Sub Cek_Lunas()
        On Error GoTo ErrH
        Dim q As Byte
        Dim l As Integer
        Dim RsCari As New DataSet
        Dim strRf As String = ""
        If vpay.Text <= 0 And vstatus.Text.Trim = "SALES" Then 'jika lunas
            If RoundOfPay <> 0 Then
                getSqldb("Insert Into Paid select top 1 '" & vno_trans.Text & "','36',(Select top 1 seq + 1 from paid where transaction_number = '" & vno_trans.Text & "' Order By Seq desc),'IDR','1','','ROUNDING'," & RoundOfPay & ",Shift from paid where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
            End If

            Call Paid_To_Sales(vno_trans.Text, CDbl(lbltotal.Text) + RoundOfPay, IIf(txtkembali.Text > 0, txtkembali.Text, 0))
            GoTo lanjut
        End If

        If vpay.Text >= 0 And vstatus.Text.Trim = "REFUND" Then 'jika lunas
            If RoundOfPay <> 0 Then
                getSqldb("Insert Into Paid select top 1 '" & vno_trans.Text & "','36',(Select top 1 seq + 1 from paid where transaction_number = '" & vno_trans.Text & "' Order By Seq desc),'IDR','1','','ROUNDING'," & RoundOfPay & ",Shift from paid where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
            End If
            Call Paid_To_Sales(vno_trans.Text, CInt(lbltotal.Text), IIf(txtkembali.Text < 0, txtkembali.Text, 0))
            GoTo lanjut
        End If
        DataGridView1.ClearSelection()
        DataGridView1.Select()
        DataGridView1.Focus()
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(1)
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
        'DataGridView1_CellClick(Me.DataGridView1, New DataGridViewCellEventArgs(1, 0))
        _frmpay_0.Visible = True
        _frmpay_1.Visible = False
        _frmpay_2.Visible = False
        _frmpay_3.Visible = False

        _frmpay_0.Visible = True
        RoundOfPay = vpay.Text - (Int(vpay.Text / 100)) * 100
        If vpay.Text < 0 Then
            If vpay.Text <> Int(vpay.Text / 100) * 100 Then
                RoundOfPay = vpay.Text - (Int(vpay.Text / 100) + 1) * 100
            Else
                RoundOfPay = 0
            End If
        End If
        'RoundOfPay = 0
        lbltotal.Text = CDec(TotPay - RoundOfPay).ToString("N0")
        lblsisa.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
        txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
        'txtcash.Text = CDec(vpay.Text).ToString("N0")
        txtcash.Select()
        txtcash.Focus()
        txtcash.SelectionStart = 0
        txtcash.SelectionLength = txtcash.Text.Length
        lokasi = "txtcash"
        'KeyDownEnterDgv()
        Exit Sub
lanjut:
        'tambahan update v_flag voucher automatic

        If vstatus.Text.Trim = "SALES" Then
            strRf = "update a set a.flag = 1 from  Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
                     "where b.transaction_number = '" & vno_trans.Text & "' and b.flag_void = 0"
        Else
            strRf = "update a set a.flag = 0 from Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
                     "where b.transaction_number = '" & vno_trans.Text & "' and b.flag_void = 0"
        End If

        'bali
        'If vstatus.Text.Trim = "SALES" Then
        '    strRf = "update a set a.flag = 1 from [POS_SERVER_HISTORY].dbo.Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
        '             "where b.transaction_number = '" & vno_trans.Text & "' and b.flag_void = 0"
        'Else
        '    strRf = "update a set a.flag = 0 from [POS_SERVER_HISTORY].dbo.Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
        '             "where b.transaction_number = '" & vno_trans.Text & "' and b.flag_void = 0"
        'End If

        getSqldb(strRf, ConnLocal)

        'If Linked() Then
        '    Call Upload_to_Server(vno_trans.Text)
        '    getSqldb(strRf, ConnServer)
        '    'getSqldb("Update newvoc Set v_flag = 'R',V_REC = CONVERT(VARCHAR(10), GETDATE(), 120)  where V_NO in (Select credit_card_no from paid " &
        '    '         "where payment_types = 8 And transaction_number = '" & vno_trans.Text & "')", ConnServer)
        'End If

        'tanpa cek PING
        If VPing = "ONLINE" Then
            Call Upload_to_Server(vno_trans.Text)
            getSqldb(strRf, ConnServer)
            'getSqldb("Update newvoc Set v_flag = 'R',V_REC = CONVERT(VARCHAR(10), GETDATE(), 120)  where V_NO in (Select credit_card_no from paid " &
            '         "where payment_types = 8 And transaction_number = '" & vno_trans.Text & "')", ConnServer)
        End If
        _cmdpay_0.Enabled = False
        Call CetakStruk(vstatus.Text, vno_trans.Text)
        If VPing <> "ONLINE" Then
            Call CetakStruk(vstatus.Text, vno_trans.Text)
        End If
        Call SaveLog(Me.Name & " " & "Transaction Success " & vno_trans.Text & " " & Format(Now,"HH:mm:ss"))
        'Call CetakStruk(vstatus.Text, vno_trans.Text)
        'If txtcard_no.Text.Trim <> "CM000-00000" Then Call Save_Point(vno_trans.Text, txtcard_no.Text)
        Call OpenLaci(0) ' buka drawer tanpa print

        If VPing = "ONLINE" Then
            If UniqueCode <> "" Then
                getSqldb("Update UniqueCode set flag = 1 where UniqueCode = '" & UniqueCode & "'", ConnServer)
        End If
        End If


        l = 0

        If l = 0 Then
            If vstatus.Text.Trim = "SALES" Then Call CetakPromo(vno_trans.Text)
        End If

        'If Linked() Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)

        'tanpa cek PING
        'If VPing = "ONLINE" Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)

        For q = 0 To 4
            frmSales.cmdsales(q).Enabled = False
        Next q

        frmSales.cmdsales(8).Enabled = False
        frmSales.cmdsales(9).Enabled = False
        frmSales.txtkode.Enabled = False
        frmSales.RfidScan2.Enabled = False
        frmSales.CmdNav(0).Enabled = False
        frmSales.CmdNav(3).Enabled = False
        frmSales.Label1.Text = "Change : Rp"

        If vstatus.Text.Trim = "SALES" Then
            frmSales.lblgrand_total.Text = CDec(IIf(txtkembali.Text > 0, txtkembali.Text, 0)).ToString("N0")
        Else
            frmSales.lblgrand_total.Text = CDec(IIf(txtkembali.Text < 0, txtkembali.Text, 0)).ToString("N0")
        End If

        frmSales.cmdsales(6).Text = "VALIDATE TOTAL"
        frmSales.cmdsales(6).ImageAlign = ContentAlignment.BottomCenter
        frmSales.cmdsales(6).TextImageRelation = TextImageRelation.ImageAboveText
        Call CDisplay("CHANGE :", "Rp. " & frmSales.lblgrand_total.Text)
        vpay.Text = 0
        Kosong()
        'VNomor = ""

        Me.Close()
        Exit Sub
ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Cek Lunas " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub
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
        RsPromo.Clear()
        RsPromo = Nothing
        Exit Sub
ErrH:
        MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Call SaveLog(Me.Name & " " & "Cek Lunas " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub
    Private Function Pakai_Voc(ByRef No_trans As String) As Integer
        Dim RsVoc As New DataSet

        RsVoc = getSqldb("select isnull(sum(Paid_Amount),0) as Nvoc from paid pd inner join Payment_Types pt on pd.Payment_Types = pt.Payment_Types " & "where types in ('SV','OV') and Transaction_Number = '" & No_trans & "'", ConnLocal)
        Pakai_Voc = RsVoc.Tables(0).Rows(0).Item("NVoc").Value
        RsVoc.Clear()
        RsVoc = Nothing
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
    Private Sub tampil_point()
        txtsaldo_point.Text = Star_Pt
        txtpoint.Text = txtsaldo_point.Text * CDbl(txtharga_point.Text)
        txttukar_point.Text = CDec(roundDown(txtpoint.Text / CDbl(txtharga_point.Text))).ToString("N0")
    End Sub
    Private Sub txtpoint_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtpoint.Enter
        lokasi = "txtpoint"
    End Sub
    Private Sub txttukar_point_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txttukar_point.Enter
        lokasi = "txttukar_point"
    End Sub
    Private Sub txttukar_point_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttukar_point.KeyDown
        Dim RsPr As New DataSet
        Select Case e.KeyCode
            Case 13

                'If Linked() = False Then
                '    MsgBox("Pembayaran dengan point reward harus Online", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                '    Exit Sub
                'End If

                'tanpa cek PING
                If VPing = "OFFLINE" Then
                    MsgBox("Pembayaran dengan point reward harus Online", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    Exit Sub
                End If

                If txtsaldo_point.Text < 20 Then
                    MsgBox("Minimal Saldo point harus 20", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    Exit Sub
                End If

                If txttukar_point.Text > txtsaldo_point.Text Then
                    MsgBox("Saldo point tidak mencukupi", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    Exit Sub
                End If

                If txtcard_no.Text = "LM-00000000" Then
                    MsgBox("Pembayaran dengan point hanya untuk member MSC", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    Exit Sub
                End If

                StrSQL = "SELECT * from paid WHERE payment_types='5' and transaction_number='" & vno_trans.Text & "'"
                RsPr = getSqldb(StrSQL, ConnLocal)

                If RsPr.Tables(0).Rows.Count > 0 Then
                    MsgBox("Pembayaran dengan point hanya bisa 1 kali/transaksi", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                    RsPr.Clear()
                    RsPr = Nothing
                    Exit Sub
                End If
                RsPr.Clear()
                RsPr = Nothing

                If txttukar_point.Text > 0 Then
                    If txtpoint.Text > vpay.Text Then
                        MsgBox("Pembayaran dengan point reward tidak boleh " & vbNewLine & "melebihi sisa yang harus dibayar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                        txttukar_point.Focus()
                        System.Windows.Forms.Application.DoEvents()
                        System.Windows.Forms.SendKeys.Send("{home}+{end}")
                    Else
                        DataGridView1.Focus()
                        VTukar_Point = Pay_Point(txttukar_point.Text, txtcard_no.Text, vno_trans.Text, txtpoint.Text)
                        If VTukar_Point <> "GAGAL" Then
                            Call Simpan_Detail(txtpoint.Text, txtcard_no.Text, VTukar_Point)
                            Call tampil_point()
                            txttukar_point.Text = 0
                            Call Cek_Lunas()
                        Else
                            MsgBox("Pembayaran dengan point reward GAGAL", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                            Exit Sub
                        End If
                    End If
                Else
                    MsgBox("Transaksi Refund tidak bisa menggunakan point reward", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                End If
            Case 27
                DataGridView1.Focus()
        End Select
    End Sub

    '    Private Sub txttukar_point_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttukar_point.TextChanged
    '        On Error GoTo x
    '        txtpoint.Text = CDec(txttukar_point.Text * CDbl(txtharga_point.Text)).ToString("N0")
    '        Exit Sub
    'x:
    '        txttukar_point.Text = txtsaldo_point.Text
    '        txtpoint.Text = CDec(txttukar_point.Text * CDbl(txtharga_point.Text)).ToString("N0")
    '    End Sub
    Private Sub txtpoint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpoint.KeyDown
        Select Case e.KeyCode
            Case 13
                txttukar_point.Focus()
            Case 27
                DataGridView1.Focus()
        End Select
    End Sub
    Private Sub txtpoint_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtpoint.Leave
        txttukar_point.Text = CDec(roundDown(txtpoint.Text / CDbl(txtharga_point.Text))).ToString("N0")
        txtpoint.Text = CDec(txttukar_point.Text * CDbl(txtharga_point.Text)).ToString("N0")
    End Sub
    Private Sub _cmdpay_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmdpay_0.Click, _cmdpay_1.Click, _cmdpay_2.Click
        Dim btn As Button = sender
        If btn.Text = "CLOSE" Then
            ClosePayment()
        ElseIf btn.Text = "DOWN" Then
            DataGridView1.ClearSelection()
            If DataGridView1.CurrentRow.Index = DataGridView1.RowCount Then
            Else
                DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.CurrentRow.Index + 1).Cells(1)
                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
                DataGridView1_CellClick(Me.DataGridView1, New DataGridViewCellEventArgs(1, DataGridView1.CurrentRow.Index))
                'DataGridView1.Focus()
            End If
        ElseIf btn.Text = "UP" Then
            DataGridView1.ClearSelection()
            If DataGridView1.CurrentRow.Index = 0 Then
            Else
                DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.CurrentRow.Index - 1).Cells(1)
                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
                DataGridView1_CellClick(Me.DataGridView1, New DataGridViewCellEventArgs(1, DataGridView1.CurrentRow.Index))
                'DataGridView1.Focus()
            End If
        End If
    End Sub
    Private Sub txtcredit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcredit.TextChanged
        Try
            If txtcredit.Text <> "" Then
                txtcredit.Text = CDec(txtcredit.Text).ToString("N0")
                txtcredit.SelectionStart = txtcredit.TextLength
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnNum_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnNum.Click
        Dim Index As Short = btnNum.GetIndex(eventSender)
        If DataGridView1.SelectedRows.Count > 0 And lokasi = "" Then
            Select Case Index
                Case 11
                    KeyDownEnterDgv()
                    Exit Sub
            End Select
        End If


        On Error Resume Next
        Dim box As System.Windows.Forms.Control
        Dim txt As New TextBox
        For Each box In Me.Controls
            If TypeOf box Is GroupBox Then
                For Each cntrl As Control In box.Controls
                    If TypeOf cntrl Is TextBox And cntrl.Name = lokasi Then
                        txt = CType(cntrl, TextBox)
                        Exit For
                    End If
                Next
            End If
        Next
        Select Case lokasi
            Case "txtcash", "txtcredit", "txtvoucher", "txttukar_point"
                If Index < 10 Then
                    If txt.SelectionLength = txt.Text.Length Then
                        txt.Text = CStr(btnNum(Index).Text)
                    Else
                        txt.Text = txt.Text & CStr(btnNum(Index).Text)
                    End If
                    txt.SelectionStart = txt.Text.Length
                End If
                Select Case Index
                    Case 10
                        txt.Select()
                        txt.Focus()
                        SendKeys.Send("{end}+{backspace}")
                    Case 11
                        txt.Select()
                        txt.Focus()
                        If lokasi = "txtcredit" Then
                            If (vstatus.Text.Trim = "SALES" And CDec(txtcredit.Text) <= CDec(vpay.Text)) Or (vstatus.Text.Trim = "REFUND" And CDec(txtcredit.Text) >= CDec(vpay.Text)) Then
                                DataGridView1.Focus()
                                If Simpan_Detail(txtcredit.Text, VB.Left(txtno_kartu.Text, 16), VB.Left(txtnama.Text, 50)) Then
                                    txtno_kartu.Text = ""
                                    txtno_kartu.Text = no_kartuECR
                                    txtnama.Text = ""
                                    txtcredit.Text = 0
                                    Call Cek_Lunas()
                                End If
                            Else
                                MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " & vbNewLine & "melebihi sisa yang harus dibayar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                                txtcredit.Focus()
                            End If
                        Else
                            SendKeys.Send("{enter}")
                        End If
                    Case 12
                        txt.Text = 0
                End Select
                txt.Focus()
            Case "txtno_kartu", "txtno_voc"
                If txtno_kartu.Text.Length > 10 And txtcredit.Enabled = False Then
                    If (vstatus.Text.Trim = "SALES" And txtcredit.Text <= vpay.Text) Or (vstatus.Text.Trim = "REFUND" And txtcredit.Text >= vpay.Text) Then
                        DataGridView1.Focus()
                        If Simpan_Detail(txtcredit.Text, VB.Left(txtno_kartu.Text, 16), VB.Left(txtnama.Text, 50)) Then
                            txtno_kartu.Text = ""
                            txtno_kartu.Text = no_kartuECR
                            txtnama.Text = ""
                            txtcredit.Text = 0
                            Call Cek_Lunas()
                        End If
                    Else
                        MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " & vbNewLine & "melebihi sisa yang harus dibayar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
                        txtcredit.Focus()
                    End If
                    Exit Sub
                End If
                If Index < 10 Then
                    If txt.SelectionLength = txt.Text.Length Then
                        txt.Text = CStr(btnNum(Index).Text)
                    Else
                        txt.Text = txt.Text & CStr(btnNum(Index).Text)
                    End If
                    txt.SelectionStart = txt.Text.Length
                End If
                Select Case Index
                    Case 10
                        txt.Select()
                        txt.Focus()
                        SendKeys.Send("{end}+{backspace}")
                    Case 11
                        txt.Select()
                        txt.Focus()
                        SendKeys.Send("{enter}")
                    Case 12
                        txt.Text = ""
                End Select
                txt.Focus()
            Case Else

        End Select
        System.Windows.Forms.SendKeys.Send("{end}")
    End Sub
    Private Sub txtpoint_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpoint.TextChanged
        If txtpoint.Text <> "" Then
            txtpoint.Text = CDec(txtpoint.Text).ToString("N0")
            txtpoint.SelectionStart = txtpoint.TextLength
        End If
    End Sub
    Private Sub txtkembali_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtkembali.TextChanged
        If txtcash.Text <> "" And txtkembali.Text <> "" Then
            txtkembali.Text = CDec(txtkembali.Text).ToString("N0")
            txtkembali.SelectionStart = txtkembali.TextLength
        End If
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
    Private Sub txtvoucher_Enter(sender As Object, e As EventArgs) Handles txtvoucher.Enter
        lokasi = "txtvoucher"
    End Sub
    Private Sub txtvoucher_TextChanged(sender As Object, e As EventArgs) Handles txtvoucher.TextChanged
        If txtvoucher.Text <> "" Then
            txtvoucher.Text = CDec(txtvoucher.Text).ToString("N0")
            txtvoucher.SelectionStart = txtvoucher.TextLength
        End If
    End Sub
    Sub Kosong()
        txtcard_no.Clear()
        txtcash.Clear()
        txtcredit.Clear()
        txtharga_point.Clear()
        txtnama.Clear()
        txtno_kartu.Clear()
        txtno_voc.Clear()
        txtpoint.Clear()
        txtsaldo_point.Clear()
        txttukar_point.Clear()
        txtvoucher.Clear()
        VDiscBySTAR = 0
        'GotoPayment = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cnt += 1
        If cnt > 2000 Then
            Timer1.Stop()
            Label3.Visible = False
            If MsgBox("Connections Time Out !!! Try Again??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cnt = 11
                Label3.Visible = True
                Timer1.Start()
            Else
                Timer1.Enabled = False
                Timer1.Stop()
                Frame2.Enabled = True
                Label3.Visible = False
                _cmdpay_0.Enabled = True
                txtno_kartu.Enabled = True
                txtnama.Enabled = True
                txtcredit.Enabled = True
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
                    MsgBox("Respon Failed From EDC Device !!!")
                    Frame2.Enabled = True
                    Label3.Visible = False
                    _cmdpay_0.Enabled = True
                    txtno_kartu.Enabled = True
                    txtnama.Enabled = True
                    txtcredit.Enabled = True
                    Exit Sub
                End If
                Timer1.Enabled = False
                Timer1.Stop()
                no_kartuECR = VB.Left(Mid(ResponseASCII, 25, 19), 16)
                txtno_kartu.Text = no_kartuECR
                If Mid(ResponseASCII, 163, 1) = "Y" Then
                    txtnama.Text = "*" & Mid(ResponseASCII, 178, 3) & "*"
                End If

                txtno_kartu.Enabled = False
                txtnama.Enabled = False
                Frame2.Enabled = True
                Label3.Visible = False
                lokasi = "txtcredit"
                txtcredit.Select()
                txtcredit.Focus()
                txtcredit.Enabled = False
                btnNum(11).Select()
                btnNum(11).Focus()
                'isECR = 2
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

    Private Sub txtvoucher_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvoucher.KeyDown
        Select Case e.KeyCode
            Case 13
                If txtvoucher.Text = "" Or txtvoucher.Text = "0" Then
                    txtvoucher.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
                    txtvoucher.Select()
                    txtvoucher.Focus()
                    txtvoucher.SelectionStart = 0
                    txtvoucher.SelectionLength = txtvoucher.Text.Length
                    Exit Sub
                End If
                If (vstatus.Text.Trim = "SALES" And txtvoucher.Text > 0) Or (vstatus.Text.Trim = "REFUND" And txtvoucher.Text < 0) Then

                    Select Case DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
                        Case "OV"
                            If Simpan_Detail(txtvoucher.Text, txtno_voc.Text, "") Then
                                txtno_voc.Text = ""
                                txtvoucher.Text = 0
                                Call Cek_Lunas()
                            End If
                    End Select
                End If
        End Select
    End Sub

End Class