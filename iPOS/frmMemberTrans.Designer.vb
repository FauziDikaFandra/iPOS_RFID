<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberTrans
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgTransactions = New System.Windows.Forms.DataGridView()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.txtMember = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDetail = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgTransactions)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transactions"
        '
        'dgTransactions
        '
        Me.dgTransactions.AllowUserToAddRows = False
        Me.dgTransactions.AllowUserToDeleteRows = False
        Me.dgTransactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgTransactions.BackgroundColor = System.Drawing.Color.White
        Me.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransactions.Location = New System.Drawing.Point(7, 20)
        Me.dgTransactions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgTransactions.Name = "dgTransactions"
        Me.dgTransactions.ReadOnly = True
        Me.dgTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransactions.Size = New System.Drawing.Size(777, 171)
        Me.dgTransactions.TabIndex = 0
        '
        'lblmsg
        '
        Me.lblmsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmsg.BackColor = System.Drawing.Color.DimGray
        Me.lblmsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblmsg.Location = New System.Drawing.Point(-7, 0)
        Me.lblmsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsg.Size = New System.Drawing.Size(830, 33)
        Me.lblmsg.TabIndex = 29
        Me.lblmsg.Text = "MEMBER TRANSACTIONS"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMember
        '
        Me.txtMember.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMember.Location = New System.Drawing.Point(161, 41)
        Me.txtMember.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMember.Name = "txtMember"
        Me.txtMember.Size = New System.Drawing.Size(262, 22)
        Me.txtMember.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Member Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgDetail)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 229)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'dgDetail
        '
        Me.dgDetail.AllowUserToAddRows = False
        Me.dgDetail.AllowUserToDeleteRows = False
        Me.dgDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDetail.BackgroundColor = System.Drawing.Color.White
        Me.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetail.Location = New System.Drawing.Point(7, 20)
        Me.dgDetail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.ReadOnly = True
        Me.dgDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetail.Size = New System.Drawing.Size(777, 197)
        Me.dgDetail.TabIndex = 0
        '
        'frmMemberTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(823, 512)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtMember)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMemberTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Trans"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents lblmsg As Label
    Friend WithEvents txtMember As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgTransactions As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgDetail As DataGridView
End Class
