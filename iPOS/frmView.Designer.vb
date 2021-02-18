<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmView))
        Me.cmdangka = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdangka
        '
        Me.cmdangka.BackColor = System.Drawing.SystemColors.Control
        Me.cmdangka.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdangka.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdangka.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdangka.Image = CType(resources.GetObject("cmdangka.Image"), System.Drawing.Image)
        Me.cmdangka.Location = New System.Drawing.Point(202, 2)
        Me.cmdangka.Name = "cmdangka"
        Me.cmdangka.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdangka.Size = New System.Drawing.Size(76, 48)
        Me.cmdangka.TabIndex = 4
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
        Me.CmdCancel.Location = New System.Drawing.Point(362, 2)
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
        Me.CmdOk.Location = New System.Drawing.Point(282, 2)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOk.Size = New System.Drawing.Size(76, 48)
        Me.CmdOk.TabIndex = 5
        Me.CmdOk.Text = "OK"
        Me.CmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.SystemColors.Control
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(56, 13)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(140, 26)
        Me.txtkode.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "PLU"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(424, 312)
        Me.DataGridView1.TabIndex = 28
        '
        'frmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdangka)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(465, 417)
        Me.MinimumSize = New System.Drawing.Size(465, 417)
        Me.Name = "frmView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIEW ARTICLE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdangka As System.Windows.Forms.Button
    Public WithEvents CmdCancel As System.Windows.Forms.Button
    Public WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
