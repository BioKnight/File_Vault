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
    Private Image_Handle As Image_Handlers

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
            Case ".jpg" ' Handle jpg's
                Image_Handle = New Image_Handlers(structs.directory(tree_Main.SelectedNode).FullName & "\" & lst_bx_Files.SelectedItem.ToString)
                Image_Handle.show_Image()
        End Select

    End Sub

    Private Sub lbl_Hidden_Button_DoubleClick(sender As Object, e As EventArgs) Handles lbl_Hidden_Button.DoubleClick
        frm_Hidden_Dialog.show
    End Sub
End Class