Option Strict Off
Option Explicit On
Imports System.ComponentModel
Imports Microsoft.VisualBasic.PowerPacks
Imports Symbol.RFID3
Imports Symbol.RFID3.Events
Imports libzkfpcsharp
Public Class frmSplash
    Inherits System.Windows.Forms.Form
    Dim xx As Byte
    Friend m_ReaderAPI As RFIDReader
    Private m_UpdateReadHandler As UpdateRead = Nothing
    Private m_UpdateStatusHandler As UpdateStatus = Nothing
    Dim antID As UInt16()
    Dim rxValues As Integer()
    Dim txValues As Integer()
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblversi.Text = "Version " & Me.GetType.Assembly.GetName.Version.ToString
        Module1.Main()
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
        LoadClose = False
        CheckForIllegalCrossThreadCalls = False
        NewMember = False
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub Mulai()
        ProgressBar1.Value = 0
        Try
            setLabelTxt("Processing... Check Connections!!", Label2)
        Catch ex As Exception

        End Try
        Dim RsAddLinked As New DataSet
        Call OpenKoneksi(ConnLocal, "Local")

        If VSvr = "." Then
            VPing = "OFFLINE"
        Else
            If Linked() Then Call OpenKoneksi(ConnServer, "Server")
        End If


        BackgroundWorker1.ReportProgress(Int(10))
        Try
            setLabelTxt("Processing... Create Linked!!", Label2)
        Catch ex As Exception

        End Try
        RsAddLinked = getSqldb("select srvname from master..sysservers where srvname='" & ReadIni("Local", "ServerName") & "'", ConnLocal)
        If RsAddLinked.Tables(0).Rows.Count = 0 Then
            getSqldb("exec sp_addlinkedserver '" & ReadIni("Local", "ServerName") & "'", ConnLocal)
            getSqldb("EXEC master.dbo.sp_addlinkedsrvlogin @rmtsrvname=N'" & ReadIni("Local", "ServerName") & "',@useself=N'False',@locallogin=N'sa',@rmtuser=N'sa',@rmtpassword='" & decrypt(ReadIni("Local", "Password")) & "'", ConnLocal)
        End If
        RsAddLinked.Clear()
        BackgroundWorker1.ReportProgress(Int(20))
        Try
            setLabelTxt("Processing... Create Linked Server!!", Label2)
        Catch ex As Exception

        End Try
        RsAddLinked = getSqldb("select srvname from master..sysservers where srvname='" & ReadIni("Server", "ServerName") & "'", ConnLocal)
        If RsAddLinked.Tables(0).Rows.Count = 0 And VSvr <> "" Then
            getSqldb("exec sp_addlinkedserver '" & ReadIni("Server", "ServerName") & "'", ConnLocal)
            getSqldb("select srvname from master..sysservers where srvname='" & ReadIni("Server", "ServerName") & "'", ConnLocal)
        End If
        RsAddLinked.Clear()
        RsAddLinked = Nothing
        BackgroundWorker1.ReportProgress(Int(30))
        Try
            setLabelTxt("Processing... Declare Parameters!!", Label2)
        Catch ex As Exception

        End Try
        Isi_Parameter()
        BackgroundWorker1.ReportProgress(Int(40))
        Call Cek_CashOpen()
        BackgroundWorker1.ReportProgress(Int(50))
        Call Cek_AdaPromo()
        Try
            setLabelTxt("Processing... Promo Checking!!", Label2)
        Catch ex As Exception

        End Try
        BackgroundWorker1.ReportProgress(Int(60))
        'CheckFinger()
        'If Linked() Then Call Cek_SOD("server")
        'Try
        '    setLabelTxt("Processing... SOD Checking!!", Label2)
        'Catch ex As Exception

        'End Try
        'BackgroundWorker1.ReportProgress(Int(70))
        'Call Cek_SOD("local")
        'BackgroundWorker1.ReportProgress(Int(80))
        'Try
        '    setLabelTxt("Processing... Card Checking!!", Label2)
        'Catch ex As Exception

        'End Try
        If RFIDType = "zebra" Then
            If RFIDStatus = False Then
                CheckCon()
            End If
        End If

        'If RFIDType = "zebra" Then
        '    CheckCon()
        'End If


        BackgroundWorker1.ReportProgress(Int(90))
        'Call Isi_key()
        If RFIDStatus = True Then
            SetReader()
        End If

        'If RFIDType = "zebra" Then
        '    SetReader()
        'End If

        BackgroundWorker1.ReportProgress(Int(100))
        If RFIDStatus = True Then
            Try
                If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
                    Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
                Else
                    Me.m_ReaderAPI.Actions.Inventory.Stop()
                End If
                Me.m_ReaderAPI.Disconnect()
                'Me.m_IsConnected = False
                'workEventArgs.Result = "Disconnect Succeed"
            Catch ofe As OperationFailureException
                'workEventArgs.Result = ofe.Result
            End Try
        End If
        'If RFIDType = "zebra" Then
        '    Try
        '        If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
        '            Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
        '        Else
        '            Me.m_ReaderAPI.Actions.Inventory.Stop()
        '        End If
        '        Me.m_ReaderAPI.Disconnect()
        '        'Me.m_IsConnected = False
        '        'workEventArgs.Result = "Disconnect Succeed"
        '    Catch ofe As OperationFailureException
        '        'workEventArgs.Result = ofe.Result
        '    End Try
        'End If

    End Sub

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
    End Sub


    Sub CheckCon()
        m_ReaderAPI = New RFIDReader(IPReader, UInt32.Parse("5084"), 0)
        Try
            m_ReaderAPI.Connect()
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

        Catch operationException As OperationFailureException
            'MsgBox(operationException.Result)
            MsgBox("RFID Offline !!!")
            RFIDStatus = False
        Catch ex As Exception
            MsgBox(ex.Message)
            RFIDStatus = False
        End Try
    End Sub

    Public Sub Events_StatusNotify(ByVal sender As Object, ByVal statusEventArgs As StatusEventArgs)
        Try
            MyBase.Invoke(Me.m_UpdateStatusHandler, New Object() {statusEventArgs.StatusEventData})
        Catch exception1 As Exception
        End Try
    End Sub

    Private Delegate Sub UpdateRead(ByVal eventData As ReadEventData)
    Private Delegate Sub UpdateStatus(ByVal eventData As StatusEventData)
    Private Sub myUpdateStatus(ByVal eventData As Events.StatusEventData)
        Select Case eventData.StatusEventType
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_START_EVENT
                'functionCallStatusLabel.Text = "Inventory started"
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_STOP_EVENT
                'functionCallStatusLabel.Text = "Inventory stopped"
                'ReadOtherBank()
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_START_EVENT
                'functionCallStatusLabel.Text = "Access Operation started"
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_STOP_EVENT
                'functionCallStatusLabel.Text = "Access Operation stopped"
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_WARNING_EVENT
                'functionCallStatusLabel.Text = " Buffer full warning"
                'myUpdateRead(Nothing)
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_EVENT
                'functionCallStatusLabel.Text = "Buffer full"
                'myUpdateRead(Nothing)
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.DISCONNECTION_EVENT
                'functionCallStatusLabel.Text = "Disconnection Event " & eventData.DisconnectionEventData.DisconnectEventInfo.ToString()
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ANTENNA_EVENT
                'functionCallStatusLabel.Text = "Antenna Status Update"
                Exit Select
            Case Symbol.RFID3.Events.STATUS_EVENT_TYPE.READER_EXCEPTION_EVENT
                'functionCallStatusLabel.Text = "Reader ExceptionEvent " & eventData.ReaderExceptionEventData.ReaderExceptionEventInfo
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub Events_ReadNotify(ByVal sender As Object, ByVal readEventArgs As ReadEventArgs)
        Try
            MyBase.Invoke(Me.m_UpdateReadHandler, New Object() {Nothing})
        Catch exception1 As Exception
        End Try
    End Sub



    Private Sub SetReader()
        Try

            Dim antID As UInt16() = m_ReaderAPI.Config.Antennas.AvailableAntennas
            Dim antConfig As Antennas.Config = m_ReaderAPI.Config.Antennas.Item(antID(0)).GetConfig
            antConfig.TransmitPowerIndex = PowerIndex

            m_ReaderAPI.Config.Antennas.Item(antID(0)).SetConfig(antConfig)

        Catch iue As InvalidUsageException

        Catch ofe As OperationFailureException

        Catch ex As Exception

        End Try
    End Sub

    Private Sub setLabelTxt(ByVal text As String, ByVal lbl As Label)
        If lbl.InvokeRequired Then
            lbl.Invoke(New setLabelTxtInvoker(AddressOf setLabelTxt), text, lbl)
        Else
            lbl.Text = text
        End If
    End Sub



    Private Delegate Sub setLabelTxtInvoker(ByVal text As String, ByVal lbl As Label)
    Private Sub Cek_SOD(ByVal StrSvr As String)
        Dim RsSOD As New DataSet

        StrSQL = "select flag_sod from branches where branch_id ='" & VBranch_ID & "'"

        Select Case StrSvr
            Case "server"
                RsSOD = getSqldb(StrSQL, ConnServer)
                If RsSOD.Tables(0).Rows(0).Item("Flag_SOD") = 0 Then
                    MsgBox("Server belum SOD..", vbCritical + vbOKOnly, "Oops..")
                    End
                End If

            Case "local"
                RsSOD = getSqldb(StrSQL, ConnLocal)
                If VPing = "ONLINE" And RsSOD.Tables(0).Rows(0).Item("Flag_SOD") = 0 Then
                    frmSOD.Text = "SOD"
                    frmSOD.ShowDialog()
                End If
        End Select
    End Sub

    Private Sub Cek_Card()
        Dim RsCcard As New DataSet

        RsCcard = getSqldb("select count(*) as berapa from customer_master_member", ConnLocal)
        If RsCcard.Tables(0).Rows(0).Item("Berapa") = 0 Then
            getSqldb("update branches set flag_sod=0 where Branch_ID = '" & VBranch_ID & "'", ConnLocal)
            MsgBox("SOD belum selesai, jalankan iPOS sekali lagi...", vbCritical + vbOKOnly, "Oops..")
            End
        End If
    End Sub

    Private Sub Cek_CashOpen()
        Dim RsCash As New DataSet

        StrSQL = "select modal from cash where branch_id = '" & VBranch_ID & "' and Cash_Register_ID='" &
                    VReg_ID & " ' and shift='" & VShift & "' and datetime='" & GetSrvDate.Date & "'"

        If VPing = "ONLINE" Then
            RsCash = getSqldb(StrSQL, ConnServer)
        Else
            RsCash = getSqldb(StrSQL, ConnLocal)
        End If
        VCopen = IIf(RsCash.Tables(0).Rows.Count = 0, False, True)
    End Sub

    Private Sub Cek_AdaPromo()
        Dim RsPro As New DataSet

        RsPro = getSqldb("select promo_id from promo_hdr where getdate() Between Start_Date And End_Date And aktif=1",
                   ConnLocal)

        VAda_Promo = RsPro.Tables(0).Rows.Count
        RsPro.Clear()
        RsPro = getSqldb("select distinct list_id from Item_Master_Listing where getdate() Between Start_Date And End_Date and active=1",
                   ConnLocal)
        VAda_Promo = RsPro.Tables(0).Rows.Count
        RsPro.Clear()
        RsPro = getSqldb("Select * from informasi", ConnLocal)
        If RsPro.Tables(0).Rows.Count > 0 Then
            Tulis(16) = RsPro.Tables(0).Rows(0).Item("pesan1") & vbNewLine & RsPro.Tables(0).Rows(0).Item("pesan2") & vbNewLine &
                        RsPro.Tables(0).Rows(0).Item("pesan3") & vbNewLine & RsPro.Tables(0).Rows(0).Item("pesan4") & vbNewLine &
                        RsPro.Tables(0).Rows(0).Item("pesan5") & vbNewLine & RsPro.Tables(0).Rows(0).Item("pesan6") & vbNewLine &
                       RsPro.Tables(0).Rows(0).Item("pesan7") & vbNewLine & RsPro.Tables(0).Rows(0).Item("pesan8")
        End If
    End Sub

    'Private Sub Isi_key()
    '    Dim RsIsi As New DataSet

    '    RsIsi = getSqldb("select form, menu, keycode from key_map", ConnLocal)
    '    For Each ro As DataRow In RsIsi.Tables(0).Rows
    '        If ro("KeyCode") < 122 And ro("KeyCode") > 26 Then KeyStroke(ro("KeyCode") - 27) = ro("Menu")
    '    Next

    'End Sub

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


            If VPing = "ONLINE" Then
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
                    "where branch_id = '" & VBranch_ID & "' and Cash_Register_ID='" & VReg_ID & " ')", ConnLocal)
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

    Public Function CEKLPT(ByVal cek As Boolean)
        Dim strOut As Object
        Dim strPRT As String
        If PPort.ToString.ToLower = "lpt1" Then
            strPRT = CStr(379)
            Do While cek <> False
                'UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strOut = Str(Inp(Val("&H" & strPRT)))
                'UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Out(Val("&H" & strPRT), Val(strOut))
                'UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If CDbl(strPRT) = 379 And strOut = 127 Then
                    MsgBox("Printer belum dinyalakan", MsgBoxStyle.Exclamation, "Warning")
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CDbl(strPRT) = 379 And strOut = 119 Or strOut = 103 Then
                        MsgBox("Kertas Printer Habis", MsgBoxStyle.Exclamation, "Warning")
                    Else
                        cek = False
                    End If
                End If
            Loop
        End If
        Return cek
    End Function



    Private Sub OpenKoneksi(ByRef SrvName As String, ByRef Strheader As Object)
        On Error GoTo ErrH
        Dim dsCek As New DataSet
        dsCek = getSqldb("Select top 1 * from item_master", SrvName)
        Exit Sub
ErrH:
        If Err.Number = CDbl("-2147467259") Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Strheader. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            MsgBox("Database " & Strheader & " tidak terkoneksi. " & vbNewLine & "Harap hubungi IT. ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Else
            MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        End If
        Call SaveLog("OpenKoneksi " & Err.Description & " " & Err.Number)
        End
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Mulai()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Visible = False
        If Isi_Parameter() Then
            Me.Hide()
            'Call CEKLPT(True)
            EODFirstForm = False
            frmSOD.Show()
            'If VPing = "ONLINE" Then
            '    FirstForm.Show()
            '    'frmShowStock.Show()
            'End If
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

End Class
