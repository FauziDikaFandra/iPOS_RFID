Option Strict Off
Option Explicit On
Imports libzkfpcsharp
Imports System.Threading
Imports System.Runtime.InteropServices
Public Class frmValid
    Inherits System.Windows.Forms.Form
    Dim ulang As Byte
    Dim posisi As String
    Dim mDevHandle As IntPtr = IntPtr.Zero
    Dim mDBHandle As IntPtr = IntPtr.Zero
    Dim RegTmps As Byte()() = New Byte(2)() {}
    Private mfpWidth As Integer = 0
    Private mfpHeight As Integer = 0
    Dim FPBuffer As Byte()
    Dim bIsTimeToDie As Boolean = False
    Dim cbCapTmp As Integer = 2048
    Dim FormHandle As IntPtr = IntPtr.Zero
    Dim CapTmp As Byte() = New Byte(2047) {}
    Const MESSAGE_CAPTURED_OK As Integer = &H0400 + 6

    <DllImport("user32.dll", EntryPoint:="SendMessageA")>
    Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

    End Function


    Sub CheckFinger()
        Dim ret As Integer = zkfperrdef.ZKFP_ERR_OK
        If (zkfp2.Init()) = zkfperrdef.ZKFP_ERR_OK Then
            Dim nCount As Integer = zkfp2.GetDeviceCount()
            If nCount > 0 Then
                FingerOK = True
            Else
                FingerOK = False
                zkfp2.Terminate()
            End If
        Else
        End If
        If FingerOK = True Then
            Dim ret2 As Integer = zkfp.ZKFP_ERR_OK
            mDevHandle = zkfp2.OpenDevice(0)
            If IntPtr.Zero = (zkfp2.OpenDevice(0)) Then
                Exit Sub
            End If
            mDBHandle = zkfp2.DBInit()
            If IntPtr.Zero = (mDBHandle = zkfp2.DBInit()) Then
                zkfp2.CloseDevice(mDevHandle)
                mDevHandle = IntPtr.Zero
                Exit Sub
            End If

            For i As Integer = 0 To 3 - 1
                RegTmps(i) = New Byte(2048) {}
            Next

            Dim paramValue As Byte() = New Byte(4) {}
            Dim size As Integer = 4
            zkfp2.GetParameters(mDevHandle, 1, paramValue, size)
            zkfp2.ByteArray2Int(paramValue, mfpWidth)
            size = 4
            zkfp2.GetParameters(mDevHandle, 2, paramValue, size)
            zkfp2.ByteArray2Int(paramValue, mfpHeight)
            FPBuffer = New Byte(mfpWidth * mfpHeight) {}
            Dim captureThread As Thread = New Thread(AddressOf DoCapture)
            captureThread.IsBackground = True
            captureThread.Start()
            bIsTimeToDie = False
        Else
        End If
    End Sub

    Private Sub DoCapture()
        While Not bIsTimeToDie
            cbCapTmp = 2048
            Dim ret As Integer = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, cbCapTmp)

            If ret = zkfp.ZKFP_ERR_OK Then
                SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero)
            End If

            Thread.Sleep(200)
        End While
    End Sub
    Private Sub _btnNum_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnNum_0.Click, _btnNum_1.Click,
    _btnNum_2.Click, _btnNum_3.Click, _btnNum_4.Click, _btnNum_5.Click, _btnNum_6.Click, _btnNum_7.Click, _btnNum_8.Click,
    _btnNum_9.Click, _btnNum_10.Click, _btnNum_11.Click, _btnNum_12.Click, _btnNum_13.Click
        Dim btn As Button = sender
        Select Case posisi
            Case "txtuser"
                txtuser.Focus()
                If CInt(btn.Tag) < 10 Then txtuser.Text = txtuser.Text & btn.Text
                txtuser.SelectionStart = txtuser.Text.Length
                Select Case CInt(btn.Tag)
                    Case 10
                        System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
                    Case 11
                        System.Windows.Forms.SendKeys.Send("{enter}")
                    Case 12
                        txtuser.Text = ""
                    Case 13
                        Me.Close()
                End Select
            Case "txtpassword"
                txtpassword.Focus()
                If CInt(btn.Tag) < 10 Then txtpassword.Text = txtpassword.Text & btn.Text
                txtpassword.SelectionStart = txtpassword.Text.Length
                Select Case CInt(btn.Tag)
                    Case 10
                        System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
                    Case 11
                        cmdLogin_Click()
                    Case 12
                        If txtuser.Text = "" Then
                            txtuser.Visible = True
                            txtuser.Visible = False
                            txtuser.Focus()
                        End If
                        txtuser.Text = ""
                    Case 13
                        Me.Close()
                End Select

        End Select
    End Sub

    Private Sub cmdLogin_Click()
        Dim RsUser As New DataSet
        StrSQL = "select * from users where User_ID='" & txtuser.Text & "' and branch_id='" & VBranch_ID & "' and security_level <='" & VLevelApp.Text & "'"

        If VPing = "ONLINE" Then
            RsUser = getSqldb(StrSQL, ConnServer)
        Else
            RsUser = getSqldb(StrSQL, ConnLocal)
        End If

        If RsUser.Tables(0).Rows.Count > 0 Then
            If Trim(RsUser.Tables(0).Rows(0).Item("Password").ToString) = txtpassword.Text Then
                VSuper_Nm = RsUser.Tables(0).Rows(0).Item("user_id").ToString & " / " & RsUser.Tables(0).Rows(0).Item("user_Name").ToString
                VOK = True
                Call SaveLog("Verifikasi Success -" & VLevelApp.Text & " " & RsUser.Tables(0).Rows(0).Item("user_id").ToString & " / " & RsUser.Tables(0).Rows(0).Item("user_Name").ToString)
                Me.Close()
            Else
                MsgBox("Password yang anda masukkan salah", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
                ulang = ulang + 1
                If ulang > 2 Then
                    Me.Close()
                    ulang = 0
                    Exit Sub
                End If
                txtpassword.Focus()
                txtuser.Focus()
                System.Windows.Forms.SendKeys.Send("{home}+{end}")
            End If
        Else
            MsgBox("User tidak ada otorisasi", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
            Me.Close()
        End If
    End Sub

    Private Sub txtpassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtpassword.Enter
        posisi = "txtpassword"
    End Sub


    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        Select Case e.KeyCode
            Case 13
                cmdLogin_Click()
            Case 27
                Me.Close()
        End Select
    End Sub

    Private Sub txtuser_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtuser.Enter
        posisi = "txtuser"
    End Sub


    Private Sub txtuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        Select Case e.KeyCode
            Case 13
                lblUser.Text = "PASSWORD"
                txtpassword.Visible = True
                txtpassword.Text = ""
                txtpassword.Focus()
            Case 27
                Me.Close()
        End Select
    End Sub

    Private Sub frmValid_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblUser.Text = "USER ID"
        txtuser.Select()
        txtuser.Focus()
        txtuser.Text = ""
        txtpassword.Text = ""
        txtpassword.Visible = False
    End Sub

    Private Sub frmValid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormHandle = Me.Handle
        CheckFinger()

    End Sub

    Protected Overrides Sub DefWndProc(ByRef m As Message)
        Select Case m.Msg
            Case MESSAGE_CAPTURED_OK

                Dim DsFinger As New DataSet
                If VPing = "ONLINE" Then
                    DsFinger = getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id and b.security_level <='" & VLevelApp.Text & "'", ConnServer)
                Else
                    DsFinger = getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id and b.security_level <='" & VLevelApp.Text & "'", ConnLocal)
                End If


                For Each dr As DataRow In DsFinger.Tables(0).Rows
                    Dim ret As Integer = zkfp2.DBMatch(mDBHandle, CapTmp, CType(dr("RegTmp"), Byte()))
                    If 0 < ret Then
                        My.Computer.Audio.Play(Application.StartupPath & "/Bleep.wav", AudioPlayMode.Background)
                        VSuper_Nm = dr("user_id").ToString & " / " & dr("user_Name").ToString
                        VOK = True
                        Call SaveLog("Verifikasi Success -" & VLevelApp.Text & " " & dr("user_id").ToString & " / " & dr("user_Name").ToString)
                        GoTo 1
                    End If
                Next
                MsgBox("Match finger fail!!", MsgBoxStyle.Critical, "Attentions")
                Exit Sub
            Case Else
                MyBase.DefWndProc(m)
                Exit Sub
        End Select
1:
        Me.Close()
    End Sub

    Private Sub frmValid_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'zkfp2.CloseDevice(mDevHandle)
        'zkfp2.Terminate()
    End Sub

    Private Sub frmValid_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Menghilangkan Bunyi ding
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class