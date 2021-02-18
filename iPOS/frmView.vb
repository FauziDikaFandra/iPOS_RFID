Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Public Class frmView
    Inherits System.Windows.Forms.Form

    Private Sub cmdangka_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdangka.Click
        frmNum.Text = "NUMBER - VIEW"
        frmNum.Label2.Text = "PLU"
        frmNum.ShowDialog()
    End Sub

    Private Sub Cmdcancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Cmdok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOk.Click
        If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
            frmSalesSelf.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Else
            frmSalesSelf.txtkode.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If VB.Right(frmSalesSelf.txtkode.Text, 1) = "*" Then
            frmSalesSelf.txtkode.Text = frmSalesSelf.txtkode.Text & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Else
            frmSalesSelf.txtkode.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        End If
        Me.Close()
    End Sub


    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        Select Case e.KeyCode
            Case 13
                Call Cmdok_Click(CmdOk, New System.EventArgs())
            Case 27
                txtkode.Focus()
        End Select
    End Sub

    Sub SubNum()
        If txtkode.Text = "" Then Exit Sub
        Dim DsCek As New DataSet
        DsCek = getSqldb("select top 200 plu As PLU, Description, current_price As Harga from item_master where PLU like '%" & txtkode.Text & "%'" & "and description <> 'TIDAK AKTIF'", ConnLocal)
        Me.Text = "VIEW ARTICLE - "
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = DsCek.Tables(0)
        DataGridView1.Columns("Harga").DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 190
        DataGridView1.Columns(2).Width = 60
        DataGridView1.Focus()
    End Sub

    Private Sub txtkode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkode.KeyDown
        Select Case e.KeyCode
            Case 13
                If txtkode.Text = "" Then Exit Sub

                Dim DsCek As New DataSet
                DsCek = getSqldb("select top 200 plu As PLU, Description, current_price As Harga from item_master where PLU like '%" & txtkode.Text & "%'" & "and description <> 'TIDAK AKTIF'", ConnLocal)
                Me.Text = "VIEW ARTICLE - "
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = DsCek.Tables(0)
                DataGridView1.Columns("Harga").DefaultCellStyle.Format = "N0"
                DataGridView1.Columns(0).Width = 110
                DataGridView1.Columns(1).Width = 190
                DataGridView1.Columns(2).Width = 60
                DataGridView1.Focus()
            Case 27
                Me.Close()
        End Select
    End Sub

    Private Sub frmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Nothing
        txtkode.Clear()
        txtkode.Select()
        txtkode.Focus()
    End Sub
End Class