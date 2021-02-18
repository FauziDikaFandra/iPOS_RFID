Imports Symbol.RFID3
Imports Symbol.RFID3.TagAccess.Sequence
Imports Symbol.RFID3.Events
Imports System.ComponentModel

Public Class frmShowStock
    Friend m_ReaderAPI As RFIDReader

    Public m_TagTable As Hashtable
    Private m_UpdateStatusHandler As UpdateStatus = Nothing
    Private m_UpdateReadHandler As UpdateRead = Nothing
    Dim NextStep As Boolean
    Dim ds, dsDG As New DataSet
    Private Sub Closebtn_Click(sender As Object, e As EventArgs)
        'Application.Exit()
        frmFirstForm.Show()
    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowDG(txtItemCode.Text.ToString.Trim, False)
        End If
        If e.KeyCode = Keys.Enter Then
            'Menghilangkan Bunyi Beep
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Sub ShowDG(ByVal Item As String, ByVal RFIDJ As Boolean)
        If RFIDJ = True Then
            Item = HexToString(Microsoft.VisualBasic.Left(Item, 26))
            txtItemCode.Text = Item
            My.Computer.Audio.Play(Application.StartupPath & "/Beep.wav", AudioPlayMode.Background)
        End If
        DataGridView1.DataSource = Nothing
        ds.Clear()
        dsDG.Clear()
        If VPing = "ONLINE" Then
            ds = getSqldb("select distinct RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,(SELECT Count(*) from Item_Master_RFID Where Location = 0 and flag = 0 and status = 1 and plu = a.plu) as Warehouse," &
                      "(SELECT Count(*) from Item_Master_RFID Where Location = 1 and flag = 0 and status = 1 and plu = a.plu) as Floor,ISNULL(last_stok,0) as Stock from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
                      "Location c on b.Location = c.Location left join t_stok d on a.PLU = d.plu where " &
                      "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.PLU " &
                      "= '" & Item & "' or b.EPC = '" & Item & "') and isnull(status,1) = 1", ConnServer)
            '''''apabila sudah ditempel semua
            'dsDG = getSqldb("Declare @art as varchar(20) Declare @brnd as varchar(20)" &
            '            "set @brnd =(select top 1 brand from item_master a inner join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "')" &
            '            "set @art = (select top 1 case when LEN(a.Article_Code) > 8 Then SUBSTRING(a.Article_Code,1,8) Else SUBSTRING(a.Article_Code,1,6) " &
            '            "End As Article from Item_Master a left join Item_Master_RFID b On a.Article_Code = b.Article_Code where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') " &
            '            "select DISTINCT RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,(SELECT Count(*) from Item_Master_RFID Where Location = 0 and flag = 0 and status = 1 and plu = a.plu) as Warehouse," &
            '          "(SELECT Count(*) from Item_Master_RFID Where Location = 1 and flag = 0 and status = 1 and plu = a.plu) as Floor, ISNULL(last_stok,0) as Stock from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
            '            "Location c on b.Location = c.Location  left join t_stok d on a.PLU = d.plu where " &
            '            "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.article_code " &
            '            " Like '' +@art+ '%') And a.PLU <> (select top 1 a.PLU from item_master a inner join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') and a.brand = @brnd ", ConnServer)
            '''''belum semua
            dsDG = getSqldb("Declare @art as varchar(20) Declare @brnd as varchar(20)" &
                        "set @brnd =(select top 1 brand from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "'  and b.status = 1)" &
                        "set @art = (select top 1 case when LEN(a.Article_Code) > 8 Then SUBSTRING(a.Article_Code,1,8) Else SUBSTRING(a.Article_Code,1,6) " &
                        "End As Article from Item_Master a left join Item_Master_RFID b On a.Article_Code = b.Article_Code where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "'  and b.status = 1) " &
                        "select DISTINCT RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand, (SELECT Count(*) from Item_Master_RFID Where Location = 0 and flag = 0 and status = 1 and plu = a.plu) as Warehouse," &
                      "(SELECT Count(*) from Item_Master_RFID Where Location = 1 and flag = 0 and status = 1 and plu = a.plu) as Floor, ISNULL(last_stok,0) as Stock from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
                        "Location c on b.Location = c.Location  left join t_stok d on a.PLU = d.plu where " &
                        "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.article_code " &
                        " Like '' +@art+ '%') And a.Description <> 'TIDAK AKTIF' and a.PLU <> (select top 1 a.PLU from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') and a.brand = @brnd ", ConnServer)
        Else
            ds = getSqldb("select  RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,'0' as Warehouse,'0' as Floor,'0' as Stock from Item_Master where PLU " &
                      "= '" & Item & "')", ConnLocal)
            dsDG = getSqldb("select top 10 RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,'0' as Warehouse,'0' as Floor,'0' as Stock from Item_Master where PLU " &
                      "like '%" & Item & "%' )", ConnLocal)
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows.Count > 1 And dsDG.Tables(0).Rows.Count > 0 Then
                DataGridView1.DataSource = dsDG.Tables(0)
                DataGridView1.Columns("Price").DefaultCellStyle.Format = "N0"
                DataGridView1.Columns("Warehouse").DefaultCellStyle.Format = "N0"
                DataGridView1.Columns("PLU").Width = 150
                DataGridView1.Columns("Description").Width = 300
                DataGridView1.Columns("Price").Width = 100
                DataGridView1.Columns("Brand").Visible = False
                DataGridView1.Columns("Warehouse").Width = 120
                DataGridView1.Columns("Floor").Width = 70
                DataGridView1.Columns("Stock").Width = 70
                DataGridView1.Columns("Stock").HeaderText = "SAP"
                DataGridView1.Refresh()
            Else
                PLU.Text = ds.Tables(0).Rows(0).Item("PLU")
                Desc.Text = ds.Tables(0).Rows(0).Item("Description")
                '''''apabila sudah ditempel semua
                whs.Text = ds.Tables(0).Rows(0).Item("Warehouse")
                floor.Text = ds.Tables(0).Rows(0).Item("Floor")
                '''''belum semua
                'whs.Text = ds.Tables(0).Rows(0).Item("Stock")
                'floor.Text = 0
                Stock.Text = ds.Tables(0).Rows(0).Item("Stock")
            End If
        Else
            PLU.Text = "_"
            Desc.Text = "_"
            whs.Text = "_"
            floor.Text = "_"
            Stock.Text = "_"
        End If

        If dsDG.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows.Count > 1 And dsDG.Tables(0).Rows.Count > 0 Then
                PLU.Text = ds.Tables(0).Rows(0).Item("PLU")
                Desc.Text = ds.Tables(0).Rows(0).Item("Description")
                '''''apabila sudah ditempel semua
                whs.Text = ds.Tables(0).Rows(0).Item("Warehouse")
                floor.Text = ds.Tables(0).Rows(0).Item("Floor")
                '''''belum semua
                'whs.Text = ds.Tables(0).Rows(0).Item("Stock")
                'floor.Text = 0
                Stock.Text = ds.Tables(0).Rows(0).Item("Stock")
            Else
                DataGridView1.DataSource = dsDG.Tables(0)
                DataGridView1.Columns("Price").DefaultCellStyle.Format = "N0"
                DataGridView1.Columns("Warehouse").DefaultCellStyle.Format = "N0"
                DataGridView1.Columns("PLU").Width = 150
                DataGridView1.Columns("Description").Width = 300
                DataGridView1.Columns("Price").Width = 100
                DataGridView1.Columns("Brand").Visible = False
                DataGridView1.Columns("Warehouse").Width = 120
                DataGridView1.Columns("Floor").Width = 70
                DataGridView1.Columns("Stock").Width = 70
                DataGridView1.Columns("Stock").HeaderText = "SAP"
                DataGridView1.Refresh()
            End If

        End If
        txtItemCode.Select(0, txtItemCode.Text.Length)
        txtItemCode.Focus()
    End Sub

    'Sub ShowDG(ByVal Item As String, ByVal RFIDJ As Boolean) 'RFID apabila belum di tempel semua
    '    If RFIDJ = True Then
    '        Item = HexToString(Microsoft.VisualBasic.Left(Item, 26))
    '        txtItemCode.Text = Item
    '        My.Computer.Audio.Play(Application.StartupPath & "/Beep.wav", AudioPlayMode.Background)
    '    End If
    '    DataGridView1.DataSource = Nothing
    '    ds.Clear()
    '        dsDG.Clear()
    '    If VPing = "ONLINE" Then

    '        'For x As Integer = 0 To 1
    '        ds = getSqldb("select RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,ISNULL(last_stok,0) as Stock " &
    '                  "from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
    '                  "Location c on b.Location = c.Location left join t_stok d on a.PLU = d.plu where " &
    '                  "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.PLU " &
    '                  "= '" & Item & "' or b.EPC = '" & Item & "')", ConnServer)
    '        'Next
    '        'For x As Integer = 0 To 1
    '        dsDG = getSqldb("Declare @art as varchar(20) Declare @brnd as varchar(20)" &
    '                                    "set @brnd =(select top 1 brand from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "')" &
    '                                    "set @art = (select distinct case when LEN(a.Article_Code) > 8 Then SUBSTRING(a.Article_Code,1,8) Else SUBSTRING(a.Article_Code,1,6) " &
    '                                    "End As Article from Item_Master a left join Item_Master_RFID b On a.Article_Code = b.Article_Code where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') " &
    '                                    "select DISTINCT RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,ISNULL(last_stok,0) as Stock " &
    '                                    "from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
    '                                    "Location c on b.Location = c.Location  left join t_stok d on a.PLU = d.plu where " &
    '                                    "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.article_code " &
    '                                    " Like '' +@art+ '%') And a.PLU <> (select top 1 a.PLU from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') and a.brand = @brnd ", ConnServer)
    '            'Next

    '            Else
    '        ds = getSqldb("select  RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,'OFFLINE' from Item_Master where PLU " &
    '                  "= '" & Item & "'", ConnLocal)
    '        dsDG = getSqldb("select top 10 RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,'OFFLINE' from Item_Master where PLU " &
    '                  "like '%" & Item & "%'", ConnLocal)
    '    End If

    '    'If ds.Tables(0).Rows.Count = 0 Then
    '    '    PLU.Text = "_"
    '    '    Desc.Text = "_"
    '    '    Stock.Text = "_"
    '    '    Exit Sub
    '    'End If

    '    If ds.Tables(0).Rows.Count > 0 Then
    '        If ds.Tables(0).Rows.Count > 1 And dsDG.Tables(0).Rows.Count > 0 Then
    '            DataGridView1.DataSource = ds.Tables(0)
    '            DataGridView1.Columns("Price").DefaultCellStyle.Format = "N0"
    '            DataGridView1.Columns("Stock").DefaultCellStyle.Format = "N0"
    '            DataGridView1.Columns("PLU").Width = 150
    '            DataGridView1.Columns("Description").Width = 340
    '            DataGridView1.Columns("Price").Width = 100
    '            DataGridView1.Columns("Brand").Visible = False
    '            DataGridView1.Columns("Stock").Width = 100
    '            DataGridView1.Refresh()
    '        Else
    '            PLU.Text = ds.Tables(0).Rows(0).Item("PLU")
    '            Desc.Text = ds.Tables(0).Rows(0).Item("Description")
    '            Stock.Text = ds.Tables(0).Rows(0).Item("Stock")
    '        End If
    '    Else
    '        PLU.Text = "_"
    '            Desc.Text = "_"
    '            Stock.Text = "_"
    '        End If

    '        If dsDG.Tables(0).Rows.Count > 0 Then
    '        If ds.Tables(0).Rows.Count > 1 And dsDG.Tables(0).Rows.Count > 0 Then
    '            PLU.Text = dsDG.Tables(0).Rows(0).Item("PLU")
    '            Desc.Text = dsDG.Tables(0).Rows(0).Item("Description")
    '            Stock.Text = dsDG.Tables(0).Rows(0).Item("Stock")
    '        Else
    '            DataGridView1.DataSource = dsDG.Tables(0)
    '            DataGridView1.Columns("Price").DefaultCellStyle.Format = "N0"
    '            DataGridView1.Columns("Stock").DefaultCellStyle.Format = "N0"
    '            DataGridView1.Columns("PLU").Width = 150
    '            DataGridView1.Columns("Description").Width = 340
    '            DataGridView1.Columns("Price").Width = 100
    '            DataGridView1.Columns("Brand").Visible = False
    '            DataGridView1.Columns("Stock").Width = 100
    '            DataGridView1.Refresh()
    '        End If

    '    End If
    '    txtItemCode.Select(0, txtItemCode.Text.Length)
    '        txtItemCode.Focus()
    'End Sub

    Private Sub Show_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Font = New Font("Arial", 12)
        txtItemCode.Select(0, txtItemCode.Text.Length)
        txtItemCode.Focus()
        NextStep = False
        RFIDStatus = False
        Me.m_UpdateStatusHandler = New UpdateStatus(AddressOf Me.myUpdateStatus)
        Me.m_UpdateReadHandler = New UpdateRead(AddressOf Me.myUpdateRead)
        Me.m_TagTable = New Hashtable
        CheckForIllegalCrossThreadCalls = False
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
            RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_Refresh3.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
            RfidScan2.Text = "REFRESH"
            RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
            RfidScan2.TextAlign = ContentAlignment.BottomCenter
            RfidScan2.TextImageRelation = TextImageRelation.Overlay
            RfidScan2.ForeColor = Color.Green
        End If
        OneReadAll = False
        Call CDisplay("  ", "*** LAKON ***")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        NextStep = True
        'Try
        '    If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
        '        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
        '        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.DeleteAll()
        '    Else
        '        Me.m_ReaderAPI.Actions.Inventory.Stop()
        '    End If
        '    RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_DEACTIVE.ico").GetThumbnailImage(20, 20, Nothing, IntPtr.Zero)
        '    RfidScan2.Text = "RFID OFF"
        '    RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
        '    RfidScan2.TextAlign = ContentAlignment.BottomCenter
        '    RfidScan2.TextImageRelation = TextImageRelation.Overlay
        '    RfidScan2.ForeColor = Color.Red
        '    RFIDStatus = False
        '    OneReadAll = False
        'Catch ex As Exception

        'End Try

        Me.Close()
    End Sub

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
                op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_TID
                op.ReadAccessParams.ByteCount = 0
                op.ReadAccessParams.ByteOffset = 0
                op.ReadAccessParams.AccessPassword = 0
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op)
                OneReadAll = True
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(Nothing, Nothing, Nothing)

                'If DataGridView1.Rows.Count > 0 Then
                '    DataGridView1.DataSource = Nothing
                'End If
            End If
        Catch operationException As OperationFailureException
            MsgBox("RFID Offline !!!")
            RFIDStatus = False
            txtItemCode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            RFIDStatus = False
        End Try
    End Sub

    Private Delegate Sub UpdateStatus(ByVal eventData As StatusEventData)
    Private Delegate Sub UpdateRead(ByVal eventData As ReadEventData)



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
                    Dim tagID As String = tag.TagID
                    Dim TIDData As String = tag.MemoryBankData
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
                            ShowDG(Trim(tag.TagID), True)
                        End If

                        'txtItemCode.Text = HexToString(Microsoft.VisualBasic.Left(Trim(tag.TagID), 26))
                        'My.Computer.Audio.Play(Application.StartupPath & "/Beep.wav", AudioPlayMode.Background)
                        'ShowDG(txtItemCode.Text.ToString.Trim, False)
                        SyncLock m_TagTable.SyncRoot
                            m_TagTable.Add(tagID, tag.TagID)
                        End SyncLock
                    End If
                End If
            Next
        End If
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
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            OneReadAll = False
            If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
                Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
                Me.m_ReaderAPI.Actions.Inventory.Stop()
            Else
                Me.m_ReaderAPI.Actions.Inventory.Stop()
            End If
            Me.m_ReaderAPI.Disconnect()

            If m_ReaderAPI.IsConnected = True Then
                m_ReaderAPI.Disconnect()
            End If

            'Me.m_IsConnected = False
            'workEventArgs.Result = "Disconnect Succeed"
        Catch ofe As OperationFailureException
            'workEventArgs.Result = ofe.Result
        End Try
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Close()
        'If NextStep = True Then
        '    frmLogin.Show()
        'End If
        Exit Sub
    End Sub

    Private Sub RfidScan2_Click(sender As Object, e As EventArgs) Handles RfidScan2.Click
        If RFIDStatus = False Then
            If RFIDType = "zebra" Then
                CheckConZebra()
            End If
            txtItemCode.Focus()
            Exit Sub
        End If
        Try
            DataGridView1.DataSource = Nothing
            PLU.Text = "_"
            Desc.Text = "_"
            Stock.Text = "_"
            txtItemCode.Clear()
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
                RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_Refresh3.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
                RfidScan2.Text = "REFRESH"
                RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
                RfidScan2.TextAlign = ContentAlignment.BottomCenter
                RfidScan2.TextImageRelation = TextImageRelation.Overlay
                RfidScan2.ForeColor = Color.Green
                RFIDStatus = True
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
                RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_Refresh3.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
                RfidScan2.Text = "REFRESH"
                RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
                RfidScan2.TextAlign = ContentAlignment.BottomCenter
                RfidScan2.TextImageRelation = TextImageRelation.Overlay
                RfidScan2.ForeColor = Color.Green
                RFIDStatus = True
                m_TagTable.Clear()
            End If
        Catch ex As Exception
            txtItemCode.Focus()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmFirstForm.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmFirstForm.Show()
    End Sub

    Private Sub frmShowStock_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If RFIDStatus = True Then
            BackgroundWorker1.WorkerReportsProgress = True
            BackgroundWorker1.WorkerSupportsCancellation = True
            BackgroundWorker1.RunWorkerAsync()
        Else
            If NextStep = True Then
                frmLogin.Show()
            End If
        End If
    End Sub
End Class