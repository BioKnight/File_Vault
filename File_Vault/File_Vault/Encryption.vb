Imports System.Security.Cryptography


Public Class Encryption

    ' Private section
    Private Const encrypton_Key As String = "Linux_Samba_5285250_8902_7798_BioKnight_1981"
    Private preEncrypt_Object As Object
    Private encrypted_Object As Object

    Private Sub encrypt_Object()

    End Sub

    ' Public section

    Sub New(ByVal obj_Encrypt As Object)
        preEncrypt_Object = obj_Encrypt

    End Sub

    Public Function get_Encrypted_Object() As Object

    End Function


End Class
