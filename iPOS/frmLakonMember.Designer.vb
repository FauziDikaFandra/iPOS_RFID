<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberRegistration))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcust_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcard_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Gender"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(144, 113)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(233, 22)
        Me.txtEmail.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Email"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(144, 81)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(188, 22)
        Me.txtPhone.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Phone Number"
        '
        'txtcust_name
        '
        Me.txtcust_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcust_name.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcust_name.Location = New System.Drawing.Point(144, 49)
        Me.txtcust_name.Name = "txtcust_name"
        Me.txtcust_name.Size = New System.Drawing.Size(233, 22)
        Me.txtcust_name.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Customer Name"
        '
        'txtcard_no
        '
        Me.txtcard_no.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtcard_no.Enabled = False
        Me.txtcard_no.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard_no.Location = New System.Drawing.Point(144, 17)
        Me.txtcard_no.Name = "txtcard_no"
        Me.txtcard_no.Size = New System.Drawing.Size(113, 22)
        Me.txtcard_no.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Card No"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.ComboBox1)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.txtEmail)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.txtPhone)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.txtcust_name)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.txtcard_no)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(6, 35)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(395, 182)
        Me.Frame2.TabIndex = 25
        Me.Frame2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(144, 145)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 24)
        Me.ComboBox1.TabIndex = 76
        '
        'lblmsg
        '
        Me.lblmsg.BackColor = System.Drawing.Color.DimGray
        Me.lblmsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblmsg.Location = New System.Drawing.Point(-5, 0)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsg.Size = New System.Drawing.Size(416, 31)
        Me.lblmsg.TabIndex = 24
        Me.lblmsg.Text = "MEMBERSHIP REGISTRATION"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOk.Image = CType(resources.GetObject("CmdOk.Image"), System.Drawing.Image)
        Me.CmdOk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdOk.Location = New System.Drawing.Point(150, 223)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOk.Size = New System.Drawing.Size(120, 48)
        Me.CmdOk.TabIndex = 21
        Me.CmdOk.Text = "OK"
        Me.CmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancel.Image = CType(resources.GetObject("CmdCancel.Image"), System.Drawing.Image)
        Me.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdCancel.Location = New System.Drawing.Point(274, 223)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancel.Size = New System.Drawing.Size(120, 48)
        Me.CmdCancel.TabIndex = 22
        Me.CmdCancel.Text = "CANCEL"
        Me.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'MemberRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdCancel)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(422, 317)
        Me.MinimumSize = New System.Drawing.Size(422, 317)
        Me.Name = "MemberRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership Lakon"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcust_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcard_no As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents Timer1 As Timer
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents Frame2 As GroupBox
    Public WithEvents lblmsg As Label
    Public WithEvents CmdOk As Button
    Public WithEvents CmdCancel As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
