Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Ports
'Imports System.Threading

'open file dialog
Imports System.IO
Imports Microsoft.VisualBasic

'my custom class
Imports WindowsApplication1.GPGGA_Class
Imports WindowsApplication1.GPGSA_Class
Imports WindowsApplication1.GPRMC_Class
Imports WindowsApplication1.GPGSV_Class

'read
Imports System.Management

Public Class frmGpsUI
    Private LocalMousePosition As Point

#Region "Member Variables"

    Dim GLOBAL_SAVE_PATH As String = "C:\BackYardGps\"
    Dim BU353_GPGGA As New GPGGA_Class
    Dim BU353_GPGSA As New GPGSA_Class
    Dim BU353_GPRMC As New GPRMC_Class
    Dim BU353_GPGSV As New GPGSV_Class
    Dim initialLatitude, initialLongitude As Double

    '''''''''''''''''

    Dim output2 As New Bitmap(300, 300)
    Dim imageGridImage As New Bitmap(Global.WindowsApplication1.My.Resources.Resources.graph_6x6) 'grid background
    Dim imageGoodSignal As New Bitmap(Global.WindowsApplication1.My.Resources.Resources.goodsignal) 'good
    Dim imageBadSignal As New Bitmap(Global.WindowsApplication1.My.Resources.Resources.nosignal) 'bad
    Dim imageSketchySignal As New Bitmap(Global.WindowsApplication1.My.Resources.Resources.sketchysignal) 'cloudy
    Dim imageMapImage As New Bitmap(Global.WindowsApplication1.My.Resources.Resources.foldedmapimage) 'neutral

    Dim tBrush2 As New TextureBrush(imageGridImage)
    Dim gfx2 As Graphics = Graphics.FromImage(output2)
    Dim SpriteX2 As Integer = 135
    Dim SpriteY2 As Integer = 135
    Dim moveStep2 As Double = 4

    '''''''''''''''''
    Public distanceTraveled As Integer = 0
    Public receptionLossHz As Integer = 0
    Public appStartUPTimeInstance As String = My.Computer.Clock.LocalTime.ToShortTimeString
    Public gpsFix As Boolean
    Public startstop As Boolean = False
    Public startPointReset As Boolean = False
    Public satelitepane As Boolean = False
    Public DecimalDegree As Boolean = False 'toggle button value

#End Region

#Region "Constructor"

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'GetSerialPortNames()
        ' Try to open the serial port

    End Sub

#End Region

#Region "Buttons"

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        enterRecord()
    End Sub
    Private Sub btnUpdateComPortNumber_Click(sender As Object, e As EventArgs) Handles btnUpdateComPortNumber.Click

        Try
            tmrBaud.Enabled = False
            GetSerialPortNames() 'fill combobox with COM port names

            spBU353.Close()

            If (cbxCOM.Items.Count > 0) Then
                cbxCOM.SelectedIndex = 0
                spBU353.PortName = cbxCOM.SelectedItem

                btnUpdate.Enabled = True
                lostSignalHz.Text = "Select COM Port and Press START Button. The displayed COM is default."

                spBU353.Open()
                btnUpdate.Enabled = True
                cbxCOM.Enabled = True

                If (spBU353.IsOpen = False) Then
                    tmrBaud.Enabled = True
                End If

            Else
                'NoSerialComDisp()
                btnUpdate.Enabled = False
                btnUpdate.BackColor = Color.LightCoral
                btnUpdate.Text = "Disabled Untill A GPS COM Port is selected"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            tmrBaud.Enabled = False
            btnUpdate.Text = "Disabled Untill A GPS COM Port is acknowledged" & Environment.NewLine & ChrW(&H25A0)
            btnUpdate.Enabled = False
            btnUpdate.BackColor = Color.LightCoral
            Return
        End Try

    End Sub
    Private Sub cbxCOM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCOM.SelectedIndexChanged

        If (cbxCOM.Items.Count > 0) Then
            Try
                If ((cbxCOM.SelectedItem <> Nothing) And (cbxCOM.SelectedItem <> "") And (cbxCOM.SelectedItem <> "COM")) Then
                    tmrBaud.Enabled = False
                    spBU353.Close()
                    spBU353.PortName = cbxCOM.SelectedItem
                    spBU353.BaudRate = 4800
                    spBU353.Open()
                    btnUpdate.Enabled = True
                    btnUpdate.Text = "START" & Environment.NewLine & ChrW(&H25B6)
                    btnUpdate.BackColor = Color.MediumSeaGreen
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                btnUpdate.Enabled = False
                btnUpdate.Text = "Disabled Untill A GPS COM Port is acknowledged"
                tmrBaud.Enabled = False
            End Try
        End If

    End Sub
    Private Sub hsbZoom_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbZoom.Scroll
        Dim i As Integer
        i = hsbZoom.Value
        lblZoom.Text = "x" + i.ToString
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim AntennaTime = GPGGA_Class.utcTime.ToString()

        startstop = Not startstop

        If ((AntennaTime <> "") Or (AntennaTime <> Nothing)) Then
            'enterRecord() 'write to text file
            lostSignalHz.Text = receptionLossHz.ToString + " lost signals since " + appStartUPTimeInstance + " Local, " + AntennaTime + " UTC"
        Else
            'lostSignalHz.Text = "Refresh 'START/PAUSE Button'"
            NoSerialComDisp()
        End If

        If (startstop = True) Then
            ToggleUpdateOFF() 'start
        Else
            ToggleUpdateON() 'stop
        End If

    End Sub
    Private Sub btnDecimalDegree_Click(sender As Object, e As EventArgs) Handles btnDecimalDegree.Click

        'toggle decimal to degree
        If (startstop = True) Then

            DecimalDegree = Not DecimalDegree

            If (DecimalDegree = True) Then
                btnDecimalDegree.Text = "decimal coordinate" & Environment.NewLine & ChrW(&HB1) & " 00.0000"
                btnDecimalDegree.BackColor = Color.Gold
            Else
                btnDecimalDegree.Text = "degree coordinate" & Environment.NewLine & "E/W 00" & ChrW(&HB0) & ".00' 00''"
                btnDecimalDegree.BackColor = Color.Plum
            End If
        End If
        

    End Sub
    Private Sub btnSateliteInfo_Click(sender As Object, e As EventArgs) Handles btnSateliteInfo.Click
        'display satelite information if satelite count is greater than 0
        'form size min 510, 676
        'form size max 610, 676

        satelitepane = Not satelitepane

        If (satelitepane = False) Then
            'normal
            Me.Size = New System.Drawing.Size(510, 676)
            btnSateliteInfo.Text = "Open Satelite Panel" & ChrW(&H2B0C)
        Else
            'expand
            Me.Size = New System.Drawing.Size(820, 676)
            btnSateliteInfo.Text = "Close Satelite Panel" & ChrW(&H2B0C)
        End If



    End Sub

#End Region

#Region "Serial"

    Private Sub readGPGSA(ByVal lineArr As Array)

        BU353_GPGSA.globalBU353ClassVar(lineArr)

        lblmode.Text = "Mode: " & GPGSA_Class.MODE1
        lblfixtype.Text = "Fix Type: " & GPGSA_Class.MODE2

        noofsats.Text = "No Of Sats.: " & GPGSA_Class.SatIDCount  '& sateltiteNo.ToString &
        lblSatID0.Text = "Sat. ID: " & GPGSA_Class.SatID(0)
        lblSatID1.Text = "Sat. ID: " & GPGSA_Class.SatID(1)
        lblSatID2.Text = "Sat. ID: " & GPGSA_Class.SatID(2)
        lblSatID3.Text = "Sat. ID: " & GPGSA_Class.SatID(3)
        lblSatID4.Text = "Sat. ID: " & GPGSA_Class.SatID(4)
        lblSatID5.Text = "Sat. ID: " & GPGSA_Class.SatID(5)
        lblSatID6.Text = "Sat. ID: " & GPGSA_Class.SatID(6)
        lblSatID7.Text = "Sat. ID: " & GPGSA_Class.SatID(7)
        lblSatID8.Text = "Sat. ID: " & GPGSA_Class.SatID(8)
        lblSatID9.Text = "Sat. ID: " & GPGSA_Class.SatID(9)
        lblSatID10.Text = "Sat. ID: " & GPGSA_Class.SatID(10)
        lblSatID11.Text = "Sat. ID: " & GPGSA_Class.SatID(11)

        lblPDOP.Text = "PDOP: " & GPGSA_Class.PDOP
        lblHDOP.Text = "HDOP: " & GPGSA_Class.HDOP
        lblVDOP.Text = "VDOP: " & GPGSA_Class.VDOP

    End Sub

    Private Sub readGPRMC(ByVal lineArr As Array)
        'Dim lat, lon, utctime, status, utcdate, mode As String
        'Dim sog, cog, NS, EW As String


        BU353_GPRMC.globalBU353ClassVar(lineArr)

        txtRMC_UtcTime.Text = "Time: " & GPRMC_Class.UTCTime.ToString()
        txtRMC_UtcDate.Text = "Date: " & GPRMC_Class.UTCDATE.ToString()

        txtRMC_Lat.Text = GPRMC_Class.LATITUDE.ToString()
        txtRMC_Lon.Text = GPRMC_Class.LONGITUDE.ToString()

        txtRMC_SOG.Text = GPRMC_Class.SOG.ToString()
        txtRMC_COG.Text = GPRMC_Class.COG.ToString()

        txtRMC_NS.Text = GPRMC_Class.NSindicator.ToString()
        txtRMC_EW.Text = GPRMC_Class.EWindicator.ToString()

        txtRMC_Status.Text = GPRMC_Class.STATUS.ToString()



    End Sub

    Private Sub readGPGGA(ByVal lineArr As Array)

        'pass all string variables
        Dim Latitude, Longitude, AntennaTime, AntennaFix, SateliteNo, Dilution, Altitude, NS, EW As String

        NS = "?"
        EW = "?"
        Latitude = "?"
        Longitude = "?"

        'counter for all the lost connections
        BU353_GPGGA.globalBU353ClassVar(lineArr, DecimalDegree)

        NS = GPGGA_Class.northsouthNSString
        Latitude = GPGGA_Class.latPosition.ToString

        EW = GPGGA_Class.eastwestEWString
        Longitude = GPGGA_Class.lonPosition.ToString

        AntennaTime = GPGGA_Class.utcTime.ToString
        AntennaFix = GPGGA_Class.qualityIndicator.ToString
        SateliteNo = GPGGA_Class.sateliteNumber.ToString
        Dilution = GPGGA_Class.horizontalDilutionPrecision.ToString
        Altitude = GPGGA_Class.altitudeSeaLevel.ToString

        Select Case AntennaFix
            Case 0
                'fix not available
                NoFixDisplayData(Latitude, Longitude)
                receptionLossHz = receptionLossHz + 1
                BadHzCounter(receptionLossHz, 10, AntennaTime)

            Case 1
                'GPS fix
                GoodFixDisplayData(Latitude, Longitude, Dilution, SateliteNo, AntennaTime, Altitude, NS, EW)
                'receptionLossHz = 0
            Case Else
                'Spotty
                SpottyFixDisplayData(AntennaTime, Dilution)
                'receptionLossHz = 0
        End Select

    End Sub

    Private Sub readGPGSV(ByVal lineArr As Array)

        BU353_GPGSV.globalBU353ClassVar(lineArr)

        lblNoOfMsgs.Text = "# Of Messages: " & GPGSV_Class.NoOfMsgs.ToString
        lblMsgNo.Text = "Message #: " & GPGSV_Class.msgNo.ToString
        lblTotalNoOfSVs.Text = "Total # Of SVs : " & GPGSV_Class.totalNoOfSV.ToString

        lblSvPrNo0.Text = "SV PR Number: " & GPGSV_Class.svPRNno(0).ToString
        lblElevation0.Text = "Elevation: " & GPGSV_Class.Elevation(0).ToString
        lblAzimuth0.Text = "Azimuth: " & GPGSV_Class.Azimuth(0).ToString
        lblSNR0.Text = "SNR: " & GPGSV_Class.SNR(0).ToString

        lblSvPrNo1.Text = "SV PR Number: " & GPGSV_Class.svPRNno(1).ToString
        lblElevation1.Text = "Elevation: " & GPGSV_Class.Elevation(1).ToString
        lblAzimuth1.Text = "Azimuth: " & GPGSV_Class.Azimuth(1).ToString
        lblSNR1.Text = "SNR: " & GPGSV_Class.SNR(1).ToString

        lblSvPrNo2.Text = "SV PR Number: " & GPGSV_Class.svPRNno(2).ToString
        lblElevation2.Text = "Elevation: " & GPGSV_Class.Elevation(2).ToString
        lblAzimuth2.Text = "Azimuth: " & GPGSV_Class.Azimuth(2).ToString
        lblSNR2.Text = "SNR: " & GPGSV_Class.SNR(2).ToString

        lblSvPrNo3.Text = "SV PR Number: " & GPGSV_Class.svPRNno(3).ToString
        lblElevation3.Text = "Elevation: " & GPGSV_Class.Elevation(3).ToString
        lblAzimuth3.Text = "Azimuth: " & GPGSV_Class.Azimuth(3).ToString
        lblSNR3.Text = "SNR: " & GPGSV_Class.SNR(3).ToString

    End Sub

    Private Sub tmrBaud_Tick(sender As Object, e As EventArgs) Handles tmrBaud.Tick

        If spBU353.IsOpen Then

            Dim data As String = spBU353.ReadExisting()
            Dim strArr() As String = data.Split("$")
            If strArr.Length > 1 Then
                For i = 0 To (strArr.Length - 1)

                    Dim strTemp As String = strArr(i)
                    Dim lineArr() As String = strTemp.Split(",")

                    Select Case lineArr(0).ToString
                        Case "GPGGA"

                            If (lineArr.Length = 15) Then
                                Try
                                    readGPGGA(lineArr)

                                    'initize a start point
                                    If (startPointReset = False) Then 'initialize a start point
                                        initialLatitude = GPGGA_Class.latPosition
                                        initialLongitude = GPGGA_Class.lonPosition
                                        startPointReset = True

                                        enterRecord()
                                    Else
                                        positionView(hsbZoom.Value)
                                    End If

                                Catch
                                    SpottyFixDisplayData("!", "!")

                                    receptionLossHz = receptionLossHz + 1
                                    BadHzCounter(receptionLossHz, 10, 0)
                                End Try
                            End If

                        Case "GPGSA"

                            If (lineArr.Length > 14) Then
                                Try
                                    readGPGSA(lineArr)
                                Catch
                                    'nothing
                                End Try
                            End If

                        Case "GPGSV"

                            If (lineArr.Length > 18) Then
                                Try
                                    readGPGSV(lineArr)
                                Catch
                                    'nothing
                                End Try
                            End If

                        Case "GPRMC"

                            If (lineArr.Length > 8) Then
                                Try
                                    readGPRMC(lineArr)
                                Catch
                                    'nothing
                                End Try
                            End If

                        Case Else
                            receptionLossHz = receptionLossHz + 1
                            BadHzCounter(receptionLossHz, 10, 0)

                    End Select

                Next
            End If
        Else
            NoSerialComDisp()
        End If

    End Sub

    Sub GetSerialPortNames()
        ' Show all available COM ports. 
        Try
            If (spBU353.IsOpen = False) Then
                spBU353.Close()
            End If

            cbxCOM.Items.Clear()
            For Each sp As String In My.Computer.Ports.SerialPortNames
                cbxCOM.Items.Add(sp)
            Next

            If (cbxCOM.Items.Count > 0) Then
                cbxCOM.SelectedIndex = 0
                lostSignalHz.Text = "Select COM Port and Press START Button. The displayed COM is default."
                Return

            Else
                NoSerialComDisp()
                Return
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            NoSerialComDisp()
            Return

        End Try

    End Sub

#End Region

#Region "Display"
    'Map View
    Sub refreshScreen2() Handles tmrGraphicsRefresh.Tick
        gfx2.FillRectangle(tBrush2, New Rectangle(0, 0, 300, 300))
        gfx2.FillRectangle(Brushes.Green, SpriteX2, SpriteY2, 15, 15)
        PictureBox2.Image = output2

    End Sub
    Sub positionView(ByVal zoomFactor As Integer)

        Dim x1, x2, y1, y2, distanceX, distanceY, distanceXY As Double
        Dim unitOfMeasure As Char
        Dim updown, leftright As Integer 'used for graphic display only

        y1 = GPGGA_Class.lonPosition
        y2 = initialLongitude

        x1 = GPGGA_Class.latPosition
        x2 = initialLatitude

        unitOfMeasure = "M" 'miles

        'i want to give a relative direction, from initial position
        If (y2 > y1) Then 'go up
            updown = 1
        Else 'go down
            updown = -1
        End If

        If (x2 > x1) Then 'go rt
            leftright = 1
        Else 'go lt
            leftright = -1
        End If

        If ((GPGGA_Class.latPosition <> Nothing) And (initialLongitude <> Nothing) And (GPGGA_Class.lonPosition <> Nothing) And (initialLatitude <> Nothing)) Then

            distanceX = distance(x1, 0, x2, 0, unitOfMeasure)
            distanceY = distance(0, y1, 0, y2, unitOfMeasure)
            distanceXY = distance(x1, y1, x2, y2, unitOfMeasure) 'un used for now

            SpriteX2 = leftright * (distanceX * (10 ^ zoomFactor)) + 150
            SpriteY2 = updown * (distanceY * (10 ^ zoomFactor)) + 150

            TextBox1.Text = SpriteX2 - 150
            TextBox2.Text = SpriteY2 - 150
        End If

    End Sub

    'Signal View
    Private Sub GoodFixDisplayData(ByVal Latitude As String, ByVal Longitude As String, ByVal Dilution As String, ByVal SateliteNo As String, ByVal AntennaTime As String, ByVal Altitude As String, ByVal NS As String, ByVal EW As String)

        'all string inputs
        txtNS.Text = NS
        txtLatitude.Text = Latitude
        txtEW.Text = EW
        txtLongitude.Text = Longitude
        'lostSignalHz.Text = receptionLossHz.ToString + " lost signals since " + appStartUPTimeInstance + " Local, " + AntennaTime + " UTC"
        txtHirizDilution.Text = Dilution 'Horizontal dilution of position
        txtNoSateltites.Text = SateliteNo
        txtAltitude.Text = Altitude
        'Me.Text = "BackYard GPS [Latest Antenna UTC Time: " + AntennaTime + " ]"

        Select Case Dilution
            'horizontal dilution preception
            Case Is < 1
                lblSignalStrength.Text = "Signal Strength: Ideal"
                PictureBox1.Image = imageGoodSignal
                txtHirizDilution.Text = "0.01"
            Case 1 To 2
                lblSignalStrength.Text = "Signal Strength: Excellent"
                PictureBox1.Image = imageGoodSignal
            Case 2 To 5
                lblSignalStrength.Text = "Signal Strength: Good"
                PictureBox1.Image = imageGoodSignal
            Case 5 To 10
                lblSignalStrength.Text = "Signal Strength: Moderate"
                PictureBox1.Image = imageSketchySignal
            Case 10 To 20
                lblSignalStrength.Text = "Signal Strength: Fair"
                PictureBox1.Image = imageSketchySignal
            Case Else
                lblSignalStrength.Text = "Signal Strength: Poor"
                PictureBox1.Image = imageBadSignal
        End Select

        receptionLossHz = 0
        appStartUPTimeInstance = My.Computer.Clock.LocalTime.ToShortTimeString()

    End Sub

    Private Sub NoFixDisplayData(ByVal Latitude As String, ByVal Longitude As String)
        txtLatitude.Text = txtLatitude.Text
        txtLongitude.Text = txtLongitude.Text
        lblSignalStrength.Text = "Signal Strength: None"
        PictureBox1.Image = imageSketchySignal
        txtHirizDilution.Text = "N/A"

        'Me.Text = vbNullString
        'Me.Text = " BackYard GPS [Latest Antenna UTC Time: ? NoFixDisplayData()]"
    End Sub
    Private Sub SpottyFixDisplayData(ByVal AntennaTime As String, ByVal Dilution As String)
        'txtLatitude.Text = "? " + txtLatitude.Text
        'txtLongitude.Text = "? " + txtLongitude.Text
        lblSignalStrength.Text = "Signal Strength: N/A"
        PictureBox1.Image = imageSketchySignal
        txtHirizDilution.Text = Dilution
        'Me.Text = "BackYard GPS [Latest Antenna UTC Time: " + AntennaTime + " ]"

    End Sub
    Private Sub ToggleUpdateON()
        btnUpdate.Text = "START" & Environment.NewLine & ChrW(&H25B6)
        cbxCOM.Enabled = True
        btnUpdateComPortNumber.Enabled = True
        tmrBaud.Enabled = False
        PictureBox1.Image = imageMapImage
        lblSignalStrength.Text = "Signal Strength: 'GPS Paused'"
        btnUpdate.BackColor = Color.MediumSeaGreen

        startPointReset = False
    End Sub
    Private Sub ToggleUpdateOFF()

        btnUpdate.Text = "PAUSE" & Environment.NewLine & ChrW(&H23F8)
        btnUpdate.BackColor = Color.LightCoral
        cbxCOM.Enabled = False
        btnUpdateComPortNumber.Enabled = False
        tmrBaud.Enabled = True
        receptionLossHz = 0


        'error catch to ensure the initial starting point came from gps coordinate

        If (startPointReset = False) Then
            'initialLatitude = GPGGA_Class.latPosition
            'initialLongitude = GPGGA_Class.lonPosition
        End If

    End Sub
    Private Sub NoSerialComDisp()
        startstop = False 'toggle on/off state
        btnUpdate.BackColor = Color.LightCoral

        txtLatitude.Text = "No GPS RX"
        txtLongitude.Text = "ERROR"
        btnUpdate.Text = "Check GPS USB"
        lostSignalHz.Text = "Antenna Could Be Unpluged. Plug-in & Refresh COM"

        tmrBaud.Enabled = False
        btnUpdate.Enabled = False
        gpsFix = False
        btnUpdateComPortNumber.Enabled = True

    End Sub
    Private Sub BadHzCounter(ByVal count As String, ByVal length As Integer, ByVal AntennaTime As Integer)
        If (count > 0) Then
            lostSignalHz.Text = receptionLossHz.ToString + " lost signals since " + appStartUPTimeInstance + ", Local App Time @ " + GPGGA_Class.utcTime.ToString + " UTC"

        Else
            lostSignalHz.Text = count + " lost signals since " + appStartUPTimeInstance + " Local App Time @ " + GPGGA_Class.utcTime.ToString + " UTC"
            Try
                SpottyFixDisplayData(AntennaTime, "?")
            Catch ex As Exception

            End Try

        End If
    End Sub

#End Region

#Region "Files"

    Sub GpsTxtFileDirectory()

        'Desktop is the Defined Root Folder

        Dim hr As String = My.Computer.Clock.LocalTime.Hour.ToString
        Dim min As String = My.Computer.Clock.LocalTime.Minute.ToString
        Dim sec As String = My.Computer.Clock.LocalTime.Second.ToString
        Dim timestamp As String = "Hr" + hr + "Min" + min + "Sec" + sec

        Dim datestamp As String = My.Computer.Clock.LocalTime.ToLongDateString

        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.Description = "Select Or Create A Location To Store Your Retrievable GPS Waypoint Log Text File (.txt)"

        Dim folderBrowser As DialogResult = FolderBrowserDialog1.ShowDialog()
        Dim outputPath As String = FolderBrowserDialog1.SelectedPath

        If Directory.Exists(outputPath) Then
            GLOBAL_SAVE_PATH = outputPath
        Else
            outputPath = FolderBrowserDialog1.SelectedPath
        End If

        'rewrite the Apps log save directory
        GLOBAL_SAVE_PATH = outputPath + "\GPSDATALOG_" + datestamp + "(" + timestamp + ")" + ".txt"

    End Sub

    Private Sub enterRecord()

        Dim lb As String
        Dim decdeg As String
        lb = Environment.NewLine


        Dim filename As String = GLOBAL_SAVE_PATH

        If (DecimalDegree = True) Then
            decdeg = "Decimal Coordinates"
        Else
            decdeg = "Degree Coordinates"
        End If

        My.Computer.FileSystem.WriteAllText(filename, "> " + GPGGA_Class.latPosition.ToString() + ", " + GPGGA_Class.lonPosition.ToString() + " " + decdeg + lb + "   Timestamp: " + GPGGA_Class.utcTime.ToString() + " UTC" + lb, True)  'make file (false=no append)"

        'Me.Text = " BackYard GPS [Latest Antenna UTC Time: " + GPGGA_Class.utcTime.ToString() + " ]"

        ' Open the file to read from. 
        Dim readText As String = My.Computer.FileSystem.ReadAllText(filename)
        txtLogDisp.Text = readText

        txtLogDisp.SelectionStart = txtLogDisp.TextLength
        txtLogDisp.ScrollToCaret()

    End Sub

#End Region

#Region "formatting"

    Function GetNumberFromStringUsingSB(ByVal theString As String) As Long
        Dim sb As New System.Text.StringBuilder(theString.Length)
        Dim outputNumber As Long
        Dim EE As Integer


        For Each ch As Char In theString
            If Char.IsDigit(ch) Then sb.Append(ch)
        Next

        'this will catch the glitchy coordinates that are short, yet still meaningful
        If (Long.Parse(sb.ToString) < 100000) Then
            EE = Int(100000 / Long.Parse(sb.ToString))
            outputNumber = Long.Parse(sb.ToString) * (10 ^ EE)
        Else
            outputNumber = Long.Parse(sb.ToString)
        End If

        Return outputNumber

    End Function

    Private Sub frmGpsUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lb As String
        Dim timestamp As String = My.Computer.Clock.LocalTime.ToLongTimeString
        Dim datestamp As String = My.Computer.Clock.LocalTime.ToLongDateString

        tmrBaud.Enabled = False
        lb = Environment.NewLine
        gpsFix = False

        GpsTxtFileDirectory()

        If (FolderBrowserDialog1.SelectedPath = "") Then
            Me.Close()
            Application.Exit()

        Else
            Dim filename As String = GLOBAL_SAVE_PATH
            Dim logHeader As String = "GPS Data Log: " + datestamp
            My.Computer.FileSystem.WriteAllText(filename, logHeader + lb + "==================================" + lb, False)  'make file (false=no append)"

            ' Open the file to read from. 
            Dim readText As String = My.Computer.FileSystem.ReadAllText(filename)
            txtLogDisp.Text = readText
        End If

        GetSerialPortNames() 'load the combobox with COM names

        'btnDecimalDegree.Text = "degree coordinate" & Environment.NewLine & "E/W 00" & ChrW(&HB0) & ".00' 00''"
        'btnUpdate.Text = "START" & Environment.NewLine & ChrW(&H25B6)
        'btnLog.Text = "LOG" & Environment.NewLine & ChrW(&H4E66) 'Unicode Han Character 'book, letter, document; writings' (U+4E66)
        hsbZoom.Value = 1

        Me.Size = New System.Drawing.Size(510, 676)
        btnSateliteInfo.Text = "Open Satelite Panel" & ChrW(&H2B0C)

    End Sub

#End Region

#Region "Math"

    ' I totally just coppied and paste this piece of math from http://www.geodatasource.com/developers/vb-dot-net
    ' no shame
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    ':::  This routine calculates the distance between two points (given the     :::
    ':::  latitude/longitude of those points). It is being used to calculate     :::
    ':::  the distance between two locations using GeoDataSource (TM) prodducts  :::
    ':::                                                                         :::
    ':::  Definitions:                                                           :::
    ':::    South latitudes are negative, east longitudes are positive           :::
    ':::                                                                         :::
    ':::  Passed to function:                                                    :::
    ':::    lat1, lon1 = Latitude and Longitude of point 1 (in decimal degrees)  :::
    ':::    lat2, lon2 = Latitude and Longitude of point 2 (in decimal degrees)  :::
    ':::    unit = the unit you desire for results                               :::
    ':::           where: 'M' is statute miles (default)                         :::
    ':::                  'K' is kilometers                                      :::
    ':::                  'N' is nautical miles                                  :::
    ':::                                                                         :::
    ':::  Worldwide cities and other features databases with latitude longitude  :::
    ':::  are available at http://www.geodatasource.com                          :::
    ':::                                                                         :::
    ':::  For enquiries, please contact sales@geodatasource.com                  :::
    ':::                                                                         :::
    ':::  Official Web site: http://www.geodatasource.com                        :::
    ':::                                                                         :::
    ':::              GeoDataSource.com (C) All Rights Reserved 2015             :::
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    Public Function distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double, ByVal unit As Char) As Double

        Dim theta As Double = lon1 - lon2
        Dim dist As Double = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))

        dist = Math.Acos(dist)
        dist = rad2deg(dist)
        dist = dist * 60 * 1.1515

        If unit = "K" Then
            dist = dist * 1.609344
        ElseIf unit = "N" Then
            dist = dist * 0.8684
        End If

        Return dist
    End Function

    Private Function deg2rad(ByVal deg As Double) As Double

        Return (deg * Math.PI / 180.0)

    End Function

    Private Function rad2deg(ByVal rad As Double) As Double

        Return rad / Math.PI * 180.0

    End Function

#End Region

End Class
