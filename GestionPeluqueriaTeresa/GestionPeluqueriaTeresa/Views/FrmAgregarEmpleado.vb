Imports MySql.Data.MySqlClient

Public Class FrmAgregarEmpleado
    Private Sub FrmAgregarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosEmpleados()
    End Sub

    Private Sub CargarDatosEmpleados()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM empleados"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            ConexionDB.CerrarConexion()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnAgregarEmpleadoNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleadoNuevo.Click

        ' Verificar si los campos están vacíos antes de registrar empleado

        If Not VerificarCamposVacíos() Then
            Return
        End If



        ' Conexión con la base de datos
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If


        Dim consulta As String = "INSERT INTO Empleados (nombre, especialidad, horario_inicio, horario_fin) VALUES (@nombre, @especialidad, @horario_inicio, @horario_fin)"

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)

                cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text)
                cmd.Parameters.AddWithValue("@especialidad", TxtEspecialidad.Text)
                cmd.Parameters.AddWithValue("@horario_inicio", TxtHorarioInicio.Text)
                cmd.Parameters.AddWithValue("@horario_fin", TxtHorarioFin.Text)


                ' Ejecutar la consulta
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro de " + TxtNombre.Text + " realizado correctamente.")
                CargarDatosEmpleados()

                ' Limpiar los campos después del registro empleado
                LimpiarCampos()


            End Using
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub


    ' Verificar si los campos no están vacíos (registro empleado)
    Private Function VerificarCamposVacíos() As Boolean
        If TxtNombre.Text = "" Or TxtEspecialidad.Text = "" Or TxtHorarioInicio.Text = "" Or TxtHorarioFin.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return False
        End If
        Return True
    End Function

    ' Función para limpiar los campos después del registro empleado
    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtEspecialidad.Clear()
        TxtHorarioInicio.Clear()
        TxtHorarioFin.Clear()
    End Sub


End Class