
Public Class frmSizeBag
    Dim dsBag As New DataSet
    Dim SqlStr As String = ""
    Private Sub RfidScan2_Click(sender As Object, e As EventArgs) Handles RfidScan2.Click
        dsBag.Clear()
        If Me.Text = "PAPER BAG" Then
            SqlStr = "Select * from Bag where Bag = 'PAPER BAG' and Size = 'S'"
        ElseIf Me.Text = "PLASTIC" Then
            SqlStr = "Select * from Bag where Bag = 'PLASTIC' and Size = 'S'"
        ElseIf Me.Text = "TOTE BAG" Then
            SqlStr = "Select * from Bag where Bag = 'TOTE BAG' and Size = 'S'"
        End If
        If VPing = "ONLINE" Then
            dsBag = getSqldb(SqlStr, ConnServer)
        Else
            dsBag = getSqldb(SqlStr, ConnLocal)
        End If
        If Me.Tag = "ALL" Then
            If dsBag.Tables(0).Rows.Count > 0 Then
                frmSales.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
            Else
                frmSales.txtkode.Text = ""
            End If
            frmSizeBagAll.Close()
        Else
            If dsBag.Tables(0).Rows.Count > 0 Then
                frmSalesSelf.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
            Else
                frmSalesSelf.txtkode.Text = ""
            End If
        End If

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dsBag.Clear()
        If Me.Text = "PAPER BAG" Then
            SqlStr = "Select * from Bag where Bag = 'PAPER BAG' and Size = 'M'"
        ElseIf Me.Text = "PLASTIC" Then
            SqlStr = "Select * from Bag where Bag = 'PLASTIC' and Size = 'M'"
        ElseIf Me.Text = "TOTE BAG" Then
            SqlStr = "Select * from Bag where Bag = 'TOTE BAG' and Size = 'M'"
        End If
        If VPing = "ONLINE" Then
            dsBag = getSqldb(SqlStr, ConnServer)
        Else
            dsBag = getSqldb(SqlStr, ConnLocal)
        End If
        If Me.Tag = "ALL" Then
            If dsBag.Tables(0).Rows.Count > 0 Then
                frmSales.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
            Else
                frmSales.txtkode.Text = ""
            End If
            frmSizeBagAll.Close()
        Else
            If dsBag.Tables(0).Rows.Count > 0 Then
                frmSalesSelf.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
            Else
                frmSalesSelf.txtkode.Text = ""
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dsBag.Clear()
        If Me.Text = "PAPER BAG" Then
            SqlStr = "Select * from Bag where Bag = 'PAPER BAG' and Size = 'L'"
        ElseIf Me.Text = "PLASTIC" Then
            SqlStr = "Select * from Bag where Bag = 'PLASTIC' and Size = 'L'"
        ElseIf Me.Text = "TOTE BAG" Then
            SqlStr = "Select * from Bag where Bag = 'TOTE BAG' and Size = 'L'"
        End If
        If VPing = "ONLINE" Then
            dsBag = getSqldb(SqlStr, ConnServer)
        Else
            dsBag = getSqldb(SqlStr, ConnLocal)
        End If
        If Me.Tag = "ALL" Then
            If dsBag.Tables(0).Rows.Count > 0 Then
                frmSales.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
            Else
                frmSales.txtkode.Text = ""
            End If
            frmSizeBagAll.Close()
        Else
            If dsBag.Tables(0).Rows.Count > 0 Then
                frmSalesSelf.txtkode.Text = Trim(dsBag.Tables(0).Rows(0).Item("PLU"))
            Else
                frmSalesSelf.txtkode.Text = ""
            End If
        End If
        Me.Close()
    End Sub
End Class