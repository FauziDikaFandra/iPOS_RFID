Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Public Class frmCard
    Inherits System.Windows.Forms.Form
    Private Sub Cmdcancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
    Private Sub Cmdok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOk.Click
        If txtcard_no.Text = "" Then
            Call isi_data("CM000-00000", "ONE TIME CUSTOMER", CStr(0), "100000", "", "", "", "", "")
            Star_Id = "100000"
            Exit Sub
        End If

        If txtcard_opt.Text <> "" Then optKeyDown13()

        VBonus_Point = 1
        frmSalesSelf.Text = Me.Text

        frmSalesSelf.txtcust_id.Text = txtcust_id.Text
        Star_No = txtcard_no.Text
        Star_Nm = txtcust_name.Text
        Star_Phone = txtno_telp.Text

        If txtcard_no.Text <> "CM000-00000" Then
            Call Cek_Bonus_Point()
            Call CDisplay(UCase(txtcard_no.Text), VB.Left(txtcust_name.Text, 20))
        End If

        Me.Close()
        frmMain.Close()
        frmSalesSelf.Show()
    End Sub
    Private Sub isi_data(ByRef no_kartu As String, ByRef Nama As String, ByRef Point As String, ByRef id As String, ByRef freq As String, ByRef omz As String, ByRef telepon As String, ByRef PointEx As String, ByRef PeriodEx As String)
        txtcard_no.Text = no_kartu
        txtcust_name.Text = Nama
        txtpoint.Text = Point
        txtcust_id.Text = id
        txtfreq.Text = freq
        If omz.ToString.Trim = "" Then
            txtomz.Text = ""
        Else
            txtomz.Text = CDec(omz).ToString("N0")
        End If
        txtno_telp.Text = telepon
        txtexprPoint.Text = PointEx
        If Point <= PointEx Then
            txtexprPoint.Text = CStr(0)
        End If
        If omz.ToString.Trim = "" Then
            txtPeriod.Text = ""
        Else
            txtPeriod.Text = Format(CDate(PeriodEx), "dd-MMM-yyyy")
        End If
    End Sub
    Private Sub Cek_Bonus_Point()
        Dim RsPoint As New DataSet
        Dim Hari As Byte

        Hari = IIf(Weekday(GetSrvDate) = 1, 7, Weekday(GetSrvDate) - 1)

        RsPoint = getSqldb("select isnull(point,0) as point, substring(activeday," & Hari & ",1) as act_day " & "from cust_param_bonus where jenis_kartu='CM' and status_active='1' and GETDATE() between Start and Finish and substring(activeday," & Hari & ",1)='1'", ConnLocal)
        If RsPoint.Tables(0).Rows.Count > 0 Then
            VBonus_Point = IIf(VBonus_Point < RsPoint.Tables(0).Rows(0).Item("Point"), RsPoint.Tables(0).Rows(0).Item("Point"), VBonus_Point)
        End If
    End Sub
    Private Sub cmdok_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CmdOk.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = 27 Then Me.Close()
    End Sub
    Private Sub frmCard_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call isi_data("", "", "", "", "", "", "", "", "")
        VIsSSC = False
        VIsKKG = False
        txtcard_no.Select()
        txtcard_no.Focus()
    End Sub
    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        lblmsg.ForeColor = System.Drawing.ColorTranslator.FromOle(IIf(System.Drawing.ColorTranslator.ToOle(lblmsg.ForeColor) = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)))
        If Len(txtcard_no.Text) <> 11 Then txtcard_no.Text = ""
    End Sub
    Private Sub txtcard_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcard_no.KeyDown
        Select Case e.KeyCode
            Case 13
                Shape1.BackColor = System.Drawing.Color.White
                txtcard_no.Text = UCase(txtcard_no.Text)
                If VB.Left(txtcard_no.Text, 2) <> "CM" Then
                    Call isi_data("CM000-00000", "ONE TIME CUSTOMER", CStr(0), "100000", "", "", "", "", "")
                    Star_Id = "100000"
                    CmdOk.Focus()
                    GoTo 1
                End If

                'If Linked() Then
                '    getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" & txtcard_no.Text & "' and Card_Status = 'D'", ConnServer)
                'Else
                '    getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" & txtcard_no.Text & "' and Card_Status = 'D'", ConnLocal)
                'End If

                'tanpa cek PING
                If VPing = "ONLINE" Then
                    getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" & txtcard_no.Text & "' and Card_Status = 'D'", ConnServer)
                Else
                    getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" & txtcard_no.Text & "' and Card_Status = 'D'", ConnLocal)
                End If
                Call MySTAR(txtcard_no.Text)
                If Star_Id = "100000" Then
                    Call isi_data("CM000-00000", "ONE TIME CUSTOMER", CStr(0), "100000", "", "", "", "", "")
                    Star_Id = "100000"
                Else
                    Call isi_data(txtcard_no.Text, Star_Nm, CStr(Star_Pt), Star_Id, Star_Freq, Star_Omz, "", Exp_Point, Expired_Date)
                    'If Linked() And Star_updsts = 0 Then
                    'tanpa cek PING
                    If VPing = "ONLINE" And Star_updsts = 0 Then
                        Call CDisplay(Star_Phone, VB.Left(Star_Email, 20))
                        Shape1.BackColor = System.Drawing.Color.Blue
                        Star_No = txtcard_no.Text

                        If MsgBox("Apakah Customer ingin mengupdate data?", MsgBoxStyle.YesNo + MsgBoxStyle.OkOnly, "Oops..") = MsgBoxResult.Yes Then
                            Call CetakData()
                        End If
                    End If
                    If Mid(txtcard_no.Text, 1, 5) = "CM999" And Linked() Then
                            If Not IsNumeric(Star_Ext1) Then
                            Else
                                If CDbl(Star_Ext1) <> 0 Then
                                    MsgBox("Sisa potongan karyawan anda senilai Rp." & FormatNumber(Star_Ext1, 0, True, True, True) & " !!!")
                                End If
                            End If
                        End If
                    End If
                    txtcard_opt.Focus()
            Case 27
                Me.Close()
        End Select
1:
        If e.KeyCode = Keys.Enter Then
            'Menghilangkan Bunyi Beep
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtcard_opt_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcard_opt.Enter
        If txtcard_no.Text = "CM000-00000" Then CmdOk.Focus()
    End Sub
    Sub optKeyDown13()
        Dim RsCari As New DataSet
        If VB.Left(txtcard_opt.Text, 2) = "CM" Or Len(txtcard_opt.Text) < 3 Or Len(txtcard_opt.Text) = 13 Then txtcard_opt.Text = ""
        If txtcard_no.Text = "CM000-00000" Or txtcard_opt.Text = "" Then
            CmdOk.Focus()
            Exit Sub
        End If

        StrSQL = "select * from card_promotion cp inner join card_promotion_name cn on cp.card_promo_id = cn.card_promo_id " & "where card_nr='" & txtcard_no.Text & "' and card_nr_promo = '" & txtcard_opt.Text & "'"

        'If Linked() Then
        '    getSqldb(StrSQL, ConnServer)
        'Else
        '    getSqldb(StrSQL, ConnLocal)
        'End If
        'tanpa cek PING
        If VPing = "ONLINE" Then
            getSqldb(StrSQL, ConnServer)
        Else
            getSqldb(StrSQL, ConnLocal)
        End If
        If RsCari.Tables(0).Rows.Count > 0 Then
            Select Case RsCari.Tables(0).Rows(0).Item("card_promo_id")
                Case "CPN001"
                    If GetSrvDate() >= RsCari.Tables(0).Rows(0).Item("start_promo_date") And GetSrvDate() <= RsCari.Tables(0).Rows(0).Item("end_promo_date") Then
                        'Promo SSC hanya untuk weekday saja
                        If (RsCari.Tables(0).Rows(0).Item("card_promo_id") = "CPN001" And Weekday(GetSrvDate) = 6) Or (RsCari.Tables(0).Rows(0).Item("card_promo_id") = "CPN001" And Weekday(GetSrvDate) = 7) Or (RsCari.Tables(0).Rows(0).Item("card_promo_id") = "CPN001" And Weekday(GetSrvDate) = 1) Then
                            MsgBox("Promo hanya berlaku weekday (Senin-Kamis)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops..")
                            VBonus_Point = 1
                        Else
                            VBonus_Point = RsCari.Tables(0).Rows(0).Item("point_bonus")
                        End If
                        VIsSSC = True
                    Else
                        VBonus_Point = 1
                    End If
                    MsgBox("Bonus Point = " & VBonus_Point, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops..")
                    Call Cmdok_Click(CmdOk, New System.EventArgs())
                    Exit Sub
                Case "CPN002"
                    If GetSrvDate() >= RsCari.Tables(0).Rows(0).Item("start_promo_date") And GetSrvDate() <= RsCari.Tables(0).Rows(0).Item("end_promo_date") Then
                        VIsKKG = True
                    End If
            End Select
        Else
            If MsgBox("Daftarkan kartu promo baru?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Oops..") = MsgBoxResult.Ok Then
                frmCardPromo.ShowDialog()
                If Vpromo_id.Text <> "" Then

                    StrSQL = "select * from card_promotion where card_nr_promo ='" & txtcard_opt.Text & "' and card_promo_id = '" & Vpromo_id.Text & "'"

                    'If Linked() Then
                    '    getSqldb(StrSQL, ConnServer)
                    'Else
                    '    getSqldb(StrSQL, ConnLocal)
                    'End If

                    'tanpa cek PING
                    If VPing = "ONLINE" Then
                        getSqldb(StrSQL, ConnServer)
                    Else
                        getSqldb(StrSQL, ConnLocal)
                    End If

                    If RsCari.Tables(0).Rows.Count > 0 Then
                        MsgBox("Kartu joint promo sudah pernah ada, harap hubungi information counter", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
                        Exit Sub
                    End If
                    StrSQL = ("insert into Card_Promotion (Card_Nr, Card_Nr_Promo, Card_Promo_Id, Card_Expired_date, " & "Card_Activate_Date, Card_Status, User_Id_Activate) values ('" & txtcard_no.Text & "','" & txtcard_opt.Text & "','" & Vpromo_id.Text & "',getdate()+1825, getdate(), 'A', '" & VKasir_ID & "')")

                    getSqldb(StrSQL, ConnLocal)
                    'If Linked() Then getSqldb(StrSQL, ConnServer)

                    'tanpa cek PING
                    If VPing = "ONLINE" Then getSqldb(StrSQL, ConnServer)
                End If
            End If
            txtcard_opt.Focus()
            System.Windows.Forms.SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        CmdOk.Focus()
    End Sub
    Private Sub txtcard_opt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcard_opt.KeyDown
        On Error GoTo ErrH
        Dim RsDobel As New DataSet
        Select Case e.KeyCode
            Case 13
                optKeyDown13()
            Case 27
                Me.Close()
        End Select
        Exit Sub
ErrH:
        If Err.Number = CDbl("-2147217873") Then
            MsgBox("Kartu promo sudah pernah ada, harap hubungi information counter", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        Else
            MsgBox(UCase(Err.Description), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
        End If
        Call SaveLog(Me.Name & " " & "Simpan Kartu Promo " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
    End Sub
    Private Sub CmdNav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNav.Click
        frmNum.Text = "NUMBER - CARD"
        frmNum.ShowDialog()
        txtcard_opt.Focus()
    End Sub
End Class