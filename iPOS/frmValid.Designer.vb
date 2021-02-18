<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValid))
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.btnNum = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.VLevelApp = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me._btnNum_13 = New System.Windows.Forms.Button()
        Me._btnNum_12 = New System.Windows.Forms.Button()
        Me._btnNum_10 = New System.Windows.Forms.Button()
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
        Me.Frame1.SuspendLayout()
        CType(Me.btnNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.DimGray
        Me.Frame1.Controls.Add(Me.lblUser)
        Me.Frame1.Controls.Add(Me.txtpassword)
        Me.Frame1.Controls.Add(Me.txtuser)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 1)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(281, 46)
        Me.Frame1.TabIndex = 19
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Yellow
        Me.lblUser.Location = New System.Drawing.Point(14, 16)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(52, 15)
        Me.lblUser.TabIndex = 27
        Me.lblUser.Text = "USER ID"
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(106, 12)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(164, 26)
        Me.txtpassword.TabIndex = 28
        Me.txtpassword.UseSystemPasswordChar = True
        Me.txtpassword.Visible = False
        '
        'txtuser
        '
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(106, 12)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(164, 26)
        Me.txtuser.TabIndex = 26
        '
        'VLevelApp
        '
        Me.VLevelApp.BackColor = System.Drawing.SystemColors.Control
        Me.VLevelApp.Cursor = System.Windows.Forms.Cursors.Default
        Me.VLevelApp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VLevelApp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VLevelApp.Location = New System.Drawing.Point(283, 15)
        Me.VLevelApp.Name = "VLevelApp"
        Me.VLevelApp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VLevelApp.Size = New System.Drawing.Size(101, 26)
        Me.VLevelApp.TabIndex = 21
        Me.VLevelApp.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me._btnNum_13)
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
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 53)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(278, 285)
        Me.Frame2.TabIndex = 23
        Me.Frame2.TabStop = False
        '
        '_btnNum_13
        '
        Me._btnNum_13.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_13.Location = New System.Drawing.Point(208, 210)
        Me._btnNum_13.Name = "_btnNum_13"
        Me._btnNum_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_13.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_13.TabIndex = 13
        Me._btnNum_13.Tag = "13"
        Me._btnNum_13.Text = "CLOSE"
        Me._btnNum_13.UseVisualStyleBackColor = False
        '
        '_btnNum_12
        '
        Me._btnNum_12.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_12.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_12.Location = New System.Drawing.Point(208, 111)
        Me._btnNum_12.Name = "_btnNum_12"
        Me._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_12.Size = New System.Drawing.Size(68, 100)
        Me._btnNum_12.TabIndex = 12
        Me._btnNum_12.Tag = "12"
        Me._btnNum_12.Text = "C"
        Me._btnNum_12.UseVisualStyleBackColor = False
        '
        '_btnNum_10
        '
        Me._btnNum_10.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_10.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_10.Location = New System.Drawing.Point(208, 9)
        Me._btnNum_10.Name = "_btnNum_10"
        Me._btnNum_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_10.Size = New System.Drawing.Size(68, 102)
        Me._btnNum_10.TabIndex = 11
        Me._btnNum_10.Tag = "10"
        Me._btnNum_10.Text = "<<"
        Me._btnNum_10.UseVisualStyleBackColor = False
        '
        '_btnNum_11
        '
        Me._btnNum_11.BackColor = System.Drawing.SystemColors.Control
        Me._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._btnNum_11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._btnNum_11.Location = New System.Drawing.Point(73, 210)
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
        Me._btnNum_0.Location = New System.Drawing.Point(6, 210)
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
        Me._btnNum_1.Location = New System.Drawing.Point(6, 143)
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
        Me._btnNum_2.Location = New System.Drawing.Point(73, 143)
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
        Me._btnNum_3.Location = New System.Drawing.Point(140, 143)
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
        Me._btnNum_4.Location = New System.Drawing.Point(6, 76)
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
        Me._btnNum_5.Location = New System.Drawing.Point(73, 76)
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
        Me._btnNum_6.Location = New System.Drawing.Point(140, 76)
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
        Me._btnNum_7.Location = New System.Drawing.Point(6, 9)
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
        Me._btnNum_8.Location = New System.Drawing.Point(73, 9)
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
        Me._btnNum_9.Location = New System.Drawing.Point(140, 9)
        Me._btnNum_9.Name = "_btnNum_9"
        Me._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._btnNum_9.Size = New System.Drawing.Size(68, 68)
        Me._btnNum_9.TabIndex = 10
        Me._btnNum_9.Tag = "9"
        Me._btnNum_9.Text = "9"
        Me._btnNum_9.UseVisualStyleBackColor = False
        '
        'frmValid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.VLevelApp)
        Me.Controls.Add(Me.Frame1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(298, 375)
        Me.MinimumSize = New System.Drawing.Size(298, 375)
        Me.Name = "frmValid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VERIFICATION"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.btnNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.Panel
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Public WithEvents btnNum As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Public WithEvents VLevelApp As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents _btnNum_13 As System.Windows.Forms.Button
    Public WithEvents _btnNum_12 As System.Windows.Forms.Button
    Public WithEvents _btnNum_10 As System.Windows.Forms.Button
    Public WithEvents _btnNum_11 As System.Windows.Forms.Button
    Public WithEvents _btnNum_0 As System.Windows.Forms.Button
    Public WithEvents _btnNum_1 As System.Windows.Forms.Button
    Public WithEvents _btnNum_2 As System.Windows.Forms.Button
    Public WithEvents _btnNum_3 As System.Windows.Forms.Button
    Public WithEvents _btnNum_4 As System.Windows.Forms.Button
    Public WithEvents _btnNum_5 As System.Windows.Forms.Button
    Public WithEvents _btnNum_6 As System.Windows.Forms.Button
    Public WithEvents _btnNum_7 As System.Windows.Forms.Button
    Public WithEvents _btnNum_8 As System.Windows.Forms.Button
    Public WithEvents _btnNum_9 As System.Windows.Forms.Button
End Class
