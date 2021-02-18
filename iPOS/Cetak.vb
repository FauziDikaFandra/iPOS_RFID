Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Imports System.IO.Ports
Module Cetak
    Dim Printer As New Printer
    Public Class RawPrinter
        ' ----- Define the data type that supplies basic print job information to the spooler.
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
        Public Structure DOCINFO
            <MarshalAs(UnmanagedType.LPWStr)>
            Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)>
            Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)>
            Public pDataType As String
        End Structure

        ' ----- Define interfaces to the functions supplied in the DLL.
        <DllImport("winspool.drv", EntryPoint:="OpenPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function OpenPrinter(ByVal printerName As String, ByRef hPrinter As IntPtr, ByVal printerDefaults As Integer) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="ClosePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartDocPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Integer, ByRef documentInfo As DOCINFO) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndDocPrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="StartPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="EndPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.drv", EntryPoint:="WritePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal buffer As IntPtr, ByVal bufferLength As Integer, ByRef bytesWritten As Integer) As Boolean
        End Function

        Public Shared Function PrintRaw(ByVal printerName As String, ByVal origString As String) As Boolean
            ' ----- Send a string of  raw data to  the printer.
            Dim hPrinter As IntPtr
            Dim spoolData As New DOCINFO
            Dim dataToSend As IntPtr
            Dim dataSize As Integer
            Dim bytesWritten As Integer

            ' ----- The internal format of a .NET String is just
            '       different enough from what the printer expects
            '       that there will be a problem if we send it
            '       directly. Convert it to ANSI format before
            '       sending.
            dataSize = origString.Length()
            dataToSend = Marshal.StringToCoTaskMemAnsi(origString)

            ' ----- Prepare information for the spooler.
            spoolData.pDocName = "OpenDrawer" ' class='highlight'
            spoolData.pDataType = "RAW"

            Try
                ' ----- Open a channel to  the printer or spooler.
                Call OpenPrinter(printerName, hPrinter, 0)

                ' ----- Start a new document and Section 1.1.
                Call StartDocPrinter(hPrinter, 1, spoolData)
                Call StartPagePrinter(hPrinter)

                ' ----- Send the data to the printer.
                Call WritePrinter(hPrinter, dataToSend,
                   dataSize, bytesWritten)

                ' ----- Close everything that we opened.
                EndPagePrinter(hPrinter)
                EndDocPrinter(hPrinter)
                ClosePrinter(hPrinter)
                PrintRaw = True
            Catch ex As Exception
                MsgBox("Error occurred: " & ex.ToString)
                PrintRaw = False
            Finally
                ' ----- Get rid of the special ANSI version.
                Marshal.FreeCoTaskMem(dataToSend)
            End Try
        End Function
    End Class
    Public Sub OpenCashdrawer()
        'Modify DrawerCode to your receipt printer open drawer code
        Dim DrawerCode As String = Chr(27) & Chr(112) & Chr(48) & Chr(64) & Chr(64)
        'Modify PrinterName to your receipt printer name
        Dim PrinterName As String = "Your receipt printer name"

        RawPrinter.PrintRaw(PrinterName, DrawerCode)
    End Sub
    Public Sub CetakBegin()
        Printer.FontName = "Printer 17cpi"
        Printer.FontSize = 9
        Printer.Print("POS BEGIN... ")
        Printer.Write("NPWP")
        Printer.CurrentX = 1000
        Printer.Print(": " & Tulis(9))
        Printer.Write("REGISTER")
        Printer.CurrentX = 1000
        Printer.Print(": " & VReg_ID)
        Printer.Write("CASHIER")
        Printer.CurrentX = 1000
        Printer.Print(": " & VShift & " - " & VKasir_ID & "/" & VKasir_Nm)
        Printer.Write("TIME")
        Printer.CurrentX = 1000
        Printer.Print(": " & Format(Now(), "dd/MMM/yyyy hh:mm:ss"))
        Printer.EndDoc()
    End Sub

    Public Sub CekMissPaid()
        Dim RsCek As New DataSet
        RsCek = getSqldb("select a.* from sales_transactions a left join paid b on a.transaction_number = b.transaction_number where a.status = '00' and b.Transaction_Number is null", ConnLocal)
        If RsCek.Tables(0).Rows.Count > 0 Then
            For Each ro As DataRow In RsCek.Tables(0).Rows
                getSqldb("Insert into paid select '" & ro("transaction_number") & "',4,1,'IDR',1,'530795******1234','','" & ro("Total_Paid") & "',1", ConnLocal)
                If VPing = "ONLINE" Then getSqldb("Insert into paid select '" & ro("transaction_number") & "',4,1,'IDR',1,'530795******1234','','" & ro("Total_Paid") & "',1", ConnServer)
            Next
        End If
    End Sub

    Public Sub XRead()
        Dim RsBayar As New DataSet, Rs As New DataSet
        Dim Jual As Long, diskon As Long, Retur As Long, Batal As Long, Modal As Long, Jumlah As Long

        Call OpenLaci(0)
        If ReadIni("Printer", "X_ReadPrint") = 1 Then
            Rs = getSqldb("SELECT isnull(SUM(Net_amount),0) AS Nilai, isnull(SUM(Total_discount),0) AS Potong " &
                    "FROM Sales_Transactions WHERE Status = '00' and substring(transaction_number, 9,8)='" & Format(GetSrvDate, "ddMMyyyy") &
                    "' and Transaction_Number in (select transaction_number from paid where Paid.Shift = '" & VShift & "') And substring(transaction_number, 5,3) = '" & VReg_ID & "' ", ConnLocal)
            Jual = Rs.Tables(0).Rows(0).Item("nilai")
            diskon = Rs.Tables(0).Rows(0).Item("Potong")
            Rs.Clear()

            Rs = getSqldb("SELECT isnull(SUM(Net_amount),0) AS Balik " &
                 "FROM Sales_Transactions WHERE Flag_Return  = '1' and substring(transaction_number, 9,8)='" & Format(GetSrvDate, "ddMMyyyy") &
                 "' and Transaction_Number in (select transaction_number from paid where Paid.Shift = '" & VShift & "')  And substring(transaction_number, 5,3) = '" & VReg_ID & "' ", ConnLocal)
            Retur = Rs.Tables(0).Rows(0).Item("balik")
            Rs.Clear()

            Rs = getSqldb("SELECT isnull(SUM(Net_Price),0) AS Nilai " &
                 "FROM Sales_Transaction_Details WHERE substring(transaction_number, 9,8)='" & Format(GetSrvDate, "ddMMyyyy") &
                 "' and Transaction_Number in (select transaction_number from paid where Paid.Shift = '" & VShift & "' and flag_void='1')  And substring(transaction_number, 5,3) = '" & VReg_ID & "'", ConnLocal)
            Batal = Rs.Tables(0).Rows(0).Item("nilai")
            Rs.Clear()

            Rs = getSqldb("SELECT Modal From Cash WHERE (Branch_ID = '" & VBranch_ID & "') AND (Datetime = '" &
                GetSrvDate.Date & "') AND (Shift = " & VShift & ") And Cash_Register_ID = '" & VReg_ID & "'", ConnLocal)
            If Rs.Tables(0).Rows.Count > 0 Then
                Modal = Rs.Tables(0).Rows(0).Item("Modal")
            Else
                Modal = 0
            End If
            Rs.Clear() : Rs = Nothing

            RsBayar = getSqldb("SELECT Payment_Types.Description, SUM(Paid.Paid_Amount) AS Nilai " &
                "FROM Paid INNER JOIN Payment_Types ON Paid.Payment_Types = Payment_Types.Payment_Types " &
                "WHERE (Paid.Shift = '" & VShift & "') and substring(transaction_number, 9,8)='" & Format(GetSrvDate, "ddMMyyyy") &
                "'  And substring(transaction_number, 5,3) = '" & VReg_ID & "' GROUP BY Payment_Types.seq, Payment_Types.Description order by Payment_Types.seq", ConnLocal)
            Printer.FontSize = 8
            Printer.Write("X-Reading Shift")
            Printer.CurrentX = 1500 : Printer.Print(": " & VShift & " " & frmMain.lblline.Text)
            Printer.Write("BRANCH")
            Printer.CurrentX = 1500 : Printer.Print(": " & Tulis(10))
            Printer.Write("REGISTER")
            Printer.CurrentX = 1500 : Printer.Print(": " & VReg_ID)
            Printer.Write("CASHIER")
            Printer.CurrentX = 1500 : Printer.Print(": " & VKasir_ID & "/" & VKasir_Nm)
            Printer.Write("TIME")
            Printer.CurrentX = 1500 : Printer.Print(": " & Format(Now(), "dd/MMM/yyyy hh:mm:ss"))
            Printer.Print(VGaris)
            Printer.Write("MODAL")
            Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
            CetakKanan(CDec(Modal).ToString("N0") & "    ")

            For Each ro As DataRow In RsBayar.Tables(0).Rows
                Printer.Write(Left(ro("Description") & Space(20), 20))
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(ro("nilai")).ToString("N0") & "    ")
                '        Printer.Print Left(RsBayar!Description & Space(20), 20) & "   : Rp. " & Kanan(14, RsBayar!nilai)
                Jumlah = Jumlah + ro("nilai")
            Next


            Printer.Print(VGaris)
            Printer.Write("TOTAL")
            Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
            CetakKanan(CDec(Jumlah).ToString("N0") & "    ")
            Printer.Write("OVER VOUCHER")
            Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
            CetakKanan(CDec(Jumlah - Jual).ToString("N0") & "    ")
            Printer.Print(VGaris)
            Printer.Write("X Reading")
            Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
            CetakKanan(CDec(Jual).ToString("N0") & "    ")
            Printer.Print("")
            Printer.Write("DISCOUNT")
            Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
            CetakKanan(CDec(diskon).ToString("N0") & "    ")
            Printer.Write("RETURN")
            Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
            CetakKanan(CDec(Retur).ToString("N0") & "    ")
            Printer.Write("VOID")
            Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
            CetakKanan(CDec(Batal).ToString("N0") & "    ")

            Printer.Print("") : Printer.Print("") : Printer.Print("")
            Printer.Print("") : Printer.Print("") : Printer.Print("")
            Printer.EndDoc()
            'update table cash
            RsBayar.Clear() : RsBayar = Nothing
        End If


        getSqldb("update cash_register set shift='2' WHERE Branch_ID = '" & VBranch_ID &
                          "' AND cash_register_id='" & VReg_ID & "'", ConnLocal)
        'If Linked() Then getSqldb("update cash_register set shift='2' WHERE Branch_ID = '" & VBranch_ID &
        '                  "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
        'tanpa cek PING
        If VPing = "ONLINE" Then getSqldb("update cash_register set shift='2' WHERE Branch_ID = '" & VBranch_ID &
                          "' AND cash_register_id='" & VReg_ID & "'", ConnServer)

    End Sub
    Private Function CetakKanan(ByVal Tex1 As String) As String
        '----------------------Normal-------------------------
        Printer.CurrentX = Printer.ScaleWidth - Printer.TextWidth(Tex1) - 90
        '----------------------POSIFLEX-----------------------
        'Printer.CurrentX = Printer.CurrentX = Printer.ScaleWidth - Printer.TextWidth(Tex1) - 270
        Printer.Print(Tex1)
        Return Tex1
    End Function
    Public Sub ZReset()
        Dim RsBayar As New DataSet, Rs As New DataSet, x As Byte
        Dim Jual As Long, diskon As Long, Retur As Long, Batal As Long, Modal As Long, Jumlah As Long

        Call OpenLaci(0)
        If ReadIni("Printer", "X_ReadPrint") = 1 Then
            Rs = getSqldb("SELECT isnull(SUM(Net_amount),0) AS Nilai, isnull(SUM(Total_discount),0) AS Potong " &
                    "FROM Sales_Transactions WHERE Status = '00' and substring(transaction_number, 9,8)='" &
                    Format(GetSrvDate, "ddMMyyyy") & "'  And substring(transaction_number, 5,3) = '" & VReg_ID & "'", ConnLocal)
            Jual = Rs.Tables(0).Rows(0).Item("nilai")
            diskon = Rs.Tables(0).Rows(0).Item("potong")
            Rs.Clear()

            Rs = getSqldb("SELECT isnull(SUM(Net_amount),0) AS Balik " &
                    "FROM Sales_Transactions WHERE Flag_Return  = '1' and substring(transaction_number, 9,8)='" &
                    Format(GetSrvDate, "ddMMyyyy") & "'  And substring(transaction_number, 5,3) = '" & VReg_ID & "'", ConnLocal)
            Retur = Rs.Tables(0).Rows(0).Item("balik")
            Rs.Clear()

            Rs = getSqldb("SELECT isnull(SUM(Net_Price),0) AS Nilai " &
                    "FROM Sales_Transaction_Details WHERE substring(transaction_number, 9,8)='" &
                    Format(GetSrvDate, "ddMMyyyy") & "' and flag_void='1'  And substring(transaction_number, 5,3) = '" & VReg_ID & "' ", ConnLocal)
            Batal = Rs.Tables(0).Rows(0).Item("nilai")
            Rs.Clear()

            Rs = getSqldb("SELECT sum(Modal) as modal From Cash WHERE (Branch_ID = '" & VBranch_ID & "') AND (Datetime = '" &
                   GetSrvDate.Date & "')  And Cash_Register_ID = '" & VReg_ID & "'", ConnLocal)
            If Rs.Tables(0).Rows.Count > 0 Then
                Modal = Rs.Tables(0).Rows(0).Item("Modal")
            Else
                Modal = 0
            End If
            Rs.Clear() : Rs = Nothing

            RsBayar = getSqldb("SELECT Payment_Types.Description, SUM(Paid.Paid_Amount) AS Nilai " &
                    "FROM Paid INNER JOIN Payment_Types ON Paid.Payment_Types = Payment_Types.Payment_Types " &
                    "WHERE substring(transaction_number, 9,8)='" & Format(GetSrvDate, "ddMMyyyy") &
                    "'  And substring(transaction_number, 5,3) = '" & VReg_ID & "' GROUP BY Payment_Types.seq, Payment_Types.Description order by Payment_Types.seq", ConnLocal)

            For x = 1 To 1
                Jumlah = 0
                Printer.FontSize = 8
                Printer.Write("Z-Reset Shift")
                Printer.CurrentX = 1500 : Printer.Print(": " & VShift & " " & frmMain.lblline.Text)
                Printer.Write("BRANCH")
                Printer.CurrentX = 1500 : Printer.Print(": " & Tulis(10))
                Printer.Write("REGISTER")
                Printer.CurrentX = 1500 : Printer.Print(": " & VReg_ID)
                Printer.Write("CASHIER")
                Printer.CurrentX = 1500 : Printer.Print(": " & VKasir_ID & "/" & VKasir_Nm)
                Printer.Write("TIME")
                Printer.CurrentX = 1500 : Printer.Print(": " & Format(Now(), "dd/MMM/yyyy hh:mm:ss"))
                Printer.Print(VGaris)
                Printer.Write("MODAL")
                Printer.CurrentX = 1800 : Printer.Print(": Rp. ")
                CetakKanan(CDec(Modal).ToString("N0") & "    ")

                If RsBayar.Tables(0).Rows.Count > 0 Then
                    For Each ro As DataRow In RsBayar.Tables(0).Rows
                        Printer.Write(Left(ro("Description") & Space(20), 20))
                        Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                        CetakKanan(CDec(ro("nilai")).ToString("N0") & "    ")
                        '        Printer.Print Left(RsBayar!Description & Space(20), 20) & "   : Rp. " & Kanan(14, RsBayar!nilai)
                        Jumlah = Jumlah + ro("nilai")
                    Next
                End If



                Printer.Print(VGaris)
                Printer.Write("TOTAL")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Jumlah).ToString("N0") & "    ")
                Printer.Write("OVER VOUCHER")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Jumlah - Jual).ToString("N0") & "    ")
                Printer.Print(VGaris)
                Printer.Write("Z Reset")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Jual).ToString("N0") & "    ")
                Printer.Print("")
                Printer.Write("DISCOUNT")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(diskon).ToString("N0") & "    ")
                Printer.Write("RETURN")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Retur).ToString("N0") & "    ")
                Printer.Write("VOID")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Batal).ToString("N0") & "    ")


                Printer.Print("") : Printer.Print("") : Printer.Print("")
                Printer.Print("") : Printer.Print("") : Printer.Print("")
                Printer.EndDoc()

            Next x
            RsBayar.Clear() : RsBayar = Nothing
        End If

        Try
            getSqldb("exec spp_ZresetLocal '" & VBranch_ID & "', '" & VReg_ID & "', '" & GetSrvDate.Date & "'", ConnLocal)
            getSqldb("exec spp_ZresetServer '" & VBranch_ID & "', '" & VReg_ID & "', '" & GetSrvDate.Date & "',''", ConnLocal)
            getSqldb("exec spp_DeleteTrans '" & VReg_ID & "'", ConnLocal)

            'If Linked() Then getSqldb("exec spp_ZresetServer '" & VBranch_ID & "', '" & VReg_ID & "', '" & Now().Date & "',''", ConnServer)

            'tanpa cek PING
            If VPing = "ONLINE" Then getSqldb("exec spp_ZresetServer '" & VBranch_ID & "', '" & VReg_ID & "', '" & GetSrvDate.Date & "',''", ConnServer)
        Catch ex As Exception
            MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
            Call SaveLog("Zreset " & Err.Description & " " & Err.Number & " " & Format(Now, "HH:mm:ss"))
        End Try


    End Sub

    Public Sub ZResetbackdate()
        Dim RsBayar As New DataSet, Rs As New DataSet, x As Byte
        Dim Jual As Long, diskon As Long, Retur As Long, Batal As Long, Modal As Long, Jumlah As Long

        Call OpenLaci(0)
        If ReadIni("Printer", "X_ReadPrint") = 1 Then
            Rs = getSqldb("SELECT isnull(SUM(Net_amount),0) AS Nilai, isnull(SUM(Total_discount),0) AS Potong " &
                    "FROM Sales_Transactions_backup WHERE Status = '00' and substring(transaction_number, 9,8)='" &
                    Format(GetSrvDate.AddDays(-1), "ddMMyyyy") & "'  And substring(transaction_number, 5,3) = '" & VReg_ID & "'", ConnLocal)
            Jual = Rs.Tables(0).Rows(0).Item("nilai")
            diskon = Rs.Tables(0).Rows(0).Item("potong")
            Rs.Clear()

            Rs = getSqldb("SELECT isnull(SUM(Net_amount),0) AS Balik " &
                    "FROM Sales_Transactions_backup WHERE Flag_Return  = '1' and substring(transaction_number, 9,8)='" &
                    Format(GetSrvDate.AddDays(-1), "ddMMyyyy") & "'  And substring(transaction_number, 5,3) = '" & VReg_ID & "'", ConnLocal)
            Retur = Rs.Tables(0).Rows(0).Item("balik")
            Rs.Clear()

            Rs = getSqldb("SELECT isnull(SUM(Net_Price),0) AS Nilai " &
                    "FROM Sales_Transaction_Details_backup WHERE substring(transaction_number, 9,8)='" &
                    Format(GetSrvDate.AddDays(-1), "ddMMyyyy") & "' and flag_void='1'  And substring(transaction_number, 5,3) = '" & VReg_ID & "' ", ConnLocal)
            Batal = Rs.Tables(0).Rows(0).Item("nilai")
            Rs.Clear()

            Rs = getSqldb("SELECT sum(Modal) as modal From Cash_backup WHERE (Branch_ID = '" & VBranch_ID & "') AND (Datetime = '" &
                   GetSrvDate.Date.AddDays(-1) & "')  And Cash_Register_ID = '" & VReg_ID & "'", ConnLocal)
            If Rs.Tables(0).Rows.Count > 0 Then
                Modal = Rs.Tables(0).Rows(0).Item("Modal")
            Else
                Modal = 0
            End If
            Rs.Clear() : Rs = Nothing

            RsBayar = getSqldb("SELECT Payment_Types.Description, SUM(Paid_backup.Paid_Amount) AS Nilai " &
                    "FROM Paid_backup INNER JOIN Payment_Types ON Paid_backup.Payment_Types = Payment_Types.Payment_Types " &
                    "WHERE substring(transaction_number, 9,8)='" & Format(GetSrvDate.AddDays(-1), "ddMMyyyy") &
                    "'  And substring(transaction_number, 5,3) = '" & VReg_ID & "' GROUP BY Payment_Types.seq, Payment_Types.Description order by Payment_Types.seq", ConnLocal)

            For x = 1 To 1
                Jumlah = 0
                Printer.FontSize = 8
                Printer.Write("Z-Reset Shift")
                Printer.CurrentX = 1500 : Printer.Print(": " & VShift & " " & frmMain.lblline.Text)
                Printer.Write("BRANCH")
                Printer.CurrentX = 1500 : Printer.Print(": " & Tulis(10))
                Printer.Write("REGISTER")
                Printer.CurrentX = 1500 : Printer.Print(": " & VReg_ID)
                Printer.Write("CASHIER")
                Printer.CurrentX = 1500 : Printer.Print(": " & VKasir_ID & "/" & VKasir_Nm)
                Printer.Write("TIME")
                Printer.CurrentX = 1500 : Printer.Print(": " & Format(Now().AddDays(-1), "dd/MMM/yyyy hh:mm:ss"))
                Printer.Print(VGaris)
                Printer.Write("MODAL")
                Printer.CurrentX = 1800 : Printer.Print(": Rp. ")
                CetakKanan(CDec(Modal).ToString("N0") & "    ")

                If RsBayar.Tables(0).Rows.Count > 0 Then
                    For Each ro As DataRow In RsBayar.Tables(0).Rows
                        Printer.Write(Left(ro("Description") & Space(20), 20))
                        Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                        CetakKanan(CDec(ro("nilai")).ToString("N0") & "    ")
                        '        Printer.Print Left(RsBayar!Description & Space(20), 20) & "   : Rp. " & Kanan(14, RsBayar!nilai)
                        Jumlah = Jumlah + ro("nilai")
                    Next
                End If



                Printer.Print(VGaris)
                Printer.Write("TOTAL")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Jumlah).ToString("N0") & "    ")
                Printer.Write("OVER VOUCHER")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Jumlah - Jual).ToString("N0") & "    ")
                Printer.Print(VGaris)
                Printer.Write("Z Reset")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Jual).ToString("N0") & "    ")
                Printer.Print("")
                Printer.Write("DISCOUNT")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(diskon).ToString("N0") & "    ")
                Printer.Write("RETURN")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Retur).ToString("N0") & "    ")
                Printer.Write("VOID")
                Printer.CurrentX = 1800 : Printer.Write(": Rp. ")
                CetakKanan(CDec(Batal).ToString("N0") & "    ")


                Printer.Print("") : Printer.Print("") : Printer.Print("")
                Printer.Print("") : Printer.Print("") : Printer.Print("")
                Printer.EndDoc()

            Next x
            RsBayar.Clear() : RsBayar = Nothing
        End If



    End Sub

    Public Sub CDisplay(Tex1 As String, Tex2 As String)
        Dim str() As String = Split(CDSet, ",")
        Dim sp As New SerialPort("COM" & CDCom, str(0), IIf(str(1) = "o", Parity.Odd, Parity.None), CInt(str(2)), IIf(str(3) = "1", StopBits.One, StopBits.None))
        If CDCom = "" Then Exit Sub
        Select Case CD_Type
            Case = "0"
                With sp
                    Tex1 = Space((20 - Len(Tex1)) / 2) & Tex1
                    Tex2 = Space((20 - Len(Tex2)) / 2) & Tex2
                    .Open()
                    .Write(Chr(27) & "[2J") 'bersihkan display
                    .WriteLine(Chr(27) & "[" & Chr(&H31 + 0) & ";" & Chr(&H31 + 0) & "H" & Tex1)
                    .WriteLine(Chr(27) & "[" & Chr(&H31 + 1) & ";" & Chr(&H31 + 0) & "H" & Tex2)
                    .Close()
                    .Dispose()
                End With
            Case = "1"
                With sp
                    .Open()
                    'to clear the display
                    .Write(Convert.ToString(Chr(12)))
                    'first line goes here
                    .WriteLine(Chr(27) & Chr(81) & Tex1 & " " & Tex2)
                    '2nd line goes here
                    'sp.WriteLine(Chr(27) & Chr(81) & Tex2)
                    .Close()
                    .Dispose()
                End With
        End Select
    End Sub

    'Public Sub CDisplay(Tex1 As String, Tex2 As String)

    '    ' Send strings to a serial port.
    '    Using com1 As IO.Ports.SerialPort =
    '        My.Computer.Ports.OpenSerialPort("COM2", 9600, Parity.None, 8, StopBits.One)
    '        com1.Write(Convert.ToString(Chr(27)) & "[2J")
    '    End Using

    'End Sub

    'Public Sub CDisplay(ByRef Tex1 As String, ByRef Tex2 As String)
    '    ''''''untuk .Net
    '    If CDCom = "" Then Exit Sub
    '    'Dim sp As New SerialPort("COM" & CDCom, Str(0), IIf(Str(1) = "o", Parity.Odd, Parity.None), CInt(Str(2)), IIf(Str(3) = "1", StopBits.One, StopBits.None))
    '    Dim sp As New SerialPort("COM" & CDCom, 9600, Parity.None, 8, StopBits.One)
    '    sp.Open()
    '    'to clear the display
    '    sp.Write(Convert.ToString(Chr(12)))
    '    'first line goes here
    '    sp.WriteLine(Chr(27) & Chr(81) & Tex1 & " " & Tex2)
    '    '2nd line goes here
    '    'sp.WriteLine(Chr(27) & Chr(81) & Tex2)
    '    sp.Close()
    '    sp.Dispose()
    'End Sub





    Public Sub OpenLaci(ByVal tipe As Byte)
        Call Open_OPOS_Drawer()
        If tipe = 1 Then
            Printer.Write("CASHIER")
            Printer.CurrentX = 1000 : Printer.Print(": " & VShift & " - " & VKasir_ID & "/" & VKasir_Nm)
            Printer.Write("TIME")
            Printer.CurrentX = 1000 : Printer.Print(": " & Format(Now(), "dd/MMM/yyyy hh:mm:ss"))
            Printer.Write("OPEN DRAWER")
            Printer.Print("") : Printer.Print("") : Printer.Print("")
            Printer.Print("") : Printer.Print("") : Printer.Print("")
            Printer.EndDoc()
        End If
    End Sub
    Private Sub Open_OPOS_Drawer()
        Dim printDoc As New PrintDocument
        'Modify DrawerCode to your receipt printer open drawer code
        Dim DrawerCode As String = Chr(27) & Chr(112) & Chr(48) & Chr(64) & Chr(64)
        'Modify PrinterName to your receipt printer name
        Dim PrinterName As String = printDoc.PrinterSettings.DefaultPageSettings.PrinterSettings.PrinterName.ToString
        RawPrinter.PrintRaw(PrinterName, DrawerCode)
    End Sub
    Public Sub CetakData()
        Dim Printer As New Printer
        Printer.FontName = "Printer 17cpi"
        Printer.FontSize = 9
        Printer.Print("-------------------------------------------------------------------")
        Printer.Write("Card Number")
        Printer.CurrentX = 1500 : Printer.Print(": " & Star_No)
        Printer.Write("Name")
        Printer.CurrentX = 1500 : Printer.Print(": " & Star_Nm)
        Printer.Print("-------------------------------------------------------------------")
        Printer.Write("Phone Number")
        Printer.CurrentX = 1500 : Printer.Print(": " & Trim(Star_Phone))
        Printer.Write("Email")
        Printer.CurrentX = 1500 : Printer.Print(": " & Trim(Star_Email))
        Printer.Print("-------------------------------------------------------------------")
        Printer.Write("New Phone")
        Printer.CurrentX = 1500 : Printer.Print(": ")
        Printer.Write("New Email")
        Printer.CurrentX = 1500 : Printer.Print(": ")
        Printer.Print("-------------------------------------------------------------------")
        Printer.EndDoc()
    End Sub

    Public Sub CetakStruk(ByRef Status As String, ByRef No_trans As String)
        Try
            Dim vqty As Short
            Dim vtotal, Vsave As Integer
            Dim abc As String
            Dim Rst As New DataSet
            Dim Rsh As New DataSet
            Dim AdaCash As Byte
            Dim RsX As New DataSet

            'cek cash terakhir
            RsX = getSqldb("SELECT TOP (1) Seq From Paid " & "WHERE (Transaction_Number = '" & No_trans & "') AND (Payment_Types = '1') " & "ORDER BY Seq DESC", ConnLocal)

            If RsX.Tables(0).Rows.Count > 0 Then
                AdaCash = RsX.Tables(0).Rows(0).Item("Seq")
            Else
                AdaCash = 0
            End If
            RsX.Clear()
            RsX = Nothing

            Rsh = getSqldb("select card_number, transaction_date, transaction_time, change_amount, Point_Of_Card_Program, pd.seq as urut, pd.*, pt.* from sales_transactions st inner join paid pd on " & "st.transaction_number = pd.transaction_number inner join payment_types pt on pd.payment_types " & "= pt.payment_types where st.transaction_number='" & No_trans & "' order by pd.seq", ConnLocal)
            If Rsh.Tables(0).Rows.Count = 0 Then
                MsgBox("This transaction has a problem, please contact IT !!")
                Exit Sub
            End If
            Printer.FontName = "Printer 17cpi"
            Printer.FontSize = 10


            If CDbl(ReadIni("Printer", "Use_Logo")) = 0 Then
                CetakTengah("LAKON")
            Else
                'CetakTengah("DEPARTMENT STORE")
            End If

            Printer.FontSize = 9
            CetakTengah(Tulis(10))
            Printer.FontName = "Printer 17cpi"
            Printer.FontSize = 9
            Printer.Print("")
            Printer.Print("No. " & No_trans)
            Printer.Print(VShift & "-" & VKasir_ID & "/" & Left(Trim(VKasir_Nm), 14) & "     " & Format(Rsh.Tables(0).Rows(0).Item("Transaction_Date"), "dd/MM/yyyy") & " " & Rsh.Tables(0).Rows(0).Item("Transaction_Time"))
            Printer.Print("")

            If Status <> "SALES" Then

                Select Case Status
                    Case "REFUND"
                        Printer.FontSize = 9
                        CetakTengah("REFUND TRANSACTION")
                    Case "REPRINT"
                        Printer.FontSize = 9
                        CetakTengah("R E P R I N T")
                End Select
                Printer.Print("")
            End If

            Rst = getSqldb("select Seq, sd.PLU, Item_Description, Price, Qty, Discount_Percentage, Discount_Amount, " & "ExtraDisc_Pct, ExtraDisc_Amt, net_price, brand from sales_transaction_details sd inner join item_master im " & "on sd.plu=im.plu where transaction_number='" & No_trans & "' order by seq", ConnLocal)
            Printer.FontSize = 8
            If Rst.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In Rst.Tables(0).Rows
                    Printer.Print(Left(Trim(ro("plu")) & " " & Trim(ro("item_description")), 42))
                    abc = "  " & CDec(ro("Qty")).ToString("N0") & "x" & CDec(ro("price")).ToString("N0") & " " & IIf(ro("Brand") = "No Brand", " ", ro("Brand"))
                    abc = Left(abc, 30)

                    Printer.Write(abc)
                    '---------------------Normal----------------
                    CetakKanan(CDec(ro("Net_Price")).ToString("N0"))
                    '---------------------POSIFLEX----------------
                    'CetakKonon (Format(Rst!Net_Price, "#,##0"))
                    If ro("Discount_Percentage") <> 0 Then
                        Printer.Print("  Disc. " & CDec(ro("Discount_Percentage")).ToString("N0") & "% = " & CDec(ro("Discount_Amount")).ToString("N0"))
                    End If

                    If ro("ExtraDisc_pct") <> 0 Then
                        Printer.Print("  Extra " & CDec(ro("ExtraDisc_pct")).ToString("N0") & "% = " & CDec(ro("ExtraDisc_amt")).ToString("N0"))
                    End If

                    vqty = vqty + ro("Qty")
                    vtotal = vtotal + ro("Net_Price")
                    Vsave = Vsave + ro("Discount_Amount") + ro("ExtraDisc_amt")
                Next
            End If
            Printer.Print("")
            Printer.Write("Total   " & Right("   " & vqty, 4) & " item(s)   ")
            '--------------Normal------------------------
            Printer.CurrentX = 2000 : Printer.Write("  : Rp. ")
            '--------------POSIFLEX----------------------
            'Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
            CetakKanan(Kanan(14, vtotal))
            Printer.Print("")

            Printer.FontSize = 9
            If Rsh.Tables(0).Rows.Count > 0 Then
                For Each ro As DataRow In Rsh.Tables(0).Rows
                    If Trim(ro("credit_card_no")) <> "" Then
                        Turun()
                        'If Len(Trim(ro("credit_card_no"))) = 16 Then
                        '    Printer.Print(Left(ro("credit_card_no"), 7) & "XXXXXXXXX")
                        'Else
                        '    Printer.Print(Left(ro("credit_card_no"), 20))
                        'End If
                        If Len(Trim(ro("credit_card_no"))) >= 14 Then
                            If isECR = "1" Then
                                Printer.Print(Left(ro("credit_card_no"), 16))
                            Else
                                Printer.Print(Left(ro("credit_card_no"), 4) & "******" & Mid(ro("credit_card_no"), 12, 6))
                            End If

                        Else
                            Printer.Print(Left(ro("credit_card_no"), 20))
                        End If
                        If Trim(ro("credit_card_name")) <> "" Then Printer.Print(Left(ro("credit_card_name"), 40))
                    End If

                    abc = Left(ro("Description") & Space(22), 22)
                    If ro("Payment_Types") > 30 Then abc = Left(ro("credit_card_name") & Space(24), 24)

                    Turun()
                    If Trim(ro("Description")) = "CASH" Then
                        Printer.Write("CASH")
                        '--------------Normal------------------------
                        Printer.CurrentX = 2000 : Printer.Write("  : Rp. ")
                        '--------------POSIFLEX----------------------
                        'Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
                        If ro("urut") = AdaCash Then
                            CetakKanan(CDec(ro("paid_amount") + ro("Change_Amount")).ToString("N0"))
                        Else
                            CetakKanan(CDec(ro("paid_amount")).ToString("N0"))
                        End If
                    Else
                        Printer.Write(abc)
                        '--------------Normal------------------------
                        Printer.CurrentX = 2000 : Printer.Write("  : Rp. ")
                        '--------------POSIFLEX----------------------
                        'Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
                        CetakKanan(CDec(ro("paid_amount")).ToString("N0"))
                    End If
                Next
            End If

            Turun()
            If Status = "REFUND" Then
                If Rsh.Tables(0).Rows(0).Item("Change_Amount") < 0 Then
                    Printer.Write("CHANGE")
                    Printer.CurrentX = 2000 : Printer.Print("  : Rp. ")
                    CetakKanan(CDec(Rsh.Tables(0).Rows(0).Item("Change_Amount")).ToString("N0"))
                End If
            Else
                If Rsh.Tables(0).Rows(0).Item("Change_Amount") > 0 Then
                    Printer.Write("CHANGE")
                    '--------------Normal------------------------
                    Printer.CurrentX = 2000 : Printer.Write("  : Rp. ")
                    '--------------POSIFLEX----------------------
                    'Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
                    CetakKanan(CDec(Rsh.Tables(0).Rows(0).Item("Change_Amount")).ToString("N0"))
                End If
            End If

            Printer.Print("")

            If Vsave > 0 Then
                Printer.Write("YOU SAVE")
                '--------------Normal------------------------
                Printer.CurrentX = 2000 : Printer.Write("  : Rp. ")
                '--------------POSIFLEX----------------------
                'Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
                CetakKanan(CDec(Vsave).ToString("N0"))
                Printer.Print("")
            End If

            If Trim(Rsh.Tables(0).Rows(0).Item("card_number")) <> "LM-00000000" Then
                Call MySTAR(Rsh.Tables(0).Rows(0).Item("card_number"))
                'Card_No_StrukTambahan = Rsh!card_number
                'Printer.Write("No MySTAR Card")
                'Printer.CurrentX = 1500 : Printer.Print(": " & Rsh.Tables(0).Rows(0).Item("card_number"))
                'Turun()
                Printer.Write("Customer Name")
                Printer.CurrentX = 1500 : Printer.Print(": " & Left(Star_Nm, 22))
                Printer.Print("")
                Turun()
                'Printer.Write("Issued Point")
                'Printer.CurrentX = 1500 : Printer.Print(": " & Get_Point(No_trans))
                'Turun()
                'If Linked() And Status <> "REPRINT" Then
                '    Printer.Write("Point Balance")
                '    Printer.CurrentX = 1500 : Printer.Print(": " & Star_Pt)
                'End If

                'tanpa cek PING
                'If VPing = "ONLINE" And Status <> "REPRINT" Then
                'Printer.Write("Point Balance")
                'Printer.CurrentX = 1500 : Printer.Print(": " & Star_Pt)
                'End If
                'Printer.Print("")
                'CetakTengah ("Tingkatkan belanja & gunakan kartu MSC")
                'CetakTengah ("Untuk memenangkan top spender")
                'Printer.Print ""
            Else
                'Card_No_StrukTambahan = "CM000-00000"
                'CetakTengah ("Not Yet A MySTAR Card member?")
                'CetakTengah ("Register Now and get more benefit")
                'Printer.Print ""
            End If

            Printer.FontSize = 9
            CetakTengah(Tulis(11))
            CetakTengah(Tulis(12))
            CetakTengah(Tulis(13) & ", " & Tulis(14))
            CetakTengah("NPWP/PKP No : " & Tulis(9))
            CetakTengah("Harga sudah termasuk pajak")
            Printer.Print("")
            CetakTengah(Tulis(7))
            'CetakTengah(Tulis(8))
            Printer.Print("")
            CetakTengah(Tulis(3))
            CetakTengah(Tulis(4))
            CetakTengah(Tulis(5))
            Printer.Print("")
            CetakTengah("Facebook / Twitter lakonstore")
            CetakTengah("Customer care : 0878 7612 0185 ")

            If Tulis(1) <> "" Then
                Printer.Print("")
                CetakTengah(VGaris)
                CetakTengah(Tulis(1))
                CetakTengah(Tulis(2))
                CetakTengah(VGaris)
            End If

            If CDbl(ReadIni("Printer", "Use_Barcode")) = 2 Then
                Printer.Print("")
                Printer.FontName = "IDAutomationHC39M"
                'Printer.CurrentX = (Printer.ScaleWidth - Printer.TextWidth(No_trans)) \ 2
                Printer.Print("*" & No_trans & "*")
            End If
            Printer.FontName = "Printer 17cpi"
            Printer.EndDoc()
            Rst.Clear()
            Rsh.Clear()
            Call SaveLog("Cetak Struk Success!! " & No_trans & " " & Format(Now, "HH:mm:ss"))
        Catch ex As Exception
            Call SaveLog("Cetak Struk Gagal !! " & No_trans & " " & Format(Now, "HH:mm:ss"))
        End Try


    End Sub
    Private Function CetakTengah(ByRef Tex1 As String) As String
        Printer.CurrentX = (Printer.ScaleWidth - Printer.TextWidth(Tex1)) \ 2
        Printer.Print(Tex1)
        Return Tex1
    End Function
    Private Sub Turun()
        Dim Printer As New Printer
        Printer.CurrentY = Printer.CurrentY + 60
    End Sub
    Private Function Kanan(ByRef geser As Byte, ByRef rupiah As Integer) As String
        Kanan = Space(geser - Len(CDec(rupiah).ToString("N0"))) & CDec(rupiah).ToString("N0")
    End Function
    Public Sub CetakPesan(ByRef Status As String, ByRef No_trans As String)
        Dim Printer As New Printer
        'Printer.Print Tulis(11) 'nama pt
        Printer.Print(Tulis(10))
        Printer.Write("TRANS#")
        Printer.CurrentX = 800 : Printer.Print(": " & No_trans)
        Printer.Write("CASHIER")
        Printer.CurrentX = 800 : Printer.Print(": " & VShift & " - " & VKasir_ID & "/" & VKasir_Nm)
        Printer.Write("TIME")
        Printer.CurrentX = 800 : Printer.Print(": " & Format(Now, "dd/MMM/yyyy hh:mm:ss"))
        Select Case Status
            Case "HOLD"
                Printer.Print("HOLD TRANSACTION")
            Case "CANCEL"
                Printer.Print("CANCEL TRANSACTION")
        End Select
        Printer.Print("") : Printer.Print("") : Printer.Print("")
        Printer.Print("") : Printer.Print("") : Printer.Print("")
        Printer.EndDoc()
    End Sub
    Public Sub CetakValid(ByRef No_trans As String, ByRef brs1 As String, ByRef brs2 As String)
        Dim Printer As New Printer
        Printer.Write("TRANS#")
        Printer.CurrentX = 800 : Printer.Print(": " & No_trans)
        Printer.Write("CASHIER")
        Printer.CurrentX = 800 : Printer.Print(": " & VShift & " - " & VKasir_ID & "/" & VKasir_Nm)
        Printer.Write("TIME")
        Printer.CurrentX = 800 : Printer.Print(": " & Format(Now, "dd/MMM/yyyy hh:mm:ss"))
        Printer.Print(brs1)
        Printer.Print(brs2)
        Printer.Print("") : Printer.Print("") : Printer.Print("")
        Printer.Print("") : Printer.Print("") : Printer.Print("")
        Printer.EndDoc()
    End Sub
    Public Sub CetakStrukPayPoint(ByRef Card_Nr As String, ByRef Card_Name As String, ByRef No_trans As String)
        Dim Printer As New Printer
        Dim RsX As New DataSet
        Dim Rst As New DataSet
        Dim AdaPayPoint As Short
        Dim SisaPayPoint As Short
        'cek pembayaran point
        RsX = getSqldb("SELECT Sum(Paid_Amount) As Amount From Paid " & "WHERE (Transaction_Number = '" & No_trans & "') AND (Payment_Types = '5') " & "", ConnServer)

        If RsX.Tables(0).Rows.Count > 0 Then
            If IsDBNull(RsX.Tables(0).Rows(0).Item("Amount").Value) Then
                AdaPayPoint = 0
            Else
                AdaPayPoint = RsX.Tables(0).Rows(0).Item("Amount").Value / CDbl(VHargaPoint)
            End If
        Else
            AdaPayPoint = 0
        End If

        RsX.Clear()
        RsX = Nothing

        If AdaPayPoint = 0 Then
            Exit Sub
        End If

        RsX = getSqldb("select card_point from card where card_nr = '" & Card_Nr & "'", ConnServer)
        If RsX.Tables(0).Rows.Count > 0 Then
            SisaPayPoint = RsX.Tables(0).Rows(0).Item("card_point").Value
        Else
            SisaPayPoint = 0
        End If
        If CDbl(ReadIni("Printer", "Use_Logo")) = 0 Then
            CetakTengah("STAR DEPARTMENT STORE")
        Else
            CetakTengah("DEPARTMENT STORE")
        End If


        Turun()

        Printer.FontSize = 9
        CetakTengah(Tulis(10))

        'UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="971F4DF4-254E-44F4-861D-3AA0031FE361"'
        Printer.FontName = "Printer 17cpi"
        Printer.FontSize = 9
        Turun()
        Printer.Print("")
        Printer.Print("POINT REWARD REDEMPTION")
        Turun()
        Printer.Write("No.")
        Printer.CurrentX = 1500 : Printer.Print(": " & No_trans)
        Turun()
        Printer.Write("No MySTAR Card")
        Printer.CurrentX = 1500 : Printer.Print(": " & Card_Nr)
        Turun()
        Printer.Write("Customer Name")
        Printer.CurrentX = 1500 : Printer.Print(": " & Left(Star_Nm, 22))
        Turun()
        Printer.Write("Claim Date")
        Printer.CurrentX = 1500 : Printer.Print(": " & Now)
        Turun()
        Printer.Print("-----------------------------------------------------")
        Turun()
        Printer.Write("Claim Point")
        Printer.CurrentX = 1500 : Printer.Print(": " & AdaPayPoint)
        Turun()
        Printer.Write("Point Balance")
        Printer.CurrentX = 1500 : Printer.Print(": " & Star_Pt)
        Printer.Print("")
        Printer.EndDoc()
        Rst.Clear()
    End Sub
    Public Sub CetakStruk_Promo(ByRef Nama As String, ByRef No_trans As String, ByRef Pesan As String)
        Dim Printer As New Printer
        If CDbl(ReadIni("Printer", "Use_Barcode")) = 1 Then
            Printer.Print("")
            Printer.FontName = "IDAutomationHC39M"
            'Printer.CurrentX = (Printer.ScaleWidth - Printer.TextWidth(No_trans)) \ 2
            Printer.FontSize = 11
            Printer.Print("*" & Left(Nama, 3) & Mid(No_trans, 4, 4) & Mid(No_trans, 9, 4) & Mid(No_trans, 15, 2) & Mid(No_trans, 19, 3) & "*")
            Printer.FontSize = 8
            'UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="971F4DF4-254E-44F4-861D-3AA0031FE361"'
            Printer.FontName = "Printer 17cpi"
            Printer.Print("")
        Else
            Printer.Print(VGaris)
            Printer.Write("TRANS#")
            Printer.CurrentX = 800 : Printer.Print(": " & No_trans)
            Printer.Write("CASHIER")
            Printer.CurrentX = 800 : Printer.Print(": " & VShift & " - " & VKasir_ID & "/" & VKasir_Nm)
            Printer.Write("TIME")
            Printer.CurrentX = 800 : Printer.Print(": " & Format(Now, "dd/MMM/yyyy hh:mm:ss"))
            Printer.Print(VGaris)
        End If
        'Printer.Print "No MySTAR Card";
        'Printer.CurrentX = 1500: Printer.Print ": " & Card_No_StrukTambahan
        Printer.Print(Pesan)
        Printer.Print(VGaris)
        Printer.Print("") : Printer.Print("") : Printer.Print("")
        Printer.Print("") : Printer.Print("") : Printer.Print("")
        Printer.EndDoc()
    End Sub

End Module
