Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class RecuperacionContrasena

    ' Método para generar un token único
    Public Shared Function GenerarToken() As String
        Using rng As New RNGCryptoServiceProvider()
            Dim buffer(32) As Byte
            rng.GetBytes(buffer)
            Return BitConverter.ToString(buffer).Replace("-", "").ToLower()
        End Using
    End Function

    ' Método para enviar el correo de recuperación de contraseña
    Public Shared Sub EnviarCorreo(recipient As String, token As String)
        Try
            ' Crear el objeto de correo
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("ivan.ramirez.torres@iepgroup.es", "vbop wvxy tktd faoj")
            smtp.EnableSsl = True

            ' Crear el mensaje de correo
            Dim mensaje As New MailMessage()
            mensaje.From = New MailAddress("ivan.ramirez.torres@iepgroup.es")
            mensaje.To.Add(recipient)
            mensaje.Subject = "Recuperación de Contraseña"
            mensaje.Body = $"Hola, has solicitado recuperar tu contraseña. Usa el siguiente enlace para restablecerla: http://www.tusitio.com/restablecer?token={token}"

            ' Enviar el correo
            smtp.Send(mensaje)
            MessageBox.Show("Correo enviado exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message)
        End Try
    End Sub

    ' Método para verificar si el correo existe en la base de datos
    Public Shared Function VerificarCorreoExistente(correo As String) As Boolean
        ' Establecer la conexión con la base de datos
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
                    reader.Read()
                    Return True
                Else
                    MessageBox.Show("Correo electrónico no encontrado.")
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

    ' Método para guardar el token en la base de datos
    Public Shared Sub GuardarToken(correo As String, token As String)
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Dim insertarToken As String = "UPDATE usuarios SET token_recuperacion = @token WHERE email = @correo"
        Try
            Using cmd As New MySqlCommand(insertarToken, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@token", token)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar el token: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Método para restablecer la contraseña en la base de datos
    Public Shared Function RestablecerContrasena(token As String, nuevaContraseña As String) As Boolean
        ' Establecer la conexión con la base de datos
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return False
        End If

        Dim consulta As String = "SELECT email FROM usuarios WHERE token_recuperacion = @token"
        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@token", token)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    Dim email As String = reader.GetString(0)

                    ' Si el token es válido, actualizamos la contraseña
                    Dim passwordHash As String = ObtenerHash(nuevaContraseña)
                    Dim actualizarPassword As String = "UPDATE usuarios SET password_hash = @password_hash, token_recuperacion = NULL WHERE email = @email"
                    Using cmdUpdate As New MySqlCommand(actualizarPassword, ConexionDB.conexion)
                        cmdUpdate.Parameters.AddWithValue("@password_hash", passwordHash)
                        cmdUpdate.Parameters.AddWithValue("@email", email)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    Return True
                Else
                    MessageBox.Show("Token inválido.")
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al restablecer la contraseña: " & ex.Message)
            Return False
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Function

    ' Función para obtener el hash de la nueva contraseña
    Private Shared Function ObtenerHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function
End Class
