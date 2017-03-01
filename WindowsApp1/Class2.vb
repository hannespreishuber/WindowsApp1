Public Class Class2
    Dim ticktack As New System.Threading.Timer(AddressOf ticking, Nothing, 0, 10)
    Dim i As Integer = 0

    Private Sub ticking(state As Object)
        RaiseEvent Fortschritt(i)
        i += 1
    End Sub

    Public Function test() As String
        System.Threading.Thread.Sleep(30000)
        Return Date.Now
    End Function
    Public Event Fortschritt(i As Integer)

End Class
