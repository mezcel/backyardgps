'Imports WindowsApplication1.frmGpsUI

Public Class GPGGA_Class

#Region "GPGAA_Notes"
    ' $GPGGA - Global Positioning System Fix Data

    ' $GPGGA,hhmmss.ss,llll.ll,a,yyyyy.yy,a,x,xx,x.x,x.x,M,x.x,M,x.x,xxxx*hh
    ' $GPGGA,194530.000,3051.8007,N,10035.9989,W,1,4,2.18,746.4,M,-22.2,M,,*6B

    ' $GPGGA = Sentence Identifier
    ' hhmmss.ss = UTC of position 
    ' llll.ll = latitude of position
    ' a = N or S
    ' yyyyy.yy = Longitude of position
    ' a = E or W 
    ' x = GPS Quality indicator (0=no fix, 1=GPS fix, 2=Dif. GPS fix) 
    ' xx = number of satellites in use 
    ' x.x = horizontal dilution of precision 
    ' x.x = Antenna altitude above mean-sea-level
    ' M = units of antenna altitude, meters 
    ' x.x = Geoidal separation
    ' M = units of geoidal separation, meters 
    ' x.x = Age of Differential GPS data (seconds) 
    ' xxxx = Differential reference station ID

    '0    = Sentence Identifier
    '1    = UTC of Position
    '2    = Latitude
    '3    = N or S
    '4    = Longitude
    '5    = E or W
    '6    = GPS quality indicator (0=invalid; 1=GPS fix; 2=Diff. GPS fix)
    '7    = Number of satellites in use [not those in view]
    '8    = Horizontal dilution of position
    '9    = Antenna altitude above/below mean sea level (geoid)
    '10   = Meters  (Antenna height unit)
    '11   = Geoidal separation (Diff. between WGS-84 earth ellipsoid and mean sea level.  -=geoid is below WGS-84 ellipsoid)
    '12   = Meters  (Units of geoidal separation)
    '13   = Age in seconds since last update from diff. reference station
    '14   = Diff. reference station ID#
    '15   = Checksum
#End Region

#Region "globalvariables"

    'Private bu353Sentence As String

    Public Shared sentenceID As String '0    = Sentence Identifier GPGGA
    Public Shared utcTime As Double '1    = UTC of Position
    Public Shared latPosition As Double '2    = Latitude
    Public Shared northsouthNSString As String '3    = N or S
    Public Shared lonPosition As Double '4    = Longitude
    Public Shared eastwestEWString As String '5    = E or W
    Public Shared qualityIndicator As Integer '6    = GPS quality indicator (0=invalid; 1=GPS fix; 2=Diff. GPS fix)
    Public Shared sateliteNumber As Integer '7    = Number of satellites in use [not those in view]
    Public Shared horizontalDilutionPrecision As Double '8    = Horizontal dilution of position
    Public Shared altitudeSeaLevel As Double '9    = Antenna altitude above/below mean sea level (geoid)
    Public Shared metersString As String '10   = Meters  (Antenna height unit)
    Public Shared geotidalSeperationDifference As Double  '11   = Geoidal separation (Diff. between WGS-84 earth ellipsoid and mean sea level.  -=geoid is below WGS-84 ellipsoid)
    Public Shared unitsofGeoTideSep As String '12   = Meters  (Units of geoidal separation)
    Public Shared differentialSeconds As Double '13   = Age in seconds since last update from diff. reference station
    Public Shared differentialStationID As String '14   = Diff. reference station ID#
    Public Shared checkSum As String '15   = Checksum

    Public Shared checkSumFlag As Boolean = True 'assume that the signal will be full and usable

#End Region

#Region "ClassSubroutines"

    Public Sub globalBU353ClassVar(ByVal bu353Sentence As Array, ByVal DecimalDegree As Boolean)

        Dim lengthN As Integer = bu353Sentence.Length
        sentenceID = bu353Sentence(0)

        lengthN = 13 '13 used out of 15 slots
            ' In $GPGGA (13) and (14) are null, the length will 2 Words Short
        differentialSeconds = 0 '13   = Age in seconds since last update from diff. reference station
        differentialStationID = "" '14   = Diff. reference station ID# 

        For word = 1 To (lengthN)
            Select Case word
                Case 1 '1    = UTC of Position
                    utcTime = timeformat(bu353Sentence(word))
                Case 2 '2    = Latitude
                    If (DecimalDegree = True) Then
                        latPosition = Str2Deg(bu353Sentence(word))
                    Else
                        latPosition = Dbl2Dec(bu353Sentence(word))
                    End If

                Case 3 '3    = N or S
                    northsouthNSString = bu353Sentence(word)
                    If (DecimalDegree = True) Then
                        If (northsouthNSString = "N") Then
                            northsouthNSString = "+"
                        ElseIf (northsouthNSString = "S") Then
                            northsouthNSString = "-"
                        End If
                    Else
                        'keep as is
                    End If

                Case 4 '4    = Longitude
                    If (DecimalDegree = True) Then
                        lonPosition = Str2Deg(bu353Sentence(word))
                    Else
                        lonPosition = Dbl2Dec(bu353Sentence(word))
                    End If

                Case 5 '5    = E or W
                    eastwestEWString = bu353Sentence(word)
                    If (DecimalDegree = True) Then
                        If (eastwestEWString = "E") Then
                            eastwestEWString = "+"
                        ElseIf (eastwestEWString = "W") Then
                            eastwestEWString = "-"
                        End If
                    Else
                        'keep as is
                    End If

                Case 6 '6    = GPS quality indicator (0=invalid; 1=GPS fix; 2=Diff. GPS fix)
                    qualityIndicator = bu353Sentence(word)
                Case 7 '7    = Number of satellites in use [not those in view]
                    sateliteNumber = bu353Sentence(word)
                Case 8 '8    = Horizontal dilution of position
                    horizontalDilutionPrecision = bu353Sentence(word)
                Case 9 '9    = Antenna altitude above/below mean sea level (geoid)
                    altitudeSeaLevel = bu353Sentence(word) * 0.1
                Case 10 '10   = Meters  (Antenna height unit)
                    metersString = bu353Sentence(word)
                Case 11 '11   = Geoidal separation (Diff. between WGS-84 earth ellipsoid and mean sea level.  -=geoid is below WGS-84 ellipsoid)
                    geotidalSeperationDifference = bu353Sentence(word)
                Case 12 '12   = Meters  (Units of geoidal separation)
                    unitsofGeoTideSep = bu353Sentence(word)
                Case 13 '15   = Checksum
                    'checkSum = checksumCalculator(bu353Sentence)
                Case Else
                    checkSumFlag = False 'a full signal was not recieved
            End Select
        Next

        differentialStationID = ""
        'http://www.trimble.com/OEM_ReceiverHelp/V4.44/en/NMEA-0183messages_MessageOverview.html
    End Sub

#End Region

#Region "ClassFunctions"

    Function Str2Deg(ByVal numberString As String) As Double
        'decimal to gegree

        Dim StrIn, DegOut As Double
        Dim MinSecStr() As String = {"0.0", "0.0"}
        Dim MinSecDbl() As Double = {0.0, 0.0}

        StrIn = Convert.ToDouble(numberString) / 100
        MinSecStr = StrIn.ToString().Split(".")

        MinSecStr(0) = Convert.ToDouble(MinSecStr(0)).ToString("######")
        MinSecStr(1) = (Convert.ToDouble(MinSecStr(1)) * (1 / 60)).ToString("######")

        MinSecDbl(0) = Convert.ToDouble(MinSecStr(0))
        MinSecDbl(1) = Convert.ToDouble(MinSecStr(1)) * (0.0001)

        DegOut = MinSecDbl(0) + MinSecDbl(1)

        Return DegOut

    End Function

    Function Dbl2Dec(ByVal numberString As String) As Double
        'decimal to gegree

        Dim DecOut As Double

        DecOut = Convert.ToDouble(numberString) * 0.01
        'StrIn = (DecOut).ToString("######")
        'DecOut = Convert.ToDouble(StrIn)

        Return DecOut

    End Function

    Function timeformat(ByVal numberString As String) As Double

        Dim tempStrParse() As String
        Dim dateNo, timeNo As Double

        tempStrParse = numberString.Split(".")

        dateNo = CInt(tempStrParse(0))
        timeNo = CDec(tempStrParse(1)) * 0.001

        dateNo = dateNo + timeNo

        Return dateNo

    End Function

    Function checksumCalculator(ByVal stringInput As String) As String
        'https://rietman.wordpress.com/2008/09/25/how-to-calculate-the-nmea-checksum/

        Dim checksum As Integer
        Dim centenceParse() As String
        Dim commastring As String
        Dim hexString As String

        centenceParse = Split(stringInput, "$")
        centenceParse = Split(centenceParse(1), "*")
        centenceParse = Split(centenceParse(0), ",")
        commastring = String.Join("", centenceParse)

        For Each Character As Char In commastring
            checksum = checksum Xor Convert.ToByte(Character)
        Next

        hexString = Hex(checksum)

        Return hexString

    End Function

#End Region

End Class
