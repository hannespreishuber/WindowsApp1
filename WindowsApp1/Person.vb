Public Class Person
    Public Sub New()

    End Sub
    Public Sub New(name As String, id As Integer)
        Me.Name = name
        Me.ID = id
    End Sub
    Public Property Name As String
    Public Property ID As Integer
End Class
