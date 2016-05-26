Imports System.Threading
Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Private Const listenPort As Integer = 11000
    Private listen_Thread As Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        listen_Thread = New Thread(AddressOf ThreadTask)
        listen_Thread.IsBackground = True
        listen_Thread.Start()
    End Sub

    Private Sub ThreadTask()
        Do
            StartListener()
        Loop
    End Sub


    Delegate Sub SetTextCallback(ByVal txt As String, txt_Box As TextBox)
    Private Sub SetText(ByVal txt As String, txt_Box As TextBox)

        ' InvokeRequired required compares the thread ID of the'
        ' calling thread to the thread ID of the creating thread.'
        ' If these threads are different, it returns true.'
        If txt_Box.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[Text]})
        Else
            txt_Box.Text = txt
        End If
    End Sub

    Private Shared Sub StartListener()
        Dim done As Boolean = False
        Dim listener As New UdpClient(listenPort)
        Dim groupEP As New IPEndPoint(IPAddress.Any, listenPort)
        Try
            While Not done
                Console.WriteLine("Waiting for broadcast")
                Dim bytes As Byte() = listener.Receive(groupEP)
                Console.WriteLine("Received broadcast from {0} :",
                    groupEP.ToString())
                Console.WriteLine(
                    Encoding.ASCII.GetString(bytes, 0, bytes.Length))
                Console.WriteLine()
            End While
        Catch e As Exception
            Console.WriteLine(e.ToString())
        Finally
            listener.Close()
        End Try
    End Sub 'StartListener
End Class
