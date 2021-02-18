Imports System.Data.SqlClient
Imports System.Xml
Imports System.Math
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Module Module1
    Public m_con As SqlConnection
    Public VSvr, ConnServer, ConnLocal, VBranch_ID, VReg_ID, VReg_OL,
    CDCom, CDSet, PPort, Log_P, TipKom, VPing, VHargaPoint,
    StrSQL, VKasir_ID, VKasir_Nm, VSuper_Nm, Star_Nm, Star_Id,
    Star_Freq, Star_Omz, VGaris, Star_No, Star_Phone, Star_Ext1,
    Star_Email, Exp_Point, Expired_Date, VNomor, VKary,
    RFIDType, IPReader, PortReader, no_kartuECR, PowerIndex, CD_Type, spg_btn As String
    Public KeyStroke(0 To 121) As String
    Public VAda_Promo, VOK, VCopen, VIsSSC, VIsKKG, VTanya, LoadClose, FingerOK, GotoPayment, EODFirstForm As Boolean
    Public VShift, Star_Pt, VDiscBySTAR, isECR, ECRComm, RegType, BagRFID As Integer
    Public VBonus_Point, Star_updsts As Byte
    Public Tulis(50) As String
    Public Declare Function Inp Lib "inpout32.dll" Alias "Inp32" (ByVal PortAddress As Integer) As Integer
    Public Declare Function Out Lib "inpout32.dll" Alias "Out32" (ByVal PortAddress As Integer, ByVal Value As Integer)
    Public conID As String = "192.168.1.116:9090"
    Public example As frmSalesSelf = New frmSalesSelf()
    Public RFIDOKE, OneReadAll, NewMember As Boolean
    Public vdiscrp1RFID, vdiscrp2RFID, vtotalRFID, vgtotalRFID As Decimal
    Public vqtyRFID, lblqtyRFID, lblgrand_totalRFID, Antenna_No, SecLev As Integer
    Public vno_transRFID, txtcust_idRFID, txtcard_noRFID As String
    Public RFIDStatus As Boolean

    Private Const INSTANCE_ID As String = "YOUR_INSTANCE_ID_HERE"
    Private Const CLIENT_ID As String = "YOUR_CLIENT_ID_HERE"
    Private Const CLIENT_SECRET As String = "YOUR_CLIENT_SECRET_HERE"
    Private Const API_URL As String = "http://api.whatsmate.net/v3/whatsapp/single/text/message/" + INSTANCE_ID

    Sub Main()
        Dim RegSetting As String

        RegSetting = System.Threading.Thread.CurrentThread.CurrentCulture.ToString
        If RegSetting <> "en-US" Then
            MsgBox("Anda menggunakan Regional Setting " & RegSetting & "Anda harus mengganti Regional Setting menjadi English(United States)", 64, "Oops..")
            System.Diagnostics.Process.Start("intl.cpl")
            End
        End If


        ConnServer = "Data Source=" & ReadIni("Server", "ServerName") & ";" &
                "Initial Catalog=" & ReadIni("Server", "DatabaseName") & ";" &
                "User ID=" & ReadIni("Server", "LoginId") & ";" &
                "Password=" & decrypt(ReadIni("Server", "Password")) & ";"

        ConnLocal = "Data Source=" & ReadIni("Local", "ServerName") & ";" &
                "Initial Catalog=" & ReadIni("Local", "DatabaseName") & ";" &
                "User ID=" & ReadIni("Local", "LoginId") & ";" &
                "Password=" & decrypt(ReadIni("Local", "Password")) & ";"

        VBranch_ID = ReadIni("RegisterInfo", "BranchID")
        VReg_ID = ReadIni("RegisterInfo", "RegID")
        VReg_OL = ReadIni("RegisterInfo", "RegOnline")
        VSvr = ReadIni("Server", "ServerName")

        CD_Type = ReadIni("Device", "CD_Type")
        CDCom = ReadIni("Device", "CD_Com")
        CDSet = ReadIni("Device", "CD_Set")
        PPort = ReadIni("Printer", "PrinterPort")
        Log_P = ReadIni("Device", "Log_Path")
        TipKom = ReadIni("Device", "Touch")
        IPReader = ReadIni("RFID", "IPReader")
        PortReader = ReadIni("RFID", "PortReader")
        Antenna_No = ReadIni("RFID", "Antenna_No")
        RFIDType = ReadIni("RFID", "ReaderTipe")
        isECR = ReadIni("RFID", "ECRisAktiv")
        ECRComm = ReadIni("RFID", "ECRComm")
        PowerIndex = ReadIni("RFID", "PowerIndex")
        RegType = ReadIni("Device", "RegType")
        'If RFIDType = "zebra" Then
        '    frmSales.CheckConZebra()
        'End If
        VPing = IIf(VSvr = "", "OFFLINE", "ONLINE")
        If VBranch_ID <> "" And VReg_ID <> "" Then
            frmSplash.Show()
        Else
            MsgBox("File konfigurasi belum lengkap", vbCritical + vbOKOnly, "Oops..")
        End If
    End Sub
    Public Function Linked() As Boolean
        Try
            If My.Computer.Network.Ping(VSvr) Then
                Linked = True
                VPing = "ONLINE"
            Else
                Linked = False
                VPing = "OFFLINE"
            End If
            If RFIDType = "zebra" Then
            Else
                'frmSales.CheckCon()
            End If

        Catch ex As Exception
            Linked = False
            VPing = "OFFLINE"
        End Try

    End Function

    Public Function getSqldb(ByVal scmd As String, ByVal Srv As String) As DataSet
        m_con = New SqlConnection(Srv)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand

        cmd = m_con.CreateCommand
        cmd.CommandText = scmd
        cmd.CommandTimeout = 120
        da.SelectCommand = cmd
        If m_con.State = ConnectionState.Open Then
            m_con.Close()
        End If
        m_con.Open()
1:
        Try
            da.Fill(ds)
        Catch ex As Exception
            'GoTo 1
            MsgBox(ex.Message)
        End Try

        m_con.Close()
        Return ds
    End Function

    Public Function ReadIni(ByVal xTipe As String, ByVal xName As String) As String
        Dim res As Integer
        Dim sb As StringBuilder
        sb = New StringBuilder(500)
        res = GetPrivateProfileString(xTipe, xName, "", sb, sb.Capacity, Application.StartupPath & "\Config.ini")
        'res = GetPrivateProfileString(xTipe, xName, "", sb, sb.Capacity, "C:\Program Files\Berca\Config.ini")
        ReadIni = sb.ToString()
    End Function

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
            ByVal lpKeyName As String,
            ByVal lpDefault As String,
            ByVal lpReturnedString As StringBuilder,
            ByVal nSize As Integer,
            ByVal lpFileName As String) As Integer

    Public Function decrypt(ByVal unpass As String) As String
        Dim x As Integer
        Dim awal As String, kembali As String
        x = 1
        awal = ""
        Do While x <= Len(Trim(unpass))
            kembali = Mid(unpass, x, 3)
            x = x + 3
            awal = awal + Chr((Val(kembali) + 11) / 3 - 5)
        Loop
        decrypt = awal
    End Function

    Sub SaveLog(ByVal Param As String)
        Dim line As String = ""
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\LOG_" & Format(Now, "ddMMyyyy") & ".txt"
        If File.Exists(path) Then
            Using sr As New StreamReader(path)
                line = sr.ReadToEnd
            End Using
        End If
        File.Delete(path)
        Dim sw As New IO.StreamWriter(path)
        sw.Write(line)
        sw.Write(vbNewLine)
        sw.Write(Param)
        sw.Close()
        sw.Dispose()
    End Sub

    Public Function Super(ByVal lvl As Byte) As Boolean
        VOK = False
        VSuper_Nm = ""
        frmValid.VLevelApp.Text = lvl
        frmValid.ShowDialog()
        Super = VOK
    End Function

    Public Function UbahChar(ByRef Kata As String) As String
        UbahChar = Replace(Kata, "'", "''")
    End Function

    Public Function GetSrvDate() As Date
        Try
            Dim RsTglVsvr As New DataSet
            If VPing = "ONLINE" Then
                RsTglVsvr = getSqldb("select getdate() as srvdt", ConnServer)
            Else
                RsTglVsvr = getSqldb("select getdate() as srvdt", ConnLocal)
            End If

            GetSrvDate = RsTglVsvr.Tables(0).Rows(0).Item("srvdt")
            RsTglVsvr.Clear()
            RsTglVsvr = Nothing
        Catch ex As Exception
            GetSrvDate = Now()
        End Try
    End Function



    Public Function sendMessage(ByVal number As String, ByVal message As String) As Boolean
        Dim success As Boolean = True
        Dim webClient As New WebClient()

        Try
            Dim payloadObj As New Payload(number, message)
            Dim serializer As New JavaScriptSerializer()
            Dim postData As String = serializer.Serialize(payloadObj)

            webClient.Headers("content-type") = "application/json"
            webClient.Headers("X-WM-CLIENT-ID") = CLIENT_ID
            webClient.Headers("X-WM-CLIENT-SECRET") = CLIENT_SECRET

            webClient.Encoding = Encoding.UTF8
            Dim response As String = webClient.UploadString(API_URL, postData)
            Console.WriteLine(response)
        Catch webEx As WebException
            Dim res As HttpWebResponse = DirectCast(webEx.Response, HttpWebResponse)
            Dim stream As Stream = res.GetResponseStream()
            Dim reader As New StreamReader(stream)
            Dim body As String = reader.ReadToEnd()

            Console.WriteLine(res.StatusCode)
            Console.WriteLine(body)
            success = False
        End Try

        Return sendMessage
    End Function


    Private Class Payload
        Public number As String
        Public message As String

        Sub New(ByVal num As String, ByVal msg As String)
            number = num
            message = msg
        End Sub
    End Class
End Module
