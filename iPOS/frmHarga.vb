Public Class frmHarga
    Private Sub cmdangka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdangka.Click
        frmNum.Text = "NUMBER - HARGA"
        frmNum.Label2.Text = "HARGA"
        frmNum.ShowDialog()
    End Sub
    Private Sub Cmdcancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
    Private Sub Cmdok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOk.Click
        txtprice.Focus()
        System.Windows.Forms.SendKeys.Send("{enter}")
    End Sub
    Private Sub txtprice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprice.KeyDown
        Dim Berapa As Double
        Select Case e.KeyCode
            Case 13
                If txtprice.Text = "" Then Exit Sub
                Berapa = CDbl(txtprice.Text)
                If Microsoft.VisualBasic.Left(txtprice.Text, 2) = "27" And Len(txtprice.Text) = 13 Then
                    Berapa = CDbl(Mid(txtprice.Text, 3, 10))
                End If
                If Berapa > 99999998 Then
                    MsgBox("Harga yang anda masukkan salah", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..")
                    txtprice.Focus()
                    System.Windows.Forms.SendKeys.Send("{home}+{end}")
                    Exit Sub
                End If

                frmSalesSelf.vharga.Text = CStr(Berapa)
                frmSales.vharga.Text = CStr(Berapa)
                VOK = True
                Me.Close()
            Case 27
                Me.Close()
                frmSalesSelf.txtkode.Text = ""
                frmSales.txtkode.Text = ""
                frmSalesSelf.txtkode.Focus()
                frmSales.txtkode.Focus()
        End Select
        If e.KeyCode = Keys.Enter Then
            'Menghilangkan Bunyi Beep
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        If txtprice.Text <> "" Then
            txtprice.Text = CDec(txtprice.Text).ToString("N0")
            txtprice.SelectionStart = txtprice.TextLength
        End If
    End Sub

    Private Sub frmHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtprice.Select()
        txtprice.Text = ""
        txtprice.Focus()
    End Sub

End Class