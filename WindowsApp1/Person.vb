Public Class Person
    Implements IDisposable
    Public Sub New()

    End Sub
    Public Sub New(name As String, id As Integer)
        Me.Name = name
        Me.ID = id
    End Sub
    Public Function Clone() As Person
        Return Me.MemberwiseClone()

    End Function

    Public Property Name As String

    Public Property ID As Integer
    Private Class test

    End Class


    Public Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class
