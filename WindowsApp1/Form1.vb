Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Hallo Welt")
    End Sub

    Private Sub HannesKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim intTastenwert =
            e.KeyValue

        '  UserControl11.Label1.Text = "12"
        UserControl11.ID = "12"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r = New rechne
        Dim ergebnis = r.Add(1, 2)

        Dim p = 10.0R
        Dim pp As Double = 10
        'literale
        Dim d = Date.Now
        Dim s = "es ist jetzt " + d.ToString("dd. MMM. yyyy") + " Uhrzeit"
        Dim s2 = $"es ist jetzt {d:dd. MMM. yyyy} Uhreit"
        Dim erg2 = rechne.Add(1, 1)
        Dim ar(5) As Integer
        ar(0) = 1

        Dim name1 As New List(Of String)
        name1.Add("hanes")

        Dim namen() = {"Franz", "Sepp", "Peter", "Beat"}
        'LINQ
        Dim result = From t In namen Where t.Contains("e") Select t



        namen(0) = "test"
        Dim xml = <root>
                      <%= From s3 In namen Select
                      <person id="1">
                          <name><%= s3 %></name>
                          <gebdat><%= d %></gebdat>
                      </person>
                      %>
                  </root>
        '  xml.<root>.<person>.First.<name>.Value = "Franz"
        'xml.<person>.Count
        'xml.<person>.First.<name>.Value
        Dim n = xml.<person>(0).<name>.Value

    End Sub
End Class
