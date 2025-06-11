<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrearNuevoCliente
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarClienteNuevo = New System.Windows.Forms.Button()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pCorreo = New System.Windows.Forms.Panel()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 332)
        Me.DataGridView1.TabIndex = 14
        '
        'btnAgregarClienteNuevo
        '
        Me.btnAgregarClienteNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAgregarClienteNuevo.BackColor = System.Drawing.Color.Black
        Me.btnAgregarClienteNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarClienteNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAgregarClienteNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnAgregarClienteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarClienteNuevo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarClienteNuevo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarClienteNuevo.Location = New System.Drawing.Point(386, 357)
        Me.btnAgregarClienteNuevo.Name = "btnAgregarClienteNuevo"
        Me.btnAgregarClienteNuevo.Size = New System.Drawing.Size(362, 41)
        Me.btnAgregarClienteNuevo.TabIndex = 38
        Me.btnAgregarClienteNuevo.Text = "Registrar cliente"
        Me.btnAgregarClienteNuevo.UseVisualStyleBackColor = False
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtContrasena.BackColor = System.Drawing.SystemColors.Window
        Me.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContrasena.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(386, 230)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(362, 32)
        Me.TxtContrasena.TabIndex = 36
        Me.TxtContrasena.Tag = "Contra"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(382, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 21)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Contraseña:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(386, 167)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(362, 32)
        Me.TxtUsuario.TabIndex = 33
        Me.TxtUsuario.Tag = "Usuario"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(382, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 21)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Usuario:"
        '
        'pCorreo
        '
        Me.pCorreo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.pCorreo.Location = New System.Drawing.Point(386, 132)
        Me.pCorreo.Name = "pCorreo"
        Me.pCorreo.Size = New System.Drawing.Size(362, 3)
        Me.pCorreo.TabIndex = 31
        '
        'TxtEmail
        '
        Me.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(386, 99)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(362, 32)
        Me.TxtEmail.TabIndex = 30
        Me.TxtEmail.Tag = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(386, 33)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(362, 32)
        Me.TxtNombre.TabIndex = 27
        Me.TxtNombre.Tag = "Nombre"
        '
        'Email
        '
        Me.Email.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.ForeColor = System.Drawing.Color.White
        Me.Email.Location = New System.Drawing.Point(382, 75)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(141, 21)
        Me.Email.TabIndex = 29
        Me.Email.Tag = "Correo"
        Me.Email.Text = "Correo electrónico:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(382, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Nombre:"
        '
        'TxtRol
        '
        Me.TxtRol.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtRol.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRol.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRol.Location = New System.Drawing.Point(386, 299)
        Me.TxtRol.Name = "TxtRol"
        Me.TxtRol.Size = New System.Drawing.Size(362, 32)
        Me.TxtRol.TabIndex = 40
        Me.TxtRol.Tag = "Contra"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(382, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 21)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Rol:"
        '
        'FrmCrearNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 457)
        Me.Controls.Add(Me.TxtRol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarClienteNuevo)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pCorreo)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FrmCrearNuevoCliente"
        Me.Text = "FrmCrearNuevoCliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarClienteNuevo As Button
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pCorreo As Panel
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRol As TextBox
    Friend WithEvents Label1 As Label
End Class
