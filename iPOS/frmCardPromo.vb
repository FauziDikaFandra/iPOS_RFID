Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Public Class frmCardPromo
    Inherits System.Windows.Forms.Form
    Private Sub cmdup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdup.Click
        On Error Resume Next
        List1.SelectedIndex = IIf(List1.SelectedIndex > 0, List1.SelectedIndex - 1, 0)
    End Sub

    Private Sub cmddown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmddown.Click
        List1.SelectedIndex = IIf(List1.SelectedIndex < List1.Items.Count - 1, List1.SelectedIndex + 1, List1.Items.Count - 1)
    End Sub

    Private Sub Cmdok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        frmCard.Vpromo_id.Text = VB.Left(List1.Text, 6)
        Me.Close()
    End Sub

    Private Sub Cmdcancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        frmCard.Vpromo_id.Text = ""
        Me.Close()
    End Sub

    Private Sub frmCardPromo_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim RsCard As New DataSet

        RsCard = getSqldb("select card_promo_id + '    ' + card_promo_name + '-' + Card_Promo_Name_Long as id " & "from Card_Promotion_Name where GETDATE() between Start_Promo_Date and End_Promo_Date ", ConnLocal)

        If RsCard.Tables(0).Rows.Count > 0 Then
            For Each ro As DataRow In RsCard.Tables(0).Rows
                List1.Items.Add(ro("id"))
            Next
            List1.SelectedIndex = 0
        End If
    End Sub

    Private Sub List1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles List1.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case 13
                Cmdok_Click(Cmdok, New System.EventArgs())
            Case 27
                Cmdcancel_Click(Cmdcancel, New System.EventArgs())
        End Select
    End Sub
End Class