<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCard))
        Me.CmdNav = New System.Windows.Forms.Button()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Vpromo_id = New System.Windows.Forms.Label()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.txtexprPoint = New System.Windows.Forms.TextBox()
        Me.txtcard_opt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtno_telp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpoint = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtomz = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfreq = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcust_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcust_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcard_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdNav
        '
        Me.CmdNav.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNav.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdNav.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNav.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdNav.Image = CType(resources.GetObject("CmdNav.Image"), System.Drawing.Image)
        Me.CmdNav.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNav.Location = New System.Drawing.Point(311, 289)
        Me.CmdNav.Name = "CmdNav"
        Me.CmdNav.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdNav.Size = New System.Drawing.Size(76, 48)
        Me.CmdNav.TabIndex = 17
        Me.CmdNav.Text = "&NUM"
        Me.CmdNav.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdNav.UseVisualStyleBackColor = False
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOk.Image = CType(resources.GetObject("CmdOk.Image"), System.Drawing.Image)
        Me.CmdOk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdOk.Location = New System.Drawing.Point(147, 289)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOk.Size = New System.Drawing.Size(76, 48)
        Me.CmdOk.TabIndex = 15
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
        Me.CmdCancel.Location = New System.Drawing.Point(229, 289)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancel.Size = New System.Drawing.Size(76, 48)
        Me.CmdCancel.TabIndex = 16
        Me.CmdCancel.Text = "CANCEL"
        Me.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'lblmsg
        '
        Me.lblmsg.BackColor = System.Drawing.Color.Red
        Me.lblmsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmsg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblmsg.Location = New System.Drawing.Point(-6, 2)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmsg.Size = New System.Drawing.Size(416, 31)
        Me.lblmsg.TabIndex = 18
        Me.lblmsg.Text = "SCAN BARCODE KARTU"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.Vpromo_id)
        Me.Frame2.Controls.Add(Me.txtPeriod)
        Me.Frame2.Controls.Add(Me.txtexprPoint)
        Me.Frame2.Controls.Add(Me.txtcard_opt)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.Controls.Add(Me.txtno_telp)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.txtpoint)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.txtomz)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.txtfreq)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.txtcust_id)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.txtcust_name)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.txtcard_no)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(5, 35)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(395, 248)
        Me.Frame2.TabIndex = 20
        Me.Frame2.TabStop = False
        '
        'Vpromo_id
        '
        Me.Vpromo_id.BackColor = System.Drawing.Color.Transparent
        Me.Vpromo_id.Cursor = System.Windows.Forms.Cursors.Default
        Me.Vpromo_id.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vpromo_id.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Vpromo_id.Location = New System.Drawing.Point(288, 176)
        Me.Vpromo_id.Name = "Vpromo_id"
        Me.Vpromo_id.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Vpromo_id.Size = New System.Drawing.Size(101, 26)
        Me.Vpromo_id.TabIndex = 44
        Me.Vpromo_id.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPeriod
        '
        Me.txtPeriod.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriod.Location = New System.Drawing.Point(234, 208)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(155, 25)
        Me.txtPeriod.TabIndex = 43
        '
        'txtexprPoint
        '
        Me.txtexprPoint.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexprPoint.Location = New System.Drawing.Point(144, 208)
        Me.txtexprPoint.Name = "txtexprPoint"
        Me.txtexprPoint.Size = New System.Drawing.Size(84, 25)
        Me.txtexprPoint.TabIndex = 42
        '
        'txtcard_opt
        '
        Me.txtcard_opt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard_opt.Location = New System.Drawing.Point(144, 176)
        Me.txtcard_opt.Name = "txtcard_opt"
        Me.txtcard_opt.Size = New System.Drawing.Size(127, 25)
        Me.txtcard_opt.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(207, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "NO TELP"
        '
        'txtno_telp
        '
        Me.txtno_telp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_telp.Location = New System.Drawing.Point(277, 144)
        Me.txtno_telp.Name = "txtno_telp"
        Me.txtno_telp.Size = New System.Drawing.Size(112, 25)
        Me.txtno_telp.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "EXPIRED POINT"
        '
        'txtpoint
        '
        Me.txtpoint.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoint.Location = New System.Drawing.Point(144, 144)
        Me.txtpoint.Name = "txtpoint"
        Me.txtpoint.Size = New System.Drawing.Size(60, 25)
        Me.txtpoint.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "KARTU PROMO"
        '
        'txtomz
        '
        Me.txtomz.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtomz.Location = New System.Drawing.Point(210, 112)
        Me.txtomz.Name = "txtomz"
        Me.txtomz.Size = New System.Drawing.Size(179, 25)
        Me.txtomz.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "JUMLAH POINT"
        '
        'txtfreq
        '
        Me.txtfreq.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfreq.Location = New System.Drawing.Point(144, 112)
        Me.txtfreq.Name = "txtfreq"
        Me.txtfreq.Size = New System.Drawing.Size(60, 25)
        Me.txtfreq.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "JUMLAH TRANS"
        '
        'txtcust_id
        '
        Me.txtcust_id.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcust_id.Location = New System.Drawing.Point(144, 80)
        Me.txtcust_id.Name = "txtcust_id"
        Me.txtcust_id.Size = New System.Drawing.Size(245, 25)
        Me.txtcust_id.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "NO ID CUSTOMER"
        '
        'txtcust_name
        '
        Me.txtcust_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcust_name.Location = New System.Drawing.Point(144, 48)
        Me.txtcust_name.Name = "txtcust_name"
        Me.txtcust_name.Size = New System.Drawing.Size(245, 25)
        Me.txtcust_name.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "NAMA CUSTOMER"
        '
        'txtcard_no
        '
        Me.txtcard_no.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard_no.Location = New System.Drawing.Point(144, 16)
        Me.txtcard_no.Name = "txtcard_no"
        Me.txtcard_no.Size = New System.Drawing.Size(113, 25)
        Me.txtcard_no.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "MYSTAR CARD NO"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.White
        Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Shape1.FillColor = System.Drawing.Color.Black
        Me.Shape1.Location = New System.Drawing.Point(10, 287)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(121, 51)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(406, 348)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'frmCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.CmdNav)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(422, 387)
        Me.MinimumSize = New System.Drawing.Size(422, 387)
        Me.Name = "frmCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MYSTAR CARD"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents CmdNav As System.Windows.Forms.Button
    Public WithEvents CmdOk As System.Windows.Forms.Button
    Public WithEvents CmdCancel As System.Windows.Forms.Button
    Public WithEvents lblmsg As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtno_telp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtpoint As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtomz As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfreq As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcust_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcust_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcard_no As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPeriod As System.Windows.Forms.TextBox
    Friend WithEvents txtexprPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtcard_opt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Public WithEvents Vpromo_id As System.Windows.Forms.Label
End Class
