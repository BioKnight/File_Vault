Public Class Image_Handlers

    Public Enum image_types
        jpeg
        bitmap
        gif
        png
    End Enum

    Private pic As Bitmap
    Private image_form As Form
    Private default_Size As New Size(300, 300)


    Sub New(Image_Path As String)
        pic = New Bitmap(Image_Path)
        image_form = New Form()
        image_form.Size = default_Size
        image_form.FormBorderStyle = FormBorderStyle.Sizable
        image_form.ControlBox = False
        image_form.MinimizeBox = False
        image_form.MaximizeBox = False
        image_form.AutoSize = True
        image_form.BackgroundImage = pic
        image_form.BackgroundImageLayout = ImageLayout.Center


        AddHandler image_form.Resize, AddressOf resize
        AddHandler image_form.DoubleClick, AddressOf close_form
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

    Private Sub size_Image()

        ' Determine difference in hight and width
        Dim NewHeight As Integer = image_form.Height
        Dim NewWidth As Integer = NewHeight / pic.Height * pic.Width

        If NewWidth > image_form.Width Then
            NewWidth = image_form.Width
            NewHeight = NewWidth / pic.Width * pic.Height
        End If

        pic = New Bitmap(pic, NewWidth, NewHeight)

    End Sub

    Private Sub resize(sender As Object, e As EventArgs)
        size_Image()
        image_form.BackgroundImage = pic
    End Sub

    Public Sub show_Image()
        image_form.Size = pic.Size
        image_form.Show()
    End Sub

    Private Sub close_form()
        image_form.Close()
    End Sub
End Class
