Imports System.ComponentModel

Public Class frmSOD
    Inherits System.Windows.Forms.Form
    Dim Dbs As String, Svr As String
    Private Sub Chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Chk.CheckStateChanged
        Dim Index As Short = Chk.GetIndex(eventSender)
    End Sub
    Private Sub frmSOD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CheckForIllegalCrossThreadCalls = False
        Dbs = ReadIni("Server", "DatabaseName")
        Svr = "[" & VSvr & "]"
    End Sub
    Private Sub frmSOD_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'CheckForIllegalCrossThreadCalls = False
        Dim RsSOD As New DataSet

        StrSQL = "select flag_sod from branches where branch_id ='" & VBranch_ID & "'"

        If VPing = "ONLINE" Then
            RsSOD = getSqldb(StrSQL, ConnServer)
            If RsSOD.Tables(0).Rows(0).Item("Flag_SOD") = 0 Then
                MsgBox("Server belum SOD..", vbCritical + vbOKOnly, "Oops..")
                Me.Close()
                End
            End If
        End If

        ' "server"


        ' "local"
        RsSOD = getSqldb(StrSQL, ConnLocal)
        If VPing = "ONLINE" Then
            If RsSOD.Tables(0).Rows(0).Item("Flag_SOD") = 0 Then
                Me.Text = "SOD"
                Proses_SOD()
                'frmLogin.Show()
            Else
                Me.Text = "EOD"
                BackgroundWorker1.WorkerReportsProgress = True
                BackgroundWorker1.WorkerSupportsCancellation = True
                BackgroundWorker1.RunWorkerAsync()
                'Proses_EOD()

            End If
        Else

            If RsSOD.Tables(0).Rows(0).Item("Flag_SOD") = 0 Then
                Me.Text = "SOD OFFLINE"
                getSqldb("update branches set flag_sod=1,date_current = getdate() where branch_id='" & VBranch_ID & "'", ConnLocal)
                Call SaveLog(Me.Name & " SOD OFFLINE SUCESS!!! @" & Now)
            End If

            frmLogin.Show()
            Me.Close()
        End If

        'ProgressBar1.Visible = True
        'ProgressBar1.Value = 0
        'CheckForIllegalCrossThreadCalls = False
        'BackgroundWorker1.WorkerReportsProgress = True
        'BackgroundWorker1.WorkerSupportsCancellation = True
        'BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub Proses_SOD()
        Try
            ProgressBar1.Value = 0
            Dim b As Byte
            lblmsg.Text = "DOWNLOAD DATA.."
            Frame2.Visible = False
            Frame1.Visible = True
            Dim Prg As Decimal = 0
            getSqldb("exec spp_BackupLocalTable", ConnLocal)
            For b = 0 To 10
                Prg += 100 / 10
                Chk(b).CheckState = System.Windows.Forms.CheckState.Checked
                Select Case b
                    Case 0 : getSqldb("exec spp_DownLoadItemMaster '" & Svr & "','" & Dbs & "',''", ConnLocal)
                    'Case 1 : getSqldb("exec spp_DownLoadPaymentTypes '" & Svr & "','" & Dbs & "'", ConnLocal)
                    'Case 2 : getSqldb("exec spp_DownLoadBinCard '" & Svr & "','" & Dbs & "'", ConnLocal)
                    Case 3 : getSqldb("exec spp_DownLoadUsers '" & Svr & "','" & Dbs & "'", ConnLocal)
                    'Case 4 : getSqldb("exec spp_DownLoadBranchAttributes '" & VBranch_ID & "','" & Svr & "','" & Dbs & "'", ConnLocal)
                    Case 5 : getSqldb("exec spp_DownLoadMC '" & Svr & "','" & Dbs & "'", ConnLocal)
                    Case 6 : getSqldb("exec spp_DownLoadUserBO '" & Svr & "','" & Dbs & "'", ConnLocal)
                    Case 7 : getSqldb("exec spp_DownloadCashRegister '" & VReg_ID & "','" & VBranch_ID & "','" & Svr & "','" & Dbs & "'", ConnLocal)
                    'Case 8 : getSqldb("exec spp_DownLoadCpoint '" & Svr & "','" & Dbs & "'", ConnLocal)
                    Case 9 : getSqldb("exec spp_DownLoadOthers '" & Svr & "','" & Dbs & "'", ConnLocal)
                    Case 10 : getSqldb("exec spp_DownLoadRFID '" & Svr & "','" & Dbs & "'", ConnLocal)
                End Select
                'If Int(Prg) <= 100 Then
                '    BackgroundWorker1.ReportProgress(Int(Prg))
                'End If

            Next b

            getSqldb("update branches set flag_sod=1,date_current = getdate() where branch_id='" & VBranch_ID & "'", ConnLocal)
            'Me.Close()
            'Exit Sub

            frmFirstForm.Show()
            'frmShowStock.Show()
        Catch ex As Exception
            MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "SOD " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try
    End Sub
    Private Sub Proses_EOD()
        Try
            ProgressBar1.Value = 0
            lblmsg.Text = "UPLOAD DATA.."
            Frame2.Visible = True
            Frame1.Visible = False
            If VPing = "ONLINE" Then
                BackgroundWorker1.ReportProgress(Int(20))
                Call Naikin_Data()
                BackgroundWorker1.ReportProgress(Int(40))
                'Call Naikin_Promo()
                BackgroundWorker1.ReportProgress(Int(60))
                'Call Naikin_Point()
                'Call Update_RfidCode()
                BackgroundWorker1.ReportProgress(Int(80))
            End If
            Me.Close()
            Exit Sub
        Catch ex As Exception
            'MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "EOD " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try
    End Sub
    Private Sub Naikin_Data()
        Try
            Dim RsA As New DataSet
            RsA = getSqldb("SELECT Transaction_Number From SALES_TRANSACTIONS Where upload_Status ='00' And Status <> '01'", ConnLocal)

            If RsA.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In RsA.Tables(0).Rows
                    StrSQL = "DELETE " & Svr & "." & Dbs & ".dbo.Sales_Transactions  WHERE transaction_number= '" & ro("Transaction_Number") & "'"

                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.Sales_Transactions " &
                    "(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, Transaction_Date " &
                    ", Total_Discount, Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, Payment_program_ID " &
                    ", Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, Flag_Arrange, WorkManShip " &
                    ", Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, Last_Point, Get_Point " &
                    ", Status, upload_status, Transaction_Time, Store_Type ) " &
                    "SELECT Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, Transaction_Date, " &
                    "Total_Discount, Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, Payment_program_ID, " &
                    "Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, Flag_Arrange, WorkManShip, " &
                    "Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, Last_Point, Get_Point, " &
                    "Status , upload_status, Transaction_Time, Store_Type " &
                    "FROM SALES_TRANSACTIONS  WHERE transaction_number= '" & ro("Transaction_Number") & "'"

                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "DELETE " & Svr & "." & Dbs & ".dbo.Sales_Transaction_Details WHERE transaction_number= '" & ro("Transaction_Number") & "'"

                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.Sales_Transaction_details " &
                    "(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, Discount_Percentage,  " &
                    "Discount_Amount, extradisc_pct, extradisc_amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " &
                    "SELECT Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, Discount_Percentage,  " &
                    "Discount_Amount, extradisc_pct, extradisc_amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code " &
                    "FROM Sales_Transaction_details WHERE transaction_number= '" & ro("Transaction_Number") & "'"

                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "DELETE " & Svr & "." & Dbs & ".dbo.paid WHERE transaction_number= '" & ro("Transaction_Number") & "'"

                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.paid " &
                    "(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No,  " &
                    "Credit_Card_Name, Paid_Amount, Shift)  " &
                    "SELECT Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No,   " &
                    "Credit_Card_Name, Paid_Amount, Shift  " &
                    "From PAID  WHERE transaction_number= '" & ro("Transaction_Number") & "'"

                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "update sales_transactions set upload_status='99' WHERE transaction_number= '" & ro("Transaction_Number") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "delete from " & Svr & "." & Dbs & ".dbo.cash where branch_id='" & VBranch_ID & "' and Cash_Register_ID ='" & VReg_ID & "' and Datetime = '" &
                    GetSrvDate.Date & "'"

                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "Insert  " & Svr & "." & Dbs & ".dbo.cash " &
                    "(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, Voucher, " &
                    "Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, Deposit, Other_Income, Netto, " &
                    "Discount, Tax, [Returns] , No_Sale, Cancel) " &
                    "SELECT Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, Voucher, " &
                    "Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, Deposit, Other_Income, Netto,  " &
                    "Discount, Tax, [Returns], No_Sale, Cancel  " &
                    "FROM Cash where branch_id='" & VBranch_ID & "' and Cash_Register_ID ='" & VReg_ID & "' and Datetime = '" &
                    GetSrvDate.Date & "'"

                    getSqldb(StrSQL, ConnLocal)

                    '--update EPC
                    'StrSQL = "update a set a.epc_code = b.epc_code from " & Svr & "." & Dbs & ".dbo.sales_transaction_details a inner join sales_transaction_details b " &
                    '         "on a.transaction_number = b.transaction_number And a.plu = b.plu And a.seq = b.seq " &
                    '         "where b.transaction_number = '" & ro("Transaction_Number") & "'"
                    'getSqldb(StrSQL, ConnLocal)
                Next
            End If
        Catch ex As Exception
            MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "Naikin_Data " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try
    End Sub
    Private Sub Naikin_Promo()
        Try
            Dim RsA As New DataSet
            RsA = getSqldb("SELECT Transaction_Number, qty_promo, promo_id From promo_sales Where Status ='00'", ConnLocal)

            If RsA.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In RsA.Tables(0).Rows
                    StrSQL = "DELETE " & Svr & "." & Dbs & ".dbo.promo_sales WHERE transaction_number= '" & ro("Transaction_Number") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.promo_sales " &
                    "(promo_id, transaction_number, nilai, qty_promo, status ) " &
                    "SELECT  promo_id, transaction_number, nilai, qty_promo, '99'" &
                    "FROM promo_sales  WHERE transaction_number= '" & ro("Transaction_Number") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "update promo_sales set status='99' WHERE transaction_number= '" & ro("Transaction_Number") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "update " & Svr & "." & Dbs & ".dbo.promo_hdr set qtyout=qtyout+ " & ro("qty_promo") & " where promo_id='" & ro("promo_id") & "' and islimit=1"
                    getSqldb(StrSQL, ConnLocal)
                Next
            End If
        Catch ex As Exception
            MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "Naikin_Promo " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try
    End Sub
    Private Sub Naikin_Point()
        Try
            Dim RsA As New DataSet
            RsA = getSqldb("SELECT * From customer_transaction_h_membercard a inner join customer_transaction_d_membercard b " &
                     "On a.CustTrans_Nr =  b.CustTrans_Nr Where a.data_Status ='00' or b.data_Status = '00'", ConnLocal)

            If RsA.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In RsA.Tables(0).Rows
                    StrSQL = "DELETE FROM " & Svr & "." & Dbs & ".dbo.customer_transaction_h_membercard WHERE CustTrans_Nr= '" & ro("CustTrans_Nr") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "DELETE FROM " & Svr & "." & Dbs & ".dbo.customer_transaction_d_membercard WHERE CustTrans_Nr= '" & ro("CustTrans_Nr") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.customer_transaction_h_membercard " &
                    "(CustTrans_Nr, CustTrans_Date, Card_Nr, CustTrans_TotAmount, CustTrans_Point, User_ID, Trans_Time, Data_Status ) " &
                    "SELECT  CustTrans_Nr, CustTrans_Date, Card_Nr, CustTrans_TotAmount, CustTrans_Point, User_ID, Trans_Time, '00'" &
                    "FROM customer_transaction_h_membercard  WHERE CustTrans_Nr= '" & ro("CustTrans_Nr") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "Insert " & Svr & "." & Dbs & ".dbo.customer_transaction_d_membercard " &
                    "(CustTrans_Nr, CustTrans_Struk, CustTrans_Amount, Data_Status) " &
                    "SELECT  CustTrans_Nr, CustTrans_Struk, CustTrans_Amount, '00'" &
                    "FROM customer_transaction_d_membercard  WHERE CustTrans_Nr= '" & ro("CustTrans_Nr") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "update customer_transaction_h_membercard set data_status='99' WHERE CustTrans_Nr= '" & ro("CustTrans_Nr") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "update customer_transaction_d_membercard set data_status='99' WHERE CustTrans_Nr= '" & ro("CustTrans_Nr") & "'"
                    getSqldb(StrSQL, ConnLocal)

                    StrSQL = "update " & Svr & "." & Dbs & ".dbo.card set card_point=card_point+ " & ro("CustTrans_Point") & " where card_nr='" & ro("Card_Nr") & "'"
                    getSqldb(StrSQL, ConnLocal)
                Next
            End If
        Catch ex As Exception
            MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "Naikin_Point " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try
    End Sub

    Private Sub Update_RfidCode()
        Try
            Dim RsA As New DataSet
            RsA = getSqldb("Select Epc_Code from sales_transaction_details a inner join sales_transactions b on a.transaction_number = b.transaction_number  " &
                           " where b.status = '00' and Epc_Code <> ''", ConnLocal)
            If RsA.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In RsA.Tables(0).Rows
                    getSqldb("Update Item_Master_RFID set Flag = 1 where TID = '" & ro("Epc_Code") & "' and [Status] = '1' And Flag = '0'", ConnServer)
                Next
            End If
            'RsA = getSqldb("update x set x.flag = y.flag from " & Svr & "." & Dbs & ".dbo.Item_Master_RFID x inner join  (SELECT * From Item_Master_RFID where TID in (select epc_code from sales_transaction_details a inner join " &
            '               "sales_transactions b on a.transaction_number = b.transaction_number  where b.status = '00' " &
            '               "and substring(a.transaction_number,9,8) = '" & Format(GetSrvDate, "ddMMyyyy") & "') and flag = 1) y on x.plu = y.plu and x.epc = y.epc", ConnLocal)
        Catch ex As Exception
            MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog(Me.Name & " " & "Update_Rfid " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try


    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If Me.Text = "SOD" Then Proses_SOD()
        If Me.Text = "EOD" Then Proses_EOD()
        'Me.Close()
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Visible = False
        'frmLogin.Show()
        If EODFirstForm = True Then
            Application.Exit()
        Else
            frmFirstForm.Show()
        End If

        'frmShowStock.Show()
        Me.Close()
    End Sub
End Class