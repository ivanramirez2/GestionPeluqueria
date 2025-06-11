<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pPrincipal = New System.Windows.Forms.Panel()
        Me.pNuevaContraseña = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnGuardarContrasena = New System.Windows.Forms.Button()
        Me.TxtConfirmarContrasena = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtNuevaContrasena = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pRestablecerContrasena = New System.Windows.Forms.Panel()
        Me.BtnEnviarEnlace = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtCorreoRecuperacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.texto = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pContenedor = New System.Windows.Forms.Panel()
        Me.pReg = New System.Windows.Forms.Panel()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.pContraseña = New System.Windows.Forms.Panel()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pUsuario = New System.Windows.Forms.Panel()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pCorreo = New System.Windows.Forms.Panel()
        Me.pNombre = New System.Windows.Forms.Panel()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Registro = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pCon = New System.Windows.Forms.Panel()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.pContraI = New System.Windows.Forms.Panel()
        Me.TxtContraseñaLogin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pUsuarioI = New System.Windows.Forms.Panel()
        Me.TxtUsuarioLogin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCredenciales = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pPrincipal.SuspendLayout()
        Me.pNuevaContraseña.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pRestablecerContrasena.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pContenedor.SuspendLayout()
        Me.pReg.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCon.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BackColor = System.Drawing.Color.Black
        Me.pPrincipal.Controls.Add(Me.pNuevaContraseña)
        Me.pPrincipal.Controls.Add(Me.pRestablecerContrasena)
        Me.pPrincipal.Controls.Add(Me.pContenedor)
        Me.pPrincipal.Controls.Add(Me.btnAc)
        Me.pPrincipal.Controls.Add(Me.Label4)
        Me.pPrincipal.Controls.Add(Me.Label5)
        Me.pPrincipal.Controls.Add(Me.btnRegistro)
        Me.pPrincipal.Controls.Add(Me.Label3)
        Me.pPrincipal.Controls.Add(Me.Label2)
        Me.pPrincipal.Controls.Add(Me.Label1)
        Me.pPrincipal.Controls.Add(Me.LblCredenciales)
        Me.pPrincipal.Location = New System.Drawing.Point(0, 40)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(913, 465)
        Me.pPrincipal.TabIndex = 0
        '
        'pNuevaContraseña
        '
        Me.pNuevaContraseña.BackColor = System.Drawing.Color.White
        Me.pNuevaContraseña.Controls.Add(Me.Panel1)
        Me.pNuevaContraseña.Controls.Add(Me.BtnGuardarContrasena)
        Me.pNuevaContraseña.Controls.Add(Me.TxtConfirmarContrasena)
        Me.pNuevaContraseña.Controls.Add(Me.TextBox2)
        Me.pNuevaContraseña.Controls.Add(Me.Label17)
        Me.pNuevaContraseña.Controls.Add(Me.Panel2)
        Me.pNuevaContraseña.Controls.Add(Me.TxtNuevaContrasena)
        Me.pNuevaContraseña.Controls.Add(Me.Label11)
        Me.pNuevaContraseña.Controls.Add(Me.Label12)
        Me.pNuevaContraseña.Controls.Add(Me.Label16)
        Me.pNuevaContraseña.Controls.Add(Me.PictureBox4)
        Me.pNuevaContraseña.Location = New System.Drawing.Point(6, 40)
        Me.pNuevaContraseña.Name = "pNuevaContraseña"
        Me.pNuevaContraseña.Size = New System.Drawing.Size(367, 456)
        Me.pNuevaContraseña.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(9, 335)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 3)
        Me.Panel1.TabIndex = 15
        '
        'BtnGuardarContrasena
        '
        Me.BtnGuardarContrasena.BackColor = System.Drawing.Color.Black
        Me.BtnGuardarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnGuardarContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnGuardarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.BtnGuardarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarContrasena.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarContrasena.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarContrasena.Location = New System.Drawing.Point(9, 366)
        Me.BtnGuardarContrasena.Name = "BtnGuardarContrasena"
        Me.BtnGuardarContrasena.Size = New System.Drawing.Size(362, 41)
        Me.BtnGuardarContrasena.TabIndex = 19
        Me.BtnGuardarContrasena.Text = "Recuperar contraseña"
        Me.BtnGuardarContrasena.UseVisualStyleBackColor = False
        '
        'TxtConfirmarContrasena
        '
        Me.TxtConfirmarContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtConfirmarContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmarContrasena.Location = New System.Drawing.Point(13, 299)
        Me.TxtConfirmarContrasena.Name = "TxtConfirmarContrasena"
        Me.TxtConfirmarContrasena.Size = New System.Drawing.Size(362, 14)
        Me.TxtConfirmarContrasena.TabIndex = 14
        Me.TxtConfirmarContrasena.Tag = "Nombre"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(13, 366)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(362, 14)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Tag = "Contra"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 268)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(164, 21)
        Me.Label17.TabIndex = 13
        Me.Label17.Tag = "Correo"
        Me.Label17.Text = "Confirmar contraseña:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(9, 246)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 3)
        Me.Panel2.TabIndex = 12
        '
        'TxtNuevaContrasena
        '
        Me.TxtNuevaContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNuevaContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNuevaContrasena.Location = New System.Drawing.Point(13, 210)
        Me.TxtNuevaContrasena.Name = "TxtNuevaContrasena"
        Me.TxtNuevaContrasena.Size = New System.Drawing.Size(362, 14)
        Me.TxtNuevaContrasena.TabIndex = 11
        Me.TxtNuevaContrasena.Tag = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Tag = "Correo"
        Me.Label11.Text = "Nueva contraseña:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 21)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Introduce una nueva contraseña"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(31, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(314, 37)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Restablecer contraseña"
        '
        'PictureBox4
        '
        Me.PictureBox4.ErrorImage = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox4.Image = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox4.InitialImage = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox4.Location = New System.Drawing.Point(150, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'pRestablecerContrasena
        '
        Me.pRestablecerContrasena.BackColor = System.Drawing.Color.White
        Me.pRestablecerContrasena.Controls.Add(Me.BtnEnviarEnlace)
        Me.pRestablecerContrasena.Controls.Add(Me.TextBox1)
        Me.pRestablecerContrasena.Controls.Add(Me.Panel4)
        Me.pRestablecerContrasena.Controls.Add(Me.TxtCorreoRecuperacion)
        Me.pRestablecerContrasena.Controls.Add(Me.Label14)
        Me.pRestablecerContrasena.Controls.Add(Me.Label15)
        Me.pRestablecerContrasena.Controls.Add(Me.texto)
        Me.pRestablecerContrasena.Controls.Add(Me.PictureBox3)
        Me.pRestablecerContrasena.Location = New System.Drawing.Point(3, 0)
        Me.pRestablecerContrasena.Name = "pRestablecerContrasena"
        Me.pRestablecerContrasena.Size = New System.Drawing.Size(390, 456)
        Me.pRestablecerContrasena.TabIndex = 20
        '
        'BtnEnviarEnlace
        '
        Me.BtnEnviarEnlace.BackColor = System.Drawing.Color.Black
        Me.BtnEnviarEnlace.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEnviarEnlace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnEnviarEnlace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.BtnEnviarEnlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviarEnlace.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviarEnlace.ForeColor = System.Drawing.Color.White
        Me.BtnEnviarEnlace.Location = New System.Drawing.Point(6, 267)
        Me.BtnEnviarEnlace.Name = "BtnEnviarEnlace"
        Me.BtnEnviarEnlace.Size = New System.Drawing.Size(362, 41)
        Me.BtnEnviarEnlace.TabIndex = 19
        Me.BtnEnviarEnlace.Text = "Recuperar contraseña"
        Me.BtnEnviarEnlace.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 366)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(362, 14)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Tag = "Contra"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Location = New System.Drawing.Point(9, 246)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(362, 3)
        Me.Panel4.TabIndex = 12
        '
        'TxtCorreoRecuperacion
        '
        Me.TxtCorreoRecuperacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCorreoRecuperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreoRecuperacion.Location = New System.Drawing.Point(13, 210)
        Me.TxtCorreoRecuperacion.Name = "TxtCorreoRecuperacion"
        Me.TxtCorreoRecuperacion.Size = New System.Drawing.Size(362, 14)
        Me.TxtCorreoRecuperacion.TabIndex = 11
        Me.TxtCorreoRecuperacion.Tag = "Nombre"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 21)
        Me.Label14.TabIndex = 10
        Me.Label14.Tag = "Correo"
        Me.Label14.Text = "Correo electrónico:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(338, 21)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Introduce tu correo electrónico de recuperación"
        '
        'texto
        '
        Me.texto.AutoSize = True
        Me.texto.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto.Location = New System.Drawing.Point(42, 97)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(314, 37)
        Me.texto.TabIndex = 1
        Me.texto.Text = "Restablecer contraseña"
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox3.Image = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox3.Location = New System.Drawing.Point(150, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'pContenedor
        '
        Me.pContenedor.BackColor = System.Drawing.Color.White
        Me.pContenedor.Controls.Add(Me.pReg)
        Me.pContenedor.Controls.Add(Me.pCon)
        Me.pContenedor.Location = New System.Drawing.Point(3, 6)
        Me.pContenedor.Name = "pContenedor"
        Me.pContenedor.Size = New System.Drawing.Size(390, 459)
        Me.pContenedor.TabIndex = 8
        '
        'pReg
        '
        Me.pReg.BackColor = System.Drawing.Color.White
        Me.pReg.Controls.Add(Me.btnReg)
        Me.pReg.Controls.Add(Me.pContraseña)
        Me.pReg.Controls.Add(Me.TxtContrasena)
        Me.pReg.Controls.Add(Me.Label9)
        Me.pReg.Controls.Add(Me.pUsuario)
        Me.pReg.Controls.Add(Me.TxtUsuario)
        Me.pReg.Controls.Add(Me.Label8)
        Me.pReg.Controls.Add(Me.pCorreo)
        Me.pReg.Controls.Add(Me.pNombre)
        Me.pReg.Controls.Add(Me.TxtEmail)
        Me.pReg.Controls.Add(Me.TxtNombre)
        Me.pReg.Controls.Add(Me.Email)
        Me.pReg.Controls.Add(Me.Label6)
        Me.pReg.Controls.Add(Me.Registro)
        Me.pReg.Controls.Add(Me.PictureBox1)
        Me.pReg.Location = New System.Drawing.Point(0, 0)
        Me.pReg.Name = "pReg"
        Me.pReg.Size = New System.Drawing.Size(390, 450)
        Me.pReg.TabIndex = 0
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.Black
        Me.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.White
        Me.btnReg.Location = New System.Drawing.Point(13, 410)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(362, 41)
        Me.btnReg.TabIndex = 19
        Me.btnReg.Text = "Registrar"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'pContraseña
        '
        Me.pContraseña.BackColor = System.Drawing.Color.Silver
        Me.pContraseña.Location = New System.Drawing.Point(13, 399)
        Me.pContraseña.Name = "pContraseña"
        Me.pContraseña.Size = New System.Drawing.Size(362, 3)
        Me.pContraseña.TabIndex = 18
        '
        'TxtContrasena
        '
        Me.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(13, 366)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(362, 14)
        Me.TxtContrasena.TabIndex = 17
        Me.TxtContrasena.Tag = "Contra"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 342)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Contraseña:"
        '
        'pUsuario
        '
        Me.pUsuario.BackColor = System.Drawing.Color.Silver
        Me.pUsuario.Location = New System.Drawing.Point(13, 336)
        Me.pUsuario.Name = "pUsuario"
        Me.pUsuario.Size = New System.Drawing.Size(362, 3)
        Me.pUsuario.TabIndex = 15
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(13, 303)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(362, 14)
        Me.TxtUsuario.TabIndex = 14
        Me.TxtUsuario.Tag = "Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Usuario:"
        '
        'pCorreo
        '
        Me.pCorreo.BackColor = System.Drawing.Color.Silver
        Me.pCorreo.Location = New System.Drawing.Point(13, 268)
        Me.pCorreo.Name = "pCorreo"
        Me.pCorreo.Size = New System.Drawing.Size(362, 3)
        Me.pCorreo.TabIndex = 12
        '
        'pNombre
        '
        Me.pNombre.BackColor = System.Drawing.Color.Silver
        Me.pNombre.Location = New System.Drawing.Point(13, 196)
        Me.pNombre.Name = "pNombre"
        Me.pNombre.Size = New System.Drawing.Size(362, 3)
        Me.pNombre.TabIndex = 9
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(13, 235)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(362, 14)
        Me.TxtEmail.TabIndex = 11
        Me.TxtEmail.Tag = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(13, 169)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(362, 14)
        Me.TxtNombre.TabIndex = 3
        Me.TxtNombre.Tag = "Nombre"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(9, 211)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(141, 21)
        Me.Email.TabIndex = 10
        Me.Email.Tag = "Correo"
        Me.Email.Text = "Correo electrónico:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nombre:"
        '
        'Registro
        '
        Me.Registro.AutoSize = True
        Me.Registro.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registro.Location = New System.Drawing.Point(133, 101)
        Me.Registro.Name = "Registro"
        Me.Registro.Size = New System.Drawing.Size(125, 37)
        Me.Registro.TabIndex = 1
        Me.Registro.Text = "Registro"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox1.Image = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(150, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pCon
        '
        Me.pCon.BackColor = System.Drawing.Color.White
        Me.pCon.Controls.Add(Me.btnAcceder)
        Me.pCon.Controls.Add(Me.pContraI)
        Me.pCon.Controls.Add(Me.TxtContraseñaLogin)
        Me.pCon.Controls.Add(Me.Label7)
        Me.pCon.Controls.Add(Me.pUsuarioI)
        Me.pCon.Controls.Add(Me.TxtUsuarioLogin)
        Me.pCon.Controls.Add(Me.Label10)
        Me.pCon.Controls.Add(Me.Label13)
        Me.pCon.Controls.Add(Me.PictureBox2)
        Me.pCon.Location = New System.Drawing.Point(3, 3)
        Me.pCon.Name = "pCon"
        Me.pCon.Size = New System.Drawing.Size(390, 454)
        Me.pCon.TabIndex = 20
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.Black
        Me.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceder.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(13, 293)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(362, 41)
        Me.btnAcceder.TabIndex = 19
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'pContraI
        '
        Me.pContraI.BackColor = System.Drawing.Color.Silver
        Me.pContraI.Location = New System.Drawing.Point(13, 265)
        Me.pContraI.Name = "pContraI"
        Me.pContraI.Size = New System.Drawing.Size(362, 3)
        Me.pContraI.TabIndex = 18
        '
        'TxtContraseñaLogin
        '
        Me.TxtContraseñaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContraseñaLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseñaLogin.Location = New System.Drawing.Point(13, 232)
        Me.TxtContraseñaLogin.Name = "TxtContraseñaLogin"
        Me.TxtContraseñaLogin.Size = New System.Drawing.Size(362, 14)
        Me.TxtContraseñaLogin.TabIndex = 17
        Me.TxtContraseñaLogin.Tag = "ContraI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Contraseña:"
        '
        'pUsuarioI
        '
        Me.pUsuarioI.BackColor = System.Drawing.Color.Silver
        Me.pUsuarioI.Location = New System.Drawing.Point(13, 202)
        Me.pUsuarioI.Name = "pUsuarioI"
        Me.pUsuarioI.Size = New System.Drawing.Size(362, 3)
        Me.pUsuarioI.TabIndex = 15
        '
        'TxtUsuarioLogin
        '
        Me.TxtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuarioLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuarioLogin.Location = New System.Drawing.Point(13, 169)
        Me.TxtUsuarioLogin.Name = "TxtUsuarioLogin"
        Me.TxtUsuarioLogin.Size = New System.Drawing.Size(362, 14)
        Me.TxtUsuarioLogin.TabIndex = 14
        Me.TxtUsuarioLogin.Tag = "UsuarioI"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 21)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Usuario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(101, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(187, 37)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Iniciar Sesión"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox2.Image = Global.GestionPeluqueriaTeresa.My.Resources.Resources.fondo_logo1
        Me.PictureBox2.Location = New System.Drawing.Point(150, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'btnAc
        '
        Me.btnAc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAc.ForeColor = System.Drawing.Color.White
        Me.btnAc.Location = New System.Drawing.Point(15, 240)
        Me.btnAc.Name = "btnAc"
        Me.btnAc.Size = New System.Drawing.Size(371, 41)
        Me.btnAc.TabIndex = 6
        Me.btnAc.Tag = "btnAc"
        Me.btnAc.Text = "Acceder"
        Me.btnAc.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Da click en acceder para iniciar sesión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(314, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "¿Cuentas con usuario?"
        '
        'btnRegistro
        '
        Me.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.Location = New System.Drawing.Point(500, 240)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(390, 41)
        Me.btnRegistro.TabIndex = 3
        Me.btnRegistro.Tag = "Button1"
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(508, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Registrate dando click en el botón de abajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(535, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Aún no tienes cuenta?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'LblCredenciales
        '
        Me.LblCredenciales.AutoSize = True
        Me.LblCredenciales.BackColor = System.Drawing.Color.Black
        Me.LblCredenciales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCredenciales.ForeColor = System.Drawing.Color.White
        Me.LblCredenciales.Location = New System.Drawing.Point(86, 292)
        Me.LblCredenciales.Name = "LblCredenciales"
        Me.LblCredenciales.Size = New System.Drawing.Size(228, 21)
        Me.LblCredenciales.TabIndex = 9
        Me.LblCredenciales.Text = "¿Has olvidado tus credenciales?"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(956, 570)
        Me.Controls.Add(Me.pPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrueba"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        Me.pNuevaContraseña.ResumeLayout(False)
        Me.pNuevaContraseña.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pRestablecerContrasena.ResumeLayout(False)
        Me.pRestablecerContrasena.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pContenedor.ResumeLayout(False)
        Me.pReg.ResumeLayout(False)
        Me.pReg.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCon.ResumeLayout(False)
        Me.pCon.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pPrincipal As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnAc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pContenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pReg As Panel
    Friend WithEvents Registro As Label
    Friend WithEvents pNombre As Panel
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pCorreo As Panel
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents pContraseña As Panel
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pUsuario As Panel
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnReg As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pCon As Panel
    Friend WithEvents btnAcceder As Button
    Friend WithEvents pContraI As Panel
    Friend WithEvents TxtContraseñaLogin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pUsuarioI As Panel
    Friend WithEvents TxtUsuarioLogin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblCredenciales As Label
    Friend WithEvents pRestablecerContrasena As Panel
    Friend WithEvents BtnEnviarEnlace As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtCorreoRecuperacion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents texto As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pNuevaContraseña As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnGuardarContrasena As Button
    Friend WithEvents TxtConfirmarContrasena As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtNuevaContrasena As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
