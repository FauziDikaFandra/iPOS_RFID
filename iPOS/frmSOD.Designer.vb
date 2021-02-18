<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSOD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSOD))
        Me._Chk_0 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Chk_1 = New System.Windows.Forms.CheckBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me._Chk_2 = New System.Windows.Forms.CheckBox()
        Me._Chk_3 = New System.Windows.Forms.CheckBox()
        Me._Chk_4 = New System.Windows.Forms.CheckBox()
        Me._Chk_5 = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._Chk_10 = New System.Windows.Forms.CheckBox()
        Me._Chk_6 = New System.Windows.Forms.CheckBox()
        Me._Chk_7 = New System.Windows.Forms.CheckBox()
        Me._Chk_8 = New System.Windows.Forms.CheckBox()
        Me._Chk_9 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Chk = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Chk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Chk_0
        '
        Me._Chk_0.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_0, CType(0, Short))
        Me._Chk_0.Location = New System.Drawing.Point(10, 15)
        Me._Chk_0.Name = "_Chk_0"
        Me._Chk_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_0.Size = New System.Drawing.Size(121, 26)
        Me._Chk_0.TabIndex = 17
        Me._Chk_0.Text = "Item Master"
        Me._Chk_0.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(396, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "SINKRONISASI DATA KE SERVER ...."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Chk_1
        '
        Me._Chk_1.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_1, CType(1, Short))
        Me._Chk_1.Location = New System.Drawing.Point(9, 45)
        Me._Chk_1.Name = "_Chk_1"
        Me._Chk_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_1.Size = New System.Drawing.Size(121, 26)
        Me._Chk_1.TabIndex = 15
        Me._Chk_1.Text = "Payment Types"
        Me._Chk_1.UseVisualStyleBackColor = False
        '
        'lblmsg
        '
        Me.lblmsg.BackColor = System.Drawing.Color.DimGray
        Me.lblmsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblmsg.Location = New System.Drawing.Point(-6, 1)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsg.Size = New System.Drawing.Size(406, 31)
        Me.lblmsg.TabIndex = 19
        Me.lblmsg.Text = "DOWNLOAD DATA"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(-1, 32)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(396, 163)
        Me.Frame2.TabIndex = 21
        Me.Frame2.TabStop = False
        '
        '_Chk_2
        '
        Me._Chk_2.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_2, CType(2, Short))
        Me._Chk_2.Location = New System.Drawing.Point(9, 75)
        Me._Chk_2.Name = "_Chk_2"
        Me._Chk_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_2.Size = New System.Drawing.Size(121, 26)
        Me._Chk_2.TabIndex = 12
        Me._Chk_2.Text = "Bin Card"
        Me._Chk_2.UseVisualStyleBackColor = False
        '
        '_Chk_3
        '
        Me._Chk_3.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_3, CType(3, Short))
        Me._Chk_3.Location = New System.Drawing.Point(9, 105)
        Me._Chk_3.Name = "_Chk_3"
        Me._Chk_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_3.Size = New System.Drawing.Size(121, 26)
        Me._Chk_3.TabIndex = 11
        Me._Chk_3.Text = "Users"
        Me._Chk_3.UseVisualStyleBackColor = False
        '
        '_Chk_4
        '
        Me._Chk_4.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_4, CType(4, Short))
        Me._Chk_4.Location = New System.Drawing.Point(140, 16)
        Me._Chk_4.Name = "_Chk_4"
        Me._Chk_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_4.Size = New System.Drawing.Size(121, 26)
        Me._Chk_4.TabIndex = 10
        Me._Chk_4.Text = "Attribute"
        Me._Chk_4.UseVisualStyleBackColor = False
        '
        '_Chk_5
        '
        Me._Chk_5.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_5, CType(5, Short))
        Me._Chk_5.Location = New System.Drawing.Point(140, 45)
        Me._Chk_5.Name = "_Chk_5"
        Me._Chk_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_5.Size = New System.Drawing.Size(121, 26)
        Me._Chk_5.TabIndex = 9
        Me._Chk_5.Text = "MC"
        Me._Chk_5.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._Chk_10)
        Me.Frame1.Controls.Add(Me._Chk_0)
        Me.Frame1.Controls.Add(Me._Chk_1)
        Me.Frame1.Controls.Add(Me._Chk_2)
        Me.Frame1.Controls.Add(Me._Chk_3)
        Me.Frame1.Controls.Add(Me._Chk_4)
        Me.Frame1.Controls.Add(Me._Chk_5)
        Me.Frame1.Controls.Add(Me._Chk_6)
        Me.Frame1.Controls.Add(Me._Chk_7)
        Me.Frame1.Controls.Add(Me._Chk_8)
        Me.Frame1.Controls.Add(Me._Chk_9)
        Me.Frame1.Controls.Add(Me.ProgressBar1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(-1, 32)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(396, 163)
        Me.Frame1.TabIndex = 20
        Me.Frame1.TabStop = False
        Me.Frame1.Visible = False
        '
        '_Chk_10
        '
        Me._Chk_10.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_10, CType(10, Short))
        Me._Chk_10.Location = New System.Drawing.Point(265, 75)
        Me._Chk_10.Name = "_Chk_10"
        Me._Chk_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_10.Size = New System.Drawing.Size(121, 26)
        Me._Chk_10.TabIndex = 18
        Me._Chk_10.Text = "RFID "
        Me._Chk_10.UseVisualStyleBackColor = False
        '
        '_Chk_6
        '
        Me._Chk_6.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_6, CType(6, Short))
        Me._Chk_6.Location = New System.Drawing.Point(140, 75)
        Me._Chk_6.Name = "_Chk_6"
        Me._Chk_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_6.Size = New System.Drawing.Size(121, 26)
        Me._Chk_6.TabIndex = 8
        Me._Chk_6.Text = "Other User"
        Me._Chk_6.UseVisualStyleBackColor = False
        '
        '_Chk_7
        '
        Me._Chk_7.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_7, CType(7, Short))
        Me._Chk_7.Location = New System.Drawing.Point(140, 107)
        Me._Chk_7.Name = "_Chk_7"
        Me._Chk_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_7.Size = New System.Drawing.Size(121, 26)
        Me._Chk_7.TabIndex = 7
        Me._Chk_7.Text = "Cash Register"
        Me._Chk_7.UseVisualStyleBackColor = False
        '
        '_Chk_8
        '
        Me._Chk_8.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_8, CType(8, Short))
        Me._Chk_8.Location = New System.Drawing.Point(265, 16)
        Me._Chk_8.Name = "_Chk_8"
        Me._Chk_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_8.Size = New System.Drawing.Size(121, 26)
        Me._Chk_8.TabIndex = 4
        Me._Chk_8.Text = "Cpoint"
        Me._Chk_8.UseVisualStyleBackColor = False
        '
        '_Chk_9
        '
        Me._Chk_9.BackColor = System.Drawing.SystemColors.Control
        Me._Chk_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Chk_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Chk_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chk.SetIndex(Me._Chk_9, CType(9, Short))
        Me._Chk_9.Location = New System.Drawing.Point(265, 45)
        Me._Chk_9.Name = "_Chk_9"
        Me._Chk_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Chk_9.Size = New System.Drawing.Size(121, 26)
        Me._Chk_9.TabIndex = 2
        Me._Chk_9.Text = "Others"
        Me._Chk_9.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 137)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(376, 21)
        Me.ProgressBar1.TabIndex = 3
        '
        'Chk
        '
        '
        'BackgroundWorker1
        '
        '
        'frmSOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(411, 235)
        Me.MinimumSize = New System.Drawing.Size(411, 235)
        Me.Name = "frmSOD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOD"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.Chk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents _Chk_0 As System.Windows.Forms.CheckBox
    Public WithEvents Chk As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _Chk_1 As System.Windows.Forms.CheckBox
    Public WithEvents lblmsg As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents _Chk_2 As System.Windows.Forms.CheckBox
    Public WithEvents _Chk_3 As System.Windows.Forms.CheckBox
    Public WithEvents _Chk_4 As System.Windows.Forms.CheckBox
    Public WithEvents _Chk_5 As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents _Chk_6 As System.Windows.Forms.CheckBox
    Public WithEvents _Chk_7 As System.Windows.Forms.CheckBox
    Public WithEvents _Chk_8 As System.Windows.Forms.CheckBox
    Public WithEvents _Chk_9 As System.Windows.Forms.CheckBox
    Public WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Public WithEvents _Chk_10 As CheckBox
End Class
