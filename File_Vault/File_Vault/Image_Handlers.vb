Public Class Image_Handlers

    Public Enum image_types
        jpeg
        bitmap
        gif
        png
    End Enum

    Private pic As Bitmap

    Sub New(Image_Path As String)
        pic = New Bitmap(Image_Path)
    End Sub

    Public Sub dispose()
        pic.Dispose()

    End Sub

    Public Sub size_Image(height, width)

        ' Determine difference in hight and width
        Dim NewHeight As Integer = height
        Dim NewWidth As Integer = NewHeight / pic.Height * pic.Width

        If NewWidth > width Then
            NewWidth = width
            NewHeight = NewWidth / pic.Width * pic.Height
        End If

        pic = New Bitmap(pic, NewWidth, NewHeight)

    End Sub

End Class
