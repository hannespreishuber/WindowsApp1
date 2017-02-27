Imports System.ComponentModel
Imports WindowsApp1

Public Class rechne
    Implements INotifyPropertyChanged, Interface1
    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property

    Public Property test As String = "test"
    'test kommentar


    Public Property ID As String Implements Interface1.ID
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public test1 As Integer?
    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    Public Shared Function Add(a As Double, b As Double) As String
        Return (a + b).ToString



    End Function
    Public Function Add(a As Double, b As Double, Optional c As Double = 0) As String
        Return (a + b + c).ToString



    End Function

    Public Function multi(a As Integer, b As Integer) As Integer Implements Interface1.multi
        Throw New NotImplementedException()
    End Function
End Class
