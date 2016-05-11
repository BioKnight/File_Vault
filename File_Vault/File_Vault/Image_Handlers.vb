Imports System.Drawing.Drawing2D

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
        image_form = New Form()
        image_form.Size = default_Size
        image_form.FormBorderStyle = FormBorderStyle.FixedSingle
        image_form.ControlBox = False
        image_form.MinimizeBox = False
        image_form.MaximizeBox = False
        image_form.BackgroundImage = pic
        image_form.BackgroundImageLayout = ImageLayout.Center


        AddHandler image_form.Resize, AddressOf resize
        AddHandler image_form.DoubleClick, AddressOf close_form
        AddHandler image_form.MouseDown, AddressOf mouse_down
        'AddHandler image_form.MouseUp, AddressOf mouse_down
        AddHandler image_form.MouseMove, AddressOf relocate

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

    Private Sub mouse_down(sender As Object, e As MouseEventArgs)
        start_location = New Point(e.Location)

        ' Found this code at https://social.msdn.microsoft.com/Forums/vstudio/en-US/b5474d08-8502-49db-8354-f30e3b90f046/resize-form-without-window-borders?forum=vbgeneral
        ' Tring to be able to resize a form with no borders.
        If e.Button = MouseButtons.Left Then
            image_form.Capture = False
            Dim theCursor As Cursor = Cursors.Arrow
            Dim Direction As New IntPtr()
            If e.X = 0 Or e.X = 1 Or e.X = 2 Or e.X = 3 _
            Or e.X = image_form.Width - 1 Or e.X = image_form.Width - 2 Or e.X = image_form.Width - 3 Or
            e.X = image_form.Width - 4 Or e.Y = 0 Or e.Y = 1 Or e.Y = 2 Or e.Y = 3 _
            Or e.Y = image_form.Height - 1 Or e.Y = image_form.Height - 2 Or e.Y = image_form.Height - 3 _
            Or e.Y = image_form.Height - 4 Then
                Select Case e.X
                    Case 0 To 3 ' On the left line
                        Select Case e.Y
                            Case 0 To 3
                                ' top left corner
                                Direction = CType(HTTOPLEFT, IntPtr)
                                theCursor = Cursors.PanSE
                            Case image_form.Height - 4 To image_form.Height - 1
                                ' bottom left corner
                                Direction = CType(HTBOTTOMLEFT, IntPtr)
                                theCursor = Cursors.PanNE
                            Case Else
                                ' left side
                                Direction = CType(HTLEFT, IntPtr)
                                theCursor = Cursors.PanEast
                        End Select

                    Case image_form.Width - 4 To image_form.Width - 1   ' On the right line
                        Select Case e.Y
                            Case 0 To 3
                                ' top right corner
                                Direction = CType(HTTOPRIGHT, IntPtr)
                                theCursor = Cursors.PanSW
                            Case image_form.Height - 4 To image_form.Height - 1
                                ' bottom right corner
                                Direction = CType(HTBOTTOMRIGHT, IntPtr)
                                theCursor = Cursors.PanNW
                            Case Else
                                ' right side
                                Direction = CType(HTRIGHT, IntPtr)
                                theCursor = Cursors.PanWest
                        End Select

                    Case Else
                        Select Case e.Y
                            Case 0 To 3
                                ' top line
                                Direction = CType(HTTOP, IntPtr)
                                theCursor = Cursors.PanSouth
                            Case image_form.Height - 4 To image_form.Height - 1
                                ' bottom line
                                Direction = CType(HTBOTTOM, IntPtr)
                                theCursor = Cursors.PanNorth
                        End Select

                End Select
                image_form.Cursor = theCursor
                Dim msg As Message = Message.Create(image_form.Handle, WM_NCLBUTTONDOWN, Direction, IntPtr.Zero)
                'image_form.DefWndProc(msg)
            Else
                'If Not hovered Then
                image_form.Cursor = Cursors.SizeAll
                Application.DoEvents()
                Dim msg As Message = Message.Create(image_form.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
                'image_form.DefWndProc(msg)
                'End If
            End If
        End If
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
End Class
