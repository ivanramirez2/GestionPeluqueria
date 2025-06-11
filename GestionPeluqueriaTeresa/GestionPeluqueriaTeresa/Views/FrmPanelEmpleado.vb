Imports MySql.Data.MySqlClient

Public Class FrmPanelEmpleado

    Private Sub FrmPanelEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosReservas()
        CargarDatosPagos()
        DataGridViewReservas.DefaultCellStyle.ForeColor = Color.Black
        DataGridViewPagos.DefaultCellStyle.ForeColor = Color.Black
    End Sub




    Private Sub CargarDatosReservas()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM reservas"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridViewReservas.DataSource = table

            ConexionDB.CerrarConexion()
        End If
    End Sub


    Private Sub CargarDatosPagos()
        If ConexionDB.AbrirConexion() Then
            Dim query As String = "SELECT * FROM pagos"
            Dim command As New MySqlCommand(query, ConexionDB.conexion)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridViewPagos.DataSource = table

            ConexionDB.CerrarConexion()
        End If
    End Sub


End Class