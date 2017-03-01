Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s(5) As String  'LINQ Provider
        's.Length
        Dim l = s.ToList()
        'l.length 
        ' s.Count LINQ
        ' Dim liste As List(Of String) = New List(Of String)
        Dim ding As Boolean?

        Dim liste As List(Of String)

        'liste.Item(1) liste(1)
        If Not liste Is Nothing AndAlso liste.Count > 1 Then


        End If
        If liste?.Count > 1 Then

        End If
        Dim dic As New Dictionary(Of String, String)

        ' Dim d = s.ToDictionary(Of String, String)
        'dic.item("wert")
        Dim table As New Hashtable
        table.Add("Area", 1000)
        table.Add("Perimeter", 55)
        table.Add("Mortgage", 540)
        table.ContainsKey("Hanes")
        '  table.Item("Area")

        'queue stack FIFO LIFO

        Dim password As String = "De24243434534534534"
        password.GetHashCode()





    End Sub
End Class