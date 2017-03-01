Imports WindowsApp1

Public Class Form15
    Delegate Function hannes() As Single
    Private Function echthannes() As Single
        Return Rnd(10)
    End Function

    Private Function fixhannes() As Single
        Return 42
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp = Function(x)
                       Return MessageBox.Show(x, "titel", MessageBoxButtons.OKCancel)
                   End Function
        Dim erg = temp("Halo Welt")
        Dim h As hannes
        If True Then
            h = AddressOf echthannes
        Else
            h = AddressOf fixhannes
        End If
        Dim t = h()


        test1(h)



    End Sub

    Private Function test1(h1 As hannes) As hannes
        Return h1
    End Function
End Class