Public Class Form14
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New Class2
        Dim t As String
        Await Task.Run(Sub() t = c.test)
        TextBox1.Text = t

    End Sub
End Class