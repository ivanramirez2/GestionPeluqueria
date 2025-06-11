Imports MySql.Data.MySqlClient

Public Class FrmActivarUsuario
    Private Sub FrmActivarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosClientes()
    End Sub





    Private Sub CargarDatosClientes()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM usuarios WHERE id_rol = 3"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            ConexionDB.CerrarConexion()
        End If
    End Sub

    Private Sub btnActivarUsuario_Click(sender As Object, e As EventArgs) Handles btnActivarUsuario.Click
        If Not VerificarCamposVacíos() Then
            Return
        End If

        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If


        Try
            Dim consultaVerificar As String = "SELECT id, estado FROM usuarios 
                                               WHERE LOWER(TRIM(nombre)) LIKE LOWER(TRIM(@nombre)) AND id_rol = 3"

            Dim idCliente As Integer = 0
            Dim estadoActual As String = ""

            Using cmdVerificar As New MySqlCommand(consultaVerificar, ConexionDB.conexion)
                cmdVerificar.Parameters.AddWithValue("@nombre", TxtNombreUsuarioActivar.Text.Trim().ToLower())

                Dim reader As MySqlDataReader = cmdVerificar.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    idCliente = reader.GetInt32(0)
                    estadoActual = reader.GetString(1)
                Else
                    MessageBox.Show("No se ha encontrado cliente con ese nombre")
                    reader.Close()
                    Return
                End If
                reader.Close()
            End Using

            Dim nuevoEstado As String = If(estadoActual = "Activo", "Inactivo", "Activo")

            Dim consultaActulizar As String = "UPDATE usuarios SET estado = @nuevoEstado WHERE id = @id"

            Using cmdActualizar As New MySqlCommand(consultaActulizar, ConexionDB.conexion)
                cmdActualizar.Parameters.AddWithValue("@nuevoEstado", nuevoEstado)
                cmdActualizar.Parameters.AddWithValue("@id", idCliente)

                Dim filasAfectadas As Integer = cmdActualizar.ExecuteNonQuery()
                If filasAfectadas > 0 Then
                    MessageBox.Show("El estado del cliente ha cambiado a '" & nuevoEstado & "' correctamente")
                    CargarDatosClientes()
                    LimpiarCampos()
                Else
                    MessageBox.Show("Se ha producido un error al activar el usuario")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al actualizar el cliente: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub


    ' Verificar si los campos no están vacíos
    Private Function VerificarCamposVacíos() As Boolean
        If TxtNombreUsuarioActivar.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return False
        End If
        Return True
    End Function

    ' Función para limpiar los campos
    Private Sub LimpiarCampos()
        TxtNombreUsuarioActivar.Clear()
    End Sub






End Class