Imports System.Windows.Forms.HtmlElementCollection
Imports System.Windows.Forms.HtmlElement

Imports System.Security.Permissions 'clear up any html/js/vb mixups
Imports Microsoft.Win32 'used for registeryKey

'Legacy from other similar app
'open file dialog
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Ports

'my custom serial classes
Imports CelestialHtmlWinForm.GPGGA_Class
Imports CelestialHtmlWinForm.GPGSA_Class
Imports CelestialHtmlWinForm.GPRMC_Class
Imports CelestialHtmlWinForm.GPGSV_Class

Public Class Form1

    Dim BU353_GPGGA As New GPGGA_Class
    Dim BU353_GPGSA As New GPGSA_Class
    Dim BU353_GPRMC As New GPRMC_Class
    Dim BU353_GPGSV As New GPGSV_Class
    Dim initialLatitude, initialLongitude As Double
    Public DecimalDegree As Boolean = False 'toggle button value

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim urlstring As String
        urlstring = "/index.html"
        wbHtmlIndex.Url = New Uri(urlstring)

        tmrBaud.Enabled = False
        GetSerialPortNames()
        tmrBaud.Enabled = True

    End Sub

    ''' 
    ''' App Buttons and Form Diaplays
    '''
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub fakeSerialInput()
        Dim randomNumber1, randomNumber2 As Integer
        Dim n As Integer
        Dim html_element1, html_element2 As HtmlElement

        n = 1234 'from 0 to n

        html_element1 = Me.wbHtmlIndex.Document.GetElementById("latitudeDiv")
        html_element2 = Me.wbHtmlIndex.Document.GetElementById("longitudeDiv")

        randomNumber1 = CInt(Math.Ceiling(Rnd() * n)) + 1
        randomNumber2 = CInt(Math.Ceiling(Rnd() * n)) + 1

        html_element1.InnerText = "N/A"

        randomNumber1 = CInt(Math.Ceiling(Rnd() * n)) + 1
        randomNumber2 = CInt(Math.Ceiling(Rnd() * n)) + 1

        html_element2.InnerText = randomNumber1.ToString + "." + randomNumber2.ToString
    End Sub

    Private Sub logInHtmlDisplay()

    End Sub

    Private Sub btnSerialInputTest_Click(sender As Object, e As EventArgs) Handles btnSerialInputTest.Click
        fakeSerialInput()
    End Sub

    Private Sub wbHtmlIndex_Resize(sender As Object, e As EventArgs) Handles wbHtmlIndex.Resize
        lblWebContainer.Text = "Web Dimentions: " + wbHtmlIndex.Width.ToString + " x " + wbHtmlIndex.Height.ToString


    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        lblAppContainer.Text = "App Dimentions: " + Me.Width.ToString + " x " + Me.Height.ToString
    End Sub

    Private Sub btnRefreshBrowser_Click(sender As Object, e As EventArgs) Handles btnRefreshBrowser.Click
        wbHtmlIndex.Refresh()
    End Sub
    ''' 
    ''' Write to HTML
    '''
    Private Sub writeGPGGAtoHTML(ByVal lat As String, ByVal lon As String, ByVal satQuantity As String, ByVal PDOP As String, ByVal altitude As String, ByVal fixstrength As String)

        'Dim html_latitude, html_longitude As HtmlElement

        Me.wbHtmlIndex.Document.GetElementById("latitudeDiv").InnerText = lat
        Me.wbHtmlIndex.Document.GetElementById("longitudeDiv").InnerText = lon
        Me.wbHtmlIndex.Document.GetElementById("numberOfsatelitesDiv").InnerText = satQuantity
        Me.wbHtmlIndex.Document.GetElementById("PDOPDiv").InnerText = PDOP
        Me.wbHtmlIndex.Document.GetElementById("altitudeDiv").InnerText = altitude
        Me.wbHtmlIndex.Document.GetElementById("signalStrengthDiv").InnerText = fixstrength

    End Sub

    ''' 
    ''' Interface with Serial Classes
    ''' 
    Private Sub readGPGSA(ByVal lineArr As Array)
        BU353_GPGSA.globalBU353ClassVar(lineArr)
    End Sub

    Private Sub readGPRMC(ByVal lineArr As Array)
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
                writeGPGGAtoHTML("N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
            Case 1
                'GPS fix
                writeGPGGAtoHTML(Latitude, Longitude, SateliteNo, Dilution, Altitude, AntennaFix)
            Case Else
                'Spotty
        End Select

    End Sub

    Private Sub readGPGSV(ByVal lineArr As Array)
        BU353_GPGSV.globalBU353ClassVar(lineArr)
    End Sub

    Sub GetSerialPortNames()
        ' it is expected that the typicall mobile app will only have at most 1 USB COM port plugged in

        Dim listOfCOMPorts As New List(Of Integer)()
        Dim portNameString As String

        portNameString = "COM4"

        Try
            If (spBU353.IsOpen = False) Then
                spBU353.Close()
            End If

            For Each sp As String In My.Computer.Ports.SerialPortNames
                ' realistically there will be only 1 COM name, but if there are more, then at least they are all archived 
                portNameString = sp

            Next

            spBU353.PortName = portNameString

            If (spBU353.IsOpen = False) Then
                spBU353.Open()
            End If

        Catch ex As Exception
        End Try

    End Sub

    ''' 
    ''' Interface Serial Iimer Signal Input/Process Trigger
    ''' 
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
                                Catch
                                End Try
                            End If
                        Case "GPGSA"
                            If (lineArr.Length > 14) Then
                                Try
                                    readGPGSA(lineArr)
                                Catch
                                End Try
                            End If
                        Case "GPGSV"
                            If (lineArr.Length > 18) Then
                                Try
                                    readGPGSV(lineArr)
                                Catch
                                End Try
                            End If
                        Case "GPRMC"
                            If (lineArr.Length > 8) Then
                                Try
                                    readGPRMC(lineArr)
                                Catch
                                End Try
                            End If
                        Case Else
                    End Select
                Next
            End If
        Else
            'no serial comms
        End If
    End Sub

End Class
