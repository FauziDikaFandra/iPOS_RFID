<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtinfo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me._cmdMenu_8 = New System.Windows.Forms.Button()
        Me._cmdMenu_9 = New System.Windows.Forms.Button()
        Me._cmdMenu_3 = New System.Windows.Forms.Button()
        Me._cmdMenu_7 = New System.Windows.Forms.Button()
        Me._cmdMenu_6 = New System.Windows.Forms.Button()
        Me._cmdMenu_5 = New System.Windows.Forms.Button()
        Me._cmdMenu_4 = New System.Windows.Forms.Button()
        Me._cmdMenu_2 = New System.Windows.Forms.Button()
        Me._cmdMenu_1 = New System.Windows.Forms.Button()
        Me._cmdMenu_0 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.Panel()
        Me.lblline = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.lblkasir = New System.Windows.Forms.Label()
        Me.lblreg = New System.Windows.Forms.Label()
        Me.lblbranch = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMember = New System.Windows.Forms.Label()
        Me.lblMemberTran = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(454, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(226, 373)
        Me.DataGridView1.TabIndex = 4
        '
        'txtinfo
        '
        Me.txtinfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinfo.Location = New System.Drawing.Point(7, 25)
        Me.txtinfo.Multiline = True
        Me.txtinfo.Name = "txtinfo"
        Me.txtinfo.Size = New System.Drawing.Size(436, 107)
        Me.txtinfo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(327, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "INFO PROMO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(302, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(146, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "PROGRAM MENU"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me._cmdMenu_8)
        Me.Frame2.Controls.Add(Me._cmdMenu_9)
        Me.Frame2.Controls.Add(Me._cmdMenu_3)
        Me.Frame2.Controls.Add(Me._cmdMenu_7)
        Me.Frame2.Controls.Add(Me._cmdMenu_6)
        Me.Frame2.Controls.Add(Me._cmdMenu_5)
        Me.Frame2.Controls.Add(Me._cmdMenu_4)
        Me.Frame2.Controls.Add(Me._cmdMenu_2)
        Me.Frame2.Controls.Add(Me._cmdMenu_1)
        Me.Frame2.Controls.Add(Me._cmdMenu_0)
        Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(7, 154)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(436, 146)
        Me.Frame2.TabIndex = 29
        '
        '_cmdMenu_8
        '
        Me._cmdMenu_8.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_8.Image = CType(resources.GetObject("_cmdMenu_8.Image"), System.Drawing.Image)
        Me._cmdMenu_8.Location = New System.Drawing.Point(346, 4)
        Me._cmdMenu_8.Name = "_cmdMenu_8"
        Me._cmdMenu_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_8.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_8.TabIndex = 4
        Me._cmdMenu_8.Tag = "8"
        Me._cmdMenu_8.Text = "CANCEL"
        Me._cmdMenu_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_8.UseVisualStyleBackColor = False
        '
        '_cmdMenu_9
        '
        Me._cmdMenu_9.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_9.Image = CType(resources.GetObject("_cmdMenu_9.Image"), System.Drawing.Image)
        Me._cmdMenu_9.Location = New System.Drawing.Point(346, 74)
        Me._cmdMenu_9.Name = "_cmdMenu_9"
        Me._cmdMenu_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_9.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_9.TabIndex = 9
        Me._cmdMenu_9.Tag = "9"
        Me._cmdMenu_9.Text = "EXIT"
        Me._cmdMenu_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_9.UseVisualStyleBackColor = False
        '
        '_cmdMenu_3
        '
        Me._cmdMenu_3.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_3.Image = CType(resources.GetObject("_cmdMenu_3.Image"), System.Drawing.Image)
        Me._cmdMenu_3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_3.Location = New System.Drawing.Point(261, 74)
        Me._cmdMenu_3.Name = "_cmdMenu_3"
        Me._cmdMenu_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_3.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_3.TabIndex = 8
        Me._cmdMenu_3.Tag = "3"
        Me._cmdMenu_3.Text = "OPEN DRAWER"
        Me._cmdMenu_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdMenu_3.UseVisualStyleBackColor = False
        '
        '_cmdMenu_7
        '
        Me._cmdMenu_7.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_7.Image = CType(resources.GetObject("_cmdMenu_7.Image"), System.Drawing.Image)
        Me._cmdMenu_7.Location = New System.Drawing.Point(261, 4)
        Me._cmdMenu_7.Name = "_cmdMenu_7"
        Me._cmdMenu_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_7.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_7.TabIndex = 3
        Me._cmdMenu_7.Tag = "7"
        Me._cmdMenu_7.Text = "RELEASE"
        Me._cmdMenu_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_7.UseVisualStyleBackColor = False
        '
        '_cmdMenu_6
        '
        Me._cmdMenu_6.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_6.Image = CType(resources.GetObject("_cmdMenu_6.Image"), System.Drawing.Image)
        Me._cmdMenu_6.Location = New System.Drawing.Point(176, 4)
        Me._cmdMenu_6.Name = "_cmdMenu_6"
        Me._cmdMenu_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_6.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_6.TabIndex = 2
        Me._cmdMenu_6.Tag = "6"
        Me._cmdMenu_6.Text = "REPRINT"
        Me._cmdMenu_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_6.UseVisualStyleBackColor = False
        '
        '_cmdMenu_5
        '
        Me._cmdMenu_5.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_5.Image = CType(resources.GetObject("_cmdMenu_5.Image"), System.Drawing.Image)
        Me._cmdMenu_5.Location = New System.Drawing.Point(91, 4)
        Me._cmdMenu_5.Name = "_cmdMenu_5"
        Me._cmdMenu_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_5.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_5.TabIndex = 1
        Me._cmdMenu_5.Tag = "5"
        Me._cmdMenu_5.Text = "REFUND"
        Me._cmdMenu_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_5.UseVisualStyleBackColor = False
        '
        '_cmdMenu_4
        '
        Me._cmdMenu_4.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_4.Image = CType(resources.GetObject("_cmdMenu_4.Image"), System.Drawing.Image)
        Me._cmdMenu_4.Location = New System.Drawing.Point(6, 4)
        Me._cmdMenu_4.Name = "_cmdMenu_4"
        Me._cmdMenu_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_4.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_4.TabIndex = 0
        Me._cmdMenu_4.Tag = "4"
        Me._cmdMenu_4.Text = "SALES"
        Me._cmdMenu_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_4.UseVisualStyleBackColor = False
        '
        '_cmdMenu_2
        '
        Me._cmdMenu_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_2.Image = CType(resources.GetObject("_cmdMenu_2.Image"), System.Drawing.Image)
        Me._cmdMenu_2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_2.Location = New System.Drawing.Point(176, 74)
        Me._cmdMenu_2.Name = "_cmdMenu_2"
        Me._cmdMenu_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_2.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_2.TabIndex = 7
        Me._cmdMenu_2.Tag = "2"
        Me._cmdMenu_2.Text = "CLOSE REGISTER"
        Me._cmdMenu_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdMenu_2.UseVisualStyleBackColor = False
        '
        '_cmdMenu_1
        '
        Me._cmdMenu_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_1.Image = CType(resources.GetObject("_cmdMenu_1.Image"), System.Drawing.Image)
        Me._cmdMenu_1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_1.Location = New System.Drawing.Point(91, 74)
        Me._cmdMenu_1.Name = "_cmdMenu_1"
        Me._cmdMenu_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_1.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_1.TabIndex = 6
        Me._cmdMenu_1.Tag = "1"
        Me._cmdMenu_1.Text = "CLOSE SHIFT"
        Me._cmdMenu_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdMenu_1.UseVisualStyleBackColor = False
        '
        '_cmdMenu_0
        '
        Me._cmdMenu_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdMenu_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdMenu_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdMenu_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdMenu_0.Image = CType(resources.GetObject("_cmdMenu_0.Image"), System.Drawing.Image)
        Me._cmdMenu_0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_0.Location = New System.Drawing.Point(6, 74)
        Me._cmdMenu_0.Name = "_cmdMenu_0"
        Me._cmdMenu_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdMenu_0.Size = New System.Drawing.Size(84, 67)
        Me._cmdMenu_0.TabIndex = 5
        Me._cmdMenu_0.Tag = "0"
        Me._cmdMenu_0.Text = "CASH OPEN"
        Me._cmdMenu_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdMenu_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._cmdMenu_0.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(302, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(146, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "INFO REGISTER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.Black
        Me.Frame3.Controls.Add(Me.lblline)
        Me.Frame3.Controls.Add(Me.lbljam)
        Me.Frame3.Controls.Add(Me.lbltgl)
        Me.Frame3.Controls.Add(Me.lblkasir)
        Me.Frame3.Controls.Add(Me.lblreg)
        Me.Frame3.Controls.Add(Me.lblbranch)
        Me.Frame3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(7, 332)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(436, 66)
        Me.Frame3.TabIndex = 30
        '
        'lblline
        '
        Me.lblline.BackColor = System.Drawing.Color.Transparent
        Me.lblline.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblline.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline.ForeColor = System.Drawing.Color.Yellow
        Me.lblline.Location = New System.Drawing.Point(224, 45)
        Me.lblline.Name = "lblline"
        Me.lblline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblline.Size = New System.Drawing.Size(206, 21)
        Me.lblline.TabIndex = 22
        Me.lblline.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbljam
        '
        Me.lbljam.BackColor = System.Drawing.Color.Transparent
        Me.lbljam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbljam.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.ForeColor = System.Drawing.Color.Yellow
        Me.lbljam.Location = New System.Drawing.Point(224, 25)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbljam.Size = New System.Drawing.Size(206, 21)
        Me.lbljam.TabIndex = 17
        Me.lbljam.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbltgl
        '
        Me.lbltgl.BackColor = System.Drawing.Color.Transparent
        Me.lbltgl.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltgl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltgl.ForeColor = System.Drawing.Color.Yellow
        Me.lbltgl.Location = New System.Drawing.Point(224, 5)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltgl.Size = New System.Drawing.Size(206, 21)
        Me.lbltgl.TabIndex = 16
        Me.lbltgl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblkasir
        '
        Me.lblkasir.BackColor = System.Drawing.Color.Transparent
        Me.lblkasir.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblkasir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkasir.ForeColor = System.Drawing.Color.Yellow
        Me.lblkasir.Location = New System.Drawing.Point(10, 45)
        Me.lblkasir.Name = "lblkasir"
        Me.lblkasir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblkasir.Size = New System.Drawing.Size(206, 21)
        Me.lblkasir.TabIndex = 15
        '
        'lblreg
        '
        Me.lblreg.BackColor = System.Drawing.Color.Transparent
        Me.lblreg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblreg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreg.ForeColor = System.Drawing.Color.Yellow
        Me.lblreg.Location = New System.Drawing.Point(10, 25)
        Me.lblreg.Name = "lblreg"
        Me.lblreg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblreg.Size = New System.Drawing.Size(206, 21)
        Me.lblreg.TabIndex = 14
        '
        'lblbranch
        '
        Me.lblbranch.BackColor = System.Drawing.Color.Transparent
        Me.lblbranch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblbranch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranch.ForeColor = System.Drawing.Color.Yellow
        Me.lblbranch.Location = New System.Drawing.Point(10, 5)
        Me.lblbranch.Name = "lblbranch"
        Me.lblbranch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblbranch.Size = New System.Drawing.Size(206, 21)
        Me.lblbranch.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(559, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "TRANSAKSI PENDING"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "Delete Row"
        '
        'lblMember
        '
        Me.lblMember.BackColor = System.Drawing.Color.Transparent
        Me.lblMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMember.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMember.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblMember.Location = New System.Drawing.Point(4, 135)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMember.Size = New System.Drawing.Size(121, 16)
        Me.lblMember.TabIndex = 33
        Me.lblMember.Text = "MEMBERSHIP"
        '
        'lblMemberTran
        '
        Me.lblMemberTran.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberTran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMemberTran.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberTran.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblMemberTran.Location = New System.Drawing.Point(4, 313)
        Me.lblMemberTran.Name = "lblMemberTran"
        Me.lblMemberTran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMemberTran.Size = New System.Drawing.Size(121, 16)
        Me.lblMemberTran.TabIndex = 34
        Me.lblMemberTran.Text = "MEMBER TRANS"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMemberTran)
        Me.Controls.Add(Me.lblMember)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtinfo)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(704, 446)
        Me.MinimumSize = New System.Drawing.Size(704, 446)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POINT OF SALES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtinfo As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.Panel
    Public WithEvents cmdMenu As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents _cmdMenu_8 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_9 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_3 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_7 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_6 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_5 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_4 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_2 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_1 As System.Windows.Forms.Button
    Public WithEvents _cmdMenu_0 As System.Windows.Forms.Button
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.Panel
    Public WithEvents lblline As System.Windows.Forms.Label
    Public WithEvents lbljam As System.Windows.Forms.Label
    Public WithEvents lbltgl As System.Windows.Forms.Label
    Public WithEvents lblkasir As System.Windows.Forms.Label
    Public WithEvents lblreg As System.Windows.Forms.Label
    Public WithEvents lblbranch As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Public WithEvents lblMember As Label
    Public WithEvents lblMemberTran As Label
End Class
