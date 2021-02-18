Option Strict Off
Option Explicit On
Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private rowIndex As Integer = 0
    Private Sub _cmdMenu_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmdMenu_0.Click, _cmdMenu_1.Click,
    _cmdMenu_2.Click, _cmdMenu_3.Click, _cmdMenu_4.Click, _cmdMenu_5.Click, _cmdMenu_6.Click, _cmdMenu_7.Click, _cmdMenu_8.Click,
    _cmdMenu_9.Click
        Dim btn As Button = sender
        Dim RsCek As New DataSet
        Select Case CInt(btn.Tag)
            Case 0 'CASH OPEN
                If _cmdMenu_0.Text = "CASH OPEN" Then
                    frmCashOpen.ShowDialog()
                Else
                    frmPassword.ShowDialog()
                End If
            Case 1 'CLOSE SHIFT
                If Not Super(2) Then Exit Sub
                CekMissPaid()
                Call XRead()
                Call SaveLog("Close Shift " & VSuper_Nm)
                Me.Close()
                LoadClose = True
                frmLogin.Show()
            Case 2 'CLOSE REGISTER
                If Not Super(2) Then Exit Sub
                frmSOD.Text = "EOD"
                frmSOD.ShowDialog()
                CekMissPaid()
                Call ZReset()
                Call SaveLog("Close Register " & VSuper_Nm)
                _cmdMenu_0_Click(_cmdMenu_9, New System.EventArgs())
            Case 3 'OPEN DRAWER
                If Not Super(2) Then Exit Sub
                Call OpenLaci(1)
                Call SaveLog("Open Drawer " & VSuper_Nm)
            Case 4 'SALES
                VNomor = ""
                Call CDisplay("  SALES", "TRANSACTION ")
                Star_Id = "10000000"
                VBonus_Point = 1
                If RegType = "0" Then
                    frmSales.Text = "SALES"
                    frmSales.txtcard_no.Text = "LM-00000000"
                    frmSales.txtcust_name.Text = "ONE TIME CUSTOMER"
                    frmSales.txtcust_id.Text = "10000000"
                    Star_No = "LM-00000000"
                    Star_Nm = "ONE TIME CUSTOMER"
                    Star_Phone = ""
                    Me.Close()
                    frmSales.Show()
                Else
                    If SecLev < 3 Then
                        frmSales.Text = "SALES"
                        frmSales.txtcard_no.Text = "LM-00000000"
                        frmSales.txtcust_name.Text = "ONE TIME CUSTOMER"
                        frmSales.txtcust_id.Text = "10000000"
                        Star_No = "LM-00000000"
                        Star_Nm = "ONE TIME CUSTOMER"
                        Star_Phone = ""
                        Me.Close()
                        frmSales.Show()
                    Else
                        frmSalesSelf.Text = "SALES"
                        frmSalesSelf.txtcard_no.Text = "LM-00000000"
                        frmSalesSelf.txtcust_name.Text = "ONE TIME CUSTOMER"
                        frmSalesSelf.txtcust_id.Text = "10000000"
                        Star_No = "LM-00000000"
                        Star_Nm = "ONE TIME CUSTOMER"
                        Star_Phone = ""
                        Me.Close()
                        frmSalesSelf.Show()
                    End If
                End If


            Case 5 ' REFUND
                If Not Super(1) Then Exit Sub
                VNomor = ""
                Call CDisplay(" REFUND", "TRANSACTION")
                Call SaveLog("Refund Transaction " & VSuper_Nm)
                'frmCard.Text = "REFUND"
                'frmCard.ShowDialog()

                'tanpa pilih member
                Star_Id = "10000000"
                VBonus_Point = 1
                frmSales.Text = "REFUND"
                frmSales.txtcard_no.Text = "LM-00000000"
                frmSales.txtcust_name.Text = "ONE TIME CUSTOMER"
                frmSales.txtcust_id.Text = "10000000"
                Star_No = "LM-00000000"
                Star_Nm = "ONE TIME CUSTOMER"
                Star_Phone = ""
                Me.Close()
                frmSales.Show()
            Case 6 'REPRINT
                If Not Super(1) Then Exit Sub
                Call CDisplay("REPRINT", "TRANSACTION")
                frmNum.Text = "REPRINT"
                frmNum.Label2.Text = "TRANS"
                frmNum.ShowDialog()
            Case 7 'RELEASE
                Call CDisplay("RELEASE", "TRANSACTION")
                frmNum.Text = "RELEASE"
                frmNum.Label2.Text = "TRANS"
                frmNum.ShowDialog()
            Case 8 'CANCEL
                If Not Super(2) Then Exit Sub
                Call CDisplay(" CANCEL", "TRANSACTION")
                frmNum.Text = "CANCEL"
                frmNum.Label2.Text = "TRANS"
                frmNum.ShowDialog()
            Case 9 'EXIT
                Call CDisplay("", "")
                'frmSOD.Text = "EOD"
                'frmSOD.ShowDialog()
                'Application.Exit()
                Me.Close()
                frmLogin.Show()
        End Select
    End Sub
    Private Sub frmMain_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Star_Nm = ""
        Star_Pt = 0
        Star_Id = ""
        Star_Freq = ""
        Star_Omz = ""
        Call Timer1_Tick(Timer1, New System.EventArgs())

        Dim btn As Button = Nothing
        For Each ctrl As Control In Frame2.Controls
            If TypeOf ctrl Is Button Then
                btn = DirectCast(ctrl, Button)
                If CInt(btn.Tag) > 0 And CInt(btn.Tag) < 9 Then
                    btn.Enabled = VCopen
                End If
            End If
        Next

        If Not VCopen Then
            _cmdMenu_0.Text = "CASH OPEN"
            _cmdMenu_0.Focus()
        Else
            _cmdMenu_0.Text = "CHANGE PASSWORD"
            _cmdMenu_4.Focus()
        End If

        lblbranch.Text = Tulis(10)
        lblreg.Text = "REGISTER # " & VReg_ID & " - " & VShift
        lblkasir.Text = VKasir_ID & " - " & VKasir_Nm
        If VPing = "ONLINE" Then
            lblline.ForeColor = Color.Yellow
        Else
            lblline.ForeColor = Color.Red
        End If
        lblline.Text = VPing
        txtinfo.Text = Tulis(16)

        _cmdMenu_9.Enabled = False
        _cmdMenu_1.Enabled = False
        _cmdMenu_2.Enabled = False


        Dim dsCek As New DataSet
        dsCek = getSqldb("SELECT cast(right(transaction_number,4)as int) as No, Net_amount as Nilai, transaction_number " & "From Sales_Transactions WHERE (Status = '01') and CONVERT(varchar(10), Transaction_Date, 102) = '" & Format(GetSrvDate, "yyyy.MM.dd") & "' and cash_register_id ='" & VReg_ID & "'", ConnLocal)

        If dsCek.Tables(0).Rows.Count = 0 Then
            _cmdMenu_9.Enabled = True
            _cmdMenu_1.Enabled = VCopen
            _cmdMenu_2.Enabled = VCopen
        Else
            DataGridView1.DataSource = dsCek.Tables(0)
            DataGridView1.Refresh()
            DataGridView1.Columns("No").Width = "50"
            DataGridView1.Columns("Nilai").DefaultCellStyle.Format = "N0"
            DataGridView1.Columns("Nilai").Width = "100"
            DataGridView1.Columns("transaction_number").Visible = False
            DataGridView1.Font = New Font("MS Sans Serif", 12, FontStyle.Regular)
        End If


    End Sub
    Sub CancelReload()
        DataGridView1.DataSource = Nothing
        Dim dsCek As New DataSet
        dsCek = getSqldb("SELECT cast(right(transaction_number,4)as int) as No, Net_amount as Nilai, transaction_number " & "From Sales_Transactions WHERE (Status = '01') and CONVERT(varchar(10), Transaction_Date, 102) = '" & Format(GetSrvDate, "yyyy.MM.dd") & "' and cash_register_id ='" & VReg_ID & "'", ConnLocal)

        If dsCek.Tables(0).Rows.Count = 0 Then
            _cmdMenu_9.Enabled = True
            _cmdMenu_1.Enabled = VCopen
            _cmdMenu_2.Enabled = VCopen
        Else
            DataGridView1.DataSource = dsCek.Tables(0)
            DataGridView1.Refresh()
            DataGridView1.Columns("No").Width = "50"
            DataGridView1.Columns("Nilai").DefaultCellStyle.Format = "N0"
            DataGridView1.Columns("Nilai").Width = "100"
            DataGridView1.Columns("transaction_number").Visible = False
            DataGridView1.Font = New Font("MS Sans Serif", 12, FontStyle.Regular)
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        lbltgl.Text = Format(Now, "dddd, d MMM yyyy")
        lbljam.Text = Format(Now, "hh:mm:ss")
    End Sub
    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Text = "POINT OF SALES V." & Me.GetType.Assembly.GetName.Version.ToString
        Call CDisplay("  ", "*** LAKON ***")
    End Sub
    Private Sub Label1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label1.Click
        If VPing = "ONLINE" Then
            Dim Dbs, Svr As String

            Dbs = ReadIni("Server", "DatabaseName")
            Svr = "[" & VSvr & "]"

            If Not Super(2) Then Exit Sub
            getSqldb("exec spp_DownLoadOthers '" & Svr & "','" & Dbs & "'", ConnLocal)
            getSqldb("exec spp_DownLoadRFID '" & Svr & "','" & Dbs & "'", ConnLocal)
            Call SaveLog("Download Promo " & VSuper_Nm)
            MsgBox("Download Promo Selesai", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
        Else
            MsgBox("Register Status is Offline!!")
        End If

    End Sub
    Private Sub txtinfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtinfo.Enter
        _cmdMenu_4.Focus()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim RsCari As New DataSet
        VNomor = DataGridView1(2, e.RowIndex).Value

        RsCari = getSqldb("select status, flag_return from sales_transactions where transaction_number ='" & VNomor & "'", ConnLocal)

        If RsCari.Tables(0).Rows.Count = 0 Then
            MsgBox("Nomor transaksi tidak valid", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
            Exit Sub
        End If
        If RsCari.Tables(0).Rows(0).Item("Status") = "01" Then
            If RegType = "0" Then
                frmSales.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag_return") = "1", "REFUND", "SALES")
                Call CDisplay(frmSales.Text, "TRANSACTION")
                frmSales.ViewRelease(VNomor)
                frmSales.Show()
            Else
                If SecLev < 3 Then
                    frmSales.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag_return") = "1", "REFUND", "SALES")
                    Call CDisplay(frmSales.Text, "TRANSACTION")
                    frmSales.ViewRelease(VNomor)
                    frmSales.Show()
                Else
                    frmSalesSelf.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag_return") = "1", "REFUND", "SALES")
                    Call CDisplay(frmSalesSelf.Text, "TRANSACTION")
                    frmSalesSelf.ViewRelease(VNomor)
                    frmSalesSelf.Show()
                End If
            End If


            Me.Close()
        End If

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

            Call CDisplay(" CANCEL", "TRANSACTION")
            Dim RsCari As New DataSet
            Dim cnt As Integer = 0
            For Each ro As DataGridViewRow In DataGridView1.SelectedRows
                cnt += 1
            Next
            Dim Nomor(cnt - 1) As String
            cnt = 0
            For Each ro As DataGridViewRow In DataGridView1.SelectedRows
                With DataGridView1
                    VNomor = VBranch_ID & VReg_ID & "-" & Format(GetSrvDate, "ddMMyyyy") & "-" & Microsoft.VisualBasic.Right("000" & CStr(.Item(2, ro.Index).Value.ToString.Trim), 4)
                    Nomor(cnt) = VNomor
                    cnt += 1
                End With
            Next
            If Not Super(2) Then Exit Sub
            For x As Integer = 0 To Nomor.Count - 1
                RsCari.Clear()
                RsCari = getSqldb("select status, flag_return from sales_transactions where transaction_number ='" & Nomor(x) & "'", ConnLocal)
                If RsCari.Tables(0).Rows(0).Item("Status") = "01" Then
                    getSqldb("Update sales_transactions set net_price=0, net_amount=0, status='02' where transaction_number='" & Nomor(x) & "'", ConnLocal)
                    getSqldb("Delete from paid where transaction_number='" & Nomor(x) & "'", ConnLocal)
                    Call CetakPesan("CANCEL", Nomor(x))
                    Call SaveLog("Cancel Transaction " & Nomor(x) & " " & VSuper_Nm)
                End If
            Next
            CancelReload()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblMember.Click
        If VPing = "ONLINE" Then
            MemberRegistration.ShowDialog()
        Else
            MsgBox("Register Status is Offline!!")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblMemberTran.Click
        If VPing = "ONLINE" Then
            frmMemberTrans.ShowDialog()
        Else
            MsgBox("Register Status is Offline!!")
        End If
    End Sub

    Private Sub lblMember_MouseHover(sender As Object, e As EventArgs) Handles lblMember.MouseHover
        lblMember.ForeColor = Color.Blue
    End Sub

    Private Sub lblMemberTran_MouseHover(sender As Object, e As EventArgs) Handles lblMemberTran.MouseHover
        lblMemberTran.ForeColor = Color.Blue
    End Sub

    Private Sub lblMember_MouseLeave(sender As Object, e As EventArgs) Handles lblMember.MouseLeave
        lblMember.ForeColor = Color.CornflowerBlue
    End Sub

    Private Sub lblMemberTran_MouseLeave(sender As Object, e As EventArgs) Handles lblMemberTran.MouseLeave
        lblMemberTran.ForeColor = Color.CornflowerBlue
    End Sub

End Class