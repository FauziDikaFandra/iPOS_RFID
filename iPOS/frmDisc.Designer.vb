<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisc))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.cmdCancel.Location = New System.Drawing.Point(96, 98)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(76, 66)
        Me.cmdCancel.TabIndex = 11
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
        Me.cmdOk.Location = New System.Drawing.Point(96, 32)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(76, 66)
        Me.cmdOk.TabIndex = 10
        Me.cmdOk.Text = "OK"
        Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 18
        Me.List1.Location = New System.Drawing.Point(-2, 32)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(106, 130)
        Me.List1.TabIndex = 7
        '
        'lblmsg
        '
        Me.lblmsg.BackColor = System.Drawing.Color.DimGray
        Me.lblmsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblmsg.Location = New System.Drawing.Point(-7, 1)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsg.Size = New System.Drawing.Size(186, 31)
        Me.lblmsg.TabIndex = 6
        Me.lblmsg.Text = "DISCOUNT"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmDisc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(172, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.lblmsg)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(188, 288)
        Me.Name = "frmDisc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmDisc"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOk As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents List1 As System.Windows.Forms.ListBox
    Public WithEvents lblmsg As System.Windows.Forms.Label
End Class
