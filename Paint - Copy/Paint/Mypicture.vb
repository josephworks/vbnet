﻿Public Class Mypicture
    Public Property x As Integer
    Public Property y As Integer
    Public Property length As Integer
    Public Property height As Integer
    Public Property picture As Image

    Public Sub draw(e As PaintEventArgs)
        e.Graphics.DrawImage(picture, x, y, length, height)
    End Sub
End Class
