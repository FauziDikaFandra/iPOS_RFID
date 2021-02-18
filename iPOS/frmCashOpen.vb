Option Strict Off
Option Explicit On
Imports System
Public Class frmCashOpen
    Inherits System.Windows.Forms.Form

    Private Sub _btnNum_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnNum_0.Click, _btnNum_1.Click, _
     _btnNum_2.Click, _btnNum_3.Click, _btnNum_4.Click, _btnNum_5.Click, _btnNum_6.Click, _btnNum_7.Click, _btnNum_8.Click, _
     _btnNum_9.Click, _btnNum_10.Click, _btnNum_11.Click, _btnNum_12.Click, _btnNum_13.Click

        Dim btn As Button = sender

        If CInt(btn.Tag) < 10 Then txtangka.Text = txtangka.Text & btn.Text

        Select Case CInt(btn.Tag)
            Case 10
                txtangka.Focus()
                System.Windows.Forms.SendKeys.Send("{end}+{backspace}")
            Case 11
                If txtangka.Text = "" Then Exit Sub
                getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnLocal)
                'If Linked() Then
                '    getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnServer)
                'End If
                'tanpa cek PING
                If VPing = "ONLINE" Then
                    getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnServer)
                End If

                VCopen = True
                Call OpenLaci(0)
                Me.Close()
            Case 12
                txtangka.Text = ""
            Case 13
                Me.Close()
        End Select

    End Sub

    Private Sub txtangka_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtangka.KeyDown
        Select Case e.KeyCode
            Case 13
                If txtangka.Text = "" Then Exit Sub
                getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnLocal)
                'If Linked() Then
                '    getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnServer)
                'End If
                'tanpa cek PING
                If VPing = "ONLINE" Then
                    getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnServer)
                End If

                VCopen = True
                Call OpenLaci(0)
                Me.Close()
            Case 27
                Me.Close()
        End Select
    End Sub

    Private Sub frmCashOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtangka.Select()
        txtangka.Focus()
    End Sub

    Private Sub txtangka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtangka.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class