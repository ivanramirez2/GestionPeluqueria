Imports MySql.Data.MySqlClient

Public Class FrmPanelAdministrador
    Private activoFormulario As Form = Nothing
    Private nombreUsuario As String

    ' Constructor
    Public Sub New(nombreUsuario As String)
        InitializeComponent()
        Me.nombreUsuario = nombreUsuario
        MostrarDiaTotalFacturado()
        MostrarMesTotalFacturado()
    End Sub

    Private Sub FrmPanelAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PersonalizarDiseño()
        TextBox1.Text = "Bienvenido " + nombreUsuario
        MostrarDiaTotalFacturado()
        MostrarMesTotalFacturado()

    End Sub


    Private Sub MostrarDiaTotalFacturado()

        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        ' Consulta SQL para obtener el total facturado en el día actual
        Dim consulta As String = "SELECT SUM(monto) AS TotalFacturado FROM pagos WHERE DATE(fecha_pago) = CURDATE()"

        Try
            ' Aseguramos que no hay ningún DataReader abierto antes de ejecutar la consulta
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                ' Limpiar cualquier DataReader que podría estar abierto
                ConexionDB.conexion.Close()
                ConexionDB.AbrirConexion()

                ' Ejecutamos la consulta
                Dim totalFacturado As Object = cmd.ExecuteScalar()

                ' Verificar si se obtuvo un valor no nulo
                If totalFacturado IsNot DBNull.Value Then
                    TxtDiaFacturado.Text = Convert.ToDecimal(totalFacturado).ToString("C")
                Else
                    TxtDiaFacturado.Text = "$0.00"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total facturado: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub

    Private Sub MostrarMesTotalFacturado()
        ' Conexión a la base de datos
        If Not ConexionDB.AbrirConexion() Then
            MessageBox.Show("No se pudo establecer conexión con la base de datos.")
            Return
        End If

        ' Consulta SQL para obtener el total facturado en el mes actual
        Dim consulta As String = "SELECT SUM(monto) AS TotalFacturado FROM Pagos WHERE MONTH(fecha_pago) = MONTH(CURDATE()) AND YEAR(fecha_pago) = YEAR(CURDATE())"

        Try
            Using cmd As New MySqlCommand(consulta, ConexionDB.conexion)
                ' Ejecutamos la consulta
                Dim totalFacturado As Object = cmd.ExecuteScalar()

                ' Verificar si se obtuvo un valor no nulo
                If totalFacturado IsNot DBNull.Value Then
                    txtMesFacturado.Text = Convert.ToDecimal(totalFacturado).ToString("C")
                Else
                    txtMesFacturado.Text = "$0.00"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total facturado: " & ex.Message)
        Finally
            ConexionDB.CerrarConexion()
        End Try
    End Sub


    ' Metodos para manejar SubMenús
    Private Sub PersonalizarDiseño()
        pSubMenuClientes.Visible = False
        pSubMenuEmpleados.Visible = False
    End Sub

    Private Sub OcultaSubMenu()
        If pSubMenuEmpleados.Visible = True Then
            pSubMenuEmpleados.Visible = False
        End If
        If pSubMenuClientes.Visible = True Then
            pSubMenuClientes.Visible = False
        End If
    End Sub

    Private Sub VerSubMenu(SubMenu As Panel)
        If SubMenu.Visible = False Then
            OcultaSubMenu()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub


    ' Método para abrir formularios hijos
    Private Sub AbrirFormularioHijo(childForm As Form)
        If activoFormulario IsNot Nothing Then
            If Not activoFormulario.IsDisposed Then
                activoFormulario.Close()
            End If
        End If

        ' Verificar si el formulario hijo está eliminado
        If childForm.IsDisposed Then
            childForm = New FrmAgregarEmpleado()
        End If

        activoFormulario = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.Controls.Add(childForm)
        Me.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    ' Eventos Click de los Botones
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        VerSubMenu(pSubMenuClientes)
    End Sub


    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        VerSubMenu(pSubMenuEmpleados)
    End Sub

    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmAgregarEmpleado())
    End Sub

    Private Sub btnEditarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEditarEmpleado.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmEditarEmpleado())
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmEliminarEmpleado())

    End Sub

    Private Sub btnConfirmarCita_Click(sender As Object, e As EventArgs) Handles btnConfirmarCita.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmConfirmarCita())
    End Sub

    Private Sub btnCrearCliente_Click(sender As Object, e As EventArgs) Handles btnCrearCliente.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmCrearNuevoCliente())
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmEliminarCliente())
    End Sub

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmEditarCliente())
    End Sub

    Private Sub btnConsultasClientes_Click(sender As Object, e As EventArgs) Handles btnConsultasClientes.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmConsultasClientes())
    End Sub

    Private Sub btnActivarUsuario_Click(sender As Object, e As EventArgs) Handles btnActivarUsuario.Click
        OcultaSubMenu()
        AbrirFormularioHijo(New FrmActivarUsuario())
    End Sub



    Private Sub pFormularioPequeño_Paint(sender As Object, e As PaintEventArgs) Handles pFormularioPequeño.Paint

    End Sub


End Class
