Imports System.Drawing.Drawing2D

Public Class Image_Handlers

    Public Enum image_types
        jpeg
        bitmap
        gif
        png
    End Enum

    Private orig_Pic As Bitmap
    Private pic As Bitmap
    Private image_form As Form
    Private default_Size As New Size(300, 300)
    Private move As Boolean = False
    Private start_location As Point
    Const WM_NCLBUTTONDOWN As Integer = &HA1S
    Const HTBORDER As Integer = 18
    Const HTBOTTOM As Integer = 15
    Const HTBOTTOMLEFT As Integer = 16
    Const HTBOTTOMRIGHT As Integer = 17
    Const HTCAPTION As Integer = 2
    Const HTCLOSE As Integer = 20
    Const HTGROWBOX As Integer = 4
    Const HTLEFT As Integer = 10
    Const HTMAXBUTTON As Integer = 9
    Const HTMINBUTTON As Integer = 8
    Const HTRIGHT As Integer = 11
    Const HTSYSMENU As Integer = 3
    Const HTTOP As Integer = 12
    Const HTTOPLEFT As Integer = 13
    Const HTTOPRIGHT As Integer = 14

    Sub New(Image_Path As String)
        pic = New Bitmap(Image_Path)
        orig_Pic = pic
        image_form = New Form()
        image_form.Size = default_Size
        image_form.FormBorderStyle = FormBorderStyle.Sizable
        image_form.ControlBox = False
        image_form.MinimizeBox = False
        image_form.MaximizeBox = False
        image_form.BackgroundImage = pic
        image_form.BackgroundImageLayout = ImageLayout.Center
        image_form.BackColor = Color.GhostWhite

        AddHandler image_form.Resize, AddressOf resize
        AddHandler image_form.DoubleClick, AddressOf close_form
        AddHandler image_form.MouseDown, AddressOf mouse_down
        AddHandler image_form.MouseMove, AddressOf relocate
        AddHandler image_form.Paint, AddressOf paint_form

    End Sub

    Public Sub dispose()
        pic.Dispose()
        image_form.Dispose()
    End Sub

    Public Sub size_Image()

        ' Determine difference in hight and width
        Dim NewHeight As Integer = image_form.Height
        Dim NewWidth As Integer = NewHeight / pic.Height * pic.Width

        If NewWidth > image_form.Width Then
            NewWidth = image_form.Width
            NewHeight = NewWidth / pic.Width * pic.Height
        End If

        pic = ResizeImage(NewHeight, NewWidth)
        'pic = New Bitmap(pic, NewWidth, NewHeight)

    End Sub

    Private Sub resize()
        size_Image()
        image_form.BackgroundImage = pic
    End Sub

    Public Sub show_Image()
        image_form.Size = pic.Size
        image_form.Show()
    End Sub

    Private Sub close_form()
        dispose()
    End Sub

    Private Sub mouse_down(sender As Object, e As MouseEventArgs)
        start_location = New Point(e.Location)
    End Sub

    Private Sub relocate(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            image_form.Left = e.X + image_form.Left - start_location.X
            image_form.Top = e.Y + image_form.Top - start_location.Y
        End If
    End Sub

    Private Sub paint_form(sender As Object, e As PaintEventArgs)
        ControlPaint.DrawBorder(e.Graphics, image_form.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Public Function ResizeImage(ByVal newHeight As Integer, newWidth As Integer) As Bitmap

        Dim Img As Bitmap = orig_Pic
        Dim thumbnailBitmap As Bitmap = New Bitmap(newWidth, newHeight)

        Dim thumbnailGraph As Graphics = Graphics.FromImage(thumbnailBitmap)
        thumbnailGraph.CompositingQuality = CompositingQuality.HighQuality
        thumbnailGraph.SmoothingMode = SmoothingMode.HighQuality
        thumbnailGraph.InterpolationMode = InterpolationMode.HighQualityBicubic

        Dim imageRectangle As Rectangle = New Rectangle(0, 0, newWidth, newHeight)
        thumbnailGraph.DrawImage(Img, imageRectangle)

        Return thumbnailBitmap
    End Function




End Class
