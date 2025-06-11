Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FrmEditarCliente

    Private Sub FrmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarDatosClientes()
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarDatosClientes()
        If ConexionDB.AbrirConexion() Then
            Try
                Dim query As String = "SELECT * FROM usuarios"
                Dim command As New MySqlCommand(query, ConexionDB.conexion)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos de clientes: " & ex.Message)
            Finally
                ConexionDB.CerrarConexion()
            End Try
        Else
            MessageBox.Show("No se pudo conectar a la base de datos.")
        End If
    End Sub

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        ' Verificar que se ha ingresado un nombre
        If String.IsNullOrWhiteSpace(TxtNombreCliente.Text) Then
            MessageBox.Show("Por favor, ingrese el nombre del cliente a editar.")
            Return
        End If

        ' Construir la consulta dinámicamente según los campos llenados
        Dim camposActualizar As New List(Of String)()
        Dim parametros As New Dictionary(Of String, Object)()

        If TxtEmail.Text <> "" Then
            ' Validar formato de email
            If Not System.Text.RegularExpressions.Regex.IsMatch(TxtEmail.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
                MessageBox.Show("Por favor, ingrese un email válido.")
                Return
            End If

            ' Verificar si el email ya existe para otro usuario
            If ConexionDB.AbrirConexion() Then
                Try
                    Dim checkQuery As String = "SELECT COUNT(*) FROM usuarios WHERE email = @email AND nombre != @nombre"
                    Using checkCmd As New MySqlCommand(checkQuery, ConexionDB.conexion)
                        checkCmd.Parameters.AddWithValue("@email", TxtEmail.Text)
                        checkCmd.Parameters.AddWithValue("@nombre", TxtNombreCliente.Text)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count > 0 Then
                            MessageBox.Show("El correo ya está en uso por otro usuario.")
                            Return
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al verificar el email: " & ex.Message)
                    Return
                Finally
                    ConexionDB.CerrarConexion()
                End Try
            Else
                MessageBox.Show("No se pudo conectar a la base de datos para verificar el email.")
                Return
            End If

            camposActualizar.Add("email = @email")
            parametros.Add("@email", TxtEmail.Text)
        End If

        ' Verificar que al menos un campo ha sido llenado
        If camposActualizar.Count = 0 Then
            MessageBox.Show("Por favor, complete al menos un campo para actualizar.")
            Return
        End If


        Dim consulta As String = "UPDATE usuarios SET " & String.Join(", ", camposActualizar) & " WHERE nombre = @nombre"
        parametros.Add("@nombre", TxtNombreCliente.Text)
        CargarDatosClientes()


        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                ' Asignar parámetros dinámicamente
                For Each param In parametros
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                ' Ejecutar la consulta
                Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                If filasAfectadas > 0 Then
                    MessageBox.Show("Cliente " + TxtNombreCliente.Text + " actualizado correctamente.")
                    CargarDatosClientes()
                    LimpiarCampos()
                Else
                    MessageBox.Show("No se encontró un cliente con ese nombre. Verifique el dato ingresado.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message & vbCrLf & "Consulta: " & consulta)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    ' Función para limpiar los campos después de la edición
    Private Sub LimpiarCampos()
        TxtNombreCliente.Clear()
        TxtEmail.Clear()
    End Sub

End Class