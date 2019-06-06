Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq



Public Class Form1
    Public goUrl = ""
    Public geUrl = ""
    Public itemName As String = ""
    Public itemDescr As String = ""
    Public itemPrice As Integer = 0





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        geUrl = "http://services.runescape.com/m=itemdb_oldschool/viewitem?obj=" + ItemNum.Text
        goUrl = "http://services.runescape.com/m=itemdb_oldschool/api/catalogue/detail.json?item=" + ItemNum.Text

        Try
            'Create the initial request
            Dim Request As HttpWebRequest = HttpWebRequest.Create(goUrl)
            Request.Proxy = Nothing ' THIS WILL SPEED UP THE REQUEST
            Request.UserAgent = "Test"

            'Create the Response and Reader
            Dim Response As HttpWebResponse = Request.GetResponse
            Dim ResponseStream As System.IO.Stream = Response.GetResponseStream

            'Create a new Stream Reader
            Dim StreamReader As New System.IO.StreamReader(ResponseStream)
            Dim Data As String = StreamReader.ReadToEnd

            'StreamReader.Close()

            'display the data on the screen
            urlResponseText.Text = Data

            Dim picUrl As String = ("http://services.runescape.com/m=itemdb_oldschool/obj_big.gif?id=" + ItemNum.Text)
            picBox1.Show()
            picBox1.Load(picUrl)

        Catch ex As Exception
            MsgBox("Inproper Input!")
            picBox1.Hide()
            'Dim itmNum As String = goUrl.Text.Substring(62, 5)
        End Try

    End Sub

    Private Sub geLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles geLink.LinkClicked
        Process.Start(geUrl)
    End Sub
End Class
