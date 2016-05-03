Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

' Tutorial: https://support.microsoft.com/en-us/kb/301070
' Tutorial: http://stackoverflow.com/questions/2301997/how-to-encrypt-a-file-folder-using-vb-net

Public Class frm_main
    Private application_Path As DirectoryInfo = New DirectoryInfo(".\")

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Read the current directory structure

        'MsgBox(application_Path.FullName)
        For Each folder As DirectoryInfo In application_Path.GetDirectories
            'MsgBox(folder.FullName)
            tree_Main.Nodes(0).Nodes.Add(create_Node(folder))
        Next
    End Sub

    Private Function create_Node(ByRef folder As DirectoryInfo) As TreeNode
        Dim tempnode As New TreeNode(folder.Name)
        For Each child_folder As DirectoryInfo In folder.GetDirectories
            tempnode.Nodes.Add(create_Node(child_folder))
        Next

        Return tempnode
    End Function

End Class