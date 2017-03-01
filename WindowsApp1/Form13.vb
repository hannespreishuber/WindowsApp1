Public Class Form13

    Dim ticktack As System.Threading.Timer
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        '  Task.Run(Sub() ProgressBar1.Increment(1))

        Debug.WriteLine(ProgressBar1.Value)

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler Button1.Click, AddressOf Button1_Click

        ticktack = New System.Threading.Timer(AddressOf ticking, Nothing, 0, 100)
        ' ticktack = New System.Threading.Timer(Sub() ProgressBar1.Increment(1), Nothing, 0, 100)
    End Sub

    Private Sub ticking(state As Object)
        BeginInvoke(Sub()
                        ProgressBar1.Increment(1)
                    End Sub)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ticktack.Change(Threading.Timeout.Infinite, Threading.Timeout.Infinite)
    End Sub
End Class