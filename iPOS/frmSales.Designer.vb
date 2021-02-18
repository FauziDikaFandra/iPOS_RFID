<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me._cmdsales_3 = New System.Windows.Forms.Button()
        Me._cmdsales_1 = New System.Windows.Forms.Button()
        Me._cmdsales_2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.lblkode = New System.Windows.Forms.Label()
        Me._CmdNav_0 = New System.Windows.Forms.Button()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me._CmdNav_3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblgrand_total = New System.Windows.Forms.Label()
        Me._cmdsales_0 = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcust_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcard_no = New System.Windows.Forms.TextBox()
        Me._cmdsales_8 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me._CmdNav_2 = New System.Windows.Forms.Button()
        Me._CmdNav_1 = New System.Windows.Forms.Button()
        Me._cmdsales_7 = New System.Windows.Forms.Button()
        Me._cmdsales_6 = New System.Windows.Forms.Button()
        Me._cmdsales_5 = New System.Windows.Forms.Button()
        Me._cmdsales_4 = New System.Windows.Forms.Button()
        Me.CmdNav = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me._cmdsales_9 = New System.Windows.Forms.Button()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vpromo = New System.Windows.Forms.Label()
        Me.lblno = New System.Windows.Forms.Label()
        Me.vgtotal = New System.Windows.Forms.Label()
        Me.vtotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vdiscrp2 = New System.Windows.Forms.Label()
        Me.vdiscrp1 = New System.Windows.Forms.Label()
        Me.vdisc2 = New System.Windows.Forms.Label()
        Me.vqty = New System.Windows.Forms.Label()
        Me.vdisc1 = New System.Windows.Forms.Label()
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
        Me.RfidScan1 = New System.Windows.Forms.Button()
        Me.RfidScan2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Frame1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.CmdNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdsales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_cmdsales_3
        '
        Me._cmdsales_3.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_3.Image = CType(resources.GetObject("_cmdsales_3.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_3, CType(3, Short))
        Me._cmdsales_3.Location = New System.Drawing.Point(221, 2)
        Me._cmdsales_3.Name = "_cmdsales_3"
        Me._cmdsales_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_3.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_3.TabIndex = 5
        Me._cmdsales_3.Text = "LINE VOID"
        Me._cmdsales_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_3.UseVisualStyleBackColor = False
        '
        '_cmdsales_1
        '
        Me._cmdsales_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_1.Image = CType(resources.GetObject("_cmdsales_1.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_1, CType(1, Short))
        Me._cmdsales_1.Location = New System.Drawing.Point(75, 2)
        Me._cmdsales_1.Name = "_cmdsales_1"
        Me._cmdsales_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_1.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_1.TabIndex = 3
        Me._cmdsales_1.Text = "HOLD"
        Me._cmdsales_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_1.UseVisualStyleBackColor = False
        '
        '_cmdsales_2
        '
        Me._cmdsales_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_2.Image = CType(resources.GetObject("_cmdsales_2.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_2, CType(2, Short))
        Me._cmdsales_2.Location = New System.Drawing.Point(148, 2)
        Me._cmdsales_2.Name = "_cmdsales_2"
        Me._cmdsales_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_2.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_2.TabIndex = 4
        Me._cmdsales_2.Text = "DISCOUNT"
        Me._cmdsales_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_2.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Black
        Me.Frame1.Controls.Add(Me.lblkode)
        Me.Frame1.Controls.Add(Me._CmdNav_0)
        Me.Frame1.Controls.Add(Me.txtkode)
        Me.Frame1.Controls.Add(Me._CmdNav_3)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lblgrand_total)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(4, 392)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(731, 45)
        Me.Frame1.TabIndex = 62
        '
        'lblkode
        '
        Me.lblkode.AutoSize = True
        Me.lblkode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkode.ForeColor = System.Drawing.Color.Yellow
        Me.lblkode.Location = New System.Drawing.Point(6, 15)
        Me.lblkode.Name = "lblkode"
        Me.lblkode.Size = New System.Drawing.Size(34, 16)
        Me.lblkode.TabIndex = 70
        Me.lblkode.Text = "PLU"
        '
        '_CmdNav_0
        '
        Me._CmdNav_0.BackColor = System.Drawing.SystemColors.Control
        Me._CmdNav_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdNav_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdNav_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdNav_0.Image = CType(resources.GetObject("_CmdNav_0.Image"), System.Drawing.Image)
        Me._CmdNav_0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNav.SetIndex(Me._CmdNav_0, CType(0, Short))
        Me._CmdNav_0.Location = New System.Drawing.Point(225, 0)
        Me._CmdNav_0.Name = "_CmdNav_0"
        Me._CmdNav_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdNav_0.Size = New System.Drawing.Size(66, 43)
        Me._CmdNav_0.TabIndex = 45
        Me._CmdNav_0.Text = "ENTER"
        Me._CmdNav_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdNav_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdNav_0.UseVisualStyleBackColor = False
        '
        'txtkode
        '
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(61, 11)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(154, 25)
        Me.txtkode.TabIndex = 69
        '
        '_CmdNav_3
        '
        Me._CmdNav_3.BackColor = System.Drawing.SystemColors.Control
        Me._CmdNav_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdNav_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdNav_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdNav_3.Image = CType(resources.GetObject("_CmdNav_3.Image"), System.Drawing.Image)
        Me._CmdNav_3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNav.SetIndex(Me._CmdNav_3, CType(3, Short))
        Me._CmdNav_3.Location = New System.Drawing.Point(295, 0)
        Me._CmdNav_3.Name = "_CmdNav_3"
        Me._CmdNav_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdNav_3.Size = New System.Drawing.Size(66, 43)
        Me._CmdNav_3.TabIndex = 40
        Me._CmdNav_3.Text = "&NUM"
        Me._CmdNav_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdNav_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._CmdNav_3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(365, 7)
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
        Me.lblgrand_total.Location = New System.Drawing.Point(470, 2)
        Me.lblgrand_total.Name = "lblgrand_total"
        Me.lblgrand_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblgrand_total.Size = New System.Drawing.Size(258, 41)
        Me.lblgrand_total.TabIndex = 34
        Me.lblgrand_total.Text = "0"
        Me.lblgrand_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_cmdsales_0
        '
        Me._cmdsales_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_0.Image = CType(resources.GetObject("_cmdsales_0.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_0, CType(0, Short))
        Me._cmdsales_0.Location = New System.Drawing.Point(3, 2)
        Me._cmdsales_0.Name = "_cmdsales_0"
        Me._cmdsales_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_0.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_0.TabIndex = 2
        Me._cmdsales_0.Text = "PAYMENT"
        Me._cmdsales_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_0.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.White
        Me.Frame3.Controls.Add(Me.Label8)
        Me.Frame3.Controls.Add(Me.txtcust_name)
        Me.Frame3.Controls.Add(Me.Label7)
        Me.Frame3.Controls.Add(Me.txtcard_no)
        Me.Frame3.Controls.Add(Me._cmdsales_8)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(4, 2)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(406, 86)
        Me.Frame3.TabIndex = 44
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "CUSTOMER "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "NAMA  "
        '
        'txtcust_name
        '
        Me.txtcust_name.Enabled = False
        Me.txtcust_name.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcust_name.Location = New System.Drawing.Point(88, 52)
        Me.txtcust_name.Name = "txtcust_name"
        Me.txtcust_name.Size = New System.Drawing.Size(230, 22)
        Me.txtcust_name.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "CARD NO  "
        '
        'txtcard_no
        '
        Me.txtcard_no.Enabled = False
        Me.txtcard_no.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard_no.Location = New System.Drawing.Point(88, 21)
        Me.txtcard_no.Name = "txtcard_no"
        Me.txtcard_no.Size = New System.Drawing.Size(108, 22)
        Me.txtcard_no.TabIndex = 33
        '
        '_cmdsales_8
        '
        Me._cmdsales_8.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_8.Image = CType(resources.GetObject("_cmdsales_8.Image"), System.Drawing.Image)
        Me._cmdsales_8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsales.SetIndex(Me._cmdsales_8, CType(8, Short))
        Me._cmdsales_8.Location = New System.Drawing.Point(328, 21)
        Me._cmdsales_8.Name = "_cmdsales_8"
        Me._cmdsales_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_8.Size = New System.Drawing.Size(68, 56)
        Me._cmdsales_8.TabIndex = 32
        Me._cmdsales_8.Text = "MEMBER CARD"
        Me._cmdsales_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdsales_8.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me._CmdNav_2)
        Me.Frame2.Controls.Add(Me._CmdNav_1)
        Me.Frame2.Controls.Add(Me._cmdsales_7)
        Me.Frame2.Controls.Add(Me._cmdsales_6)
        Me.Frame2.Controls.Add(Me._cmdsales_5)
        Me.Frame2.Controls.Add(Me._cmdsales_4)
        Me.Frame2.Controls.Add(Me._cmdsales_3)
        Me.Frame2.Controls.Add(Me._cmdsales_2)
        Me.Frame2.Controls.Add(Me._cmdsales_1)
        Me.Frame2.Controls.Add(Me._cmdsales_0)
        Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(4, 442)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(728, 66)
        Me.Frame2.TabIndex = 43
        '
        '_CmdNav_2
        '
        Me._CmdNav_2.BackColor = System.Drawing.SystemColors.Control
        Me._CmdNav_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdNav_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdNav_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdNav_2.Image = CType(resources.GetObject("_CmdNav_2.Image"), System.Drawing.Image)
        Me.CmdNav.SetIndex(Me._CmdNav_2, CType(2, Short))
        Me._CmdNav_2.Location = New System.Drawing.Point(583, 2)
        Me._CmdNav_2.Name = "_CmdNav_2"
        Me._CmdNav_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdNav_2.Size = New System.Drawing.Size(70, 62)
        Me._CmdNav_2.TabIndex = 44
        Me._CmdNav_2.TabStop = False
        Me._CmdNav_2.Text = "DOWN"
        Me._CmdNav_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdNav_2.UseVisualStyleBackColor = False
        '
        '_CmdNav_1
        '
        Me._CmdNav_1.BackColor = System.Drawing.SystemColors.Control
        Me._CmdNav_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._CmdNav_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmdNav_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CmdNav_1.Image = CType(resources.GetObject("_CmdNav_1.Image"), System.Drawing.Image)
        Me.CmdNav.SetIndex(Me._CmdNav_1, CType(1, Short))
        Me._CmdNav_1.Location = New System.Drawing.Point(511, 2)
        Me._CmdNav_1.Name = "_CmdNav_1"
        Me._CmdNav_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._CmdNav_1.Size = New System.Drawing.Size(70, 62)
        Me._CmdNav_1.TabIndex = 43
        Me._CmdNav_1.TabStop = False
        Me._CmdNav_1.Text = "UP"
        Me._CmdNav_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._CmdNav_1.UseVisualStyleBackColor = False
        '
        '_cmdsales_7
        '
        Me._cmdsales_7.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_7.Image = CType(resources.GetObject("_cmdsales_7.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_7, CType(7, Short))
        Me._cmdsales_7.Location = New System.Drawing.Point(655, 2)
        Me._cmdsales_7.Name = "_cmdsales_7"
        Me._cmdsales_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_7.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_7.TabIndex = 9
        Me._cmdsales_7.Text = "CLOSE"
        Me._cmdsales_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_7.UseVisualStyleBackColor = False
        '
        '_cmdsales_6
        '
        Me._cmdsales_6.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_6.Image = CType(resources.GetObject("_cmdsales_6.Image"), System.Drawing.Image)
        Me._cmdsales_6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsales.SetIndex(Me._cmdsales_6, CType(6, Short))
        Me._cmdsales_6.Location = New System.Drawing.Point(439, 2)
        Me._cmdsales_6.Name = "_cmdsales_6"
        Me._cmdsales_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_6.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_6.TabIndex = 8
        Me._cmdsales_6.Text = "SHOPPING BAG"
        Me._cmdsales_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdsales_6.UseVisualStyleBackColor = False
        '
        '_cmdsales_5
        '
        Me._cmdsales_5.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me._cmdsales_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_5.Image = CType(resources.GetObject("_cmdsales_5.Image"), System.Drawing.Image)
        Me._cmdsales_5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsales.SetIndex(Me._cmdsales_5, CType(5, Short))
        Me._cmdsales_5.Location = New System.Drawing.Point(367, 2)
        Me._cmdsales_5.Name = "_cmdsales_5"
        Me._cmdsales_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_5.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_5.TabIndex = 7
        Me._cmdsales_5.Text = "VALIDATE ARTICLE"
        Me._cmdsales_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdsales_5.UseVisualStyleBackColor = False
        '
        '_cmdsales_4
        '
        Me._cmdsales_4.BackColor = System.Drawing.SystemColors.Control
        Me._cmdsales_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdsales_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdsales_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdsales_4.Image = CType(resources.GetObject("_cmdsales_4.Image"), System.Drawing.Image)
        Me.cmdsales.SetIndex(Me._cmdsales_4, CType(4, Short))
        Me._cmdsales_4.Location = New System.Drawing.Point(294, 2)
        Me._cmdsales_4.Name = "_cmdsales_4"
        Me._cmdsales_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_4.Size = New System.Drawing.Size(70, 62)
        Me._cmdsales_4.TabIndex = 6
        Me._cmdsales_4.Text = "VIEW"
        Me._cmdsales_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_4.UseVisualStyleBackColor = False
        '
        'CmdNav
        '
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
        Me._cmdsales_9.Location = New System.Drawing.Point(427, 23)
        Me._cmdsales_9.Name = "_cmdsales_9"
        Me._cmdsales_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdsales_9.Size = New System.Drawing.Size(68, 56)
        Me._cmdsales_9.TabIndex = 63
        Me._cmdsales_9.Text = "CEK PROMO"
        Me._cmdsales_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdsales_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdsales_9.UseVisualStyleBackColor = False
        '
        'lblqty
        '
        Me.lblqty.BackColor = System.Drawing.Color.Transparent
        Me.lblqty.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblqty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblqty.Location = New System.Drawing.Point(671, 63)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblqty.Size = New System.Drawing.Size(36, 21)
        Me.lblqty.TabIndex = 66
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(591, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Total QTY :"
        '
        'vpromo
        '
        Me.vpromo.BackColor = System.Drawing.SystemColors.Control
        Me.vpromo.Cursor = System.Windows.Forms.Cursors.Default
        Me.vpromo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpromo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vpromo.Location = New System.Drawing.Point(354, 277)
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
        Me.lblno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblno.Location = New System.Drawing.Point(592, 2)
        Me.lblno.Name = "lblno"
        Me.lblno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblno.Size = New System.Drawing.Size(131, 21)
        Me.lblno.TabIndex = 64
        '
        'vgtotal
        '
        Me.vgtotal.BackColor = System.Drawing.SystemColors.Control
        Me.vgtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgtotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vgtotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vgtotal.Location = New System.Drawing.Point(424, 277)
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(706, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(21, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(706, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(21, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "%"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(591, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Extra Disc :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(591, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Discount :"
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
        'vdisc2
        '
        Me.vdisc2.BackColor = System.Drawing.Color.Transparent
        Me.vdisc2.Cursor = System.Windows.Forms.Cursors.Default
        Me.vdisc2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdisc2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vdisc2.Location = New System.Drawing.Point(671, 43)
        Me.vdisc2.Name = "vdisc2"
        Me.vdisc2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vdisc2.Size = New System.Drawing.Size(36, 21)
        Me.vdisc2.TabIndex = 53
        Me.vdisc2.Text = "0"
        Me.vdisc2.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'vdisc1
        '
        Me.vdisc1.BackColor = System.Drawing.Color.Transparent
        Me.vdisc1.Cursor = System.Windows.Forms.Cursors.Default
        Me.vdisc1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdisc1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vdisc1.Location = New System.Drawing.Point(671, 23)
        Me.vdisc1.Name = "vdisc1"
        Me.vdisc1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vdisc1.Size = New System.Drawing.Size(36, 21)
        Me.vdisc1.TabIndex = 51
        Me.vdisc1.Text = "0"
        Me.vdisc1.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.vdesc.Location = New System.Drawing.Point(289, 252)
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
        'cmdsales
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(731, 292)
        Me.DataGridView1.TabIndex = 68
        '
        'txtcust_id
        '
        Me.txtcust_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcust_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcust_id.Location = New System.Drawing.Point(756, 54)
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
        Me.vrfid.Location = New System.Drawing.Point(314, 245)
        Me.vrfid.Name = "vrfid"
        Me.vrfid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vrfid.Size = New System.Drawing.Size(96, 21)
        Me.vrfid.TabIndex = 70
        Me.vrfid.Text = "plu"
        '
        'Timer1
        '
        '
        'RfidScan1
        '
        Me.RfidScan1.BackColor = System.Drawing.SystemColors.Control
        Me.RfidScan1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RfidScan1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RfidScan1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RfidScan1.Image = CType(resources.GetObject("RfidScan1.Image"), System.Drawing.Image)
        Me.RfidScan1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RfidScan1.Location = New System.Drawing.Point(508, 23)
        Me.RfidScan1.Name = "RfidScan1"
        Me.RfidScan1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RfidScan1.Size = New System.Drawing.Size(68, 56)
        Me.RfidScan1.TabIndex = 71
        Me.RfidScan1.Text = "READ RFID"
        Me.RfidScan1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RfidScan1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RfidScan1.UseVisualStyleBackColor = False
        '
        'RfidScan2
        '
        Me.RfidScan2.BackColor = System.Drawing.SystemColors.Control
        Me.RfidScan2.Cursor = System.Windows.Forms.Cursors.Default
        Me.RfidScan2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RfidScan2.ForeColor = System.Drawing.Color.Red
        Me.RfidScan2.Image = CType(resources.GetObject("RfidScan2.Image"), System.Drawing.Image)
        Me.RfidScan2.Location = New System.Drawing.Point(508, 23)
        Me.RfidScan2.Name = "RfidScan2"
        Me.RfidScan2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RfidScan2.Size = New System.Drawing.Size(68, 56)
        Me.RfidScan2.TabIndex = 72
        Me.RfidScan2.Text = "RFID OFF"
        Me.RfidScan2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RfidScan2.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(737, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.RfidScan2)
        Me.Controls.Add(Me.RfidScan1)
        Me.Controls.Add(Me.txtcust_id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._cmdsales_9)
        Me.Controls.Add(Me.lblqty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vpromo)
        Me.Controls.Add(Me.lblno)
        Me.Controls.Add(Me.vgtotal)
        Me.Controls.Add(Me.vtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.vdiscrp2)
        Me.Controls.Add(Me.vdiscrp1)
        Me.Controls.Add(Me.vdisc2)
        Me.Controls.Add(Me.vqty)
        Me.Controls.Add(Me.vdisc1)
        Me.Controls.Add(Me.vflag)
        Me.Controls.Add(Me.vno_trans)
        Me.Controls.Add(Me.vharga)
        Me.Controls.Add(Me.vdesc)
        Me.Controls.Add(Me.vspg)
        Me.Controls.Add(Me.vplu)
        Me.Controls.Add(Me.vrfid)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(753, 548)
        Me.MinimumSize = New System.Drawing.Size(741, 548)
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        CType(Me.CmdNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdsales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents _cmdsales_3 As System.Windows.Forms.Button
    Public WithEvents cmdsales As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents _cmdsales_1 As System.Windows.Forms.Button
    Public WithEvents _cmdsales_2 As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Public WithEvents _CmdNav_0 As System.Windows.Forms.Button
    Public WithEvents CmdNav As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents _CmdNav_3 As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblgrand_total As System.Windows.Forms.Label
    Public WithEvents _cmdsales_0 As System.Windows.Forms.Button
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents _cmdsales_8 As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.Panel
    Public WithEvents _CmdNav_2 As System.Windows.Forms.Button
    Public WithEvents _CmdNav_1 As System.Windows.Forms.Button
    Public WithEvents _cmdsales_7 As System.Windows.Forms.Button
    Public WithEvents _cmdsales_6 As System.Windows.Forms.Button
    Public WithEvents _cmdsales_5 As System.Windows.Forms.Button
    Public WithEvents _cmdsales_4 As System.Windows.Forms.Button
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcust_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcard_no As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcust_id As System.Windows.Forms.TextBox
    Friend WithEvents lblkode As Label
    Friend WithEvents txtkode As TextBox
    Public WithEvents vrfid As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents RfidScan1 As Button
    Public WithEvents RfidScan2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
