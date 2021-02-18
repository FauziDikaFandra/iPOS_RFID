
Imports libzkfpcsharp
Imports System.Threading
Imports System.Runtime.InteropServices
Public Class frmLogin
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

    Protected Overrides Sub DefWndProc(ByRef m As Message)
        Select Case m.Msg
            Case MESSAGE_CAPTURED_OK

                Dim DsFinger As New DataSet
                If VPing = "ONLINE" Then
                    DsFinger = getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id", ConnServer)
                Else
                    DsFinger = getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id", ConnLocal)
                End If


                For Each dr As DataRow In DsFinger.Tables(0).Rows
                    Dim ret As Integer = zkfp2.DBMatch(mDBHandle, CapTmp, CType(dr("RegTmp"), Byte()))
                    If 0 < ret Then
                        My.Computer.Audio.Play(Application.StartupPath & "/Bleep.wav", AudioPlayMode.Background)
                        VSuper_Nm = dr("user_id").ToString & " / " & dr("user_Name").ToString
                        VOK = True
                        Call SaveLog("Verifikasi Success - Login " & dr("user_id").ToString & " / " & dr("user_Name").ToString)
                        CheckLogin("select * from users where User_ID='" & dr("user_id") & "' and branch_id='" & VBranch_ID & "'", True)
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
    Private Sub Form_Activate()
        '    txtuser = "1313"
        '    txtpassword = "2011"
        '    Call cmdLogin_Click
    End Sub
    Private Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'frmSplash.Close()
        lbltoko.Text = Tulis(10)
        txtregidNet.Text = VReg_ID
        lblonline.Text = VPing
        txtuserNet.Select()
        txtuserNet.Focus()
        If LoadClose = True Then
            Isi_Parameter()
            Cek_CashOpen()
        End If
        If VPing = "ONLINE" Then
            lblonline.ForeColor = Color.Green
        Else
            lblonline.ForeColor = Color.Red
        End If
        Call CDisplay("  ", "*** LAKON ***")
        FormHandle = Me.Handle
        CheckFinger()
    End Sub

    Sub CheckLogin(ByVal str As String, ByVal Log As Boolean)
        Dim RsUser As New DataSet
        StrSQL = str

        'lemot pas ping
        'If Linked Then
        '    RsUser = getSqldb(StrSQL, ConnServer)
        'Else
        '    RsUser = getSqldb(StrSQL, ConnLocal)
        'End If

        If VPing = "ONLINE" Then
            For x As Integer = 0 To 1
                RsUser = getSqldb(StrSQL, ConnServer)
            Next
        Else
            RsUser = getSqldb(StrSQL, ConnLocal)
        End If

        If RsUser.Tables(0).Rows.Count > 0 Then
            'Cek E-Commerce User
            If Trim(RsUser.Tables(0).Rows(0).Item("User_ID")) = "5000" Then
                VReg_ID = VReg_OL
                Isi_Parameter()
                Cek_CashOpen()
            Else
                VReg_ID = ReadIni("RegisterInfo", "RegID")
            End If

            If Log = True Then
                VKasir_ID = Trim(RsUser.Tables(0).Rows(0).Item("User_ID"))
                VKasir_Nm = Trim(RsUser.Tables(0).Rows(0).Item("user_Name"))
                SecLev = RsUser.Tables(0).Rows(0).Item("Security_Level")
                'Pindah ke Form Splash
                'If Linked() Then Call Cek_SOD("server")
                'Call Cek_SOD("local")
                'Call Cek_Card()
                'Call Cek_CashOpen()
                'Call Cek_AdaPromo()
                'Call Isi_key()
                '---------------------
                If RegType = "0" Then
                    Call CetakBegin()
                Else
                    If SecLev >= 3 Then
                        If VCopen = False Then
                            MsgBox("Masukan Modal Terlebih Dahulu !!")
                            txtuserNet.Visible = True
                            Label2.Text = "USER ID"
                            txtpasswordNet.Visible = False
                            txtuserNet.Focus()
                            Me.WindowState = FormWindowState.Minimized
                            frmCashOpen.ShowDialog()
                            'SendKeys.Send("{home}+{end}")
                            'Exit Sub
                        End If
                    End If
                End If


                Me.Close()


                getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
                            VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnLocal)
                'If Linked() Then
                '    getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
                '            VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
                'End If

                'tanpa cek PING
                If VPing = "ONLINE" Then
                    getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
                            VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
                End If
                Call SaveLog("Login Success" & " " & VKasir_ID & " / " & VKasir_Nm)

                If RegType = "0" Then
                    frmMain.Show()
                Else
                    If SecLev < 3 Then
                        frmMain.Show()
                    Else
                        Call CDisplay("  SALES", "TRANSACTION ")
                        Star_Id = "10000000"
                        VBonus_Point = 1
                        frmSalesSelf.Text = "SALES"
                        frmSalesSelf.txtcard_no.Text = "LM-00000000"
                        frmSalesSelf.txtcust_name.Text = "ONE TIME CUSTOMER"
                        frmSalesSelf.txtcust_id.Text = "10000000"
                        Star_No = "LM-00000000"
                        Star_Nm = "ONE TIME CUSTOMER"
                        Star_Phone = ""
                        VNomor = ""
                        frmSalesSelf.Show()
                    End If
                End If
            Else
                If Trim(RsUser.Tables(0).Rows(0).Item("Password")) = txtpasswordNet.Text Then
                    VKasir_ID = Trim(RsUser.Tables(0).Rows(0).Item("User_ID"))
                    VKasir_Nm = Trim(RsUser.Tables(0).Rows(0).Item("user_Name"))
                    SecLev = RsUser.Tables(0).Rows(0).Item("Security_Level")
                    'Pindah ke Form Splash
                    'If Linked() Then Call Cek_SOD("server")
                    'Call Cek_SOD("local")
                    'Call Cek_Card()
                    'Call Cek_CashOpen()
                    'Call Cek_AdaPromo()
                    'Call Isi_key()
                    '---------------------
                    If RegType = "0" Then
                    Else
                        If SecLev >= 3 Then
                            If VCopen = False Then
                                MsgBox("Masukan Modal Terlebih Dahulu !!")
                                txtuserNet.Visible = True
                                Label2.Text = "USER ID"
                                txtpasswordNet.Visible = False
                                txtuserNet.Focus()
                                'SendKeys.Send("{home}+{end}")
                                Me.WindowState = FormWindowState.Minimized
                                frmCashOpen.ShowDialog()
                                'Exit Sub
                            End If
                        End If
                    End If

                    Call CetakBegin()
                    Me.Close()


                    getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
                                VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnLocal)
                    'If Linked() Then
                    '    getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
                    '            VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
                    'End If

                    'tanpa cek PING
                    If VPing = "ONLINE" Then
                        getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
                                VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
                    End If
                    Call SaveLog("Login Success" & " " & VKasir_ID & " / " & VKasir_Nm)

                    If RegType = "0" Then
                        frmMain.Show()
                    Else
                        If SecLev < 3 Then
                            frmMain.Show()
                        Else
                            Call CDisplay("  SALES", "TRANSACTION ")
                            Star_Id = "10000000"
                            VBonus_Point = 1
                            frmSalesSelf.Text = "SALES"
                            frmSalesSelf.txtcard_no.Text = "LM-00000000"
                            frmSalesSelf.txtcust_name.Text = "ONE TIME CUSTOMER"
                            frmSalesSelf.txtcust_id.Text = "10000000"
                            Star_No = "LM-00000000"
                            Star_Nm = "ONE TIME CUSTOMER"
                            Star_Phone = ""
                            VNomor = ""
                            frmSalesSelf.Show()
                        End If
                    End If

                Else
                    MsgBox("Password yang anda masukkan salah", vbCritical + vbOKOnly, "Oops..")
                    ulang = ulang + 1
                    If ulang > 2 Then
                        Me.Close()
                        If VPing = "ONLINE" Then
                            frmFirstForm.Show()
                        Else
                            Application.Exit()
                        End If
                    End If
                    txtpasswordNet.Visible = True
                    txtuserNet.Visible = False
                    txtpasswordNet.Focus()
                    SendKeys.Send("{home}+{end}")
                End If
            End If

        Else
            Label2.Text = "USER ID"
            txtuserNet.Visible = True
            txtpasswordNet.Visible = False
            MsgBox("Username tidak terdaftar", vbCritical + vbOKOnly, "Oops..")
            txtuserNet.Focus()
            SendKeys.Send("{home}+{end}")
        End If
    End Sub
    Private Sub cmdLogin_Click()
        CheckLogin("select * from users where User_ID='" & txtuserNet.Text & "' and branch_id='" & VBranch_ID & "'", False)
    End Sub
    Private Sub txtpasswordNet_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtpasswordNet.Enter
        posisi = "txtpasswordNet"
    End Sub
    Private Sub txtuserNet_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtuserNet.Enter
        posisi = "txtuserNet"
    End Sub
    Private Sub txtuserNet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuserNet.KeyDown
        Select Case e.KeyCode
            Case 13
                txtuserNet.Visible = False
                txtpasswordNet.Visible = True
                txtpasswordNet.Text = ""
                'penambahan
                Label2.Text = "PASSWORD"
                txtpasswordNet.Focus()
            Case 27
                End
        End Select
        If e.KeyCode = Keys.Enter Then
            'Menghilangkan Bunyi Beep
            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub
    Private Sub txtpasswordNet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpasswordNet.KeyDown
        Select Case e.KeyCode
            Case 13
                cmdLogin_Click()
            Case 27
                txtuserNet.Visible = True
                txtpasswordNet.Visible = False
                txtuserNet.Focus()
                txtpasswordNet.Text = ""
        End Select
        If e.KeyCode = Keys.Enter Then
            'Menghilangkan Bunyi Beep
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub _btnNum_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnNum_0.Click, _btnNum_1.Click,
    _btnNum_2.Click, _btnNum_3.Click, _btnNum_4.Click, _btnNum_5.Click, _btnNum_6.Click, _btnNum_7.Click, _btnNum_8.Click,
    _btnNum_9.Click, _btnNum_10.Click, _btnNum_11.Click, _btnNum_12.Click, _btnNum_13.Click

        Dim btn As Button = sender
        Select Case posisi
            Case "txtuserNet"
                If CInt(btn.Tag) < 10 Then txtuserNet.Text = txtuserNet.Text & btn.Text
                txtuserNet.SelectionStart = txtuserNet.Text.Length
                Select Case CInt(btn.Tag)
                    Case 10
                        txtuserNet.Focus()
                        SendKeys.Send("{end}+{backspace}")
                    Case 11
                        txtuserNet.Focus()
                        SendKeys.Send("{enter}")
                    Case 12
                        txtuserNet.Text = ""
                    Case 13
                        Me.Close()
                        If VPing = "ONLINE" Then
                            'frmSOD.Text = "EOD"
                            'frmSOD.ShowDialog()
                            frmFirstForm.Show()
                        Else
                            Application.Exit()
                        End If
                End Select

            Case "txtpasswordNet"
                If CInt(btn.Tag) < 10 Then txtpasswordNet.Text = txtpasswordNet.Text & btn.Text
                txtpasswordNet.SelectionStart = txtpasswordNet.Text.Length
                Select Case CInt(btn.Tag)
                    Case 10
                        txtpasswordNet.Focus()
                        System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
                    Case 11
                        cmdLogin_Click()
                    Case 12
                        If txtpasswordNet.Text = "" Then
                            Label2.Text = "USER ID"
                            txtuserNet.Visible = True
                            txtpasswordNet.Visible = False
                            txtuserNet.Focus()
                        End If
                        txtpasswordNet.Text = ""
                    Case 13
                        Me.Close()
                        If VPing = "ONLINE" Then
                            'frmSOD.Text = "EOD"
                            'frmSOD.ShowDialog()
                            frmFirstForm.Show()
                        Else
                            Application.Exit()
                        End If

                End Select

        End Select
    End Sub

    Private Sub Cek_CashOpen()
        Dim RsCash As New DataSet

        StrSQL = "select modal from cash where branch_id = '" & VBranch_ID & "' and Cash_Register_ID='" &
                    VReg_ID & " ' and shift='" & VShift & "' and datetime='" & GetSrvDate.Date & "'"

        If Linked() Then
            RsCash = getSqldb(StrSQL, ConnServer)
        Else
            RsCash = getSqldb(StrSQL, ConnLocal)
        End If

        VCopen = IIf(RsCash.Tables(0).Rows.Count = 0, False, True)
    End Sub


    Private Function Isi_Parameter() As Boolean
        Try
            Isi_Parameter = True
            Dim Rst As New DataSet
            Dim tgl_aktif As Date
            Rst = getSqldb("Select * from Branches Where Branch_ID = '" & VBranch_ID & "' ", ConnLocal)
            If Rst.Tables(0).Rows.Count = 0 Then
                If VPing = "ONLINE" Then
                    getSqldb("insert into Branches(Branch_ID, Branch_Name, Company_Name, Address1, Address2, City, Zip_Code, Country, Phone," &
                     "Fax, Loyalty_Check, Flag_SOD, Date_Yesterday, Date_Current, Password_Valid, Voucher_Get_Point)" &
                     "(select Branch_id, Branch_Name, Company_Name, Address1, Address2, City, Zip_Code, Country, Phone," &
                     "Fax , Loyalty_Check, 0, Date_Yesterday, Date_Current, Password_Valid, Voucher_Get_Point " &
                     "FROM [" & ReadIni("Server", "ServerName") & "]." &
                     ReadIni("Server", "DatabaseName") & ".dbo.branches  " &
                     "where branch_id = '" & VBranch_ID & "')", ConnLocal)
                Else
                    MsgBox("Tabel Branches tidak lengkap", vbCritical + vbOKOnly, "Oops..")
                    Isi_Parameter = False
                    Exit Function
                End If
            Else
                Tulis(10) = Rst.Tables(0).Rows(0).Item("branch_name")
                Tulis(11) = Rst.Tables(0).Rows(0).Item("company_name")
                Tulis(12) = Rst.Tables(0).Rows(0).Item("address1")
                Tulis(13) = Rst.Tables(0).Rows(0).Item("address2")
                Tulis(14) = Rst.Tables(0).Rows(0).Item("city")
                Tulis(15) = Rst.Tables(0).Rows(0).Item("zip_code")
                tgl_aktif = Rst.Tables(0).Rows(0).Item("date_current")
            End If


            If Linked() Then
                Rst.Clear()
                Rst = getSqldb("Select * from [Parameters] Where [Type] = 'HargaPoint'", ConnServer)
                If Rst.Tables(0).Rows.Count = 0 Then
                    VHargaPoint = "1000"
                Else
                    VHargaPoint = Rst.Tables(0).Rows(0).Item("Value")
                End If
            Else
                VHargaPoint = "1000"
            End If


            Rst.Clear()
            Rst = getSqldb("Select * from Cash_Register Where Branch_ID = '" & VBranch_ID & "' and Cash_register_Id = '" &
                    VReg_ID & "' ", ConnLocal)

            If Rst.Tables(0).Rows.Count = 0 Then
                If VPing = "ONLINE" Then
                    getSqldb("insert into Cash_Register(Branch_ID, Cash_Register_ID, Spending_Program_ID, Store_Type, Void_Flag, Item_Correct_Flag, Return_Flag, Cancel_Flag, Discount_Flag, Tax_Flag," &
                    "Calc_Point_Flag, Bill_No, Shift, Reset_Date, Last_Reset_Date, Disc_1, Disc_2, Disc_3, Disc_4, Disc_5, Disc_6, Disc_7, Footer_1, Footer_2, Footer_3, Footer_4, Footer_5, Footer_6, Active_Status, ZReset_Status, NPWP, SMessage1, SMessage2)" &
                    "(select Branch_ID, Cash_Register_ID, Spending_Program_ID, Store_Type, Void_Flag, Item_Correct_Flag, Return_Flag, Cancel_Flag, Discount_Flag, Tax_Flag," &
                    "Calc_Point_Flag, Bill_No, Shift, Reset_Date, Last_Reset_Date, Disc_1, Disc_2, Disc_3, Disc_4, Disc_5, Disc_6, Disc_7, Footer_1, Footer_2, Footer_3, Footer_4, Footer_5, Footer_6, Active_Status, ZReset_Status, NPWP, SMessage1, SMessage2 " &
                    "FROM [" & ReadIni("Server", "ServerName") & "]." &
                    ReadIni("Server", "DatabaseName") & ".dbo.cash_register  " &
                    "where branch_id = '" & VBranch_ID & "' and Cash_Register_ID='" & VReg_ID & " ')", ConnServer)
                Else
                    MsgBox("Tabel Cash Register tidak lengkap", vbCritical + vbOKOnly, "Oops..")
                    Isi_Parameter = False
                    Exit Function
                End If
            Else
                If CDate(Rst.Tables(0).Rows(0).Item("reset_date")) > GetSrvDate.Date Then
                    If CDate(tgl_aktif) > GetSrvDate.Date Then
                        MsgBox("Transaksi hari ini sudah closed (Z-Reset)", vbCritical + vbOKOnly, "Oops..")
                        End
                    End If
                End If

                VShift = Rst.Tables(0).Rows(0).Item("Shift")

                Tulis(1) = Rst.Tables(0).Rows(0).Item("Footer_1")
                Tulis(2) = Rst.Tables(0).Rows(0).Item("Footer_2")
                Tulis(3) = Rst.Tables(0).Rows(0).Item("Footer_3")
                Tulis(4) = Rst.Tables(0).Rows(0).Item("Footer_4")
                Tulis(5) = Rst.Tables(0).Rows(0).Item("Footer_5")
                Tulis(6) = Rst.Tables(0).Rows(0).Item("Footer_6")
                Tulis(7) = Rst.Tables(0).Rows(0).Item("SMessage1")
                Tulis(8) = Rst.Tables(0).Rows(0).Item("SMessage2")
                Tulis(9) = Rst.Tables(0).Rows(0).Item("NPWP")
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "Isi_Parameter " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try
    End Function

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        zkfp2.CloseDevice(mDevHandle)
        zkfp2.Terminate()
    End Sub

End Class