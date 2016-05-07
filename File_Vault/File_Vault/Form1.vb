Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Drawing


' Tutorial: https://support.microsoft.com/en-us/kb/301070
' Tutorial: http://stackoverflow.com/questions/2301997/how-to-encrypt-a-file-folder-using-vb-net

Public Class frm_main
    Private application_Path As String = ".\"

    Private structs As Structures

    Private grapx As Graphics

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        structs = New Structures(application_Path)
        tree_Main.Nodes.Add(structs.tree_Node)
    End Sub

    Private Sub tree_Main_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tree_Main.AfterSelect
        lst_bx_Files.Items.Clear()
        lst_bx_Files.Items.AddRange(structs.get_Files(structs.directory(tree_Main.SelectedNode)))
    End Sub

    Private Sub lst_bx_Files_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_bx_Files.SelectedIndexChanged
        Select Case lst_bx_Files.SelectedItem.ToString.Remove(0, (lst_bx_Files.SelectedItem.ToString.IndexOf(".")))
            Case ".jpg"
                Dim pic As Bitmap = New Bitmap(structs.directory(tree_Main.SelectedNode).FullName & "\" & lst_bx_Files.SelectedItem.ToString)
                If Not Size.op_Equality(pic.Size, picbx_Main.Size) Then
                    Dim siz As New Size
                    If pic.Height > picbx_Main.Height Then

                        ' Create the starting point.
                        Dim startPoint As New Point(pic.Size)

                        ' Use the addition operator to get the end point.
                        Dim endPoint As Point = Point.op_Addition(startPoint, pic.Size)

                        ' Draw a line between the points.
                        grapx.DrawLine(SystemPens.Highlight, startPoint, endPoint)

                        ' Convert the starting point to a size and compare it to the
                        ' subtractButton size.  
                        Dim picsize As Size = Point.op_Explicit(startPoint)
                        If (Size.op_Equality(picsize, pic.Size)) Then

                        End If

                        siz.Height = picbx_Main.Height
                    End If
                    If pic.Width > picbx_Main.Width Then
                        siz.Width = picbx_Main.Width
                    End If

                    pic = New Bitmap(pic, siz)
                End If
                picbx_Main.Image = pic
        End Select

    End Sub
End Class