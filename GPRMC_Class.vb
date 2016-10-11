Public Class GPRMC_Class

#Region "GPGMC_Notes"
    '    RMC - NMEA has its own version of essential gps pvt (position, velocity, time) data. It is called RMC, The Recommended Minimum, which will look similar to:
    '$GPRMC,123519,A,4807.038,N,01131.000,E,022.4,084.4,230394,003.1,W*6A
    'Where:
    '    RMC          Recommended Minimum sentence C
    '    123519       Fix taken at 12:35:19 UTC
    '    A            Status A=active or V=Void.
    '   4807.038,N   Latitude 48 deg 07.038' N
    '   01131.000,E  Longitude 11 deg 31.000' E
    '   022.4        Speed over the ground in knots
    '   084.4        Track angle in degrees True
    '   230394       Date - 23rd of March 1994
    '   003.1,W      Magnetic Variation
    '   *6A          The checksum data, always begins with *
#End Region


#Region "Global_Vars"

    Public Shared sentenceID As String
    Public Shared UTCTime As String
    Public Shared STATUS As String
    Public Shared LATITUDE As String
    Public Shared NSindicator As String
    Public Shared LONGITUDE As String
    Public Shared EWindicator As String
    Public Shared SOG As String
    Public Shared COG As String
    Public Shared UTCDATE As String
    Public Shared MODE As String
    Public Shared CHECKSUM As String

#End Region

    Public Sub globalBU353ClassVar(ByVal bu353Sentence As Array)

        Dim centenceParse() As String 'used for checksum
        Dim SatIDCount As String = 0

        Dim lengthN As Integer = bu353Sentence.Length

        sentenceID = bu353Sentence(0)

        For word = 1 To (lengthN - 1)
            Select Case word
                Case 1
                    UTCTime = bu353Sentence(word)
                Case 2
                    STATUS = bu353Sentence(word)
                Case 3
                    LATITUDE = bu353Sentence(word)
                Case 4
                    NSindicator = bu353Sentence(word)
                Case 5
                    LONGITUDE = bu353Sentence(word)
                Case 6
                    EWindicator = bu353Sentence(word)
                Case 7
                    SOG = bu353Sentence(word)
                Case 8
                    COG = bu353Sentence(word)
                Case 9
                    UTCDATE = bu353Sentence(word)
                Case 10
                    MODE = bu353Sentence(word)
                Case 11
                    centenceParse = Split(bu353Sentence(word), "*")
                    CHECKSUM = centenceParse(1)
            End Select

        Next
    End Sub



End Class
