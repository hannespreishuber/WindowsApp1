Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim farbe As Color
        farbe = Color.AliceBlue


        Dim ampel = Ampel1.rot
        Dim aa = Ampel1.gelb And Ampel1.rot 'Flags
    End Sub
End Class
<Flags>
Enum Ampel1 As Byte
    rot
    gelb
    grun
End Enum
Public Enum InterfaceColors
    MistyRose = &HE1E4FF
    SlateGray = &H908070
    DodgerBlue = &HFF901E
    DeepSkyBlue = &HFFBF00
    SpringGreen = &H7FFF00
    ForestGreen = &H228B22
    Goldenrod = &H20A5DA
    Firebrick = &H2222B2
End Enum
