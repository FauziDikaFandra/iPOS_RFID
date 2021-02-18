Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Public Class frmNum
    Inherits System.Windows.Forms.Form
    Private Sub _btnNum_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnNum_0.Click, _btnNum_1.Click,
    _btnNum_2.Click, _btnNum_3.Click, _btnNum_4.Click, _btnNum_5.Click, _btnNum_6.Click, _btnNum_7.Click, _btnNum_8.Click,
    _btnNum_9.Click, _btnNum_10.Click, _btnNum_11.Click, _btnNum_12.Click, _btnNum_13.Click, _btnNum_14.Click
        Dim btn As Button = sender
        If Me.Text = "NUMBER - VIEW" And CInt(btn.Tag) = 10 Then Exit Sub
        If CInt(btn.Tag) < 11 Then txtno.Text = txtno.Text & btn.Text
        txtno.SelectionStart = txtno.Text.Length
        Dim RsCari As New DataSet
        Select Case CInt(btn.Tag)
            Case 11 'Enter
                If Me.Text = "NUMBER - MEMBER" Then
                    InputMember.txtPhone.Text = txtno.Text
                    Me.Close()
                    InputMember.txtPhone.Focus()
                    InputMember.SubView()
                    Exit Sub
                End If

                If Me.Text = "NUMBER - VIEW" Then
                    frmView.txtkode.Text = txtno.Text
                    Me.Close()
                    frmView.txtkode.Focus()
                    frmView.SubNum()
                    Exit Sub
                End If

                If Me.Text = "NUMBER - HARGA" Then
                    frmHarga.txtprice.Text = txtno.Text
                    Me.Close()
                    frmHarga.txtprice.Focus()
                    'endKeys "{enter}"
                    Exit Sub
                End If

                If Me.Text = "NUMBER - ID" Then
                    frmkaryawan.txtid.Text = txtno.Text
                    Me.Close()
                    frmkaryawan.txtid.Focus()
                    'endKeys "{enter}"
                    Exit Sub
                End If

                If Me.Text = "NUMBER - SALES" Then
                    frmSales.txtkode.Text = txtno.Text
                    Me.Close()
                    frmSales.txtkode.Focus()
                    If VB.Right(frmSales.txtkode.Text, 1) = "*" Then
                        System.Windows.Forms.SendKeys.Send("{end}")
                    Else
                        System.Windows.Forms.SendKeys.Send("{enter}")
                    End If
                    Exit Sub
                End If

                VNomor = VBranch_ID & VReg_ID & "-" & Format(GetSrvDate, "ddMMyyyy") & "-" & VB.Right("000" & CStr(txtno.Text), 4)

                RsCari = getSqldb("select status, flag_return from sales_transactions where transaction_number ='" & VNomor & "'", ConnLocal)

                If RsCari.Tables(0).Rows.Count = 0 Then
                    MsgBox("Nomor transaksi tidak valid", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
                    GoTo xx
                End If

                Select Case Me.Text
                    Case "REPRINT"
                        If RsCari.Tables(0).Rows(0).Item("Status") = "00" Then
                            Call CetakStruk("REPRINT", VNomor)
                            Call SaveLog("Reprint Transaction " & VNomor & " " & VSuper_Nm)
                            GoTo xx
                        End If
                    Case "RELEASE"
                        'If RsCari.Tables(0).Rows(0).Item("Status") = "01" Then
                        '    frmSalesSelf.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag_return") = "1", "REFUND", "SALES")
                        '    Call CDisplay(frmSalesSelf.Text, "TRANSACTION")
                        '    Me.Close()
                        '    frmSalesSelf.ViewRelease(VNomor)
                        '    frmSalesSelf.Show()
                        '    frmMain.Close()
                        '    GoTo xx
                        'End If
                        If RsCari.Tables(0).Rows(0).Item("Status") = "01" Then
                            frmSales.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag_return") = "1", "REFUND", "SALES")
                            Call CDisplay(frmSales.Text, "TRANSACTION")
                            Me.Close()
                            frmSales.ViewRelease(VNomor)
                            frmSales.Show()
                            frmMain.Close()
                            GoTo xx
                        End If
                    Case "CANCEL"
                        If RsCari.Tables(0).Rows(0).Item("Status") = "01" Then
                            getSqldb("Update sales_transactions set net_price=0, net_amount=0, status='02' where transaction_number='" & VNomor & "'", ConnLocal)
                            getSqldb("Delete from paid where transaction_number='" & VNomor & "'", ConnLocal)
                            Call CetakPesan("CANCEL", VNomor)
                            Call SaveLog("Cancel Transaction " & VNomor & " " & VSuper_Nm)
                            frmMain.CancelReload()
                            GoTo xx
                        End If
                End Select
                MsgBox("Nomor transaksi tidak valid", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")

xx:
                RsCari.Clear()
                RsCari = Nothing
                Me.Close()
                VNomor = ""
            Case 12 'Backspace
                txtno.Focus()
                System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
            Case 13 'Clear
                txtno.Text = ""
            Case 14 'Close
                Me.Close()
        End Select
    End Sub
    Private Sub frmNum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtno.Select()
        txtno.Focus()
        txtno.Clear()
        txtpassword.Clear()
        Me.TopMost = True
    End Sub
    Private Sub txtno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtno.KeyDown
        Select Case e.KeyCode
            Case 13
                _btnNum_0_Click(_btnNum_11, New System.EventArgs())
            Case 27
                Me.Close()
        End Select
    End Sub

End Class