Imports System.Windows.Forms.HtmlElementCollection
Imports System.Windows.Forms.HtmlElement

Imports System.Security.Permissions 'clear up any html/js/vb mixups
Imports Microsoft.Win32 'used for registeryKey

Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim urlstring As String
        urlstring = "C:/Users/Michael/Documents/HTML Related/GPS_GUI/Simple_Version/index.html"
        wbHtmlIndex.Url = New Uri(urlstring)

    End Sub

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

        html_element1.InnerText = randomNumber1.ToString + "." + randomNumber2.ToString

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
End Class
