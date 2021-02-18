Imports VB = Microsoft.VisualBasic
Public Class frmView2
    Private Sub frmView2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.Items.Clear()
        End If
        ComboBox1.Items.Add("Description")
        ComboBox1.Items.Add("Long_Description")
        ComboBox1.Items.Add("Current_Price")
        ComboBox1.Items.Add("Article")
        ComboBox1.SelectedIndex = 0
        DataGridView1.DataSource = Nothing
        txtkode.Clear()
        txtkode.Select()
        txtkode.Focus()
        ViewDG()
    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles txtkode.TextChanged
        ViewDG()
    End Sub

    Sub ViewDG()
        DataGridView1.DataSource = Nothing
        Dim ds As New DataSet
        Dim order As String = ""
        If ComboBox1.SelectedIndex = 0 Then
            order = " Order By Description"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            order = " Order By Long_Description"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            order = " Order By Current_Price"
        End If
        'If VPing = "ONLINE" Then
        '    ds = getSqldb("select top 200 a.article_code as Article,RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,ISNULL(last_stok,0) as Stock," &
        '              "isnull(Location_Name,'') as Location from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
        '              "Location c on b.Location = c.Location  left join [POS_SERVER].dbo.t_stok d on a.PLU = d.plu where " &
        '              "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (Description " &
        '              "Like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%')" & order & "", ConnServer)
        'Else
        '    ds = getSqldb("select top 200 a.article_code as Article,RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand from Item_Master where Description " &
        '              "Like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%')" & order & "", ConnLocal)
        'End If
        ds = getSqldb("select top 200 article_code as Article,RTRIM(PLU) as PLU,Description,Long_Description,Current_Price,DP2 As SBU,Brand from Item_Master where Description like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%'" & order & "", ConnLocal)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns("Current_Price").DefaultCellStyle.Format = "N0"
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
        Try
            If RegType = "0" Then
                If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
                    frmSales.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                Else
                    frmSales.txtkode.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                End If
            Else
                If SecLev >= 3 Then
                    If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
                        frmSalesSelf.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                    Else
                        frmSalesSelf.txtkode.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                    End If
                Else
                    If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
                        frmSales.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                    Else
                        frmSales.txtkode.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                    End If
                End If
            End If


            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If RegType = "0" Then
            If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
                frmSales.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
            Else
                frmSales.txtkode.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
            End If
        Else
            If SecLev >= 3 Then
                If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
                    frmSalesSelf.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                Else
                    frmSalesSelf.txtkode.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                End If
            Else
                If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
                    frmSales.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                Else
                    frmSales.txtkode.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                End If
            End If
        End If

        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        DataGridView1.DataSource = Nothing
        Dim ds As New DataSet
        Dim order As String = ""
        If ComboBox1.SelectedIndex = 0 Then
            order = " Order By Description"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            order = " Order By Long_Description"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            order = " Order By Current_Price"
        End If
        'ds = getSqldb("select top 200 article_code as Article,RTRIM(PLU) as PLU,Description,Long_Description,Current_Price,DP2 As SBU,Brand from Item_Master where Description like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%'" & order & "", ConnLocal)
        ds = getSqldb("select top 200 article_code as Article,RTRIM(PLU) as PLU,Description,Long_Description,Current_Price,DP2 As SBU,Brand from Item_Master where Description like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%'" & order & "", ConnLocal)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns("Current_Price").DefaultCellStyle.Format = "N0"
            DataGridView1.Refresh()
        End If
    End Sub
End Class