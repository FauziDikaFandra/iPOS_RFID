<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesSelf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesSelf))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblgrand_total = New System.Windows.Forms.Label()
        Me._cmdsales_0 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me._CmdNav_2 = New System.Windows.Forms.Button()
        Me._cmdsales_7 = New System.Windows.Forms.Button()
        Me._CmdNav_1 = New System.Windows.Forms.Button()
        Me.RfidScan2 = New System.Windows.Forms.Button()
        Me.txtcard_no = New System.Windows.Forms.Label()
        Me._cmdsales_9 = New System.Windows.Forms.Button()
        Me.CmdNav = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vpromo = New System.Windows.Forms.Label()
        Me.lblno = New System.Windows.Forms.Label()
        Me.vgtotal = New System.Windows.Forms.Label()
        Me.vtotal = New System.Windows.Forms.Label()
        Me.vdiscrp2 = New System.Windows.Forms.Label()
        Me.vdiscrp1 = New System.Windows.Forms.Label()
        Me.vqty = New System.Windows.Forms.Label()
        Me.vflag = New System.Windows.Forms.Label()
        Me.vno_trans = New System.Windows.Forms.Label()
        Me.vharga = New System.Windows.Forms.Label()
        Me.vdesc = New System.Windows.Forms.Label()
        Me.vspg = New System.Windows.Forms.Label()
        Me.vplu = New System.Windows.Forms.Label()
        Me.cmdsales = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcust_id = New System.Windows.Forms.TextBox()
        Me.vrfid = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me._btnNum_10 = New System.Windows.Forms.Button()
        Me._btnNum_13 = New System.Windows.Forms.Button()
        Me._btnNum_12 = New System.Windows.Forms.Button()
        Me._btnNum_11 = New System.Windows.Forms.Button()
        Me._btnNum_0 = New System.Windows.Forms.Button()
        Me._btnNum_1 = New System.Windows.Forms.Button()
        Me._btnNum_2 = New System.Windows.Forms.Button()
        Me._btnNum_3 = New System.Windows.Forms.Button()
        Me._btnNum_4 = New System.Windows.Forms.Button()
        Me._btnNum_5 = New System.Windows.Forms.Button()
        Me._btnNum_6 = New System.Windows.Forms.Button()
        Me._btnNum_7 = New System.Windows.Forms.Button()
        Me._btnNum_8 = New System.Windows.Forms.Button()
        Me._btnNum_9 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.txtcust_name = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Frame2.SuspendLayout()
        CType(Me.CmdNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdsales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtkode
        '
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(112, 10)
        Me.txtkode.Margin = New System.Windows.Forms.Padding(1)
        Me.txtkode.MaxLength = 16
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(269, 41)
        Me.txtkode.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(3, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(161, 36)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "TOTAL : Rp"
        '
        'lblgrand_total
        '
        Me.lblgrand_total.BackColor = System.Drawing.Color.Black
        Me.lblgrand_total.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblgrand_total.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrand_total.ForeColor = System.Drawing.Color.Yellow
        Me.lblgrand_total.Location = New System.Drawing.Point(130, 109)
        Me.lblgrand_total.Name = "lblgrand_total"
        Me.lblgrand_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblgrand_total.Size = New System.Drawing.Size(246, 41)
        Me.lblgrand_total.TabIndex = 34
        Me.lblgrand_total.Text = "0"
        Me.lblgrand_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_cmdsales_0
        '
        Me._cmdsales_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_0.ForeColor = System.Drawing.Color.Black
        Me._cmdsales_0.Image = CType(resources.GetObject("_cmdsales_0.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_0, CType(0, Short))
        Me._cmdsales_0.Location = New System.Drawing.Point(400, 3)
        Me._cmdsales_0.Name = "_cmdsales_0"
        Me._cmdsales_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_0.Size = New System.Drawing.Size(114, 62)
        Me._cmdsales_0.TabIndex = 2
        Me._cmdsales_0.Text = "PAYMENT"
        Me._cmdsales_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_0.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Controls.Add(Me.Button6)
        Me.Frame2.Controls.Add(Me._CmdNav_2)
        Me.Frame2.Controls.Add(Me._cmdsales_7)
        Me.Frame2.Controls.Add(Me._CmdNav_1)
        Me.Frame2.Controls.Add(Me.RfidScan2)
        Me.Frame2.Controls.Add(Me.txtcard_no)
        Me.Frame2.Controls.Add(Me._cmdsales_0)
        Me.Frame2.Controls.Add(Me._cmdsales_9)
        Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(4, 3)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(517, 68)
        Me.Frame2.TabIndex = 43
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(168, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button6.Size = New System.Drawing.Size(114, 62)
        Me.Button6.TabIndex = 74
        Me.Button6.Text = "MEMBER"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        '_CmdNav_2
        '
        Me._CmdNav_2.BackColor = System.Drawing.SystemColors.Control
        Me._CmdNav_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdNav_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdNav_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdNav_2.Image = CType(resources.GetObject("_CmdNav_2.Image"), System.Drawing.Image)
        Me._CmdNav_2.Location = New System.Drawing.Point(3, 34)
        Me._CmdNav_2.Name = "_CmdNav_2"
        Me._CmdNav_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdNav_2.Size = New System.Drawing.Size(48, 30)
        Me._CmdNav_2.TabIndex = 73
        Me._CmdNav_2.TabStop = False
        Me._CmdNav_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdNav_2.UseVisualStyleBackColor = False
        '
        '_cmdsales_7
        '
        Me._cmdsales_7.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_7.Image = CType(resources.GetObject("_cmdsales_7.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_7, CType(7, Short))
        Me._cmdsales_7.Location = New System.Drawing.Point(533, 2)
        Me._cmdsales_7.Name = "_cmdsales_7"
        Me._cmdsales_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_7.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_7.TabIndex = 9
        Me._cmdsales_7.Text = "CLOSE"
        Me._cmdsales_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_7.UseVisualStyleBackColor = False
        '
        '_CmdNav_1
        '
        Me._CmdNav_1.BackColor = System.Drawing.SystemColors.Control
        Me._CmdNav_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdNav_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdNav_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdNav_1.Image = CType(resources.GetObject("_CmdNav_1.Image"), System.Drawing.Image)
        Me._CmdNav_1.Location = New System.Drawing.Point(3, 3)
        Me._CmdNav_1.Name = "_CmdNav_1"
        Me._CmdNav_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdNav_1.Size = New System.Drawing.Size(48, 30)
        Me._CmdNav_1.TabIndex = 72
        Me._CmdNav_1.TabStop = False
        Me._CmdNav_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdNav_1.UseVisualStyleBackColor = False
        '
        'RfidScan2
        '
        Me.RfidScan2.BackColor = System.Drawing.SystemColors.Control
        Me.RfidScan2.Cursor = System.Windows.Forms.Cursors.Default
        Me.RfidScan2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RfidScan2.ForeColor = System.Drawing.Color.Red
        Me.RfidScan2.Image = CType(resources.GetObject("RfidScan2.Image"), System.Drawing.Image)
        Me.RfidScan2.Location = New System.Drawing.Point(52, 3)
        Me.RfidScan2.Name = "RfidScan2"
        Me.RfidScan2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RfidScan2.Size = New System.Drawing.Size(114, 62)
        Me.RfidScan2.TabIndex = 72
        Me.RfidScan2.Text = "RFID OFF"
        Me.RfidScan2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RfidScan2.UseVisualStyleBackColor = False
        '
        'txtcard_no
        '
        Me.txtcard_no.BackColor = System.Drawing.Color.Transparent
        Me.txtcard_no.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtcard_no.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard_no.ForeColor = System.Drawing.Color.Yellow
        Me.txtcard_no.Location = New System.Drawing.Point(533, 30)
        Me.txtcard_no.Name = "txtcard_no"
        Me.txtcard_no.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcard_no.Size = New System.Drawing.Size(95, 21)
        Me.txtcard_no.TabIndex = 68
        Me.txtcard_no.Text = "No Member"
        '
        '_cmdsales_9
        '
        Me._cmdsales_9.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_9.Image = CType(resources.GetObject("_cmdsales_9.Image"), System.Drawing.Image)
        Me._cmdsales_9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsales.SetIndex(Me._cmdsales_9, CType(9, Short))
        Me._cmdsales_9.Location = New System.Drawing.Point(284, 3)
        Me._cmdsales_9.Name = "_cmdsales_9"
        Me._cmdsales_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_9.Size = New System.Drawing.Size(114, 62)
        Me._cmdsales_9.TabIndex = 63
        Me._cmdsales_9.Text = "PROMO CHECKING"
        Me._cmdsales_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdsales_9.UseVisualStyleBackColor = False
        '
        'lblqty
        '
        Me.lblqty.BackColor = System.Drawing.Color.Transparent
        Me.lblqty.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblqty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.ForeColor = System.Drawing.Color.Yellow
        Me.lblqty.Location = New System.Drawing.Point(300, 85)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblqty.Size = New System.Drawing.Size(73, 21)
        Me.lblqty.TabIndex = 66
        Me.lblqty.Text = "pcs"
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "QTY :"
        Me.Label2.Visible = False
        '
        'vpromo
        '
        Me.vpromo.BackColor = System.Drawing.SystemColors.Control
        Me.vpromo.Cursor = System.Windows.Forms.Cursors.Default
        Me.vpromo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpromo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vpromo.Location = New System.Drawing.Point(317, 277)
        Me.vpromo.Name = "vpromo"
        Me.vpromo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vpromo.Size = New System.Drawing.Size(46, 21)
        Me.vpromo.TabIndex = 65
        Me.vpromo.Text = "promo"
        '
        'lblno
        '
        Me.lblno.BackColor = System.Drawing.Color.Transparent
        Me.lblno.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblno.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Yellow
        Me.lblno.Location = New System.Drawing.Point(6, 6)
        Me.lblno.Name = "lblno"
        Me.lblno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblno.Size = New System.Drawing.Size(131, 21)
        Me.lblno.TabIndex = 64
        Me.lblno.Text = "Trans : xxx"
        '
        'vgtotal
        '
        Me.vgtotal.BackColor = System.Drawing.SystemColors.Control
        Me.vgtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgtotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vgtotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vgtotal.Location = New System.Drawing.Point(320, 277)
        Me.vgtotal.Name = "vgtotal"
        Me.vgtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vgtotal.Size = New System.Drawing.Size(46, 21)
        Me.vgtotal.TabIndex = 61
        Me.vgtotal.Text = "gtotal"
        '
        'vtotal
        '
        Me.vtotal.BackColor = System.Drawing.SystemColors.Control
        Me.vtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.vtotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vtotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vtotal.Location = New System.Drawing.Point(254, 277)
        Me.vtotal.Name = "vtotal"
        Me.vtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vtotal.Size = New System.Drawing.Size(46, 21)
        Me.vtotal.TabIndex = 60
        Me.vtotal.Text = "total"
        '
        'vdiscrp2
        '
        Me.vdiscrp2.BackColor = System.Drawing.SystemColors.Control
        Me.vdiscrp2.Cursor = System.Windows.Forms.Cursors.Default
        Me.vdiscrp2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdiscrp2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vdiscrp2.Location = New System.Drawing.Point(204, 277)
        Me.vdiscrp2.Name = "vdiscrp2"
        Me.vdiscrp2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vdiscrp2.Size = New System.Drawing.Size(46, 21)
        Me.vdiscrp2.TabIndex = 55
        Me.vdiscrp2.Text = "Disc2Rp"
        '
        'vdiscrp1
        '
        Me.vdiscrp1.BackColor = System.Drawing.SystemColors.Control
        Me.vdiscrp1.Cursor = System.Windows.Forms.Cursors.Default
        Me.vdiscrp1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdiscrp1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vdiscrp1.Location = New System.Drawing.Point(154, 277)
        Me.vdiscrp1.Name = "vdiscrp1"
        Me.vdiscrp1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vdiscrp1.Size = New System.Drawing.Size(46, 21)
        Me.vdiscrp1.TabIndex = 54
        Me.vdiscrp1.Text = "Disc1Rp"
        '
        'vqty
        '
        Me.vqty.BackColor = System.Drawing.SystemColors.Control
        Me.vqty.Cursor = System.Windows.Forms.Cursors.Default
        Me.vqty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vqty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vqty.Location = New System.Drawing.Point(9, 277)
        Me.vqty.Name = "vqty"
        Me.vqty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vqty.Size = New System.Drawing.Size(46, 21)
        Me.vqty.TabIndex = 52
        Me.vqty.Text = "qty"
        '
        'vflag
        '
        Me.vflag.BackColor = System.Drawing.SystemColors.Control
        Me.vflag.Cursor = System.Windows.Forms.Cursors.Default
        Me.vflag.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vflag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vflag.Location = New System.Drawing.Point(304, 277)
        Me.vflag.Name = "vflag"
        Me.vflag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vflag.Size = New System.Drawing.Size(46, 21)
        Me.vflag.TabIndex = 50
        Me.vflag.Text = "flag"
        '
        'vno_trans
        '
        Me.vno_trans.BackColor = System.Drawing.SystemColors.Control
        Me.vno_trans.Cursor = System.Windows.Forms.Cursors.Default
        Me.vno_trans.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vno_trans.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vno_trans.Location = New System.Drawing.Point(9, 252)
        Me.vno_trans.Name = "vno_trans"
        Me.vno_trans.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vno_trans.Size = New System.Drawing.Size(126, 21)
        Me.vno_trans.TabIndex = 49
        '
        'vharga
        '
        Me.vharga.BackColor = System.Drawing.SystemColors.Control
        Me.vharga.Cursor = System.Windows.Forms.Cursors.Default
        Me.vharga.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vharga.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vharga.Location = New System.Drawing.Point(59, 277)
        Me.vharga.Name = "vharga"
        Me.vharga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vharga.Size = New System.Drawing.Size(91, 21)
        Me.vharga.TabIndex = 48
        Me.vharga.Text = "harga"
        '
        'vdesc
        '
        Me.vdesc.BackColor = System.Drawing.SystemColors.Control
        Me.vdesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.vdesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vdesc.Location = New System.Drawing.Point(185, 252)
        Me.vdesc.Name = "vdesc"
        Me.vdesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vdesc.Size = New System.Drawing.Size(181, 21)
        Me.vdesc.TabIndex = 47
        Me.vdesc.Text = "desc"
        '
        'vspg
        '
        Me.vspg.BackColor = System.Drawing.SystemColors.Control
        Me.vspg.Cursor = System.Windows.Forms.Cursors.Default
        Me.vspg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vspg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vspg.Location = New System.Drawing.Point(139, 252)
        Me.vspg.Name = "vspg"
        Me.vspg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vspg.Size = New System.Drawing.Size(46, 21)
        Me.vspg.TabIndex = 46
        Me.vspg.Text = "spg"
        '
        'vplu
        '
        Me.vplu.BackColor = System.Drawing.SystemColors.Control
        Me.vplu.Cursor = System.Windows.Forms.Cursors.Default
        Me.vplu.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vplu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vplu.Location = New System.Drawing.Point(189, 252)
        Me.vplu.Name = "vplu"
        Me.vplu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vplu.Size = New System.Drawing.Size(96, 21)
        Me.vplu.TabIndex = 45
        Me.vplu.Text = "plu"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(9, 73)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(512, 422)
        Me.DataGridView1.TabIndex = 68
        '
        'txtcust_id
        '
        Me.txtcust_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcust_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcust_id.Location = New System.Drawing.Point(783, 54)
        Me.txtcust_id.Name = "txtcust_id"
        Me.txtcust_id.Size = New System.Drawing.Size(48, 26)
        Me.txtcust_id.TabIndex = 39
        '
        'vrfid
        '
        Me.vrfid.BackColor = System.Drawing.SystemColors.Control
        Me.vrfid.Cursor = System.Windows.Forms.Cursors.Default
        Me.vrfid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vrfid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vrfid.Location = New System.Drawing.Point(277, 245)
        Me.vrfid.Name = "vrfid"
        Me.vrfid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vrfid.Size = New System.Drawing.Size(96, 21)
        Me.vrfid.TabIndex = 70
        Me.vrfid.Text = "plu"
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        '
        '_btnNum_10
        '
        Me._btnNum_10.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_10.Location = New System.Drawing.Point(246, 256)
        Me._btnNum_10.Name = "_btnNum_10"
        Me._btnNum_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_10.Size = New System.Drawing.Size(135, 68)
        Me._btnNum_10.TabIndex = 15
        Me._btnNum_10.Tag = "14"
        Me._btnNum_10.Text = "CLOSE"
        Me._btnNum_10.UseVisualStyleBackColor = False
        '
        '_btnNum_13
        '
        Me._btnNum_13.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_13.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_13.Location = New System.Drawing.Point(313, 189)
        Me._btnNum_13.Name = "_btnNum_13"
        Me._btnNum_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_13.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_13.TabIndex = 12
        Me._btnNum_13.Tag = "13"
        Me._btnNum_13.Text = "C"
        Me._btnNum_13.UseVisualStyleBackColor = False
        '
        '_btnNum_12
        '
        Me._btnNum_12.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_12.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_12.Location = New System.Drawing.Point(313, 122)
        Me._btnNum_12.Name = "_btnNum_12"
        Me._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_12.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_12.TabIndex = 11
        Me._btnNum_12.Tag = "12"
        Me._btnNum_12.Text = "<<"
        Me._btnNum_12.UseVisualStyleBackColor = False
        '
        '_btnNum_11
        '
        Me._btnNum_11.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_11.Location = New System.Drawing.Point(112, 256)
        Me._btnNum_11.Name = "_btnNum_11"
        Me._btnNum_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_11.Size = New System.Drawing.Size(135, 68)
        Me._btnNum_11.TabIndex = 14
        Me._btnNum_11.Tag = "11"
        Me._btnNum_11.Text = "ENTER"
        Me._btnNum_11.UseVisualStyleBackColor = False
        '
        '_btnNum_0
        '
        Me._btnNum_0.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_0.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_0.Location = New System.Drawing.Point(313, 55)
        Me._btnNum_0.Name = "_btnNum_0"
        Me._btnNum_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_0.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_0.TabIndex = 1
        Me._btnNum_0.Tag = "0"
        Me._btnNum_0.Text = "0"
        Me._btnNum_0.UseVisualStyleBackColor = False
        '
        '_btnNum_1
        '
        Me._btnNum_1.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_1.Location = New System.Drawing.Point(112, 189)
        Me._btnNum_1.Name = "_btnNum_1"
        Me._btnNum_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_1.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_1.TabIndex = 2
        Me._btnNum_1.Tag = "1"
        Me._btnNum_1.Text = "1"
        Me._btnNum_1.UseVisualStyleBackColor = False
        '
        '_btnNum_2
        '
        Me._btnNum_2.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_2.Location = New System.Drawing.Point(179, 189)
        Me._btnNum_2.Name = "_btnNum_2"
        Me._btnNum_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_2.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_2.TabIndex = 3
        Me._btnNum_2.Tag = "2"
        Me._btnNum_2.Text = "2"
        Me._btnNum_2.UseVisualStyleBackColor = False
        '
        '_btnNum_3
        '
        Me._btnNum_3.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_3.Location = New System.Drawing.Point(246, 189)
        Me._btnNum_3.Name = "_btnNum_3"
        Me._btnNum_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_3.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_3.TabIndex = 4
        Me._btnNum_3.Tag = "3"
        Me._btnNum_3.Text = "3"
        Me._btnNum_3.UseVisualStyleBackColor = False
        '
        '_btnNum_4
        '
        Me._btnNum_4.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_4.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_4.Location = New System.Drawing.Point(112, 122)
        Me._btnNum_4.Name = "_btnNum_4"
        Me._btnNum_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_4.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_4.TabIndex = 5
        Me._btnNum_4.Tag = "4"
        Me._btnNum_4.Text = "4"
        Me._btnNum_4.UseVisualStyleBackColor = False
        '
        '_btnNum_5
        '
        Me._btnNum_5.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_5.Location = New System.Drawing.Point(179, 122)
        Me._btnNum_5.Name = "_btnNum_5"
        Me._btnNum_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_5.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_5.TabIndex = 6
        Me._btnNum_5.Tag = "5"
        Me._btnNum_5.Text = "5"
        Me._btnNum_5.UseVisualStyleBackColor = False
        '
        '_btnNum_6
        '
        Me._btnNum_6.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_6.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_6.Location = New System.Drawing.Point(246, 122)
        Me._btnNum_6.Name = "_btnNum_6"
        Me._btnNum_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_6.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_6.TabIndex = 7
        Me._btnNum_6.Tag = "6"
        Me._btnNum_6.Text = "6"
        Me._btnNum_6.UseVisualStyleBackColor = False
        '
        '_btnNum_7
        '
        Me._btnNum_7.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_7.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_7.Location = New System.Drawing.Point(112, 55)
        Me._btnNum_7.Name = "_btnNum_7"
        Me._btnNum_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_7.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_7.TabIndex = 8
        Me._btnNum_7.Tag = "7"
        Me._btnNum_7.Text = "7"
        Me._btnNum_7.UseVisualStyleBackColor = False
        '
        '_btnNum_8
        '
        Me._btnNum_8.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_8.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_8.Location = New System.Drawing.Point(179, 55)
        Me._btnNum_8.Name = "_btnNum_8"
        Me._btnNum_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_8.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_8.TabIndex = 9
        Me._btnNum_8.Tag = "8"
        Me._btnNum_8.Text = "8"
        Me._btnNum_8.UseVisualStyleBackColor = False
        '
        '_btnNum_9
        '
        Me._btnNum_9.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_9.Location = New System.Drawing.Point(246, 55)
        Me._btnNum_9.Name = "_btnNum_9"
        Me._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_9.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_9.TabIndex = 10
        Me._btnNum_9.Tag = "9"
        Me._btnNum_9.Text = "9"
        Me._btnNum_9.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.txtkode)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me._btnNum_10)
        Me.Panel1.Controls.Add(Me._btnNum_7)
        Me.Panel1.Controls.Add(Me._btnNum_9)
        Me.Panel1.Controls.Add(Me._btnNum_13)
        Me.Panel1.Controls.Add(Me._btnNum_8)
        Me.Panel1.Controls.Add(Me._btnNum_12)
        Me.Panel1.Controls.Add(Me._btnNum_6)
        Me.Panel1.Controls.Add(Me._btnNum_11)
        Me.Panel1.Controls.Add(Me._btnNum_5)
        Me.Panel1.Controls.Add(Me._btnNum_0)
        Me.Panel1.Controls.Add(Me._btnNum_4)
        Me.Panel1.Controls.Add(Me._btnNum_1)
        Me.Panel1.Controls.Add(Me._btnNum_3)
        Me.Panel1.Controls.Add(Me._btnNum_2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(527, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(385, 327)
        Me.Panel1.TabIndex = 74
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkGray
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(2, 256)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(109, 68)
        Me.Button5.TabIndex = 20
        Me.Button5.Tag = "7"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Image = Global.iPOS.My.Resources.Resources.bag_2__dTN_icon
        Me.Button4.Location = New System.Drawing.Point(2, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(109, 67)
        Me.Button4.TabIndex = 19
        Me.Button4.Tag = "7"
        Me.Button4.Text = "TOTE BAG"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Image = Global.iPOS.My.Resources.Resources.plastic_bag_QJ2_icon
        Me.Button3.Location = New System.Drawing.Point(2, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(109, 67)
        Me.Button3.TabIndex = 18
        Me.Button3.Tag = "7"
        Me.Button3.Text = "PLASTIC"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = Global.iPOS.My.Resources.Resources.bag_xNf_icon
        Me.Button2.Location = New System.Drawing.Point(2, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(109, 68)
        Me.Button2.TabIndex = 17
        Me.Button2.Tag = "7"
        Me.Button2.Text = "PAPER BAG"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(109, 53)
        Me.Button1.TabIndex = 16
        Me.Button1.Tag = "7"
        Me.Button1.Text = "PLU/EAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Black
        Me.Frame1.Controls.Add(Me.txtcust_name)
        Me.Frame1.Controls.Add(Me.lblqty)
        Me.Frame1.Controls.Add(Me.lblno)
        Me.Frame1.Controls.Add(Me.lblgrand_total)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(527, 6)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(385, 160)
        Me.Frame1.TabIndex = 62
        '
        'txtcust_name
        '
        Me.txtcust_name.BackColor = System.Drawing.Color.Transparent
        Me.txtcust_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtcust_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcust_name.ForeColor = System.Drawing.Color.Yellow
        Me.txtcust_name.Location = New System.Drawing.Point(178, 6)
        Me.txtcust_name.Name = "txtcust_name"
        Me.txtcust_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcust_name.Size = New System.Drawing.Size(195, 21)
        Me.txtcust_name.TabIndex = 68
        Me.txtcust_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem1.Text = "Delete Row"
        '
        'frmSalesSelf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(916, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtcust_id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.vpromo)
        Me.Controls.Add(Me.vgtotal)
        Me.Controls.Add(Me.vtotal)
        Me.Controls.Add(Me.vdiscrp2)
        Me.Controls.Add(Me.vdiscrp1)
        Me.Controls.Add(Me.vqty)
        Me.Controls.Add(Me.vflag)
        Me.Controls.Add(Me.vno_trans)
        Me.Controls.Add(Me.vharga)
        Me.Controls.Add(Me.vdesc)
        Me.Controls.Add(Me.vspg)
        Me.Controls.Add(Me.vplu)
        Me.Controls.Add(Me.vrfid)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(894, 561)
        Me.Name = "frmSalesSelf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES"
        Me.TopMost = True
        Me.Frame2.ResumeLayout(False)
        CType(Me.CmdNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdsales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdsales As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents CmdNav As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblgrand_total As System.Windows.Forms.Label
    Public WithEvents _cmdsales_0 As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.Panel
    Public WithEvents _cmdsales_7 As System.Windows.Forms.Button
    Public WithEvents _cmdsales_9 As System.Windows.Forms.Button
    Public WithEvents lblqty As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents vpromo As System.Windows.Forms.Label
    Public WithEvents lblno As System.Windows.Forms.Label
    Public WithEvents vgtotal As System.Windows.Forms.Label
    Public WithEvents vtotal As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents vdiscrp2 As System.Windows.Forms.Label
    Public WithEvents vdiscrp1 As System.Windows.Forms.Label
    Public WithEvents vdisc2 As System.Windows.Forms.Label
    Public WithEvents vqty As System.Windows.Forms.Label
    Public WithEvents vdisc1 As System.Windows.Forms.Label
    Public WithEvents vflag As System.Windows.Forms.Label
    Public WithEvents vno_trans As System.Windows.Forms.Label
    Public WithEvents vharga As System.Windows.Forms.Label
    Public WithEvents vdesc As System.Windows.Forms.Label
    Public WithEvents vspg As System.Windows.Forms.Label
    Public WithEvents vplu As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcust_id As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As TextBox
    Public WithEvents vrfid As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents RfidScan2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Public WithEvents _CmdNav_2 As Button
    Public WithEvents _CmdNav_1 As Button
    Public WithEvents _btnNum_10 As Button
    Public WithEvents _btnNum_13 As Button
    Public WithEvents _btnNum_12 As Button
    Public WithEvents _btnNum_11 As Button
    Public WithEvents _btnNum_0 As Button
    Public WithEvents _btnNum_1 As Button
    Public WithEvents _btnNum_2 As Button
    Public WithEvents _btnNum_3 As Button
    Public WithEvents _btnNum_4 As Button
    Public WithEvents _btnNum_5 As Button
    Public WithEvents _btnNum_6 As Button
    Public WithEvents _btnNum_7 As Button
    Public WithEvents _btnNum_8 As Button
    Public WithEvents _btnNum_9 As Button
    Public WithEvents Panel1 As Panel
    Public WithEvents Button5 As Button
    Public WithEvents Button4 As Button
    Public WithEvents Button3 As Button
    Public WithEvents Button2 As Button
    Public WithEvents Button1 As Button
    Public WithEvents Frame1 As Panel
    Public WithEvents Button6 As Button
    Public WithEvents txtcard_no As Label
    Public WithEvents txtcust_name As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
