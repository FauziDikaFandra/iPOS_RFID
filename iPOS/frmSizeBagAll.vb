Public Class frmSizeBagAll
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dsBag As New DataSet
        If VPing = "ONLINE" Then
            dsBag = getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", ConnServer)
        Else
            dsBag = getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", ConnLocal)
        End If

        If dsBag.Tables(0).Rows.Count > 0 Then
            frmSales.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
        Else
            frmSales.txtkode.Text = ""
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Me.TopMost = False
        'Me.Hide()
        'frmSizeBag.Text = "PLASTIC"
        'frmSizeBag.Tag = "ALL"
        'frmSizeBag.ShowDialog()
        'frmSizeBag.TopMost = True
        Dim dsBag As New DataSet
        If VPing = "ONLINE" Then
            dsBag = getSqldb("Select * from Bag where Bag = 'PLASTIC' and Size = 'M'", ConnServer)
        Else
            dsBag = getSqldb("Select * from Bag where Bag = 'PLASTIC' and Size = 'M'", ConnLocal)
        End If

        If dsBag.Tables(0).Rows.Count > 0 Then
            frmSales.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
        Else
            frmSales.txtkode.Text = ""
        End If
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TopMost = False
        Me.Hide()
        frmSizeBag.Text = "TOTE BAG"
        frmSizeBag.Tag = "ALL"
        frmSizeBag.ShowDialog()
        frmSizeBag.TopMost = True
    End Sub
End Class