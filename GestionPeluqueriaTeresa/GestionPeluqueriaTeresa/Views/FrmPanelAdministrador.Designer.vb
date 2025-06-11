<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPanelAdministrador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pMenuLateral = New System.Windows.Forms.Panel()
        Me.pSubMenuClientes = New System.Windows.Forms.Panel()
        Me.btnActivarUsuario = New System.Windows.Forms.Button()
        Me.btnConsultasClientes = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnCrearCliente = New System.Windows.Forms.Button()
        Me.btnConfirmarCita = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.pSubMenuEmpleados = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnEditarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.pLogo = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pFormularioPequeño = New System.Windows.Forms.Panel()
        Me.txtMesFacturado = New System.Windows.Forms.Label()
        Me.TxtDiaFacturado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.texto = New System.Windows.Forms.Label()
        Me.pFormularioHijo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pMenuLateral.SuspendLayout()
        Me.pSubMenuClientes.SuspendLayout()
        Me.pSubMenuEmpleados.SuspendLayout()
        Me.pLogo.SuspendLayout()
        Me.pFormularioPequeño.SuspendLayout()
        Me.pFormularioHijo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pMenuLateral
        '
        Me.pMenuLateral.AutoScroll = True
        Me.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.pMenuLateral.Controls.Add(Me.pSubMenuClientes)
        Me.pMenuLateral.Controls.Add(Me.btnClientes)
        Me.pMenuLateral.Controls.Add(Me.pSubMenuEmpleados)
        Me.pMenuLateral.Controls.Add(Me.btnEmpleados)
        Me.pMenuLateral.Controls.Add(Me.pLogo)
        Me.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.pMenuLateral.Name = "pMenuLateral"
        Me.pMenuLateral.Size = New System.Drawing.Size(250, 650)
        Me.pMenuLateral.TabIndex = 0
        '
        'pSubMenuClientes
        '
        Me.pSubMenuClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pSubMenuClientes.Controls.Add(Me.btnActivarUsuario)
        Me.pSubMenuClientes.Controls.Add(Me.btnConsultasClientes)
        Me.pSubMenuClientes.Controls.Add(Me.btnEditarCliente)
        Me.pSubMenuClientes.Controls.Add(Me.btnEliminarCliente)
        Me.pSubMenuClientes.Controls.Add(Me.btnCrearCliente)
        Me.pSubMenuClientes.Controls.Add(Me.btnConfirmarCita)
        Me.pSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSubMenuClientes.Location = New System.Drawing.Point(0, 328)
        Me.pSubMenuClientes.Name = "pSubMenuClientes"
        Me.pSubMenuClientes.Size = New System.Drawing.Size(250, 310)
        Me.pSubMenuClientes.TabIndex = 4
        '
        'btnActivarUsuario
        '
        Me.btnActivarUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActivarUsuario.FlatAppearance.BorderSize = 0
        Me.btnActivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivarUsuario.ForeColor = System.Drawing.Color.LightGray
        Me.btnActivarUsuario.Location = New System.Drawing.Point(0, 225)
        Me.btnActivarUsuario.Name = "btnActivarUsuario"
        Me.btnActivarUsuario.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnActivarUsuario.Size = New System.Drawing.Size(250, 45)
        Me.btnActivarUsuario.TabIndex = 9
        Me.btnActivarUsuario.Text = "Activar Usuario"
        Me.btnActivarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivarUsuario.UseCompatibleTextRendering = True
        Me.btnActivarUsuario.UseVisualStyleBackColor = True
        '
        'btnConsultasClientes
        '
        Me.btnConsultasClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultasClientes.FlatAppearance.BorderSize = 0
        Me.btnConsultasClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultasClientes.ForeColor = System.Drawing.Color.LightGray
        Me.btnConsultasClientes.Location = New System.Drawing.Point(0, 180)
        Me.btnConsultasClientes.Name = "btnConsultasClientes"
        Me.btnConsultasClientes.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnConsultasClientes.Size = New System.Drawing.Size(250, 45)
        Me.btnConsultasClientes.TabIndex = 8
        Me.btnConsultasClientes.Text = "Consultas Clientes"
        Me.btnConsultasClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultasClientes.UseCompatibleTextRendering = True
        Me.btnConsultasClientes.UseVisualStyleBackColor = True
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditarCliente.FlatAppearance.BorderSize = 0
        Me.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCliente.ForeColor = System.Drawing.Color.LightGray
        Me.btnEditarCliente.Location = New System.Drawing.Point(0, 135)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEditarCliente.Size = New System.Drawing.Size(250, 45)
        Me.btnEditarCliente.TabIndex = 7
        Me.btnEditarCliente.Text = "Editar Cliente"
        Me.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarCliente.UseCompatibleTextRendering = True
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminarCliente.FlatAppearance.BorderSize = 0
        Me.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCliente.ForeColor = System.Drawing.Color.LightGray
        Me.btnEliminarCliente.Location = New System.Drawing.Point(0, 90)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEliminarCliente.Size = New System.Drawing.Size(250, 45)
        Me.btnEliminarCliente.TabIndex = 6
        Me.btnEliminarCliente.Text = "Eliminar Cliente"
        Me.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarCliente.UseCompatibleTextRendering = True
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnCrearCliente
        '
        Me.btnCrearCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCrearCliente.FlatAppearance.BorderSize = 0
        Me.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearCliente.ForeColor = System.Drawing.Color.LightGray
        Me.btnCrearCliente.Location = New System.Drawing.Point(0, 45)
        Me.btnCrearCliente.Name = "btnCrearCliente"
        Me.btnCrearCliente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCrearCliente.Size = New System.Drawing.Size(250, 45)
        Me.btnCrearCliente.TabIndex = 5
        Me.btnCrearCliente.Text = "Crear nuevo cliente"
        Me.btnCrearCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearCliente.UseCompatibleTextRendering = True
        Me.btnCrearCliente.UseVisualStyleBackColor = True
        '
        'btnConfirmarCita
        '
        Me.btnConfirmarCita.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfirmarCita.FlatAppearance.BorderSize = 0
        Me.btnConfirmarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarCita.ForeColor = System.Drawing.Color.LightGray
        Me.btnConfirmarCita.Location = New System.Drawing.Point(0, 0)
        Me.btnConfirmarCita.Name = "btnConfirmarCita"
        Me.btnConfirmarCita.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnConfirmarCita.Size = New System.Drawing.Size(250, 45)
        Me.btnConfirmarCita.TabIndex = 4
        Me.btnConfirmarCita.Text = "Confirmar Cita"
        Me.btnConfirmarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmarCita.UseCompatibleTextRendering = True
        Me.btnConfirmarCita.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClientes.Location = New System.Drawing.Point(0, 283)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnClientes.Size = New System.Drawing.Size(250, 45)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'pSubMenuEmpleados
        '
        Me.pSubMenuEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pSubMenuEmpleados.Controls.Add(Me.Button5)
        Me.pSubMenuEmpleados.Controls.Add(Me.btnEliminarEmpleado)
        Me.pSubMenuEmpleados.Controls.Add(Me.btnEditarEmpleado)
        Me.pSubMenuEmpleados.Controls.Add(Me.btnAgregarEmpleado)
        Me.pSubMenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSubMenuEmpleados.Location = New System.Drawing.Point(0, 145)
        Me.pSubMenuEmpleados.Name = "pSubMenuEmpleados"
        Me.pSubMenuEmpleados.Size = New System.Drawing.Size(250, 138)
        Me.pSubMenuEmpleados.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.LightGray
        Me.Button5.Location = New System.Drawing.Point(0, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(250, 45)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Empleados"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseCompatibleTextRendering = True
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarEmpleado.ForeColor = System.Drawing.Color.LightGray
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(0, 90)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(250, 45)
        Me.btnEliminarEmpleado.TabIndex = 5
        Me.btnEliminarEmpleado.Text = "Eliminar empleado"
        Me.btnEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarEmpleado.UseCompatibleTextRendering = True
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'btnEditarEmpleado
        '
        Me.btnEditarEmpleado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarEmpleado.ForeColor = System.Drawing.Color.LightGray
        Me.btnEditarEmpleado.Location = New System.Drawing.Point(0, 45)
        Me.btnEditarEmpleado.Name = "btnEditarEmpleado"
        Me.btnEditarEmpleado.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEditarEmpleado.Size = New System.Drawing.Size(250, 45)
        Me.btnEditarEmpleado.TabIndex = 4
        Me.btnEditarEmpleado.Text = "Editar empleado"
        Me.btnEditarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarEmpleado.UseCompatibleTextRendering = True
        Me.btnEditarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarEmpleado.ForeColor = System.Drawing.Color.LightGray
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(250, 45)
        Me.btnAgregarEmpleado.TabIndex = 3
        Me.btnAgregarEmpleado.Text = "Agregar empleado"
        Me.btnAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarEmpleado.UseCompatibleTextRendering = True
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 100)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEmpleados.Size = New System.Drawing.Size(250, 45)
        Me.btnEmpleados.TabIndex = 1
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'pLogo
        '
        Me.pLogo.Controls.Add(Me.TextBox1)
        Me.pLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLogo.Location = New System.Drawing.Point(0, 0)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.Size = New System.Drawing.Size(250, 100)
        Me.pLogo.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(18, 26)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 71)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pFormularioPequeño
        '
        Me.pFormularioPequeño.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pFormularioPequeño.Controls.Add(Me.txtMesFacturado)
        Me.pFormularioPequeño.Controls.Add(Me.TxtDiaFacturado)
        Me.pFormularioPequeño.Controls.Add(Me.Label2)
        Me.pFormularioPequeño.Controls.Add(Me.Label1)
        Me.pFormularioPequeño.Controls.Add(Me.texto)
        Me.pFormularioPequeño.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pFormularioPequeño.Location = New System.Drawing.Point(250, 555)
        Me.pFormularioPequeño.Name = "pFormularioPequeño"
        Me.pFormularioPequeño.Size = New System.Drawing.Size(700, 95)
        Me.pFormularioPequeño.TabIndex = 1
        '
        'txtMesFacturado
        '
        Me.txtMesFacturado.AutoSize = True
        Me.txtMesFacturado.BackColor = System.Drawing.Color.Transparent
        Me.txtMesFacturado.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMesFacturado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMesFacturado.Location = New System.Drawing.Point(567, 3)
        Me.txtMesFacturado.Name = "txtMesFacturado"
        Me.txtMesFacturado.Size = New System.Drawing.Size(0, 37)
        Me.txtMesFacturado.TabIndex = 8
        '
        'TxtDiaFacturado
        '
        Me.TxtDiaFacturado.AutoSize = True
        Me.TxtDiaFacturado.BackColor = System.Drawing.Color.Transparent
        Me.TxtDiaFacturado.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiaFacturado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtDiaFacturado.Location = New System.Drawing.Point(324, 3)
        Me.TxtDiaFacturado.Name = "TxtDiaFacturado"
        Me.TxtDiaFacturado.Size = New System.Drawing.Size(0, 37)
        Me.TxtDiaFacturado.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(484, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(239, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Día:"
        '
        'texto
        '
        Me.texto.AutoSize = True
        Me.texto.BackColor = System.Drawing.Color.Transparent
        Me.texto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texto.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.texto.Location = New System.Drawing.Point(0, 0)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(224, 37)
        Me.texto.TabIndex = 2
        Me.texto.Text = "Total Facturado:"
        '
        'pFormularioHijo
        '
        Me.pFormularioHijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pFormularioHijo.Controls.Add(Me.PictureBox1)
        Me.pFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFormularioHijo.Location = New System.Drawing.Point(250, 0)
        Me.pFormularioHijo.Name = "pFormularioHijo"
        Me.pFormularioHijo.Size = New System.Drawing.Size(700, 555)
        Me.pFormularioHijo.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GestionPeluqueriaTeresa.My.Resources.Resources.barbershop_logo_free_vector_1031695305_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(53, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(552, 450)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmPanelAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.pFormularioHijo)
        Me.Controls.Add(Me.pFormularioPequeño)
        Me.Controls.Add(Me.pMenuLateral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(950, 650)
        Me.Name = "FrmPanelAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "D"
        Me.pMenuLateral.ResumeLayout(False)
        Me.pSubMenuClientes.ResumeLayout(False)
        Me.pSubMenuEmpleados.ResumeLayout(False)
        Me.pLogo.ResumeLayout(False)
        Me.pLogo.PerformLayout()
        Me.pFormularioPequeño.ResumeLayout(False)
        Me.pFormularioPequeño.PerformLayout()
        Me.pFormularioHijo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pMenuLateral As Panel
    Friend WithEvents pSubMenuEmpleados As Panel
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents pLogo As Panel
    Friend WithEvents btnAgregarEmpleado As Button
    Friend WithEvents btnEliminarEmpleado As Button
    Friend WithEvents btnEditarEmpleado As Button
    Friend WithEvents pSubMenuClientes As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnConfirmarCita As Button
    Friend WithEvents pFormularioPequeño As Panel
    Friend WithEvents pFormularioHijo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCrearCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnConsultasClientes As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents texto As Label
    Friend WithEvents TxtDiaFacturado As Label
    Friend WithEvents txtMesFacturado As Label
    Friend WithEvents btnActivarUsuario As Button
End Class
