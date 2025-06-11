Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FrmCrearNuevoCliente

    Private Sub FrmCrearNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosClientes()
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        TxtContrasena.PasswordChar = "*"
    End Sub



    Private Sub CargarDatosClientes()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM usuarios"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            ConexionDB.CerrarConexion()
        End If
    End Sub


    Private Sub btnAgregarClienteNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregarClienteNuevo.Click

        If Not VerificarCamposVacíos() Then
            Return
        End If

        ' Obtener el hash de la contraseña
        Dim passwordHash As String = ObtenerHash(TxtContrasena.Text)

        ' Conexión con la base de datos
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If


        Dim consulta As String = "INSERT INTO usuarios (nombre, email, usuario, password_hash, id_rol) VALUES (@nombre, @email, @usuario, @password_hash, @id_rol)"

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text)
                cmd.Parameters.AddWithValue("@email", TxtEmail.Text)
                cmd.Parameters.AddWithValue("@usuario", TxtUsuario.Text)
                cmd.Parameters.AddWithValue("@password_hash", passwordHash)
                cmd.Parameters.AddWithValue("@id_rol", TxtRol.Text)

                ' Ejecutar la consulta
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro realizado correctamente.")
                CargarDatosClientes()
                ' Limpiar los campos después del registro
                LimpiarCampos()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Función para obtener el hash de la contraseña usando SHA256
    Private Function ObtenerHash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

    ' Verificar si los campos no están vacíos (registro)
    Private Function VerificarCamposVacíos() As Boolean
        If TxtNombre.Text = "" Or TxtContrasena.Text = "" Or TxtEmail.Text = "" Or TxtUsuario.Text = "" Or TxtRol.Text = "" Then
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
        TxtRol.Clear()
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub
End Class