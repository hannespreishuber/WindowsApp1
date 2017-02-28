Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class vornamen
    Public Property Id As Integer

    <StringLength(50)>
    Public Property vorname As String
End Class
