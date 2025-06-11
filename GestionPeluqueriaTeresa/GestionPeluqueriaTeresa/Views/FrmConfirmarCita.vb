Imports MySql.Data.MySqlClient

Public Class FrmConfirmarCita
    Private Sub FrmConfirmarCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosReservas()
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
    End Sub

    Private Sub CargarDatosReservas()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM Reservas"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            ConexionDB.CerrarConexion()
        End If
    End Sub


    ' Verificar si los campos no están vacíos
    Private Function VerificarCamposVacíos() As Boolean
        If TxtIdReserva.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return False
        End If
        Return True
    End Function

    Private Sub FrmConfirmarCita_Click(sender As Object, e As EventArgs) Handles btnConfirmarReserva.Click

        ' Verificar si los campos están vacíos

        If Not VerificarCamposVacíos() Then
            Return
        End If



        ' Conexión con la base de datos
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If


        Dim consulta As String = "UPDATE Reservas SET estado = @estado WHERE id = @id"

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)

                cmd.Parameters.AddWithValue("@estado", TxtEstado.Text)
                cmd.Parameters.AddWithValue("@id", TxtIdReserva.Text)




                ' Ejecutar la consulta
                cmd.ExecuteNonQuery()
                MessageBox.Show(TxtIdReserva.Text + " editado correctamente.")
                CargarDatosReservas()
                ' Limpiar los campos después
                LimpiarCampos()


            End Using
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub


    ' Función para limpiar los campos
    Private Sub LimpiarCampos()
        TxtEstado.Clear()
        TxtIdReserva.Clear()


    End Sub




End Class