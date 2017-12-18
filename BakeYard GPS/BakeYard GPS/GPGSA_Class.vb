Public Class GPGSA_Class

#Region "GPGSA_Notes"
    'The GSA message identifies the GPS position fix mode, the Satellite Vehicles (SVs) used for navigation, and the Dilution of Precision (DOP) values.
    '   $GPGSA,A,3,04,05,,09,12,,,24,,,,,2.5,1.3,2.1*39

    'Where:
    '     GSA      Satellite status
    '     A        Auto selection of 2D or 3D fix (M = manual) 
    '    3        3D fix - values include: 1 = no fix
    '                                       2 = 2D fix
    '                                      3 = 3D fix
    '     04,05... PRNs of satellites used for fix (space for 12) 
    '               01 ~ 32 are for GPS; 33 ~ 64 are for SBAS (PRN minus 87); 65 ~ 96 are for GLONASS (64 plus slot numbers); 193 ~ 197 are for QZSS; 01 ~ 37 are for Beidou (BD PRN). GPS and Beidou satellites are differentiated by the GP and BD prefix. Maximally 12 satellites are included in each GSA sentence 
    '     2.5      PDOP (dilution of precision) 
    '    1.3      Horizontal dilution of precision (HDOP) 
    '    2.1      Vertical dilution of precision (VDOP)
    '    *39      the checksum data, always begins with *
#End Region

#Region "Global_Vars"

    Public Shared sentenceID As String
    Public Shared MODE1 As String
    Public Shared MODE2 As Integer
    Public Shared SatID(11) As Integer ' Maximally 12 satellites are included in each GSA sentence
    Public Shared SatIDCount As Integer
    Public Shared PDOP As Double
    Public Shared HDOP As Double
    Public Shared VDOP As Double
    Public Shared CHECKSUM As String

#End Region

    Public Sub globalBU353ClassVar(ByVal bu353Sentence As Array)
        Dim centenceParse() As String

        Dim lengthN As Integer = bu353Sentence.Length
        sentenceID = bu353Sentence(0)
        SatIDCount = 0
        For word = 1 To (lengthN - 1)
            Select Case word
                Case 1
                    MODE1 = bu353Sentence(word)
                Case 2
                    MODE2 = bu353Sentence(word)
                Case 3 To 14
                    If (bu353Sentence(word) <> "") Then
                        SatID(word - 3) = Convert.ToDouble(bu353Sentence(word))
                        SatIDCount = SatIDCount + 1
                    End If
                Case 15
                    PDOP = bu353Sentence(word)
                Case 16
                    HDOP = bu353Sentence(word)
                Case 17
                    centenceParse = Split(bu353Sentence(word), "*")
                    VDOP = centenceParse(0)
                    CHECKSUM = centenceParse(1)
            End Select

        Next

    End Sub

End Class
