Public Class frmSPG
    Dim dsSPG As New DataSet
    Dim x As Integer = 1
    Private Sub frmSPG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsSPG = getSqldb("Select User_ID,User_Name from USERS where security_level = 3 and password <> 'xxxx' order by User_Name", ConnLocal)
        If dsSPG.Tables(0).Rows.Count > 0 Then
            x = 1
            For Each ro As DataRow In dsSPG.Tables(0).Rows
                DirectCast(Me.Controls.Find("btn" & x, True)(0), Button).Text = ro("User_Name")
                DirectCast(Me.Controls.Find("btn" & x, True)(0), Button).Tag = ro("User_ID")
                x += 1
                If x > dsSPG.Tables(0).Rows.Count Then
                    Exit For
                End If
            Next
        End If
    End Sub



    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click _
        , btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click,
        btn17.Click, btn18.Click, btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click, btn24.Click
        Dim btn As Button = sender
        spg_btn = btn.Tag
        Me.Close()
    End Sub
End Class