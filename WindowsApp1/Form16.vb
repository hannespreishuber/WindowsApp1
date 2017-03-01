Public Class Form16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim ex As New Exception("haben hunger")
        'ex.Source = "sadsdsf"
        'Throw ex
        Dim i As Integer = 0
        Dim ii As Integer = 0
        'on error resume next
        Try
            Throw New keinePrimzahlException("keine schöne Primzahl")
            ii = 4 / i

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Catch ex As DivideByZeroException
            MessageBox.Show(ex.Message)

            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        Catch ex As keinePrimzahlException
            MessageBox.Show(ex.Message)

        Finally
            i = 1
        End Try




    End Sub
End Class