Imports System.IO

Public Class Structures

    ''' <summary>
    ''' The treenode object we will use to fill the tree view
    ''' </summary>
    ''' <returns>Treenode</returns>
    Public ReadOnly Property tree_Node As TreeNode
        Get
            Return tree
        End Get
    End Property

    Public ReadOnly Property directory(dir_Name) As DirectoryInfo
        Get
            Return (find_Dir_Info(tree, dir_Name))
        End Get
    End Property
    Private root As DirectoryInfo
    Private tree As New TreeNode("Root")

    ''' <summary>
    ''' Create a new instance of the structures object
    ''' </summary>
    ''' <param name="default_Path">The top level path of the files this program will use.</param>
    Public Sub New(default_Path As String)
        root = New DirectoryInfo(default_Path)
        build_List()
    End Sub

    ''' <summary>
    ''' Read the current directory structure
    ''' </summary>
    Private Function build_List() As TreeNode
        For Each folder As DirectoryInfo In root.GetDirectories
            'tree_Main.Nodes(0).Nodes.Add(create_Node(folder))
            tree.Nodes.Add(create_Node(folder))
        Next
    End Function

    ''' <summary>
    ''' Build the treeview.
    ''' </summary>
    ''' <param name="folder">the folder to be turned into a tree node.</param>
    ''' <returns>a tree node</returns>
    Private Function create_Node(ByRef folder As DirectoryInfo) As TreeNode
        Dim tempnode As New TreeNode(folder.Name)
        For Each child_folder As DirectoryInfo In folder.GetDirectories
            tempnode.Nodes.Add(create_Node(child_folder))
        Next

        Return tempnode
    End Function

    ''' <summary>
    ''' Searches the tree to find the node path, then returnes a directoryinfo object.
    ''' </summary>
    ''' <param name="node">the node to check, and search</param>
    ''' <param name="directory_Name">a string representing the name of the directory.</param>
    ''' <returns></returns>
    Private Function find_Dir_Info(node As TreeNode, directory_Name As String)
        If node.Name = directory_Name Then Return node.Name
        For Each nodes As TreeNode In node.Nodes
            If nodes.Nodes.Count > 0 Then
                For Each child As TreeNode In node.Nodes

                Next
            End If
        Next
    End Function

End Class
