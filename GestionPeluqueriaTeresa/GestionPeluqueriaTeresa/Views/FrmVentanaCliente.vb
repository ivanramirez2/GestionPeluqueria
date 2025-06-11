Imports MySql.Data.MySqlClient
Imports Savage.Data
'Imports Calendario.dll
Imports Mysqlx.XDevAPI
Imports System.IO
Imports System.Drawing.Drawing2D
Public Class FrmVentanaCliente

    Private nombreUsuario As String
    Private idUsuario As Integer

    ' Constructor que recibe el nombre del usuario
    Public Sub New(nombre As String, id As Integer)
        InitializeComponent()
        nombreUsuario = nombre
        idUsuario = id
    End Sub

    ' LLAMADAS A LAS FUNCIONES
    Private Sub FrmVentanaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Evento Load de la ventana para mostrar el nombre
        LblBienvenido.Text = "Bienvenido " & nombreUsuario

        Dim idCliente As Integer = IdUsuarioLogueado
        CargarServicios()
        CargarHoras()

        CargarHistorialReservaTabla(idUsuario)
        CargarCbxReservas(idCliente)


    End Sub





    Private Sub CargarHistorialReservaTabla(idCliente)

        If ConexionDB.AbrirConexion() Then

            Dim consulta As String = "SELECT r.fecha_hora, s.nombre AS servicio, e.nombre AS empleado, r.estado
                                   FROM reservas r 
                                   INNER JOIN servicios s ON r.id_servicio = s.id
                                   INNER JOIN empleados e ON r.id_empleado = e.id
                                   WHERE r.id_cliente = @id_Cliente
                                   ORDER BY r.fecha_hora DESC"

            Try
                Dim command As New MySqlCommand(consulta, ConexionDB.conexion)
                command.Parameters.AddWithValue("@id_cliente", idCliente)

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table

            Catch ex As Exception
                MessageBox.Show("Error al cargar historial de reservas")
            Finally
                ConexionDB.CerrarConexion()
            End Try

        End If

    End Sub

    '---------------------- CARGAR DATOS EN CBX O STACK PANEL ----------------------

    ' Cargar SERVICIOS 

    Private Sub CargarServicios()
        ConexionDB.CerrarConexion()
        Dim consulta As String = "SELECT id, nombre FROM Servicios"
        Try
            ConexionDB.AbrirConexion()
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    CbxServicios.Items.Clear()
                    CbxServicios.Items.Clear()
                    CbxServicios.Tag = New Dictionary(Of String, Integer)

                    Dim dicServicios As Dictionary(Of String, Integer) = CType(CbxServicios.Tag, Dictionary(Of String, Integer))

                    While reader.Read()
                        Dim nombreService As String = reader("nombre").ToString()
                        Dim idServicio As Integer = Convert.ToInt32(reader("id"))

                        CbxServicios.Items.Add(nombreService)

                        dicServicios(nombreService) = idServicio
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los servicios: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' CARGAR HORAS 
    Private Sub CargarHoras()
        CbxHoras.Items.Clear()

        Dim horaInicio As DateTime = DateTime.Parse("09:00 AM")
        Dim horaFin As DateTime = DateTime.Parse("21:00 PM")

        While horaInicio <= horaFin
            CbxHoras.Items.Add(horaInicio.ToString("HH:mm"))
            horaInicio = horaInicio.AddMinutes(30)
        End While
    End Sub

    'CARGAR RESERVAS
    Private Sub CargarCbxReservas(idCliente As Integer)

        Dim consulta As String = "SELECT r.id, s.nombre AS servicio, r.fecha_hora 
                                  FROM reservas r 
                                  INNER JOIN servicios s ON r.id_servicio = s.id 
                                  WHERE r.id_cliente = @id_cliente"

        Try
            ConexionDB.AbrirConexion()

            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                '
                cmd.Parameters.AddWithValue("@id_cliente", idCliente)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    CbxCitas.Items.Clear()
                    CbxCitas.Tag = New Dictionary(Of String, Integer)

                    Dim dicCitas As Dictionary(Of String, Integer) = CType(CbxCitas.Tag, Dictionary(Of String, Integer))

                    ' Cargar datos en el ComboBox
                    While reader.Read()
                        Dim idReserva As Integer = Convert.ToInt32(reader("id"))
                        Dim texto As String = reader("servicio").ToString() & " - " & Convert.ToDateTime(reader("fecha_hora")).ToString("dd/MM/yyyy HH:mm")


                        ' Agregar la cita al ComboBox, mostrando la fecha y hora de la reserva
                        CbxCitas.Items.Add(texto)
                        dicCitas(texto) = idReserva
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar las reservas: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    '----------------------BOTONES----------------------

    ' CONFIRMAR RESERVAS
    Private Sub BtnConfirmCita_Click(sender As Object, e As EventArgs) Handles BtnConfirmCita.Click
        ' Verificar si el MonthCalendar tiene una fecha seleccionada
        If Calendario.SelectionStart = Nothing Then
            MessageBox.Show("La fecha no está seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(CbxHoras.Text) Then
            MessageBox.Show("La hora no está seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CbxServicios.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un servicio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If idUsuario = 0 Then
            MessageBox.Show("No se ha encontrado un cliente logueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim nombreServicio As String = CbxServicios.SelectedItem.ToString()
        Dim dicServicios As Dictionary(Of String, Integer) = CType(CbxServicios.Tag, Dictionary(Of String, Integer))
        Dim idServicio As Integer

        If dicServicios.ContainsKey(nombreServicio) Then
            idServicio = dicServicios(nombreServicio)
        Else
            MessageBox.Show("El servicio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Fijamos que sea el primer empleado disponible
        Dim idEmpleado As Integer = 1
        If idEmpleado = 0 Then
            MessageBox.Show("No se ha seleccionado un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim fechaSeleccionada As DateTime = Calendario.SelectionStart
        Dim fechaHora As String = fechaSeleccionada.ToString("yyyy-MM-dd") & " " & CbxHoras.Text

        Dim consulta As String = "INSERT INTO reservas (id_cliente, id_empleado, id_servicio, fecha_hora, estado) 
                             VALUES (@id_cliente, @id_empleado, @id_servicio, @fecha_hora, @estado)"

        ConexionDB.AbrirConexion()
        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                cmd.Parameters.AddWithValue("@id_cliente", idUsuario)
                cmd.Parameters.AddWithValue("@id_empleado", idEmpleado)
                cmd.Parameters.AddWithValue("@id_servicio", idServicio)
                cmd.Parameters.AddWithValue("@fecha_hora", fechaHora)
                cmd.Parameters.AddWithValue("@estado", "Pendiente")

                Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                If filasAfectadas > 0 Then
                    MessageBox.Show("Reserva creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarCbxReservas(idUsuario)
                    CargarHistorialReservaTabla(idUsuario)
                Else
                    MessageBox.Show("No se pudo crear la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al crear la reserva: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    'CANCELAR RESERVA
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        If CbxCitas.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una cita para poder eliminar")
            Exit Sub
        End If

        Dim dicCitas As Dictionary(Of String, Integer) = CType(CbxCitas.Tag, Dictionary(Of String, Integer))
        Dim citaSeleccionada As String = CbxCitas.SelectedItem.ToString()


        If Not dicCitas.ContainsKey(citaSeleccionada) Then
            MessageBox.Show("Error al obtener la cita")
        End If

        Dim idCita As Integer = dicCitas(citaSeleccionada)


        Dim consulta As String = "DELETE FROM reservas WHERE id = @id;"

        Try

            ConexionDB.AbrirConexion()


            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)

                cmd.Parameters.AddWithValue("@id", idCita)


                Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                ' Comprobar si la cita fue eliminada
                If filasAfectadas > 0 Then
                    MessageBox.Show("Cita cancelada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarCbxReservas(idUsuario)
                    CargarHistorialReservaTabla(idUsuario)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cancelar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    'MODIFICAR RESERVA
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click



        If CbxCitas.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una cita para poder modificar")
            Exit Sub
        End If

        Dim dicCitas As Dictionary(Of String, Integer) = CType(CbxCitas.Tag, Dictionary(Of String, Integer))
        Dim citaSeleccionada As String = CbxCitas.SelectedItem.ToString()


        If Not dicCitas.ContainsKey(citaSeleccionada) Then
            MessageBox.Show("Error al obtener la cita")
        End If

        Dim idCita As Integer = dicCitas(citaSeleccionada)

        If Calendario.SelectionRange Is Nothing OrElse CbxHoras.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona una nueva fecha y hora")
            Exit Sub
        End If

        ' Obtener la nueva fecha seleccionada del MonthCalendar
        Dim nuevaFecha As String = Calendario.SelectionRange.Start.ToString("yyyy-MM-dd")
        Dim nuevaHora As String = CbxHoras.SelectedItem.ToString()
        Dim nuevaFechaHora As String = nuevaFecha & " " & nuevaHora


        If CbxServicios.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un nuevo servicio")
            Exit Sub
        End If

        Dim servicioSeleccionado As String = CbxServicios.SelectedItem.ToString()
        Dim dicServicios As Dictionary(Of String, Integer) = CType(CbxServicios.Tag, Dictionary(Of String, Integer))

        Dim servicioId As Integer
        If dicServicios.ContainsKey(servicioSeleccionado) Then
            servicioId = dicServicios(servicioSeleccionado)
        Else
            MessageBox.Show("No se puedo obtener el id del servicio seleccionado")
            Exit Sub
        End If

        Dim consulta As String = "UPDATE reservas SET fecha_hora = @fecha_hora, id_servicio = @id_servicio WHERE id = @id;"

        ' Consulta de actualización solo de la fecha y hora (sin modificar el servicio)

        Try
            ConexionDB.AbrirConexion()

            ' Actualizar la cita solo con la nueva fecha y hora
            Using cmdActualizacion As New MySqlCommand(consulta, ConexionDB.conexion)
                cmdActualizacion.Parameters.AddWithValue("@fecha_hora", nuevaFechaHora)
                cmdActualizacion.Parameters.AddWithValue("@id_servicio", servicioId)
                cmdActualizacion.Parameters.AddWithValue("@id", idCita)

                Dim filasAfectadas As Integer = cmdActualizacion.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    MessageBox.Show("Cita modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarCbxReservas(1)
                    CargarHistorialReservaTabla(1)
                Else
                    MessageBox.Show("No se encontró la cita con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        CargarCbxReservas(idUsuario)
        CargarHistorialReservaTabla(idUsuario)
    End Sub
    Private Sub Calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario.DateChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
