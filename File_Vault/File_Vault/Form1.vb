Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

' Tutorial: https://support.microsoft.com/en-us/kb/301070
' Tutorial: http://stackoverflow.com/questions/2301997/how-to-encrypt-a-file-folder-using-vb-net

Public Class frm_main
    Private application_Path As String = ".\"

    Private structs As Structures

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        structs = New Structures(application_Path)
        tree_Main.Nodes.Add(structs.tree_Node)
    End Sub

    Private Sub tree_Main_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tree_Main.AfterSelect
        lst_bx_Files.Items.Clear()
        lst_bx_Files.Items.AddRange(structs.get_Files(structs.directory(tree_Main.SelectedNode)))
    End Sub
End Class