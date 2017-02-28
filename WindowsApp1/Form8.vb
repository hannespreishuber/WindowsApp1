Imports System.IO

Public Class Form8
    Dim liste As New List(Of plzort)
    Dim hliste As New Hashtable()
    Dim page As Integer = 0
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Using rd = New StreamReader("c:\temp\plzortgeo.csv")
            While rd.Peek > 0
                Dim daten = rd.ReadLine().Split(";")
                liste.Add(New plzort With {.plz = daten(0), .ort = daten(1)})
                'hliste.Add(daten(0), New plzort With {.plz = daten(0), .ort = daten(1)})
            End While
        End Using



        DataGridView1.DataSource = liste
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Label1.Visible = True
        Me.Refresh()
        'Dim suchliste = From o In liste
        '                Order By o.ort
        '                Select New With {.Postleitzahl = o.plz, .Ortschaft = o.ort}
        Dim suchliste = From o In liste
                        Where (o.plz.Contains(TextBox1.Text))
                        Order By o.ort
                        Select o
        DataGridView1.DataSource = suchliste.ToList
        Label1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filterdListe = liste.Skip(page * 10).Take(10)
        page += 1
        DataGridView1.DataSource = filterdListe.ToList
    End Sub
End Class