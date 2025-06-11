Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FrmPrincipal
    Private controlTimer As Boolean = False
    Private moveToRegister As Boolean = False
    Private idUsuarioTemporal As Integer = 0

    ' Variables globales para el usuario logueado
    Public Shared IdUsuarioLogueado As Integer
    Public Shared NombreUsuarioLogueado As String

    ' Evento para cambiar el color de los botones al pasar el ratón
    Private Sub btnMouseEnter(sender As Object, e As EventArgs) Handles btnAc.MouseEnter, btnRegistro.MouseEnter
        For Each ctr As Control In pPrincipal.Controls
            If TypeOf ctr Is Button Then
                ctr.ForeColor = Color.Black
            End If
        Next
    End Sub

    ' Evento para restaurar el color de los botones al salir el ratón
    Private Sub btnMouseLeave(sender As Object, e As EventArgs) Handles btnAc.MouseLeave, btnRegistro.MouseLeave
        For Each ctr As Control In pPrincipal.Controls
            If TypeOf ctr Is Button Then
                ctr.ForeColor = Color.White
            End If
        Next
    End Sub

    ' Evento del Timer para mover el contenedor
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pContenedor IsNot Nothing Then
            If moveToRegister Then
                If pContenedor.Left < 500 Then
                    pContenedor.Left += 10
                    pReg.Visible = True
                    pCon.Visible = False
                    texto.Visible = False
                    pRestablecerContrasena.Visible = False
                    pNuevaContraseña.Visible = False
                Else
                    Timer1.Stop()
                End If
            Else
                If pContenedor.Left > 0 Then
                    pContenedor.Left -= 10
                    pCon.Visible = True
                    pReg.Visible = False
                    pRestablecerContrasena.Visible = False
                    pNuevaContraseña.Visible = False
                Else
                    Timer1.Stop()
                End If
            End If
        End If
    End Sub

    ' Evento para el botón "Registrar" (mueve el contenedor hacia el panel de registro)
    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        texto.Visible = False
        moveToRegister = True
        Timer1.Start()
    End Sub

    ' Evento para el botón "Acceder" (mueve el contenedor hacia el panel de login)
    Private Sub btnAc_Click(sender As Object, e As EventArgs) Handles btnAc.Click
        moveToRegister = False
        Timer1.Start()
    End Sub

    Private Sub FrmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCon.Visible = True
        pReg.Visible = False
        pRestablecerContrasena.Visible = False
        pNuevaContraseña.Visible = False
        pContenedor.Left = 0


        TxtContrasena.PasswordChar = "*" ' Registro
        TxtContraseñaLogin.PasswordChar = "*" ' Login
        TxtNuevaContrasena.PasswordChar = "*" ' Nueva contraseña
        TxtConfirmarContrasena.PasswordChar = "*" ' Confirmar nueva contraseña
    End Sub

    ' Función para validar el formato del correo electrónico
    Private Function EsCorreoValido(email As String, Optional soloGmail As Boolean = False) As Boolean
        ' Expresión para validar el formato general del correo
        Dim regex As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(email, regex) Then
            Return False
        End If


        Return True
    End Function

    ' Evento para el botón "Registrar" - Verificar campos y registrar el usuario
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If Not VerificarCamposVacíos() Then
            Return
        End If

        ' Validar el correo electrónico
        If Not EsCorreoValido(TxtEmail.Text) Then
            MessageBox.Show("Por favor, ingrese un correo electrónico válido.")
            Return
        End If


        Dim passwordHash As String = ObtenerHash(TxtContrasena.Text)

        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Dim consulta As String = "INSERT INTO usuarios (nombre, email, usuario, password_hash, id_rol, estado, es_temporal) VALUES (@nombre, @email, @usuario, @password_hash, @id_rol, @estado, @es_temporal)"

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text)
                cmd.Parameters.AddWithValue("@email", TxtEmail.Text)
                cmd.Parameters.AddWithValue("@usuario", TxtUsuario.Text)
                cmd.Parameters.AddWithValue("@password_hash", passwordHash)
                cmd.Parameters.AddWithValue("@id_rol", 3) ' Rol de cliente
                cmd.Parameters.AddWithValue("@estado", "Activo")
                cmd.Parameters.AddWithValue("@es_temporal", 0)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro realizado correctamente.")
                LimpiarCampos()

                moveToRegister = False
                Timer1.Start()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Verificar si los campos no están vacíos (registro)
    Private Function VerificarCamposVacíos() As Boolean
        If TxtNombre.Text = "" Or TxtContrasena.Text = "" Or TxtEmail.Text = "" Or TxtUsuario.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return False
        End If
        Return True
    End Function

    ' Función para limpiar los campos después del registro
    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtContrasena.Clear()
        TxtUsuario.Clear()
        TxtEmail.Clear()
    End Sub

    ' Evento para el botón "Acceder" - Verificar usuario y contraseña
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If TxtUsuarioLogin.Text = "" Or TxtContraseñaLogin.Text = "" Then
            MessageBox.Show("Por favor, ingrese usuario y contraseña.")
            Return
        End If

        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Dim consulta As String = "SELECT id, password_hash, nombre, id_rol, estado, es_temporal FROM usuarios WHERE usuario = @usuario"
        Dim idUsuario As Integer = 0
        Dim passwordHash As String = String.Empty
        Dim nombreUsuario As String = String.Empty
        Dim idRol As Integer = 0
        Dim estadoUsuario As String = String.Empty
        Dim esTemporal As Boolean = False

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@usuario", TxtUsuarioLogin.Text)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        idUsuario = reader.GetInt32(0)
                        passwordHash = reader.GetString(1)
                        nombreUsuario = reader.GetString(2)
                        idRol = reader.GetInt32(3)
                        estadoUsuario = reader.GetString(4)
                        esTemporal = reader.GetBoolean(5)
                        reader.Close()
                    Else
                        reader.Close()
                        MessageBox.Show("Usuario no encontrado.")
                        Return
                    End If
                End Using

                If estadoUsuario <> "Activo" Then
                    MessageBox.Show("El usuario está " & estadoUsuario.ToLower() & ". No puede iniciar sesión.")
                    Return
                End If

                Dim inputHash As String = ObtenerHash(TxtContraseñaLogin.Text)
                If passwordHash = inputHash Then
                    If esTemporal Then
                        idUsuarioTemporal = idUsuario
                        pCon.Visible = False
                        pReg.Visible = False
                        pRestablecerContrasena.Visible = False
                        pNuevaContraseña.Visible = True
                        TxtContraseñaLogin.Clear()
                    Else
                        MessageBox.Show("Acceso exitoso para " & nombreUsuario & ".")
                        IdUsuarioLogueado = idUsuario
                        NombreUsuarioLogueado = nombreUsuario

                        Dim formularioVer As Form = Nothing
                        If idRol = 1 Then
                            formularioVer = New FrmPanelAdministrador(nombreUsuario)


                        ElseIf idRol = 2 Then
                            formularioVer = New FrmPanelEmpleado()
                        Else
                            formularioVer = New FrmVentanaCliente(nombreUsuario, IdUsuarioLogueado)
                        End If

                        Me.Hide()

                        formularioVer.Show()
                        Timer1.Stop()
                    End If
                Else
                    MessageBox.Show("Contraseña incorrecta.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al acceder: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Evento para guardar la nueva contraseña desde el panel pNuevaContraseña
    Private Sub BtnGuardarContrasena_Click(sender As Object, e As EventArgs) Handles BtnGuardarContrasena.Click
        If TxtNuevaContrasena.Text = "" Or TxtConfirmarContrasena.Text = "" Then
            MessageBox.Show("Por favor, completa ambos campos.")
            Return
        End If

        If TxtNuevaContrasena.Text <> TxtConfirmarContrasena.Text Then
            MessageBox.Show("Las contraseñas no coinciden.")
            Return
        End If

        Dim nuevoHash As String = ObtenerHash(TxtNuevaContrasena.Text)

        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo conectar a la base de datos.")
            Return
        End If

        Try
            Dim consulta As String = "UPDATE usuarios SET password_hash = @password_hash, es_temporal = 0 WHERE id = @id"
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@password_hash", nuevoHash)
                cmd.Parameters.AddWithValue("@id", idUsuarioTemporal)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Contraseña cambiada exitosamente. Por favor, inicia sesión con tu nueva contraseña.")
            TxtNuevaContrasena.Clear()
            TxtConfirmarContrasena.Clear()
            pNuevaContraseña.Visible = False
            pCon.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error al cambiar la contraseña: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Evento para mostrar el panel de recuperación
    Private Sub LblCredenciales_Click(sender As Object, e As EventArgs) Handles LblCredenciales.Click
        pCon.Visible = False
        pReg.Visible = False
        pContenedor.Visible = False
        pRestablecerContrasena.Visible = True
        pNuevaContraseña.Visible = False
    End Sub

    ' Evento para enviar la contraseña temporal
    Private Sub btnEnviarEnlace_Click(sender As Object, e As EventArgs) Handles BtnEnviarEnlace.Click
        Dim correo As String = TxtCorreoRecuperacion.Text.Trim()

        If correo = "" Then
            MessageBox.Show("Por favor ingresa tu correo electrónico.")
            Return
        End If

        ' Validar el correo electrónico
        If Not EsCorreoValido(correo) Then
            MessageBox.Show("Por favor, ingrese un correo electrónico válido.")
            Return
        End If


        If Not RecuperacionContrasena.VerificarCorreoExistente(correo) Then
            Return
        End If

        Dim contrasenaTemporal As String = RecuperacionContrasena.GenerarContrasenaTemporal()
        RecuperacionContrasena.GuardarContrasenaTemporal(correo, contrasenaTemporal)
        RecuperacionContrasena.EnviarCorreo(correo, contrasenaTemporal)

        MessageBox.Show("Hemos enviado una contraseña temporal a tu correo electrónico.")
        TxtCorreoRecuperacion.Clear()

        pRestablecerContrasena.Visible = False
        pCon.Visible = True
        pContenedor.Left = 0
        pContenedor.Visible = True
        Timer1.Stop()
    End Sub

    ' Función para obtener el hash de la contraseña usando SHA256
    Private Function ObtenerHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function
End Class