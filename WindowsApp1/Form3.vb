Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o = New Person
        o.Dispose()

        Using p As New Person 'p lokal gültig 
            p.Name = "Hannes"

        End Using



    End Sub
End Class