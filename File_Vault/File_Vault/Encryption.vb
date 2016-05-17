Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Encryption

    ' Private section
    'Private crypto As New CryptoConfig()
    Private cryptoService As New DESCryptoServiceProvider()
    Private Const encrypton_Key As String = "Linux_Samba_5285250_8902_7798_BioKnight_1981"
    Private preEncrypt_File() As Byte
    Private encrypt_File() As Byte
    Private str_input_File As String
    Private fsInput As FileStream
    Private fsEncrypted As FileStream
    'Private encrypted_Stream As FileStream

    Private Sub encrypt_Object()

        ' Create the DES encryptor from this instance.
        Dim desencrypt As ICryptoTransform = cryptoService.CreateEncryptor()
        ' Create the crypto stream that transforms the file stream by using DES encryption.
        Dim cryptostream As New CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write)

        ' Write out the DES encrypted file.
        cryptostream.Write(encrypt_File, 0, encrypt_File.Length)
        cryptostream.Close()
    End Sub


    ' Call this function to remove the key from memory after it is used for security.
    Private Declare Sub ZeroMemory Lib "kernel32.dll" Alias "RtlZeroMemory" (ByVal Destination As String, ByVal Length As Integer)

    ' Careful with these, how do we decrypt if we do not know the key?

    ' Function to generate a key.
    Function GenerateKey() As String
        ' Create an instance of Symmetric Algorithm. The key and the IV are generated automatically.
        Dim desCrypto As DESCryptoServiceProvider = DESCryptoServiceProvider.Create()

        ' Use the automatically generated key for encryption. 
        Return ASCIIEncoding.ASCII.GetString(desCrypto.Key)
    End Function

    ' Public section

    Sub New(ByVal input_File As String)   ' Sub EncryptFile(ByVal sInputFilename As String, ByVal sOutputFilename As String, ByVal sKey As String)
        str_input_File = input_File

        ' Read the file to the byte array.
        fsInput = New FileStream(str_input_File, FileMode.Open, FileAccess.Read)
        ReDim preEncrypt_File(fsInput.Length - 1)
        ReDim encrypt_File(fsInput.Length - 1)
        fsInput.Read(preEncrypt_File, 0, preEncrypt_File.Length)

        ' Set secret key for DES algorithm.
        cryptoService.Key = ASCIIEncoding.ASCII.GetBytes(encrypton_Key) ' A 64-bit key and an IV are required for this provider.
        cryptoService.IV = ASCIIEncoding.ASCII.GetBytes(encrypton_Key)  ' Set the initialization vector.


    End Sub




End Class
