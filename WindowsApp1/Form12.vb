Public Class Form12
    Dim ef As New Model1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.DataSource = ef.vornamen.ToList
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ef.vornamen.Add(New vornamen With {.vorname = TextBox1.Text})
        ef.SaveChanges()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.DataSource = ef.vornamen.Where(Function(x) x.vorname.Contains(TextBox2.Text)).ToList
    End Sub
End Class