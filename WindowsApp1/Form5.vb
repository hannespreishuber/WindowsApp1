Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text += 1

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        'AddHandler Label1.MouseDown, AddressOf lblDown
        'AddHandler Label1.MouseUp, AddressOf lblUp
    End Sub

    Private Sub lblUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        RemoveHandler Label1.MouseMove, AddressOf lblMove
    End Sub

    Private Sub lblDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        AddHandler Label1.MouseMove, AddressOf lblMove
    End Sub

    Private Sub lblMove(sender As Object, e As MouseEventArgs)

        Label1.Top = e.Y
        Label1.Left = e.X
        Debug.WriteLine(e.Y)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            AddHandler Button1.Click, AddressOf Button1_Click
        Else
            RemoveHandler Button1.Click, AddressOf Button1_Click
        End If
    End Sub


End Class