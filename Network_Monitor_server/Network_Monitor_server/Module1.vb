
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Text

Module Module1

    Sub Main()
        Dim host_Name As String = System.Net.Dns.GetHostName()
        ' This will not work in all situations, revamp
        Dim IP_Address As String = System.Net.Dns.GetHostEntry(host_Name).AddressList(4).ToString()
        Dim netmask As String


        Dim Interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface
        Dim adapter_Properties As IPInterfaceProperties = Nothing
        Dim myGateways As GatewayIPAddressInformationCollection = Nothing

        For Each adapter In Interfaces
            If adapter.NetworkInterfaceType = NetworkInterfaceType.Loopback Then
                Continue For
            End If
            Dim adapter_Name As String = adapter.Name
            Dim adapter_Description As String = adapter.Description
            adapter_Properties = adapter.GetIPProperties
            myGateways = adapter_Properties.GatewayAddresses
            Dim IPInfo As UnicastIPAddressInformationCollection = adapter.GetIPProperties().UnicastAddresses
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()

            For Each IPAddressInfo As UnicastIPAddressInformation In IPInfo
                If IPAddressInfo.Address.ToString = IP_Address Then
                    netmask = IPAddressInfo.IPv4Mask.ToString
                    MsgBox(IP_Address & " " & netmask)
                End If
            Next

            For Each Gateway As GatewayIPAddressInformation In myGateways
                'TextBox1.AppendText("Gateway IP :" & Gateway.Address.ToString & Environment.NewLine)
            Next

            'TextBox1.AppendText("DNS Address :" & properties.DnsAddresses.ToString & Environment.NewLine)
        Next



        Dim socket As New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
        Dim broadcast_Address As IPAddress = IPAddress.Parse("192.168.1.255")
        Dim send_buffer As Byte() = Encoding.ASCII.GetBytes("Message")
        Dim end_Point As New IPEndPoint(broadcast_Address, 11000)
        socket.SendTo(send_buffer, end_Point)
    End Sub

End Module
