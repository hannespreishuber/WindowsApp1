Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim personen = New List(Of Person)
        personen.Add(New Person("Hannes", 1))
        personen.Add(New Person With {.Name = "Franz", .ID = 2})
        personen.Add(New Person With {.Name = "Beat", .ID = 3})
        personen.Add(New Person With {.ID = 4, .Name = "Sepp"})

        For i = 0 To personen.Count - 1
            Debug.WriteLine(personen(i).ID)
        Next
        Dim ii = 0
        While True

            Debug.WriteLine(personen(ii).Name)
            ii += 1
            If ii > 3 Then Exit While
        End While

        For Each p In personen
            Debug.WriteLine(p.ID)
        Next

        Dim i2 = 12
        Dim a As String = i2

        Dim z1 = CInt(a)
        Dim z2 = Convert.ToInt32(a)
        Dim z3 = CType(a, Integer)

        Dim z4 = String.Format("{0:d5}", i2)



    End Sub
End Class