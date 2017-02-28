
Imports Newtonsoft.Json

Public Class Rootobject
    Public Property city As City
    Public Property cod As String
    Public Property message As Single
    Public Property cnt As Integer
    <JsonProperty("list")>
    Public Property wlist As List(Of Liste)
End Class

Public Class City
    Public Property id As Integer
    Public Property name As String
    Public Property coord As Coord
    Public Property country As String
    Public Property population As Integer
End Class

Public Class Coord
    Public Property lon As Single
    Public Property lat As Single
End Class

Public Class Liste
    Public Property dt As Integer
    Public Property temp As Temp
    Public Property pressure As Single
    Public Property humidity As Integer
    Public Property weather As List(Of Wetter)
    Public Property speed As Single
    Public Property deg As Integer
    Public Property clouds As Integer
    Public Property rain As Single
    Public Property snow As Single
End Class

Public Class Temp
    Public Property day As Single
    Public Property min As Single
    Public Property max As Single
    Public Property night As Single
    Public Property eve As Single
    Public Property morn As Single
End Class

Public Class Wetter
    Public Property id As Integer
    Public Property main As String
    Public Property description As String
    Public Property icon As String
End Class
