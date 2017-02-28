Imports System.Data.SqlClient

Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pre\documents\visual studio 2017\Projects\WindowsApp1\WindowsApp1\Database1.mdf"";Integrated Security=True"
        Dim con = New SqlConnection(conn)
        Dim cmd = New SqlCommand("select * from vornamen", con)
        Dim liste As New List(Of vorname1)
        con.Open()
        Dim rd = cmd.ExecuteReader
        While rd.Read()
            liste.Add(New vorname1 With {.ID = rd("id"), .vorname = rd("vorname")})
        End While

        DataGridView1.DataSource = liste.ToList
    End Sub
End Class
Public Class vorname1
    Property ID As Integer
    Property vorname As String
End Class