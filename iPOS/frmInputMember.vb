Public Class InputMember
    Private Sub InputMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As New ArrayList
        c.Add(New CCombo("M", "MALE"))
        c.Add(New CCombo("F", "FEMALE"))
        With ComboBox1
            .DataSource = c
            .DisplayMember = "Number_Name"
            .ValueMember = "ID"
        End With
        txtcard_no.Clear()
        txtcust_name.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtPhone.Select()
        txtPhone.SelectionStart = 0
        txtPhone.Focus()
        Me.TopMost = True
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown

        Dim RsCari As New DataSet
        If e.KeyCode = Keys.Enter Then
            If txtPhone.Text = "" Then
                MsgBox("Member Not Found !!!")
                Call isi_data("LM-00000000", "ONE TIME CUSTOMER", CStr(0), "10000000", "", "", "0800000000", "", "")
                Star_Id = "10000000"
                CmdOk.Focus()
                Exit Sub
            End If
            txtcard_no.Clear()
            txtEmail.Clear()
            txtcust_name.Clear()
            If VPing = "ONLINE" Then
                RsCari = getSqldb("Select * from members where Phone = '" & txtPhone.Text.ToString.Trim & "' and STATUS ='A'", ConnServer)
            Else
                RsCari = getSqldb("Select * from members where Phone = '" & txtPhone.Text.ToString.Trim & "' and STATUS ='A'", ConnLocal)
            End If

            If RsCari.Tables(0).Rows.Count > 0 Then
                txtcard_no.Text = RsCari.Tables(0).Rows(0).Item("Member_Code")
                txtcust_name.Text = RsCari.Tables(0).Rows(0).Item("Member_Name")
                txtEmail.Text = RsCari.Tables(0).Rows(0).Item("Email")
                ComboBox1.SelectedValue = RsCari.Tables(0).Rows(0).Item("Gender")
                CmdOk.Focus()
            Else
                MsgBox("Member Not Found !!!")
                Call isi_data("LM-00000000", "ONE TIME CUSTOMER", CStr(0), "10000000", "", "", "0800000000", "", "")
                Star_Id = "10000000"
                CmdOk.Focus()
                Exit Sub
            End If
        End If

    End Sub

    Sub SubView()
        Dim RsCari As New DataSet

        If txtPhone.Text = "" Then
                MsgBox("Member Not Found !!!")
                Call isi_data("LM-00000000", "ONE TIME CUSTOMER", CStr(0), "10000000", "", "", "0800000000", "", "")
                Star_Id = "10000000"
                CmdOk.Focus()
                Exit Sub
            End If
            txtcard_no.Clear()
            txtEmail.Clear()
            txtcust_name.Clear()
            If VPing = "ONLINE" Then
                RsCari = getSqldb("Select * from members where Phone = '" & txtPhone.Text.ToString.Trim & "' and STATUS ='A'", ConnServer)
            Else
                RsCari = getSqldb("Select * from members where Phone = '" & txtPhone.Text.ToString.Trim & "' and STATUS ='A'", ConnLocal)
            End If

            If RsCari.Tables(0).Rows.Count > 0 Then
                txtcard_no.Text = RsCari.Tables(0).Rows(0).Item("Member_Code")
                txtcust_name.Text = RsCari.Tables(0).Rows(0).Item("Member_Name")
                txtEmail.Text = RsCari.Tables(0).Rows(0).Item("Email")
                ComboBox1.SelectedValue = RsCari.Tables(0).Rows(0).Item("Gender")
                CmdOk.Focus()
            Else
                MsgBox("Member Not Found !!!")
                Call isi_data("LM-00000000", "ONE TIME CUSTOMER", CStr(0), "10000000", "", "", "0800000000", "", "")
                Star_Id = "10000000"
                CmdOk.Focus()
                Exit Sub
            End If

    End Sub


    Private Sub isi_data(ByRef no_kartu As String, ByRef Nama As String, ByRef Point As String, ByRef id As String, ByRef freq As String, ByRef omz As String, ByRef telepon As String, ByRef PointEx As String, ByRef PeriodEx As String)
        txtcard_no.Text = no_kartu
        txtcust_name.Text = Nama
        frmSalesSelf.txtcust_id.Text = id
        txtPhone.Text = telepon
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
        If txtPhone.Text.ToString.Trim = "" Or txtcard_no.Text.ToString.Trim = "" Then
            'MsgBox("Member Not Found !!!")
            Call isi_data("LM-00000000", "ONE TIME CUSTOMER", CStr(0), "10000000", "", "", "0800000000", "", "")
            Star_Id = "10000000"
        End If

        If RegType = "0" Then
            frmSales.txtcard_no.Text = txtcard_no.Text
            frmSales.txtcust_name.Text = txtcust_name.Text
            frmSales.txtcust_id.Text = Replace(txtcard_no.Text, "LM-", "")
        Else
            If SecLev >= 3 Then
                frmSalesSelf.txtcard_no.Text = txtcard_no.Text
                frmSalesSelf.txtcust_name.Text = txtcust_name.Text
                frmSalesSelf.txtcust_id.Text = Replace(txtcard_no.Text, "LM-", "")
            Else
                frmSales.txtcard_no.Text = txtcard_no.Text
                frmSales.txtcust_name.Text = txtcust_name.Text
                frmSales.txtcust_id.Text = Replace(txtcard_no.Text, "LM-", "")
            End If
        End If


        Star_No = txtcard_no.Text
        Star_Nm = txtcust_name.Text
        Star_Phone = txtPhone.Text
        Me.Close()

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If VPing = "ONLINE" Then
            NewMember = True
            Me.TopMost = False
            Me.Close()
            MemberRegistration.ShowDialog()
            MemberRegistration.TopMost = True
            MemberRegistration.txtcust_name.Select()
            MemberRegistration.txtcust_name.SelectionStart = 0
            MemberRegistration.txtcust_name.Focus()
        Else
            MsgBox("Register Status is Offline!!")
        End If
    End Sub

    Private Sub CmdNav_Click(sender As Object, e As EventArgs) Handles CmdNav.Click
        frmNum.Text = "NUMBER - MEMBER"
        frmNum.ShowDialog()
        txtPhone.Focus()
    End Sub
End Class