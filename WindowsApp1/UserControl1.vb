Public Class UserControl1

    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value + "€"
        End Set
    End Property
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = _ID
    End Sub
End Class
