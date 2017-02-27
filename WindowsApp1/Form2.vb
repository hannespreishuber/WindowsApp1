Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim personen = New List(Of Person)
        personen.Add(New Person("Hannes", 1))
        personen.Add(New Person With {.Name = "Franz", .ID = 2})
        personen.Add(New Person With {.Name = "Beat", .ID = 3})
        personen.Add(New Person With {.ID = 4, .Name = "Sepp"})

        Dim o = New With {.Plz = "84489", .Ort = "Burghausen"}

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

        If i2 = 11 AndAlso i2 = 12 Then  'bei 1ter Ausdruck False, abbruch
            Debug.WriteLine("true")
        End If
        If True Then
            If True Then
                If True Then

                End If
            End If
        End If

        a.Replace("H", "M")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim w As New Person With {.ID = 1, .Name = "Hannes"}
        'w = test(w)
        test(w)
        Debug.WriteLine(w.Name)
        Dim w2 = "barbara"
        test1(w2)
        Debug.WriteLine(w2)

        Dim x = w.Clone
        x.ID = 999


    End Sub

    Public Function test(ByVal wert As Person) As String 'byref wegen komplex
        wert.Name = wert.Name.ToUpper

    End Function

    Public Function test1(wert As String) As String 'byval
        wert = wert.ToUpper
        Dim neu = New ppedv.burghausen.privtest
        Dim neu2 = New privtest

    End Function
End Class