Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class RecuperacionContrasena
    ' Método para generar una contraseña temporal
    Public Shared Function GenerarContrasenaTemporal() As String
        Dim caracteres As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim random As New Random()
        Dim contrasena As New StringBuilder()
        For i As Integer = 0 To 9 ' Genera una contraseña de 10 caracteres
            contrasena.Append(caracteres(random.Next(caracteres.Length)))
        Next
        Return contrasena.ToString()
    End Function

    ' Método para enviar el correo con la contraseña temporal
    Public Shared Sub EnviarCorreo(recipient As String, contrasenaTemporal As String)
        Try
            ' Crear el objeto de correo
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("ivan.ramirez.torres@alumnojoyfe.iepgroup.es", "vbop wvxy tktd faoj")
            smtp.EnableSsl = True

            ' Crear el mensaje de correo
            Dim mensaje As New MailMessage()
            mensaje.From = New MailAddress("ivan.ramirez.torres@alumnojoyfe.iepgroup.es")
            mensaje.To.Add(recipient)
            mensaje.Subject = "Recuperación de Contraseña"
            mensaje.Body = $"Hola, has solicitado recuperar tu contraseña. Usa esta contraseña temporal para iniciar sesión: {contrasenaTemporal}. Cámbiala inmediatamente después de iniciar sesión."

            ' Enviar el correo
            smtp.Send(mensaje)
            MessageBox.Show("Correo enviado exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message)
        End Try
    End Sub

    ' Método para verificar si el correo existe en la base de datos
    Public Shared Function VerificarCorreoExistente(correo As String) As Boolean
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return False
        End If

        Dim consulta As String = "SELECT usuario FROM usuarios WHERE email = @correo"
        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@correo", correo)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close()
                    Return True
                Else
                    MessageBox.Show("Correo electrónico no encontrado.")
                    reader.Close()
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar el correo: " & ex.Message)
            Return False
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Function

    ' Método para guardar la contraseña temporal en la base de datos
    Public Shared Sub GuardarContrasenaTemporal(correo As String, contrasenaTemporal As String)
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Dim passwordHash As String = ObtenerHash(contrasenaTemporal)
        Dim consulta As String = "UPDATE usuarios SET password_hash = @password_hash, es_temporal = 1 WHERE email = @correo"
        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@password_hash", passwordHash)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar la contraseña temporal: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Función para obtener el hash de la contraseña
    Private Shared Function ObtenerHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function
End Class