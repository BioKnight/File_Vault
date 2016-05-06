<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.tree_Main = New System.Windows.Forms.TreeView()
        Me.lst_bx_Files = New System.Windows.Forms.ListBox()
        Me.picbx_Main = New System.Windows.Forms.PictureBox()
        CType(Me.picbx_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tree_Main
        '
        Me.tree_Main.Location = New System.Drawing.Point(0, 0)
        Me.tree_Main.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tree_Main.Name = "tree_Main"
        Me.tree_Main.Size = New System.Drawing.Size(121, 628)
        Me.tree_Main.TabIndex = 0
        '
        'lst_bx_Files
        '
        Me.lst_bx_Files.FormattingEnabled = True
        Me.lst_bx_Files.ItemHeight = 16
        Me.lst_bx_Files.Location = New System.Drawing.Point(129, 0)
        Me.lst_bx_Files.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lst_bx_Files.Name = "lst_bx_Files"
        Me.lst_bx_Files.Size = New System.Drawing.Size(159, 196)
        Me.lst_bx_Files.TabIndex = 2
        '
        'picbx_Main
        '
        Me.picbx_Main.Location = New System.Drawing.Point(297, 0)
        Me.picbx_Main.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picbx_Main.Name = "picbx_Main"
        Me.picbx_Main.Size = New System.Drawing.Size(576, 629)
        Me.picbx_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picbx_Main.TabIndex = 3
        Me.picbx_Main.TabStop = False
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 628)
        Me.Controls.Add(Me.picbx_Main)
        Me.Controls.Add(Me.lst_bx_Files)
        Me.Controls.Add(Me.tree_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_main"
        Me.Text = "File Vault"
        CType(Me.picbx_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tree_Main As TreeView
    Friend WithEvents lst_bx_Files As ListBox
    Friend WithEvents picbx_Main As PictureBox
End Class
