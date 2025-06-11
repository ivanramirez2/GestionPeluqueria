Imports MySql.Data.MySqlClient

Public Class FrmEliminarCliente

    Private Sub FrmEliminarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        If Not VerificarCamposVacíos() Then
            Return
        End If

        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Try

            Dim consultaVerificar As String = "SELECT id, estado, ultima_conexion FROM usuarios " &
                                         "WHERE LOWER(TRIM(nombre)) LIKE LOWER(TRIM(@nombre)) AND id_rol = 3"
            Dim idCliente As Integer = 0
            Dim estadoActual As String = ""
            Dim ultimaConexion As DateTime = DateTime.MinValue

            Using cmdVerificar As New MySqlCommand(consultaVerificar, ConexionDB.conexion)
                cmdVerificar.Parameters.AddWithValue("@nombre", TxtNombreCliente.Text.Trim().ToLower())
                Dim reader As MySqlDataReader = cmdVerificar.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    idCliente = reader.GetInt32(0)
                    estadoActual = reader.GetString(1)
                    ultimaConexion = If(reader.IsDBNull(2), DateTime.MinValue, reader.GetDateTime(2))
                    reader.Close()
                Else
                    MessageBox.Show("No se ha encontrado cliente con ese nombre")
                    reader.Close()
                    Return
                End If
            End Using

            ' Verificar si han pasado 3 días desde la última conexión
            Dim diasSinConectar As Integer = DateTime.Now.Subtract(ultimaConexion).Days
            Dim tieneConexionReciente As Boolean = diasSinConectar < 3

            'Si lleva 3 días o más sin conectarse, cambiar el estado a "Eliminado"
            If Not tieneConexionReciente Then
                Dim nuevoEstado As String = "Eliminado"

                Dim consultaActualizar As String = "UPDATE usuarios SET estado = @nuevoEstado WHERE id = @id"
                Using cmdActualizar As New MySqlCommand(consultaActualizar, ConexionDB.conexion)
                    cmdActualizar.Parameters.AddWithValue("@nuevoEstado", nuevoEstado)
                    cmdActualizar.Parameters.AddWithValue("@id", idCliente)

                    Dim filasAfectadas As Integer = cmdActualizar.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        MessageBox.Show("El estado del cliente ha cambiado a '" & nuevoEstado & "' por llevar " & diasSinConectar & " días sin conectarse.")
                        CargarDatosClientes()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("Se ha producido un error al actualizar el estado del cliente.")
                    End If
                End Using
            Else
                MessageBox.Show("El cliente se ha conectado en los últimos 3 días (" & diasSinConectar & " días). No se modificará su estado.")
            End If

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al actualizar el cliente: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub


    ' Verificar si los campos no están vacíos (registro empleado)
    Private Function VerificarCamposVacíos() As Boolean
        If TxtNombreCliente.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return False
        End If
        Return True
    End Function

    ' Función para limpiar los campos después del registro empleado
    Private Sub LimpiarCampos()
        TxtNombreCliente.Clear()
    End Sub

    Private Sub Eliminar_Cliente_Sin_Pagar_Click(sender As Object, e As EventArgs) Handles Eliminar_Cliente_Sin_Pagar.Click


        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Try
            ' 1. Verificar si el cliente existe y obtener su ID
            Dim consultaVerificar As String = "SELECT id, estado FROM usuarios 
                                           WHERE LOWER(TRIM(nombre)) LIKE LOWER(TRIM(@nombre)) AND id_rol = 3"
            Dim idCliente As Integer = 0
            Dim estadoActual As String = ""

            Using cmdVerificar As New MySqlCommand(consultaVerificar, ConexionDB.conexion)
                cmdVerificar.Parameters.AddWithValue("@nombre", TxtNombreCliente2.Text.Trim().ToLower())
                Dim reader As MySqlDataReader = cmdVerificar.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    idCliente = reader.GetInt32(0)
                    estadoActual = reader.GetString(1)
                    reader.Close()
                Else
                    MessageBox.Show("No se ha encontrado cliente con ese nombre")
                    reader.Close()
                    Return
                End If
            End Using

            ' 2. Verificar si el cliente tiene pagos en los últimos 2 meses
            Dim consultaPagos As String = "SELECT COUNT(*) FROM Pagos 
                                       WHERE id_usuario = @idCliente 
                                       AND fecha_pago >= DATE_SUB(NOW(), INTERVAL 2 MONTH)"
            Dim tienePagosRecientes As Boolean = False

            Using cmdPagos As New MySqlCommand(consultaPagos, ConexionDB.conexion)
                cmdPagos.Parameters.AddWithValue("@idCliente", idCliente)
                Dim resultado As Object = cmdPagos.ExecuteScalar()
                tienePagosRecientes = Convert.ToInt32(resultado) > 0
            End Using

            ' 3. Si no tiene pagos recientes, cambiar el estado
            If Not tienePagosRecientes Then
                Dim nuevoEstado As String = "Eliminado" ' O "Eliminado" si prefieres eliminarlo permanentemente

                Dim consultaActualizar As String = "UPDATE usuarios SET estado = @nuevoEstado WHERE id = @id"
                Using cmdActualizar As New MySqlCommand(consultaActualizar, ConexionDB.conexion)
                    cmdActualizar.Parameters.AddWithValue("@nuevoEstado", nuevoEstado)
                    cmdActualizar.Parameters.AddWithValue("@id", idCliente)

                    Dim filasAfectadas As Integer = cmdActualizar.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        MessageBox.Show("El estado del cliente ha cambiado a '" & nuevoEstado & "' por no tener pagos en los últimos 2 meses.")
                        CargarDatosClientes()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("Se ha producido un error al actualizar el estado del cliente.")
                    End If
                End Using
            Else
                MessageBox.Show("El cliente tiene pagos recientes en los últimos 2 meses. No se modificará su estado.")
            End If

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub
End Class