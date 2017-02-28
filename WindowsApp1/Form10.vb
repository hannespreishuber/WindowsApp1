Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form10
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ort = "Burghausen"
        Dim client As New HttpClient
        Dim json = Await client.GetStringAsync(($"http://api.openweathermap.org/data/2.5/forecast/daily?q={Ort}&units=metric&appid=b72e486c65374cfd2e73de0c78332d8f"))
        Dim wetter = JsonConvert.DeserializeObject(Of Rootobject)(json)
        DataGridView1.DataSource = wetter.wlist

    End Sub
End Class