Imports MySql.Data.MySqlClient

Public Class FrmEliminarEmpleado

    Private Sub FrmEliminarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ConexionDB.CerrarConexion()
        End If
    End Sub
    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click

        ' Verificar si los campos están vacíos
        If Not VerificarCamposVacíos() Then
            Return
        End If



        ' Conexión con la base de datos
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If


        Dim consulta As String = "DELETE FROM empleados WHERE nombre = @nombre"

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)

                cmd.Parameters.AddWithValue("@nombre", TxtNombreEmpleado.Text)



                ' Ejecutar la consulta
                cmd.ExecuteNonQuery()
                MessageBox.Show("Empleado " + TxtNombreEmpleado.Text + " eliminado correctamente.")
                CargarDatosEmpleados()
                ' Limpiar los campos
                LimpiarCampos()


            End Using
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Verificar si los campos no están vacíos
    Private Function VerificarCamposVacíos() As Boolean
        If TxtNombreEmpleado.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return False
        End If
        Return True
    End Function

    ' Función para limpiar los campos
    Private Sub LimpiarCampos()
        TxtNombreEmpleado.Clear()
    End Sub

End Class