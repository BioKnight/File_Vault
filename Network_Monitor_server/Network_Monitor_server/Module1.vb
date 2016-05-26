
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Module Module1

    Private str_IP As String = "192.168.3.0"
    Private ipadd_broadcast_Address As IPAddress = IPAddress.Parse("192.168.3.255")
    Private str_Name As String = "Default"
    Private str_Computer_Name As String = "Default_PC"
    Private str_Uptime As String = "A_While"
    Private socket As New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
    Private end_Point As IPEndPoint
    Private send_buffer As Byte()

    Sub Main(ByVal args As String())
        process_CLI_Args(args)

        'Dim host_Name As String = System.Net.Dns.GetHostName()
        ' This will not work in all situations, revamp
        Dim IP_Address As String = str_IP
        'Dim netmask As String


        'Dim Interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        'Dim adapter As NetworkInterface
        'Dim adapter_Properties As IPInterfaceProperties = Nothing
        'Dim myGateways As GatewayIPAddressInformationCollection = Nothing


        end_Point = New IPEndPoint(ipadd_broadcast_Address, 11000)

        While True
            Broadcast()
            Thread.Sleep(5000)
        End While

        socket.Close()

    End Sub

    Private Sub process_CLI_Args(ByVal args As String())
        If args.Count <= 0 Then Exit Sub

        For counter As Integer = 0 To args.Count - 1
            Select Case LCase(args(counter))
                Case "-ip"
                    str_IP = args(counter + 1)
                Case "-broadcast"
                    ipadd_broadcast_Address = IPAddress.Parse(args(counter + 1))
                Case "-name"

                Case "-uptime"

                Case "-pcname"



            End Select
        Next


    End Sub

    Private Function build_Message() As String
        Dim message As String = ""

        message &= "Name: " & str_Name
        message &= " ; "
        message &= "PC_Name: " & str_Computer_Name
        message &= " ; "
        message &= "UpTime: " & str_Uptime
        message &= " ; "
        message &= "IP_Addess: " & str_IP

        Return message
    End Function

    Private Sub Broadcast()
        Dim message As String = build_Message()
        send_buffer = Encoding.ASCII.GetBytes(message)
        Console.WriteLine("Sending: " & message)
        socket.SendTo(send_buffer, end_Point)
    End Sub
End Module
