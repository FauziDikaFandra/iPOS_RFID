<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkaryawan))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.cmdangka = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtid)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(1, 2)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(256, 61)
        Me.Frame1.TabIndex = 8
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "MASUKAN ID KARYAWAN"
        '
        'txtid
        '
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(13, 21)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(233, 26)
        Me.txtid.TabIndex = 36
        '
        'cmdangka
        '
        Me.cmdangka.BackColor = System.Drawing.SystemColors.Control
        Me.cmdangka.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdangka.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdangka.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdangka.Image = CType(resources.GetObject("cmdangka.Image"), System.Drawing.Image)
        Me.cmdangka.Location = New System.Drawing.Point(11, 72)
        Me.cmdangka.Name = "cmdangka"
        Me.cmdangka.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdangka.Size = New System.Drawing.Size(76, 48)
        Me.cmdangka.TabIndex = 7
        Me.cmdangka.Text = "&NUM"
        Me.cmdangka.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdangka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdangka.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancel.Image = CType(resources.GetObject("CmdCancel.Image"), System.Drawing.Image)
        Me.CmdCancel.Location = New System.Drawing.Point(171, 72)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancel.Size = New System.Drawing.Size(76, 48)
        Me.CmdCancel.TabIndex = 6
        Me.CmdCancel.Text = "CANCEL"
        Me.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOk.Image = CType(resources.GetObject("CmdOk.Image"), System.Drawing.Image)
        Me.CmdOk.Location = New System.Drawing.Point(91, 72)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOk.Size = New System.Drawing.Size(76, 48)
        Me.CmdOk.TabIndex = 5
        Me.CmdOk.Text = "OK"
        Me.CmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'frmkaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 122)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdangka)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(274, 161)
        Me.MinimumSize = New System.Drawing.Size(274, 161)
        Me.Name = "frmkaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTER ID"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdangka As System.Windows.Forms.Button
    Public WithEvents CmdCancel As System.Windows.Forms.Button
    Public WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
End Class
