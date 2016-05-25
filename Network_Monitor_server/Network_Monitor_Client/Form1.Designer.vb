<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.clst_Devices = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_Info = New System.Windows.Forms.GroupBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Computer = New System.Windows.Forms.Label()
        Me.txt_Computer_Name = New System.Windows.Forms.TextBox()
        Me.lbl_IP = New System.Windows.Forms.Label()
        Me.lbl_UpTime = New System.Windows.Forms.Label()
        Me.txt_UpTime = New System.Windows.Forms.TextBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.llbl_IP = New System.Windows.Forms.LinkLabel()
        Me.lbl_Stat_Display = New System.Windows.Forms.Label()
        Me.lbl_Last_Checkin = New System.Windows.Forms.Label()
        Me.txt_Checkin = New System.Windows.Forms.TextBox()
        Me.gbx_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'clst_Devices
        '
        Me.clst_Devices.FormattingEnabled = True
        Me.clst_Devices.Location = New System.Drawing.Point(0, 0)
        Me.clst_Devices.Name = "clst_Devices"
        Me.clst_Devices.Size = New System.Drawing.Size(177, 446)
        Me.clst_Devices.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'gbx_Info
        '
        Me.gbx_Info.Controls.Add(Me.txt_Checkin)
        Me.gbx_Info.Controls.Add(Me.lbl_Last_Checkin)
        Me.gbx_Info.Controls.Add(Me.lbl_Stat_Display)
        Me.gbx_Info.Controls.Add(Me.llbl_IP)
        Me.gbx_Info.Controls.Add(Me.lbl_Status)
        Me.gbx_Info.Controls.Add(Me.txt_UpTime)
        Me.gbx_Info.Controls.Add(Me.lbl_UpTime)
        Me.gbx_Info.Controls.Add(Me.lbl_IP)
        Me.gbx_Info.Controls.Add(Me.txt_Computer_Name)
        Me.gbx_Info.Controls.Add(Me.lbl_Computer)
        Me.gbx_Info.Controls.Add(Me.txt_Name)
        Me.gbx_Info.Controls.Add(Me.lbl_Name)
        Me.gbx_Info.Location = New System.Drawing.Point(183, 12)
        Me.gbx_Info.Name = "gbx_Info"
        Me.gbx_Info.Size = New System.Drawing.Size(465, 422)
        Me.gbx_Info.TabIndex = 2
        Me.gbx_Info.TabStop = False
        Me.gbx_Info.Text = "Info"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Location = New System.Drawing.Point(16, 32)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(45, 17)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Name"
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(19, 52)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.ReadOnly = True
        Me.txt_Name.Size = New System.Drawing.Size(118, 22)
        Me.txt_Name.TabIndex = 1
        '
        'lbl_Computer
        '
        Me.lbl_Computer.AutoSize = True
        Me.lbl_Computer.Location = New System.Drawing.Point(174, 32)
        Me.lbl_Computer.Name = "lbl_Computer"
        Me.lbl_Computer.Size = New System.Drawing.Size(110, 17)
        Me.lbl_Computer.TabIndex = 2
        Me.lbl_Computer.Text = "Computer Name"
        '
        'txt_Computer_Name
        '
        Me.txt_Computer_Name.Location = New System.Drawing.Point(177, 52)
        Me.txt_Computer_Name.Name = "txt_Computer_Name"
        Me.txt_Computer_Name.ReadOnly = True
        Me.txt_Computer_Name.Size = New System.Drawing.Size(118, 22)
        Me.txt_Computer_Name.TabIndex = 3
        '
        'lbl_IP
        '
        Me.lbl_IP.AutoSize = True
        Me.lbl_IP.Location = New System.Drawing.Point(174, 116)
        Me.lbl_IP.Name = "lbl_IP"
        Me.lbl_IP.Size = New System.Drawing.Size(76, 17)
        Me.lbl_IP.TabIndex = 4
        Me.lbl_IP.Text = "IP Address"
        '
        'lbl_UpTime
        '
        Me.lbl_UpTime.AutoSize = True
        Me.lbl_UpTime.Location = New System.Drawing.Point(326, 32)
        Me.lbl_UpTime.Name = "lbl_UpTime"
        Me.lbl_UpTime.Size = New System.Drawing.Size(61, 17)
        Me.lbl_UpTime.TabIndex = 6
        Me.lbl_UpTime.Text = "Up Time"
        '
        'txt_UpTime
        '
        Me.txt_UpTime.Location = New System.Drawing.Point(329, 52)
        Me.txt_UpTime.Name = "txt_UpTime"
        Me.txt_UpTime.ReadOnly = True
        Me.txt_UpTime.Size = New System.Drawing.Size(118, 22)
        Me.txt_UpTime.TabIndex = 7
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(16, 116)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(48, 17)
        Me.lbl_Status.TabIndex = 9
        Me.lbl_Status.Text = "Status"
        '
        'llbl_IP
        '
        Me.llbl_IP.Location = New System.Drawing.Point(174, 135)
        Me.llbl_IP.Name = "llbl_IP"
        Me.llbl_IP.Size = New System.Drawing.Size(120, 23)
        Me.llbl_IP.TabIndex = 10
        Me.llbl_IP.TabStop = True
        Me.llbl_IP.Text = "255.255.255.255"
        '
        'lbl_Stat_Display
        '
        Me.lbl_Stat_Display.AutoSize = True
        Me.lbl_Stat_Display.ForeColor = System.Drawing.Color.Red
        Me.lbl_Stat_Display.Location = New System.Drawing.Point(16, 139)
        Me.lbl_Stat_Display.Name = "lbl_Stat_Display"
        Me.lbl_Stat_Display.Size = New System.Drawing.Size(43, 17)
        Me.lbl_Stat_Display.TabIndex = 11
        Me.lbl_Stat_Display.Text = "Down"
        '
        'lbl_Last_Checkin
        '
        Me.lbl_Last_Checkin.AutoSize = True
        Me.lbl_Last_Checkin.Location = New System.Drawing.Point(326, 116)
        Me.lbl_Last_Checkin.Name = "lbl_Last_Checkin"
        Me.lbl_Last_Checkin.Size = New System.Drawing.Size(89, 17)
        Me.lbl_Last_Checkin.TabIndex = 12
        Me.lbl_Last_Checkin.Text = "Last Checkin"
        '
        'txt_Checkin
        '
        Me.txt_Checkin.Location = New System.Drawing.Point(329, 136)
        Me.txt_Checkin.Name = "txt_Checkin"
        Me.txt_Checkin.ReadOnly = True
        Me.txt_Checkin.Size = New System.Drawing.Size(118, 22)
        Me.txt_Checkin.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 446)
        Me.Controls.Add(Me.gbx_Info)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clst_Devices)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbx_Info.ResumeLayout(False)
        Me.gbx_Info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clst_Devices As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbx_Info As GroupBox
    Friend WithEvents txt_Computer_Name As TextBox
    Friend WithEvents lbl_Computer As Label
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents txt_UpTime As TextBox
    Friend WithEvents lbl_UpTime As Label
    Friend WithEvents lbl_IP As Label
    Friend WithEvents llbl_IP As LinkLabel
    Friend WithEvents lbl_Status As Label
    Friend WithEvents txt_Checkin As TextBox
    Friend WithEvents lbl_Last_Checkin As Label
    Friend WithEvents lbl_Stat_Display As Label
End Class
