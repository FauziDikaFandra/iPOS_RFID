Public Class frmMemberTrans
    Dim dsMember, dsDetail As New DataSet
    Private Sub frmMemberTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMember.Focus()
    End Sub

    Private Sub txtMember_TextChanged(sender As Object, e As EventArgs) Handles txtMember.TextChanged
        dsMember.Clear()
        dgDetail.DataSource = Nothing
        dsMember = getSqldb("select DISTINCT top 50  b.Transaction_Number as Transactions,Phone,Member_Name as  Name,Transaction_Date as Date,b.Net_Price as Total  from " &
                            "[POS_SERVER_HISTORY].dbo.Sales_Transaction_Details a inner join [POS_SERVER_HISTORY].dbo.Sales_Transactions b on a.Transaction_Number = b.Transaction_Number   " &
                            "inner join Members c on b.Card_Number = c.Member_Code where b.Status = '00' and c.member_code <> 'LM-00000000' and (c.Phone like '" & txtMember.Text & "%' or c.Member_Name like '" & txtMember.Text & "%') order by b.Transaction_Date desc ", ConnServer)

        If dsMember.Tables(0).Rows.Count > 0 Then
            dgTransactions.DataSource = dsMember.Tables(0)
            dgTransactions.Columns("Total").DefaultCellStyle.Format = "N0"
            dgTransactions.Refresh()
        End If

    End Sub

    Private Sub dgTransactions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTransactions.CellClick
        Try
            dsDetail.Clear()
            dsDetail = getSqldb("select top 50 seq as No,a.PLU,item_description as Description,b.brand as Brand,qty as Qty,price as Price,amount as Amount,discount_amount as Disc,net_price as Total from " &
                                "[POS_SERVER_HISTORY].dbo.Sales_Transaction_Details a inner join item_master b on " &
                                "a.plu = b.plu where transaction_number = '" & dgTransactions.Item(0, e.RowIndex).Value & "'", ConnServer)
            If dsDetail.Tables(0).Rows.Count > 0 Then
                dgDetail.DataSource = dsDetail.Tables(0)
                dgDetail.Columns("No").DefaultCellStyle.Format = "N0"
                dgDetail.Columns("Qty").DefaultCellStyle.Format = "N0"
                dgDetail.Columns("Price").DefaultCellStyle.Format = "N0"
                dgDetail.Columns("Amount").DefaultCellStyle.Format = "N0"
                dgDetail.Columns("Disc").DefaultCellStyle.Format = "N0"
                dgDetail.Columns("Total").DefaultCellStyle.Format = "N0"
                dgDetail.Refresh()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class