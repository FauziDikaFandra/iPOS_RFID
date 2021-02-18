<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.vpay = New System.Windows.Forms.TextBox()
        Me.vstatus = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._btnNum_12 = New System.Windows.Forms.Button()
        Me._btnNum_10 = New System.Windows.Forms.Button()
        Me._btnNum_0 = New System.Windows.Forms.Button()
        Me._btnNum_1 = New System.Windows.Forms.Button()
        Me.cmdvoc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._frmpay_2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtvoucher = New System.Windows.Forms.TextBox()
        Me.txtno_voc = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtno_kartu = New System.Windows.Forms.TextBox()
        Me.txtcredit = New System.Windows.Forms.TextBox()
        Me.txtcash = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._btnNum_11 = New System.Windows.Forms.Button()
        Me._frmpay_0 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me._btnNum_2 = New System.Windows.Forms.Button()
        Me._frmpay_1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtsaldo_point = New System.Windows.Forms.TextBox()
        Me.txtcard_no = New System.Windows.Forms.TextBox()
        Me.txttukar_point = New System.Windows.Forms.TextBox()
        Me.txtpoint = New System.Windows.Forms.TextBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me._btnNum_3 = New System.Windows.Forms.Button()
        Me.btnNum = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me._btnNum_4 = New System.Windows.Forms.Button()
        Me._btnNum_5 = New System.Windows.Forms.Button()
        Me._btnNum_6 = New System.Windows.Forms.Button()
        Me._btnNum_7 = New System.Windows.Forms.Button()
        Me._btnNum_8 = New System.Windows.Forms.Button()
        Me._btnNum_9 = New System.Windows.Forms.Button()
        Me.cmdpay = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me._cmdpay_0 = New System.Windows.Forms.Button()
        Me._cmdpay_2 = New System.Windows.Forms.Button()
        Me._cmdpay_1 = New System.Windows.Forms.Button()
        Me.vno_trans = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblsisa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblbayar = New System.Windows.Forms.Label()
        Me._frmpay_3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtharga_point = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.Panel()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me.frmpay = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me._frmpay_2.SuspendLayout()
        Me._frmpay_0.SuspendLayout()
        Me._frmpay_1.SuspendLayout()
        CType(Me.btnNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdpay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._frmpay_3.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.frmpay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vpay
        '
        Me.vpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vpay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpay.Location = New System.Drawing.Point(382, 12)
        Me.vpay.Name = "vpay"
        Me.vpay.Size = New System.Drawing.Size(108, 26)
        Me.vpay.TabIndex = 34
        Me.vpay.Visible = False
        '
        'vstatus
        '
        Me.vstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vstatus.Location = New System.Drawing.Point(382, 59)
        Me.vstatus.Name = "vstatus"
        Me.vstatus.Size = New System.Drawing.Size(108, 26)
        Me.vstatus.TabIndex = 35
        Me.vstatus.Visible = False
        '
        '_btnNum_12
        '
        Me._btnNum_12.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_12.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_12, CType(12, Short))
        Me._btnNum_12.Location = New System.Drawing.Point(270, 10)
        Me._btnNum_12.Name = "_btnNum_12"
        Me._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_12.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_12.TabIndex = 43
        Me._btnNum_12.TabStop = False
        Me._btnNum_12.Text = "C"
        Me._btnNum_12.UseVisualStyleBackColor = False
        '
        '_btnNum_10
        '
        Me._btnNum_10.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_10.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_10, CType(10, Short))
        Me._btnNum_10.Location = New System.Drawing.Point(205, 10)
        Me._btnNum_10.Name = "_btnNum_10"
        Me._btnNum_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_10.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_10.TabIndex = 42
        Me._btnNum_10.TabStop = False
        Me._btnNum_10.Text = "<<"
        Me._btnNum_10.UseVisualStyleBackColor = False
        '
        '_btnNum_0
        '
        Me._btnNum_0.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_0.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_0, CType(0, Short))
        Me._btnNum_0.Location = New System.Drawing.Point(205, 140)
        Me._btnNum_0.Name = "_btnNum_0"
        Me._btnNum_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_0.Size = New System.Drawing.Size(130, 65)
        Me._btnNum_0.TabIndex = 40
        Me._btnNum_0.TabStop = False
        Me._btnNum_0.Text = "0"
        Me._btnNum_0.UseVisualStyleBackColor = False
        '
        '_btnNum_1
        '
        Me._btnNum_1.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_1, CType(1, Short))
        Me._btnNum_1.Location = New System.Drawing.Point(10, 140)
        Me._btnNum_1.Name = "_btnNum_1"
        Me._btnNum_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_1.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_1.TabIndex = 39
        Me._btnNum_1.TabStop = False
        Me._btnNum_1.Text = "1"
        Me._btnNum_1.UseVisualStyleBackColor = False
        '
        'cmdvoc
        '
        Me.cmdvoc.BackColor = System.Drawing.SystemColors.Control
        Me.cmdvoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdvoc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdvoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdvoc.Image = CType(resources.GetObject("cmdvoc.Image"), System.Drawing.Image)
        Me.cmdvoc.Location = New System.Drawing.Point(268, 21)
        Me.cmdvoc.Name = "cmdvoc"
        Me.cmdvoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdvoc.Size = New System.Drawing.Size(66, 26)
        Me.cmdvoc.TabIndex = 49
        Me.cmdvoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdvoc.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(5, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(141, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "SISA        : Rp"
        '
        '_frmpay_2
        '
        Me._frmpay_2.BackColor = System.Drawing.Color.White
        Me._frmpay_2.Controls.Add(Me.Label14)
        Me._frmpay_2.Controls.Add(Me.Label13)
        Me._frmpay_2.Controls.Add(Me.txtvoucher)
        Me._frmpay_2.Controls.Add(Me.txtno_voc)
        Me._frmpay_2.Controls.Add(Me.cmdvoc)
        Me._frmpay_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmpay_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmpay.SetIndex(Me._frmpay_2, CType(2, Short))
        Me._frmpay_2.Location = New System.Drawing.Point(4, 215)
        Me._frmpay_2.Name = "_frmpay_2"
        Me._frmpay_2.Padding = New System.Windows.Forms.Padding(0)
        Me._frmpay_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._frmpay_2.Size = New System.Drawing.Size(351, 96)
        Me._frmpay_2.TabIndex = 52
        Me._frmpay_2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "BAYAR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "NO VOUCHER"
        '
        'txtvoucher
        '
        Me.txtvoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvoucher.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvoucher.Location = New System.Drawing.Point(101, 55)
        Me.txtvoucher.Name = "txtvoucher"
        Me.txtvoucher.Size = New System.Drawing.Size(144, 25)
        Me.txtvoucher.TabIndex = 65
        '
        'txtno_voc
        '
        Me.txtno_voc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtno_voc.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_voc.Location = New System.Drawing.Point(101, 21)
        Me.txtno_voc.MaxLength = 15
        Me.txtno_voc.Name = "txtno_voc"
        Me.txtno_voc.Size = New System.Drawing.Size(144, 25)
        Me.txtno_voc.TabIndex = 60
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(93, 55)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(240, 25)
        Me.txtnama.TabIndex = 64
        '
        'txtno_kartu
        '
        Me.txtno_kartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtno_kartu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_kartu.Location = New System.Drawing.Point(93, 24)
        Me.txtno_kartu.MaxLength = 16
        Me.txtno_kartu.Name = "txtno_kartu"
        Me.txtno_kartu.Size = New System.Drawing.Size(240, 25)
        Me.txtno_kartu.TabIndex = 63
        '
        'txtcredit
        '
        Me.txtcredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcredit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcredit.Location = New System.Drawing.Point(93, 88)
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.Size = New System.Drawing.Size(161, 25)
        Me.txtcredit.TabIndex = 62
        Me.txtcredit.Text = "0"
        Me.txtcredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcash
        '
        Me.txtcash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcash.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcash.Location = New System.Drawing.Point(88, 15)
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(161, 25)
        Me.txtcash.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(326, 11)
        Me.Label1.TabIndex = 20
        '
        '_btnNum_11
        '
        Me._btnNum_11.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_11, CType(11, Short))
        Me._btnNum_11.Location = New System.Drawing.Point(205, 75)
        Me._btnNum_11.Name = "_btnNum_11"
        Me._btnNum_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_11.Size = New System.Drawing.Size(130, 65)
        Me._btnNum_11.TabIndex = 41
        Me._btnNum_11.TabStop = False
        Me._btnNum_11.Text = "ENTER"
        Me._btnNum_11.UseVisualStyleBackColor = False
        '
        '_frmpay_0
        '
        Me._frmpay_0.BackColor = System.Drawing.Color.White
        Me._frmpay_0.Controls.Add(Me.Label12)
        Me._frmpay_0.Controls.Add(Me.Label11)
        Me._frmpay_0.Controls.Add(Me.txtkembali)
        Me._frmpay_0.Controls.Add(Me.txtcash)
        Me._frmpay_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmpay_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmpay.SetIndex(Me._frmpay_0, CType(0, Short))
        Me._frmpay_0.Location = New System.Drawing.Point(4, 215)
        Me._frmpay_0.Name = "_frmpay_0"
        Me._frmpay_0.Padding = New System.Windows.Forms.Padding(0)
        Me._frmpay_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._frmpay_0.Size = New System.Drawing.Size(351, 96)
        Me._frmpay_0.TabIndex = 49
        Me._frmpay_0.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 22)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "KEMBALI"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 22)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "CASH"
        '
        'txtkembali
        '
        Me.txtkembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkembali.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkembali.Location = New System.Drawing.Point(88, 48)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(161, 25)
        Me.txtkembali.TabIndex = 69
        '
        '_btnNum_2
        '
        Me._btnNum_2.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_2, CType(2, Short))
        Me._btnNum_2.Location = New System.Drawing.Point(75, 140)
        Me._btnNum_2.Name = "_btnNum_2"
        Me._btnNum_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_2.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_2.TabIndex = 38
        Me._btnNum_2.TabStop = False
        Me._btnNum_2.Text = "2"
        Me._btnNum_2.UseVisualStyleBackColor = False
        '
        '_frmpay_1
        '
        Me._frmpay_1.BackColor = System.Drawing.Color.White
        Me._frmpay_1.Controls.Add(Me.Label17)
        Me._frmpay_1.Controls.Add(Me.txtcredit)
        Me._frmpay_1.Controls.Add(Me.Label16)
        Me._frmpay_1.Controls.Add(Me.txtnama)
        Me._frmpay_1.Controls.Add(Me.Label15)
        Me._frmpay_1.Controls.Add(Me.txtno_kartu)
        Me._frmpay_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmpay_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmpay.SetIndex(Me._frmpay_1, CType(1, Short))
        Me._frmpay_1.Location = New System.Drawing.Point(4, 215)
        Me._frmpay_1.Name = "_frmpay_1"
        Me._frmpay_1.Padding = New System.Windows.Forms.Padding(0)
        Me._frmpay_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._frmpay_1.Size = New System.Drawing.Size(351, 131)
        Me._frmpay_1.TabIndex = 51
        Me._frmpay_1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 15)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "BAYAR"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 15)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "NAMA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 15)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "NO KARTU"
        '
        'txtsaldo_point
        '
        Me.txtsaldo_point.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtsaldo_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsaldo_point.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldo_point.Location = New System.Drawing.Point(302, 13)
        Me.txtsaldo_point.Name = "txtsaldo_point"
        Me.txtsaldo_point.Size = New System.Drawing.Size(39, 22)
        Me.txtsaldo_point.TabIndex = 70
        '
        'txtcard_no
        '
        Me.txtcard_no.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtcard_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcard_no.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard_no.Location = New System.Drawing.Point(92, 15)
        Me.txtcard_no.Name = "txtcard_no"
        Me.txtcard_no.Size = New System.Drawing.Size(101, 22)
        Me.txtcard_no.TabIndex = 68
        '
        'txttukar_point
        '
        Me.txttukar_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttukar_point.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttukar_point.Location = New System.Drawing.Point(92, 87)
        Me.txttukar_point.Name = "txttukar_point"
        Me.txttukar_point.Size = New System.Drawing.Size(101, 22)
        Me.txttukar_point.TabIndex = 67
        '
        'txtpoint
        '
        Me.txtpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpoint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoint.Location = New System.Drawing.Point(92, 49)
        Me.txtpoint.Name = "txtpoint"
        Me.txtpoint.Size = New System.Drawing.Size(101, 22)
        Me.txtpoint.TabIndex = 66
        '
        'lblmsg
        '
        Me.lblmsg.BackColor = System.Drawing.Color.Red
        Me.lblmsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblmsg.Location = New System.Drawing.Point(25, 50)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsg.Size = New System.Drawing.Size(224, 26)
        Me.lblmsg.TabIndex = 50
        Me.lblmsg.Text = "PAYMENT TYPES"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_btnNum_3
        '
        Me._btnNum_3.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_3, CType(3, Short))
        Me._btnNum_3.Location = New System.Drawing.Point(140, 140)
        Me._btnNum_3.Name = "_btnNum_3"
        Me._btnNum_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_3.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_3.TabIndex = 37
        Me._btnNum_3.TabStop = False
        Me._btnNum_3.Text = "3"
        Me._btnNum_3.UseVisualStyleBackColor = False
        '
        'btnNum
        '
        '
        '_btnNum_4
        '
        Me._btnNum_4.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_4.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_4, CType(4, Short))
        Me._btnNum_4.Location = New System.Drawing.Point(10, 75)
        Me._btnNum_4.Name = "_btnNum_4"
        Me._btnNum_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_4.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_4.TabIndex = 36
        Me._btnNum_4.TabStop = False
        Me._btnNum_4.Text = "4"
        Me._btnNum_4.UseVisualStyleBackColor = False
        '
        '_btnNum_5
        '
        Me._btnNum_5.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_5, CType(5, Short))
        Me._btnNum_5.Location = New System.Drawing.Point(75, 75)
        Me._btnNum_5.Name = "_btnNum_5"
        Me._btnNum_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_5.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_5.TabIndex = 35
        Me._btnNum_5.TabStop = False
        Me._btnNum_5.Text = "5"
        Me._btnNum_5.UseVisualStyleBackColor = False
        '
        '_btnNum_6
        '
        Me._btnNum_6.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_6.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_6, CType(6, Short))
        Me._btnNum_6.Location = New System.Drawing.Point(140, 75)
        Me._btnNum_6.Name = "_btnNum_6"
        Me._btnNum_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_6.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_6.TabIndex = 34
        Me._btnNum_6.TabStop = False
        Me._btnNum_6.Text = "6"
        Me._btnNum_6.UseVisualStyleBackColor = False
        '
        '_btnNum_7
        '
        Me._btnNum_7.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_7.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_7, CType(7, Short))
        Me._btnNum_7.Location = New System.Drawing.Point(10, 10)
        Me._btnNum_7.Name = "_btnNum_7"
        Me._btnNum_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_7.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_7.TabIndex = 33
        Me._btnNum_7.TabStop = False
        Me._btnNum_7.Text = "7"
        Me._btnNum_7.UseVisualStyleBackColor = False
        '
        '_btnNum_8
        '
        Me._btnNum_8.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_8.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_8, CType(8, Short))
        Me._btnNum_8.Location = New System.Drawing.Point(75, 10)
        Me._btnNum_8.Name = "_btnNum_8"
        Me._btnNum_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_8.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_8.TabIndex = 32
        Me._btnNum_8.TabStop = False
        Me._btnNum_8.Text = "8"
        Me._btnNum_8.UseVisualStyleBackColor = False
        '
        '_btnNum_9
        '
        Me._btnNum_9.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNum.SetIndex(Me._btnNum_9, CType(9, Short))
        Me._btnNum_9.Location = New System.Drawing.Point(140, 10)
        Me._btnNum_9.Name = "_btnNum_9"
        Me._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_9.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_9.TabIndex = 31
        Me._btnNum_9.TabStop = False
        Me._btnNum_9.Text = "9"
        Me._btnNum_9.UseVisualStyleBackColor = False
        '
        '_cmdpay_0
        '
        Me._cmdpay_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdpay_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdpay_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdpay_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdpay_0.Image = CType(resources.GetObject("_cmdpay_0.Image"), System.Drawing.Image)
        Me.cmdpay.SetIndex(Me._cmdpay_0, CType(0, Short))
        Me._cmdpay_0.Location = New System.Drawing.Point(5, 139)
        Me._cmdpay_0.Name = "_cmdpay_0"
        Me._cmdpay_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdpay_0.Size = New System.Drawing.Size(76, 56)
        Me._cmdpay_0.TabIndex = 46
        Me._cmdpay_0.TabStop = False
        Me._cmdpay_0.Text = "CLOSE"
        Me._cmdpay_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdpay_0.UseVisualStyleBackColor = False
        '
        '_cmdpay_2
        '
        Me._cmdpay_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdpay_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdpay_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdpay_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdpay_2.Image = CType(resources.GetObject("_cmdpay_2.Image"), System.Drawing.Image)
        Me.cmdpay.SetIndex(Me._cmdpay_2, CType(2, Short))
        Me._cmdpay_2.Location = New System.Drawing.Point(5, 74)
        Me._cmdpay_2.Name = "_cmdpay_2"
        Me._cmdpay_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdpay_2.Size = New System.Drawing.Size(76, 56)
        Me._cmdpay_2.TabIndex = 47
        Me._cmdpay_2.TabStop = False
        Me._cmdpay_2.Text = "DOWN"
        Me._cmdpay_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdpay_2.UseVisualStyleBackColor = False
        '
        '_cmdpay_1
        '
        Me._cmdpay_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdpay_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdpay_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdpay_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdpay_1.Image = CType(resources.GetObject("_cmdpay_1.Image"), System.Drawing.Image)
        Me.cmdpay.SetIndex(Me._cmdpay_1, CType(1, Short))
        Me._cmdpay_1.Location = New System.Drawing.Point(5, 9)
        Me._cmdpay_1.Name = "_cmdpay_1"
        Me._cmdpay_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdpay_1.Size = New System.Drawing.Size(76, 56)
        Me._cmdpay_1.TabIndex = 45
        Me._cmdpay_1.TabStop = False
        Me._cmdpay_1.Text = "UP"
        Me._cmdpay_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdpay_1.UseVisualStyleBackColor = False
        '
        'vno_trans
        '
        Me.vno_trans.BackColor = System.Drawing.SystemColors.Control
        Me.vno_trans.Cursor = System.Windows.Forms.Cursors.Default
        Me.vno_trans.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vno_trans.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vno_trans.Location = New System.Drawing.Point(94, 445)
        Me.vno_trans.Name = "vno_trans"
        Me.vno_trans.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vno_trans.Size = New System.Drawing.Size(126, 21)
        Me.vno_trans.TabIndex = 53
        Me.vno_trans.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(321, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(31, 76)
        Me.Label6.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(179, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(41, 21)
        Me.Label2.TabIndex = 55
        Me.Label2.Visible = False
        '
        'lblsisa
        '
        Me.lblsisa.BackColor = System.Drawing.Color.Black
        Me.lblsisa.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblsisa.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsisa.ForeColor = System.Drawing.Color.Yellow
        Me.lblsisa.Location = New System.Drawing.Point(146, 75)
        Me.lblsisa.Name = "lblsisa"
        Me.lblsisa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblsisa.Size = New System.Drawing.Size(186, 26)
        Me.lblsisa.TabIndex = 15
        Me.lblsisa.Text = "999,999,999"
        Me.lblsisa.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(5, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(141, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "BAYAR    : Rp"
        '
        'lblbayar
        '
        Me.lblbayar.BackColor = System.Drawing.Color.Black
        Me.lblbayar.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblbayar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbayar.ForeColor = System.Drawing.Color.Yellow
        Me.lblbayar.Location = New System.Drawing.Point(146, 40)
        Me.lblbayar.Name = "lblbayar"
        Me.lblbayar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblbayar.Size = New System.Drawing.Size(186, 26)
        Me.lblbayar.TabIndex = 17
        Me.lblbayar.Text = "999,999,999"
        Me.lblbayar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_frmpay_3
        '
        Me._frmpay_3.BackColor = System.Drawing.Color.White
        Me._frmpay_3.Controls.Add(Me.txtsaldo_point)
        Me._frmpay_3.Controls.Add(Me.Label10)
        Me._frmpay_3.Controls.Add(Me.txttukar_point)
        Me._frmpay_3.Controls.Add(Me.Label9)
        Me._frmpay_3.Controls.Add(Me.txtpoint)
        Me._frmpay_3.Controls.Add(Me.Label7)
        Me._frmpay_3.Controls.Add(Me.txtcard_no)
        Me._frmpay_3.Controls.Add(Me.txtharga_point)
        Me._frmpay_3.Controls.Add(Me.Label8)
        Me._frmpay_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmpay_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmpay.SetIndex(Me._frmpay_3, CType(3, Short))
        Me._frmpay_3.Location = New System.Drawing.Point(4, 215)
        Me._frmpay_3.Name = "_frmpay_3"
        Me._frmpay_3.Padding = New System.Windows.Forms.Padding(0)
        Me._frmpay_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._frmpay_3.Size = New System.Drawing.Size(351, 141)
        Me._frmpay_3.TabIndex = 56
        Me._frmpay_3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(199, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 15)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "SALDO POINT"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 36)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "POINT DITUKARKAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "NO KARTU"
        '
        'txtharga_point
        '
        Me.txtharga_point.AcceptsReturn = True
        Me.txtharga_point.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtharga_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtharga_point.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtharga_point.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga_point.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtharga_point.Location = New System.Drawing.Point(285, 46)
        Me.txtharga_point.MaxLength = 0
        Me.txtharga_point.Name = "txtharga_point"
        Me.txtharga_point.ReadOnly = True
        Me.txtharga_point.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtharga_point.Size = New System.Drawing.Size(56, 22)
        Me.txtharga_point.TabIndex = 28
        Me.txtharga_point.TabStop = False
        Me.txtharga_point.Text = "1000"
        Me.txtharga_point.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 36)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "RUPIAH DITUKARKAN"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.White
        Me.Frame3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Frame3.Controls.Add(Me._cmdpay_2)
        Me.Frame3.Controls.Add(Me._cmdpay_0)
        Me.Frame3.Controls.Add(Me._cmdpay_1)
        Me.Frame3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(272, 5)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(88, 208)
        Me.Frame3.TabIndex = 58
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.Black
        Me.lbltotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Yellow
        Me.lbltotal.Location = New System.Drawing.Point(146, 5)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltotal.Size = New System.Drawing.Size(186, 36)
        Me.lbltotal.TabIndex = 19
        Me.lbltotal.Text = "999,999,999"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(0, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(141, 36)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "TOTAL : Rp"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Frame2.Controls.Add(Me._btnNum_12)
        Me.Frame2.Controls.Add(Me._btnNum_10)
        Me.Frame2.Controls.Add(Me._btnNum_11)
        Me.Frame2.Controls.Add(Me._btnNum_0)
        Me.Frame2.Controls.Add(Me._btnNum_1)
        Me.Frame2.Controls.Add(Me._btnNum_2)
        Me.Frame2.Controls.Add(Me._btnNum_3)
        Me.Frame2.Controls.Add(Me._btnNum_4)
        Me.Frame2.Controls.Add(Me._btnNum_5)
        Me.Frame2.Controls.Add(Me._btnNum_6)
        Me.Frame2.Controls.Add(Me._btnNum_7)
        Me.Frame2.Controls.Add(Me._btnNum_8)
        Me.Frame2.Controls.Add(Me._btnNum_9)
        Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(366, 138)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(346, 216)
        Me.Frame2.TabIndex = 57
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Black
        Me.Frame1.Controls.Add(Me.lbltotal)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.lblbayar)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.lblsisa)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.ShapeContainer1)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(367, 5)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(336, 106)
        Me.Frame1.TabIndex = 54
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(336, 106)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'Line1
        '
        Me.Line1.BorderColor = System.Drawing.Color.Red
        Me.Line1.BorderWidth = 4
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 160
        Me.Line1.X2 = 325
        Me.Line1.Y1 = 70
        Me.Line1.Y2 = 70
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(264, 208)
        Me.DataGridView1.TabIndex = 60
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(4, 362)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(706, 136)
        Me.DataGridView2.TabIndex = 61
        '
        'Timer1
        '
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me._frmpay_3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._frmpay_0)
        Me.Controls.Add(Me._frmpay_2)
        Me.Controls.Add(Me._frmpay_1)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.vno_trans)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.vstatus)
        Me.Controls.Add(Me.vpay)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(731, 548)
        Me.MinimumSize = New System.Drawing.Size(731, 548)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT"
        Me._frmpay_2.ResumeLayout(False)
        Me._frmpay_2.PerformLayout()
        Me._frmpay_0.ResumeLayout(False)
        Me._frmpay_0.PerformLayout()
        Me._frmpay_1.ResumeLayout(False)
        Me._frmpay_1.PerformLayout()
        CType(Me.btnNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdpay, System.ComponentModel.ISupportInitialize).EndInit()
        Me._frmpay_3.ResumeLayout(False)
        Me._frmpay_3.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        CType(Me.frmpay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vpay As System.Windows.Forms.TextBox
    Friend WithEvents vstatus As System.Windows.Forms.TextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents _btnNum_12 As System.Windows.Forms.Button
    Public WithEvents btnNum As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents _btnNum_10 As System.Windows.Forms.Button
    Public WithEvents _btnNum_0 As System.Windows.Forms.Button
    Public WithEvents _btnNum_1 As System.Windows.Forms.Button
    Public WithEvents cmdvoc As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents _frmpay_2 As System.Windows.Forms.GroupBox
    Public WithEvents frmpay As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _btnNum_11 As System.Windows.Forms.Button
    Public WithEvents _frmpay_0 As System.Windows.Forms.GroupBox
    Public WithEvents _btnNum_2 As System.Windows.Forms.Button
    Public WithEvents _frmpay_1 As System.Windows.Forms.GroupBox
    Public WithEvents lblmsg As System.Windows.Forms.Label
    Public WithEvents _btnNum_3 As System.Windows.Forms.Button
    Public WithEvents _btnNum_4 As System.Windows.Forms.Button
    Public WithEvents _btnNum_5 As System.Windows.Forms.Button
    Public WithEvents _btnNum_6 As System.Windows.Forms.Button
    Public WithEvents _btnNum_7 As System.Windows.Forms.Button
    Public WithEvents _btnNum_8 As System.Windows.Forms.Button
    Public WithEvents _btnNum_9 As System.Windows.Forms.Button
    Public WithEvents cmdpay As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents _cmdpay_0 As System.Windows.Forms.Button
    Public WithEvents _cmdpay_2 As System.Windows.Forms.Button
    Public WithEvents _cmdpay_1 As System.Windows.Forms.Button
    Public WithEvents vno_trans As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblsisa As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblbayar As System.Windows.Forms.Label
    Public WithEvents _frmpay_3 As System.Windows.Forms.GroupBox
    Public WithEvents txtharga_point As System.Windows.Forms.TextBox
    Public WithEvents Frame3 As System.Windows.Forms.Panel
    Public WithEvents lbltotal As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.Panel
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtno_voc As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcash As System.Windows.Forms.TextBox
    Friend WithEvents txtcredit As System.Windows.Forms.TextBox
    Friend WithEvents txtno_kartu As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtvoucher As System.Windows.Forms.TextBox
    Friend WithEvents txtpoint As System.Windows.Forms.TextBox
    Friend WithEvents txttukar_point As System.Windows.Forms.TextBox
    Friend WithEvents txtcard_no As System.Windows.Forms.TextBox
    Friend WithEvents txtkembali As System.Windows.Forms.TextBox
    Friend WithEvents txtsaldo_point As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
End Class
