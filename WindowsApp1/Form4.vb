Imports System.IO

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim liste As New List(Of Object)

        Using rd = New StreamReader("c:\temp\plzortgeo.csv")
            While rd.Peek > 0
                Dim daten = rd.ReadLine().Split(";")
                liste.Add(New With {.plz = daten(0), .ort = daten(1)})
            End While
        End Using
        Dim ort = liste.Where(Function(o) o.plz = "84489").ToList


        Dim temp As Double = 286.67
        Dim cels = temp.ConvertoCelsius
        Dim s = "Hannes"
        Dim s1 = s.add()
    End Sub
End Class