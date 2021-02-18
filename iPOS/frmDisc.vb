Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Public Class frmDisc
    Private Sub cmdup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        List1.SelectedIndex = IIf(List1.SelectedIndex > 0, List1.SelectedIndex - 1, 0)
    End Sub
    Private Sub cmddown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        List1.SelectedIndex = IIf(List1.SelectedIndex < List1.Items.Count - 1, List1.SelectedIndex + 1, List1.Items.Count - 1)
    End Sub
    Private Sub Cmdok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        Dim RsV As New DataSet
        Dim aa, bb As String
        aa = ""
        Dim cc As Integer
        Select Case lblmsg.Text
            Case "DISCOUNT"

                If frmSales.vdisc1.Text = "0" Then
                    frmSales.vdisc1.Text = List1.Text
                Else
                    frmSales.vdisc2.Text = List1.Text
                End If

            Case "VALIDASI"
                If List1.Text = "TOTAL" Then
                    Call CetakValid(VNomor, "Total Rp. " & CDec(frmSales.vgtotal.Text).ToString("N0"), "")
                    Me.Close()
                    Exit Sub
                End If


                RsV = getSqldb("select sd.* from sales_transaction_details sd inner join item_master it " &
                               "on sd.plu=it.plu where transaction_number='" & VNomor & "' and brand='" & UbahChar((List1.Text)) & "'", ConnLocal)
                If RsV.Tables(0).Rows.Count > 0 Then
                    For Each ro As DataRow In RsV.Tables(0).Rows
                        aa = aa & vbNewLine & ro("plu") & " " & ro("Qty") & "X" & CDec((ro("price"))).ToString("N0")
                        If ro("Discount_Percentage") > 0 Then aa = aa & vbNewLine & "Disc." & ro("Discount_Percentage") & "% = " & CDec(ro("Discount_Amount")).ToString("N0")
                        If ro("ExtraDisc_pct") > 0 Then aa = aa & vbNewLine & "Disc." & ro("ExtraDisc_pct") & "% = " & CDec((ro("ExtraDisc_amt"))).ToString("N0")
                        aa = aa & vbNewLine & ro("item_description") & " Rp. " & CDec(ro("Net_Price")).ToString("N0")
                        cc = cc + ro("Net_Price")
                    Next
                End If

                If RsV.Tables(0).Rows.Count > 0 Then
                    For Each ro As DataRow In RsV.Tables(0).Rows
                        bb = vbNewLine & ro("flag_paket_discount") & "/" & VB.Left(Siapa_SPG(ro("flag_paket_discount")), 10)
                        bb = vbNewLine & "Total " & List1.Text & " Rp. " & CDec(cc).ToString("N0") & bb
                        Call CetakValid(VNomor, aa, bb)
                        Call SaveLog("Validasi Kasir : " & VKasir_ID & "/" & VKasir_Nm & "SPG : " & ro("flag_paket_discount") & "/" & VB.Left(Siapa_SPG(ro("flag_paket_discount")), 10))
                        Exit For
                    Next
                End If
                RsV.Clear()
                RsV = Nothing
            Case "VOUCHER"
                frmPayment.txtno_voc.Text = List1.Text & "-"
        End Select

        Me.Close()
    End Sub
    Private Function Siapa_SPG(ByRef kode As Object) As String
        Dim RsCari As New DataSet
        RsCari = getSqldb("select spg_id, spg_name from spg where spg_id = '" & Trim(kode) & "'", ConnLocal)
        Siapa_SPG = IIf(RsCari.Tables(0).Rows.Count > 0, RsCari.Tables(0).Rows(0).Item("spg_name"), "")
        RsCari.Clear()
        RsCari = Nothing
    End Function
    Private Sub Cmdcancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub frmDisc_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Dim RsCari As New DataSet
        List1.Items.Clear()

        Select Case lblmsg.Text
            Case "DISCOUNT"
                RsCari = getSqldb("select disc_1,disc_2,disc_3,disc_4,disc_5,disc_6,disc_7 from cash_register where branch_id = '" & VBranch_ID & "' and cash_register_id = '" & VReg_ID & "'", ConnLocal)

                List1.Items.Add(CDec(RsCari.Tables(0).Rows(0).Item("disc_1")).ToString("N0"))
                List1.Items.Add(CDec(RsCari.Tables(0).Rows(0).Item("disc_2")).ToString("N0"))
                List1.Items.Add(CDec(RsCari.Tables(0).Rows(0).Item("disc_3")).ToString("N0"))
                List1.Items.Add(CDec(RsCari.Tables(0).Rows(0).Item("disc_4")).ToString("N0"))
                List1.Items.Add(CDec(RsCari.Tables(0).Rows(0).Item("disc_5")).ToString("N0"))
                List1.Items.Add(CDec(RsCari.Tables(0).Rows(0).Item("disc_6")).ToString("N0"))
                List1.Items.Add(CDec(RsCari.Tables(0).Rows(0).Item("disc_7")).ToString("N0"))

            Case "VALIDASI"
                RsCari = getSqldb("select distinct brand from sales_transaction_details sd inner join item_master it " & "on sd.plu=it.plu where transaction_number='" & VNomor & "'", ConnLocal)

                List1.Items.Add("TOTAL")
                If RsCari.Tables(0).Rows.Count > 0 Then
                    For Each ro As DataRow In RsCari.Tables(0).Rows
                        List1.Items.Add(ro("Brand"))
                    Next
                End If
            Case "VOUCHER"
                List1.Items.Add("AA")
                List1.Items.Add("AF")
                List1.Items.Add("AM")
                List1.Items.Add("AS")
                List1.Items.Add("BG")
                List1.Items.Add("BQ")
                List1.Items.Add("BR")
                List1.Items.Add("BS")
                List1.Items.Add("BW")
                List1.Items.Add("BY")
                List1.Items.Add("CB")
                List1.Items.Add("CJ")
                List1.Items.Add("CK")
                List1.Items.Add("CM")
                List1.Items.Add("CN")
                List1.Items.Add("CY")
                List1.Items.Add("DB")
                List1.Items.Add("DE")
                List1.Items.Add("DH")
                List1.Items.Add("DK")
                List1.Items.Add("DN")
                List1.Items.Add("DP")
                List1.Items.Add("ZA")
                List1.Items.Add("ZB")
                List1.Items.Add("ZR")
                List1.SelectedIndex = 0
                Exit Sub
        End Select

        RsCari.Clear()
        RsCari = Nothing
        List1.SelectedIndex = 0
    End Sub
    Private Sub List1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles List1.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case 13
                Cmdok_Click(cmdOk, New System.EventArgs())
            Case 27
                Cmdcancel_Click(cmdCancel, New System.EventArgs())
        End Select
    End Sub

End Class