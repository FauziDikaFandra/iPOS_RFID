<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardPromo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCardPromo))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmddown = New System.Windows.Forms.Button()
        Me.cmdup = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(221, 111)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(76, 56)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "CANCEL"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Image = CType(resources.GetObject("cmdOk.Image"), System.Drawing.Image)
        Me.cmdOk.Location = New System.Drawing.Point(146, 111)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(76, 56)
        Me.cmdOk.TabIndex = 7
        Me.cmdOk.Text = "OK"
        Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmddown
        '
        Me.cmddown.BackColor = System.Drawing.SystemColors.Control
        Me.cmddown.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmddown.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmddown.Image = CType(resources.GetObject("cmddown.Image"), System.Drawing.Image)
        Me.cmddown.Location = New System.Drawing.Point(71, 111)
        Me.cmddown.Name = "cmddown"
        Me.cmddown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmddown.Size = New System.Drawing.Size(76, 56)
        Me.cmddown.TabIndex = 11
        Me.cmddown.Text = "DOWN"
        Me.cmddown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmddown.UseVisualStyleBackColor = False
        '
        'cmdup
        '
        Me.cmdup.BackColor = System.Drawing.SystemColors.Control
        Me.cmdup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdup.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdup.Image = CType(resources.GetObject("cmdup.Image"), System.Drawing.Image)
        Me.cmdup.Location = New System.Drawing.Point(-4, 111)
        Me.cmdup.Name = "cmdup"
        Me.cmdup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdup.Size = New System.Drawing.Size(76, 56)
        Me.cmdup.TabIndex = 10
        Me.cmdup.Text = "UP"
        Me.cmdup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdup.UseVisualStyleBackColor = False
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 16
        Me.List1.Location = New System.Drawing.Point(-4, 26)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(301, 84)
        Me.List1.TabIndex = 6
        '
        'lblmsg
        '
        Me.lblmsg.BackColor = System.Drawing.Color.DimGray
        Me.lblmsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblmsg.Location = New System.Drawing.Point(-4, 2)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsg.Size = New System.Drawing.Size(301, 31)
        Me.lblmsg.TabIndex = 9
        Me.lblmsg.Text = "KARTU PROMOSI"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmCardPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmddown)
        Me.Controls.Add(Me.cmdup)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.lblmsg)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(308, 200)
        Me.MinimumSize = New System.Drawing.Size(308, 200)
        Me.Name = "frmCardPromo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARD PROMO"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOk As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmddown As System.Windows.Forms.Button
    Public WithEvents cmdup As System.Windows.Forms.Button
    Public WithEvents List1 As System.Windows.Forms.ListBox
    Public WithEvents lblmsg As System.Windows.Forms.Label
End Class
