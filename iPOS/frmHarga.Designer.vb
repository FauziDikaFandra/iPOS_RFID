<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHarga))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.cmdangka = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOk.Image = CType(resources.GetObject("CmdOk.Image"), System.Drawing.Image)
        Me.CmdOk.Location = New System.Drawing.Point(90, 73)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOk.Size = New System.Drawing.Size(76, 48)
        Me.CmdOk.TabIndex = 8
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
        Me.CmdCancel.Location = New System.Drawing.Point(170, 73)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancel.Size = New System.Drawing.Size(76, 48)
        Me.CmdCancel.TabIndex = 7
        Me.CmdCancel.Text = "CANCEL"
        Me.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'cmdangka
        '
        Me.cmdangka.BackColor = System.Drawing.SystemColors.Control
        Me.cmdangka.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdangka.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdangka.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdangka.Image = CType(resources.GetObject("cmdangka.Image"), System.Drawing.Image)
        Me.cmdangka.Location = New System.Drawing.Point(10, 73)
        Me.cmdangka.Name = "cmdangka"
        Me.cmdangka.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdangka.Size = New System.Drawing.Size(76, 48)
        Me.cmdangka.TabIndex = 6
        Me.cmdangka.Text = "&NUM"
        Me.cmdangka.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdangka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdangka.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtprice)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 3)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(256, 61)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "SCAN BARCODE HARGA"
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(12, 23)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(233, 26)
        Me.txtprice.TabIndex = 35
        '
        'frmHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 123)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.cmdangka)
        Me.Controls.Add(Me.Frame1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(273, 162)
        Me.MinimumSize = New System.Drawing.Size(273, 162)
        Me.Name = "frmHarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTER PRICE"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents CmdOk As System.Windows.Forms.Button
    Public WithEvents CmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdangka As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
End Class
