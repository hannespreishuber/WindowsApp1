Imports System.Runtime.CompilerServices

Module Module1
    <Extension()>
    Public Function ConvertoCelsius(temp As Double) As Double
        Return temp - 273.15
    End Function

    <Extension()>
    Public Function add(a As String) As String
        Return a + a
    End Function



End Module
