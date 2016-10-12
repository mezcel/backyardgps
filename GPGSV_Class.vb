Public Class GPGSV_Class

#Region "GPGSV_Notes"    '
    'The GSV message string identifies the number of SVs in view, the PRN numbers, elevations, azimuths, and SNR values. An example of the GSV message string is:
    '      $GPGSV,2,1,08,01,40,083,46,02,17,308,41,12,07,344,39,14,22,228,45*75

    'Where:
    '     GSV          Satellites in view
    '     2            Number of sentences for full data
    '     1            sentence 1 of 2
    '     08           Number of satellites in view
    '01 ~ 32 are for GPS; 33 ~ 64 are for SBAS (PRN minus 87); 65 ~ 96 are for GLONASS (64 plus slot numbers); 193 ~ 197 are for QZSS; 01 ~ 37 are for Beidou (BD PRN). GPS and Beidou satellites are differentiated by the GP and BD prefix. Maximally 4 satellites are included in each GSV sentence. 
    '     01           Satellite PRN number
    '    40           Elevation, degrees
    '    083          Azimuth, degrees
    '    46           SNR - higher is better
    '         for up to 4 satellites per sentence
    '   *75          the checksum data, always begins with *
#End Region

#Region "Global_Vars"
    Public Shared sentenceID As String

    Public Shared NoOfMsgs As Integer
    Public Shared msgNo As Integer
    Public Shared totalNoOfSV As Integer

    Public Shared svPRNno(3) As Integer
    Public Shared Elevation(3) As Integer
    Public Shared Azimuth(3) As Integer
    Public Shared SNR(3) As Integer

    Public Shared CHECKSUM As Integer

#End Region

    Public Sub globalBU353ClassVar(ByVal bu353Sentence As Array)
        Dim centenceParse() As String
        Dim SatIDCount As String = 0
        Dim lengthN As Integer = bu353Sentence.Length

        Array.Clear(svPRNno, 0, 3)
        Array.Clear(Elevation, 0, 3)
        Array.Clear(Azimuth, 0, 3)
        Array.Clear(SNR, 0, 3)

        sentenceID = bu353Sentence(0)

        For word = 1 To (lengthN - 1)
            Select Case word
                Case 1
                    NoOfMsgs = bu353Sentence(word)
                Case 2
                    msgNo = bu353Sentence(word)
                Case 3
                    totalNoOfSV = bu353Sentence(word)
                Case 4 ' To 7
                    '(0)
                    svPRNno(0) = bu353Sentence(word)
                Case 5
                    Elevation(0) = bu353Sentence(word)
                Case 6
                    Azimuth(0) = bu353Sentence(word)
                Case 7
                    SNR(0) = bu353Sentence(word)
                Case 8 ' To 11
                    '(1)
                    svPRNno(1) = bu353Sentence(word)
                Case 9
                    Elevation(1) = bu353Sentence(word)
                Case 10
                    Azimuth(1) = bu353Sentence(word)
                Case 11
                    SNR(1) = bu353Sentence(word)

                Case 12 ' To 15
                    '(2)
                    svPRNno(2) = bu353Sentence(word)
                Case 13

                    Elevation(2) = bu353Sentence(word)
                Case 14
                    Azimuth(2) = bu353Sentence(word)
                Case 15
                    SNR(2) = bu353Sentence(word)
                Case 16 'To 19
                    '(3)
                    svPRNno(3) = bu353Sentence(word)
                Case 17
                    Elevation(3) = bu353Sentence(word)
                Case 18
                    Azimuth(3) = bu353Sentence(word)
                Case 19
                    centenceParse = Split(bu353Sentence(word), "*")
                    SNR(3) = centenceParse(0)
                    CHECKSUM = centenceParse(1)
            End Select

        Next
    End Sub

End Class
