Public Class frmFirstForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EODFirstForm = True
        frmSOD.Text = "EOD"
        frmSOD.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        frmShowStock.Show()
    End Sub

    Private Sub FirstForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CDisplay("  ", "*** LAKON ***")
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    sendMessage("081806241210", "tes")
    'End Sub
End Class