Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(Application.StartupPath & "\App.txt") Then
            Using sr As New StreamReader(Application.StartupPath & "\App.txt")
                Dim line As String
                line = sr.ReadToEnd
                Label1.Text = line
            End Using
        End If
        For Each P As Process In System.Diagnostics.Process.GetProcessesByName(Label1.Text)
            P.Kill()
        Next
        Me.Close()
    End Sub
End Class
