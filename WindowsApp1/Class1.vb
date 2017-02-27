
Public Class Rootobject
    Public Property cod As String
    Public Property message As Single
    Public Property cnt As Integer
    Public Property list() As List
    Public Property city As City
End Class

Public Class City
    Public Property id As Integer
    Public Property [name] As String
    Public Property coord As Coord
    Public Property country As String
End Class

Public Class Coord
    Public Property lat As Single
    Public Property lon As Single
End Class

Public Class List
    Public Property dt As Integer
    Public Property main As Main
    Public Property weather() As Weather
    Public Property clouds As Clouds
    Public Property wind As Wind
    Public Property sys As Sys
    Public Property dt_txt As String
    Public Property rain As Rain
    Public Property snow As Snow
End Class

Public Class Main
    Public Property temp As Single
    Public Property temp_min As Single
    Public Property temp_max As Single
    Public Property pressure As Single
    Public Property sea_level As Single
    Public Property grnd_level As Single
    Public Property humidity As Integer
    Public Property temp_kf As Single
End Class

Public Class Clouds
    Public Property all As Integer
End Class

Public Class Wind
    Public Property speed As Single
    Public Property deg As Single
End Class

Public Class Sys
    Public Property pod As String
End Class

Public Class Rain
    Public Property _3h As Single
End Class

Public Class Snow
    Public Property _3h As Single
End Class

Public Class Weather
    Public Property id As Integer
    Public Property main As String
    Public Property description As String
    Public Property icon As String
End Class
