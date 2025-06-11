Imports MySql.Data.MySqlClient

Public Class FrmConsultasClientes

    Private Sub FrmConsultasClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvResultados.DefaultCellStyle.ForeColor = Color.Black
        CargarDatosClientes()
    End Sub

    Private Sub CargarDatosClientes()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM usuarios"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvResultados.DataSource = table
            ConexionDB.CerrarConexion()
        End If
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo conectar a la base de datos.")
            Return
        End If

        Dim consulta As String = ""
        Dim command As MySqlCommand
        Dim adapter As MySqlDataAdapter
        Dim table As New DataTable()

        Select Case cmbTipoConsulta.SelectedItem.ToString()
            Case "Usuarios creados entre dos fechas"
                consulta = "SELECT * FROM usuarios WHERE fecha_registro BETWEEN @inicio AND @fin"
                command = New MySqlCommand(consulta, ConexionDB.conexion)
                command.Parameters.AddWithValue("@inicio", dtpFechaInicio.Value)
                command.Parameters.AddWithValue("@fin", dtpFechaFin.Value)

            Case "Usuarios existentes"
                consulta = "SELECT * FROM usuarios"
                command = New MySqlCommand(consulta, ConexionDB.conexion)

            Case "Usuarios conectados este mes"
                consulta = "SELECT * FROM usuarios WHERE ultima_conexion >= DATE_FORMAT(NOW(), '%Y-%m-01')"
                command = New MySqlCommand(consulta, ConexionDB.conexion)

            Case "Usuarios borrados"
                consulta = "SELECT * FROM usuarios WHERE estado = 'Inactivo'"
                command = New MySqlCommand(consulta, ConexionDB.conexion)

            Case "Usuarios activos"
                consulta = "SELECT * FROM usuarios WHERE estado = 'activo'"
                command = New MySqlCommand(consulta, ConexionDB.conexion)

            Case Else
                MessageBox.Show("Seleccione una consulta válida.")
                ConexionDB.CerrarConexion()
                Return
        End Select

        Try
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(table)
            dgvResultados.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub
End Class
