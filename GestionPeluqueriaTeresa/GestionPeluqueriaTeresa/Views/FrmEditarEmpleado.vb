Imports MySql.Data.MySqlClient

Public Class FrmEditarEmpleado
    Private Sub FrmEditarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosEmpleados()
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
    End Sub

    Private Sub CargarDatosEmpleados()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM empleados"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            ConfigurarEstilosDataGridView()

            ConexionDB.CerrarConexion()
        End If
    End Sub

    ' Configurar Estilos del DataGridView
    Private Sub ConfigurarEstilosDataGridView()
        With DataGridView1
            .BackgroundColor = Color.White
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .GridColor = Color.Black
        End With
    End Sub

    ' Verificar si los campos no están vacíos
    Private Function VerificarCamposVacíos() As Boolean
        If TxtNombre.Text = "" Or TxtEspecialidad.Text = "" Or TxtHorarioInicio.Text = "" Or TxtHorarioFin.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return False
        End If
        Return True
    End Function

    Private Sub btnEditarEmpleadoExistente_Click(sender As Object, e As EventArgs) Handles btnEditarEmpleadoExistente.Click
        ' Verificar si los campos están vacíos
        If Not VerificarCamposVacíos() Then
            Return
        End If

        ' Conexión con la base de datos
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Try

            Dim consultaEmpleado As String = "SELECT id FROM empleados WHERE nombre = @nombre"
            Dim idEmpleado As Integer = 0

            Using cmdEmpleado As New MySqlCommand(consultaEmpleado, ConexionDB.conexion)
                cmdEmpleado.Parameters.AddWithValue("@nombre", TxtNombre.Text)
                Dim reader As MySqlDataReader = cmdEmpleado.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    idEmpleado = reader.GetInt32(0)
                    reader.Close()
                Else
                    MessageBox.Show("Empleado no encontrado.")
                    reader.Close()
                    Return
                End If
            End Using

            ' Actualizar los datos del empleado
            Dim consultaActualizarEmpleado As String = "UPDATE empleados SET especialidad = @especialidad, horario_inicio = @horario_inicio, horario_fin = @horario_fin WHERE id = @id"

            Using cmdActualizarEmpleado As New MySqlCommand(consultaActualizarEmpleado, ConexionDB.conexion)
                cmdActualizarEmpleado.Parameters.AddWithValue("@id", idEmpleado)
                cmdActualizarEmpleado.Parameters.AddWithValue("@especialidad", TxtEspecialidad.Text)
                cmdActualizarEmpleado.Parameters.AddWithValue("@horario_inicio", TxtHorarioInicio.Text)
                cmdActualizarEmpleado.Parameters.AddWithValue("@horario_fin", TxtHorarioFin.Text)
                Dim filasAfectadas As Integer = cmdActualizarEmpleado.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    MessageBox.Show(TxtNombre.Text & " editado correctamente.")
                    CargarDatosEmpleados()
                    LimpiarCampos()
                Else
                    MessageBox.Show("No se pudo actualizar el empleado.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Función para limpiar los campos
    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtEspecialidad.Clear()
        TxtHorarioInicio.Clear()
        TxtHorarioFin.Clear()
    End Sub

End Class