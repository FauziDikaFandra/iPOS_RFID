Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class MemberRegistration
    Private Sub LakonMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As New ArrayList
        c.Add(New CCombo("M", "MALE"))
        c.Add(New CCombo("F", "FEMALE"))
        With ComboBox1
            .DataSource = c
            .DisplayMember = "Number_Name"
            .ValueMember = "ID"
        End With
        txtcust_name.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtcard_no.Text = Cek_No()
        txtcust_name.Select()
        txtcust_name.SelectionStart = 0
        txtcust_name.Focus()
    End Sub



    Private Function Cek_No() As String
        Dim RsCari As New DataSet

        RsCari = getSqldb("SELECT  max (CAST(RIGHT(Member_Code, 5) AS int)) AS nomor " &
                          "FROM Members where SUBSTRING(Member_Code,4,3)='" & Microsoft.VisualBasic.Right(VBranch_ID, 3) & "' ", ConnServer)

        If IsDBNull(RsCari.Tables(0).Rows(0).Item("nomor")) Then
            Cek_No = "LM-" & Microsoft.VisualBasic.Right(VBranch_ID, 3) & "00001"
        Else
            Cek_No = "LM-" & Microsoft.VisualBasic.Right(VBranch_ID, 3) & Microsoft.VisualBasic.Right("0000" & CStr(RsCari.Tables(0).Rows(0).Item("nomor") + 1), 5)
        End If
        RsCari.Clear()
        RsCari = Nothing
    End Function


    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        Dim temp As String
        temp = txtEmail.Text
        'Dim conditon As Boolean
        'emailaddresscheck(temp)
        If emailaddresscheck(temp) = False Then
            MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
            txtEmail.Text = ""
            txtEmail.BackColor = Color.Blue
        Else
            txtEmail.BackColor = Color.White
        End If
    End Sub

    Private Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        txtEmail.BackColor = Color.White
        Dim temp As String
        temp = txtEmail.Text
        Dim conditon As Boolean
        emailaddresscheck(temp)
        If emailaddresscheck(conditon) = True Then
            MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
            txtEmail.Text = ""
            txtEmail.BackColor = Color.Yellow
        Else
            txtEmail.BackColor = Color.White
        End If
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
        Dim textBoxes = Me.Controls.OfType(Of TextBox)
        For Each t In textBoxes
            If String.IsNullOrEmpty(t.Text) Then
                MsgBox("Complete Entry!")
                Exit For
            End If
        Next t
        Dim RsCari As New DataSet
        Dim NoMem As String
        NoMem = Cek_No()
        RsCari = getSqldb("select * from members where phone = '" & txtPhone.Text & "' and STATUS ='A'", ConnServer)
        If RsCari.Tables(0).Rows.Count = 0 Then
            getSqldb("insert into members values ('" & NoMem & "','" & txtcust_name.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & ComboBox1.SelectedValue & "',0,'A',getdate(),getdate())", ConnLocal)
            If VPing = "ONLINE" Then
                getSqldb("insert into members values ('" & NoMem & "','" & txtcust_name.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & ComboBox1.SelectedValue & "',0,'A',getdate(),getdate())", ConnServer)
            End If
            MsgBox("Successfull!!!")
        Else
            MsgBox("Member sudah terdaftar dengan Nama : '" & RsCari.Tables(0).Rows(0).Item("Member_Name") & "'")
            Exit Sub
        End If

        If NewMember = True Then
            frmSalesSelf.txtcard_no.Text = txtcard_no.Text
            frmSalesSelf.txtcust_name.Text = txtcust_name.Text
            frmSalesSelf.txtcust_id.Text = Replace(txtcard_no.Text, "LM-", "")
            frmSales.txtcard_no.Text = txtcard_no.Text
            frmSales.txtcust_name.Text = txtcust_name.Text
            frmSales.txtcust_id.Text = Replace(txtcard_no.Text, "LM-", "")
            Star_No = txtcard_no.Text
            Star_Nm = txtcust_name.Text
            Star_Phone = txtPhone.Text
        End If
        txtcust_name.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtcard_no.Text = Cek_No()
        txtcust_name.Select()
        txtcust_name.SelectionStart = 0
        txtcust_name.Focus()
        Me.Close()
    End Sub

    Private Sub txtcust_name_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcust_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
            txtPhone.SelectionLength = txtPhone.Text.Length
        End If
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
            txtEmail.SelectionLength = txtEmail.Text.Length
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdOk.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CmdOk.Focus()
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class