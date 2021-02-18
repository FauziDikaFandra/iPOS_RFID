<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaymentSelf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentSelf))
        Me.vpay = New System.Windows.Forms.TextBox()
        Me.vstatus = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._btnNum_13 = New System.Windows.Forms.Button()
        Me._btnNum_12 = New System.Windows.Forms.Button()
        Me._btnNum_0 = New System.Windows.Forms.Button()
        Me._btnNum_1 = New System.Windows.Forms.Button()
        Me.txtno_kartu = New System.Windows.Forms.TextBox()
        Me._btnNum_2 = New System.Windows.Forms.Button()
        Me._btnNum_3 = New System.Windows.Forms.Button()
        Me._btnNum_4 = New System.Windows.Forms.Button()
        Me._btnNum_5 = New System.Windows.Forms.Button()
        Me._btnNum_6 = New System.Windows.Forms.Button()
        Me._btnNum_7 = New System.Windows.Forms.Button()
        Me._btnNum_8 = New System.Windows.Forms.Button()
        Me._btnNum_9 = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.Panel()
        Me.vno_trans = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me._cmdpay_0 = New System.Windows.Forms.Button()
        Me.frmpay = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me._btnNum_11 = New System.Windows.Forms.Button()
        Me.lblPleaseWait = New System.Windows.Forms.Label()
        Me.lblCancel = New System.Windows.Forms.Label()
        Me.lblPayTypes = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAnother = New System.Windows.Forms.RadioButton()
        Me.rbGopay = New System.Windows.Forms.RadioButton()
        Me.rbMaster = New System.Windows.Forms.RadioButton()
        Me.rbVisa = New System.Windows.Forms.RadioButton()
        Me.rbDebitBCA = New System.Windows.Forms.RadioButton()
        Me.rbBcaCard = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.frmpay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vpay
        '
        Me.vpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vpay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpay.Location = New System.Drawing.Point(-25, -1)
        Me.vpay.Name = "vpay"
        Me.vpay.Size = New System.Drawing.Size(108, 26)
        Me.vpay.TabIndex = 34
        Me.vpay.Visible = False
        '
        'vstatus
        '
        Me.vstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vstatus.Location = New System.Drawing.Point(-25, -5)
        Me.vstatus.Name = "vstatus"
        Me.vstatus.Size = New System.Drawing.Size(108, 26)
        Me.vstatus.TabIndex = 35
        Me.vstatus.Visible = False
        '
        '_btnNum_13
        '
        Me._btnNum_13.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_13.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_13.Location = New System.Drawing.Point(264, 4)
        Me._btnNum_13.Name = "_btnNum_13"
        Me._btnNum_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_13.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_13.TabIndex = 43
        Me._btnNum_13.TabStop = False
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
        Me._btnNum_12.Location = New System.Drawing.Point(199, 4)
        Me._btnNum_12.Name = "_btnNum_12"
        Me._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_12.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_12.TabIndex = 42
        Me._btnNum_12.TabStop = False
        Me._btnNum_12.Tag = "12"
        Me._btnNum_12.Text = "<<"
        Me._btnNum_12.UseVisualStyleBackColor = False
        '
        '_btnNum_0
        '
        Me._btnNum_0.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_0.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_0.Location = New System.Drawing.Point(199, 134)
        Me._btnNum_0.Name = "_btnNum_0"
        Me._btnNum_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_0.Size = New System.Drawing.Size(130, 65)
        Me._btnNum_0.TabIndex = 40
        Me._btnNum_0.TabStop = False
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
        Me._btnNum_1.Location = New System.Drawing.Point(4, 134)
        Me._btnNum_1.Name = "_btnNum_1"
        Me._btnNum_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_1.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_1.TabIndex = 39
        Me._btnNum_1.TabStop = False
        Me._btnNum_1.Tag = "1"
        Me._btnNum_1.Text = "1"
        Me._btnNum_1.UseVisualStyleBackColor = False
        '
        'txtno_kartu
        '
        Me.txtno_kartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtno_kartu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_kartu.Location = New System.Drawing.Point(21, 18)
        Me.txtno_kartu.MaxLength = 16
        Me.txtno_kartu.Name = "txtno_kartu"
        Me.txtno_kartu.Size = New System.Drawing.Size(198, 25)
        Me.txtno_kartu.TabIndex = 63
        '
        '_btnNum_2
        '
        Me._btnNum_2.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_2.Location = New System.Drawing.Point(69, 134)
        Me._btnNum_2.Name = "_btnNum_2"
        Me._btnNum_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_2.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_2.TabIndex = 38
        Me._btnNum_2.TabStop = False
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
        Me._btnNum_3.Location = New System.Drawing.Point(134, 134)
        Me._btnNum_3.Name = "_btnNum_3"
        Me._btnNum_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_3.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_3.TabIndex = 37
        Me._btnNum_3.TabStop = False
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
        Me._btnNum_4.Location = New System.Drawing.Point(4, 69)
        Me._btnNum_4.Name = "_btnNum_4"
        Me._btnNum_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_4.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_4.TabIndex = 36
        Me._btnNum_4.TabStop = False
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
        Me._btnNum_5.Location = New System.Drawing.Point(69, 69)
        Me._btnNum_5.Name = "_btnNum_5"
        Me._btnNum_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_5.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_5.TabIndex = 35
        Me._btnNum_5.TabStop = False
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
        Me._btnNum_6.Location = New System.Drawing.Point(134, 69)
        Me._btnNum_6.Name = "_btnNum_6"
        Me._btnNum_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_6.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_6.TabIndex = 34
        Me._btnNum_6.TabStop = False
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
        Me._btnNum_7.Location = New System.Drawing.Point(4, 4)
        Me._btnNum_7.Name = "_btnNum_7"
        Me._btnNum_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_7.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_7.TabIndex = 33
        Me._btnNum_7.TabStop = False
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
        Me._btnNum_8.Location = New System.Drawing.Point(69, 4)
        Me._btnNum_8.Name = "_btnNum_8"
        Me._btnNum_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_8.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_8.TabIndex = 32
        Me._btnNum_8.TabStop = False
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
        Me._btnNum_9.Location = New System.Drawing.Point(134, 4)
        Me._btnNum_9.Name = "_btnNum_9"
        Me._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_9.Size = New System.Drawing.Size(65, 65)
        Me._btnNum_9.TabIndex = 31
        Me._btnNum_9.TabStop = False
        Me._btnNum_9.Tag = "9"
        Me._btnNum_9.Text = "9"
        Me._btnNum_9.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.White
        Me.Frame3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Frame3.Controls.Add(Me.vpay)
        Me.Frame3.Controls.Add(Me.vstatus)
        Me.Frame3.Controls.Add(Me.vno_trans)
        Me.Frame3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(229, 69)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(84, 64)
        Me.Frame3.TabIndex = 58
        '
        'vno_trans
        '
        Me.vno_trans.BackColor = System.Drawing.SystemColors.Control
        Me.vno_trans.Cursor = System.Windows.Forms.Cursors.Default
        Me.vno_trans.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vno_trans.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vno_trans.Location = New System.Drawing.Point(-43, -5)
        Me.vno_trans.Name = "vno_trans"
        Me.vno_trans.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vno_trans.Size = New System.Drawing.Size(126, 21)
        Me.vno_trans.TabIndex = 58
        Me.vno_trans.Visible = False
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.Black
        Me.lbltotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Yellow
        Me.lbltotal.Location = New System.Drawing.Point(153, 13)
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
        Me.Label5.Location = New System.Drawing.Point(6, 15)
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
        Me.Frame2.Controls.Add(Me._btnNum_13)
        Me.Frame2.Controls.Add(Me._btnNum_12)
        Me.Frame2.Controls.Add(Me._btnNum_0)
        Me.Frame2.Controls.Add(Me._btnNum_1)
        Me.Frame2.Controls.Add(Me._btnNum_2)
        Me.Frame2.Controls.Add(Me._cmdpay_0)
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
        Me.Frame2.Location = New System.Drawing.Point(401, 78)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(339, 206)
        Me.Frame2.TabIndex = 57
        '
        '_cmdpay_0
        '
        Me._cmdpay_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdpay_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdpay_0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdpay_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdpay_0.Image = CType(resources.GetObject("_cmdpay_0.Image"), System.Drawing.Image)
        Me._cmdpay_0.Location = New System.Drawing.Point(199, 69)
        Me._cmdpay_0.Name = "_cmdpay_0"
        Me._cmdpay_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdpay_0.Size = New System.Drawing.Size(130, 66)
        Me._cmdpay_0.TabIndex = 46
        Me._cmdpay_0.TabStop = False
        Me._cmdpay_0.Text = "BACK"
        Me._cmdpay_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdpay_0.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Black
        Me.Frame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Frame1.Controls.Add(Me.GroupBox2)
        Me.Frame1.Controls.Add(Me.lblPayTypes)
        Me.Frame1.Controls.Add(Me.GroupBox1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Frame3)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(4, 6)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(391, 286)
        Me.Frame1.TabIndex = 54
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me._btnNum_11)
        Me.GroupBox2.Controls.Add(Me.txtno_kartu)
        Me.GroupBox2.Controls.Add(Me.lblPleaseWait)
        Me.GroupBox2.Controls.Add(Me.lblCancel)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 72)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        '
        '_btnNum_11
        '
        Me._btnNum_11.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_11.Image = Global.iPOS.My.Resources.Resources.cash
        Me._btnNum_11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._btnNum_11.Location = New System.Drawing.Point(244, 14)
        Me._btnNum_11.Name = "_btnNum_11"
        Me._btnNum_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_11.Size = New System.Drawing.Size(93, 51)
        Me._btnNum_11.TabIndex = 41
        Me._btnNum_11.TabStop = False
        Me._btnNum_11.Tag = "11"
        Me._btnNum_11.Text = "PAY"
        Me._btnNum_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._btnNum_11.UseVisualStyleBackColor = False
        '
        'lblPleaseWait
        '
        Me.lblPleaseWait.AutoSize = True
        Me.lblPleaseWait.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseWait.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblPleaseWait.Location = New System.Drawing.Point(18, 49)
        Me.lblPleaseWait.Name = "lblPleaseWait"
        Me.lblPleaseWait.Size = New System.Drawing.Size(95, 16)
        Me.lblPleaseWait.TabIndex = 77
        Me.lblPleaseWait.Text = "Please Wait ..."
        '
        'lblCancel
        '
        Me.lblCancel.AutoSize = True
        Me.lblCancel.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancel.ForeColor = System.Drawing.Color.Red
        Me.lblCancel.Location = New System.Drawing.Point(174, 49)
        Me.lblCancel.Name = "lblCancel"
        Me.lblCancel.Size = New System.Drawing.Size(50, 16)
        Me.lblCancel.TabIndex = 78
        Me.lblCancel.Text = "Cancel"
        '
        'lblPayTypes
        '
        Me.lblPayTypes.BackColor = System.Drawing.Color.Black
        Me.lblPayTypes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPayTypes.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayTypes.ForeColor = System.Drawing.Color.Blue
        Me.lblPayTypes.Location = New System.Drawing.Point(215, 15)
        Me.lblPayTypes.Name = "lblPayTypes"
        Me.lblPayTypes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPayTypes.Size = New System.Drawing.Size(173, 26)
        Me.lblPayTypes.TabIndex = 80
        Me.lblPayTypes.Text = "BCA CARD"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAnother)
        Me.GroupBox1.Controls.Add(Me.rbGopay)
        Me.GroupBox1.Controls.Add(Me.rbMaster)
        Me.GroupBox1.Controls.Add(Me.rbVisa)
        Me.GroupBox1.Controls.Add(Me.rbDebitBCA)
        Me.GroupBox1.Controls.Add(Me.rbBcaCard)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 166)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'rbAnother
        '
        Me.rbAnother.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbAnother.BackgroundImage = Global.iPOS.My.Resources.Resources.Other
        Me.rbAnother.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbAnother.Location = New System.Drawing.Point(236, 91)
        Me.rbAnother.Name = "rbAnother"
        Me.rbAnother.Size = New System.Drawing.Size(101, 59)
        Me.rbAnother.TabIndex = 85
        Me.rbAnother.Tag = "10"
        Me.rbAnother.UseVisualStyleBackColor = True
        '
        'rbGopay
        '
        Me.rbGopay.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGopay.BackgroundImage = Global.iPOS.My.Resources.Resources.Gopayok
        Me.rbGopay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbGopay.Location = New System.Drawing.Point(236, 19)
        Me.rbGopay.Name = "rbGopay"
        Me.rbGopay.Size = New System.Drawing.Size(101, 59)
        Me.rbGopay.TabIndex = 84
        Me.rbGopay.Tag = "6"
        Me.rbGopay.UseVisualStyleBackColor = True
        '
        'rbMaster
        '
        Me.rbMaster.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbMaster.BackgroundImage = Global.iPOS.My.Resources.Resources.mastercard_1_82737
        Me.rbMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbMaster.Location = New System.Drawing.Point(129, 91)
        Me.rbMaster.Name = "rbMaster"
        Me.rbMaster.Size = New System.Drawing.Size(90, 59)
        Me.rbMaster.TabIndex = 83
        Me.rbMaster.Tag = "17"
        Me.rbMaster.UseVisualStyleBackColor = True
        '
        'rbVisa
        '
        Me.rbVisa.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbVisa.BackgroundImage = Global.iPOS.My.Resources.Resources._1280px_Visa_svg
        Me.rbVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbVisa.Location = New System.Drawing.Point(21, 91)
        Me.rbVisa.Name = "rbVisa"
        Me.rbVisa.Size = New System.Drawing.Size(90, 59)
        Me.rbVisa.TabIndex = 82
        Me.rbVisa.Tag = "17"
        Me.rbVisa.UseVisualStyleBackColor = True
        '
        'rbDebitBCA
        '
        Me.rbDebitBCA.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDebitBCA.BackgroundImage = Global.iPOS.My.Resources.Resources.debit_bca_green_logo_D8EE725387_seeklogo_com
        Me.rbDebitBCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbDebitBCA.Location = New System.Drawing.Point(129, 19)
        Me.rbDebitBCA.Name = "rbDebitBCA"
        Me.rbDebitBCA.Size = New System.Drawing.Size(90, 59)
        Me.rbDebitBCA.TabIndex = 81
        Me.rbDebitBCA.Tag = "4"
        Me.rbDebitBCA.UseVisualStyleBackColor = True
        '
        'rbBcaCard
        '
        Me.rbBcaCard.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbBcaCard.BackgroundImage = Global.iPOS.My.Resources.Resources.cara_c
        Me.rbBcaCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbBcaCard.Location = New System.Drawing.Point(21, 19)
        Me.rbBcaCard.Name = "rbBcaCard"
        Me.rbBcaCard.Size = New System.Drawing.Size(90, 59)
        Me.rbBcaCard.TabIndex = 80
        Me.rbBcaCard.Tag = "3"
        Me.rbBcaCard.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(212, 36)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Process Payment "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(326, 11)
        Me.Label1.TabIndex = 20
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(90, 256)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(234, 25)
        Me.ComboBox1.TabIndex = 75
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(401, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(339, 58)
        Me.Panel1.TabIndex = 80
        '
        'frmPaymentSelf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(746, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPaymentSelf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        CType(Me.frmpay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vpay As System.Windows.Forms.TextBox
    Friend WithEvents vstatus As System.Windows.Forms.TextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents _btnNum_13 As System.Windows.Forms.Button
    Public WithEvents _btnNum_12 As System.Windows.Forms.Button
    Public WithEvents _btnNum_0 As System.Windows.Forms.Button
    Public WithEvents _btnNum_1 As System.Windows.Forms.Button
    Public WithEvents frmpay As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    Public WithEvents _btnNum_11 As System.Windows.Forms.Button
    Public WithEvents _btnNum_2 As System.Windows.Forms.Button
    Public WithEvents _btnNum_3 As System.Windows.Forms.Button
    Public WithEvents _btnNum_4 As System.Windows.Forms.Button
    Public WithEvents _btnNum_5 As System.Windows.Forms.Button
    Public WithEvents _btnNum_6 As System.Windows.Forms.Button
    Public WithEvents _btnNum_7 As System.Windows.Forms.Button
    Public WithEvents _btnNum_8 As System.Windows.Forms.Button
    Public WithEvents _btnNum_9 As System.Windows.Forms.Button
    Public WithEvents _cmdpay_0 As System.Windows.Forms.Button
    Public WithEvents Frame3 As System.Windows.Forms.Panel
    Public WithEvents lbltotal As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.Panel
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Friend WithEvents txtno_kartu As System.Windows.Forms.TextBox
    Public WithEvents Label2 As Label
    Public WithEvents vno_trans As Label
    Friend WithEvents ComboBox1 As ComboBox
    Public WithEvents Label1 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPleaseWait As Label
    Friend WithEvents lblCancel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbVisa As RadioButton
    Friend WithEvents rbDebitBCA As RadioButton
    Friend WithEvents rbBcaCard As RadioButton
    Friend WithEvents rbMaster As RadioButton
    Friend WithEvents rbGopay As RadioButton
    Friend WithEvents rbAnother As RadioButton
    Public WithEvents Panel1 As Panel
    Public WithEvents lblPayTypes As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
