Option Strict Off
Option Explicit On
Public Class frmPassword
    Inherits System.Windows.Forms.Form
    Dim lama As String
    Private Sub _btnNum_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnNum_0.Click, _btnNum_1.Click,
    _btnNum_2.Click, _btnNum_3.Click, _btnNum_4.Click, _btnNum_5.Click, _btnNum_6.Click, _btnNum_7.Click, _btnNum_8.Click,
    _btnNum_9.Click, _btnNum_10.Click, _btnNum_11.Click, _btnNum_12.Click, _btnNum_13.Click
        Dim btn As Button = sender

        If CInt(btn.Tag) < 10 Then txtpassword.Text = txtpassword.Text & btn.Text

        Select Case CInt(btn.Tag)
            Case 10
                System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
            Case 11
                Select Case Label2.Text
                    Case "PASSWORD LAMA"
                        If txtpassword.Text = "" Then
                            txtpassword.Focus()
                            Exit Sub
                        End If
                        Label2.Text = "PASSWORD BARU"
                        lama = txtpassword.Text
                        txtpassword.Text = ""
                    Case "PASSWORD BARU"
                        If txtpassword.Text = "" Then
                            txtpassword.Focus()
                            Exit Sub
                        End If
                        cmdLogin_Click()
                        Label2.Text = "PASSWORD LAMA"
                End Select
            Case 12
                Select Case Label2.Text
                    Case "PASSWORD LAMA"
                        If txtpassword.Text <> "" Then
                            txtpassword.Text = ""
                        End If
                    Case "PASSWORD BARU"
                        If txtpassword.Text <> "" Then
                            txtpassword.Text = ""
                        Else
                            Label2.Text = "PASSWORD LAMA"
                            txtpassword.Text = ""
                        End If

                End Select
                txtpassword.Focus()
            Case 13
                txtpassword.Focus()
                Me.Close()

        End Select
    End Sub
    Private Sub cmdLogin_Click()
        Dim RsUser As New DataSet
        If VPing <> "ONLINE" Then
            MsgBox("Perubahan password harus saat online", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Oops..")
            Exit Sub
        Else
            RsUser = getSqldb("select * from users where User_ID='" & VKasir_ID & "' and branch_id='" & VBranch_ID & "'", ConnServer)

            If RsUser.Tables(0).Rows.Count > 0 Then
                If Trim(RsUser.Tables(0).Rows(0).Item("Password")) = lama Then
                    getSqldb("update users set password = '" & txtpassword.Text & "' where User_ID='" & VKasir_ID & "' and branch_id='" & VBranch_ID & "'", ConnServer)
                    MsgBox("Password sudah berubah", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops..")
                    Me.Close()
                Else
                    MsgBox("Password yang anda masukkan salah", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
                    txtpassword.Focus()
                    System.Windows.Forms.SendKeys.Send("{home}+{end}")
                End If
            End If
        End If
    End Sub
    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        Select Case e.KeyCode
            Case 13
                Select Case Label2.Text
                    Case "PASSWORD LAMA"
                        If txtpassword.Text = "" Then
                            txtpassword.Focus()
                            Exit Sub
                        End If
                        Label2.Text = "PASSWORD BARU"
                        lama = txtpassword.Text
                        txtpassword.Text = ""
                    Case "PASSWORD BARU"
                        If txtpassword.Text = "" Then
                            txtpassword.Focus()
                            Exit Sub
                        End If
                        cmdLogin_Click()
                        Label2.Text = "PASSWORD LAMA"
                End Select
            Case 27
                Me.Close()
        End Select
    End Sub
    Private Sub frmPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtpassword.Text = ""
        Label2.Text = "PASSWORD LAMA"
        txtpassword.Focus()
    End Sub
End Class