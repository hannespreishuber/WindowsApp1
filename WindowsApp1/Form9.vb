Imports System.IO

Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste As New List(Of plzort)
        Using rd = New StreamReader("c:\temp\plzortgeo.csv")
            While rd.Peek > 0
                Dim daten = rd.ReadLine().Split(";")
                liste.Add(New plzort With {.plz = daten(0), .ort = daten(1)})

            End While
        End Using
        Dim query = From o In liste
                    Group By key = o.plz Into gruppe = Group
                    Select key, gruppe.Count, gruppe

        DataGridView1.DataSource = query.ToList
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView2.DataSource = DataGridView1.CurrentRow.DataBoundItem.gruppe
    End Sub
End Class