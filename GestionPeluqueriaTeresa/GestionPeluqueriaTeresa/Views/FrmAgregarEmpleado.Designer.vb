<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarEmpleado
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtEspecialidad = New System.Windows.Forms.TextBox()
        Me.TxtHorarioInicio = New System.Windows.Forms.TextBox()
        Me.TxtHorarioFin = New System.Windows.Forms.TextBox()
        Me.btnAgregarEmpleadoNuevo = New System.Windows.Forms.Button()
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
        Me.DataGridView1.Location = New System.Drawing.Point(32, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(370, 270)
        Me.DataGridView1.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(427, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(174, 24)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(427, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Especialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(427, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Horario Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(427, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Horario Fin"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(431, 98)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(225, 20)
        Me.TxtNombre.TabIndex = 10
        '
        'TxtEspecialidad
        '
        Me.TxtEspecialidad.Location = New System.Drawing.Point(431, 177)
        Me.TxtEspecialidad.Name = "TxtEspecialidad"
        Me.TxtEspecialidad.Size = New System.Drawing.Size(225, 20)
        Me.TxtEspecialidad.TabIndex = 11
        '
        'TxtHorarioInicio
        '
        Me.TxtHorarioInicio.Location = New System.Drawing.Point(431, 246)
        Me.TxtHorarioInicio.Name = "TxtHorarioInicio"
        Me.TxtHorarioInicio.Size = New System.Drawing.Size(225, 20)
        Me.TxtHorarioInicio.TabIndex = 12
        '
        'TxtHorarioFin
        '
        Me.TxtHorarioFin.Location = New System.Drawing.Point(431, 312)
        Me.TxtHorarioFin.Name = "TxtHorarioFin"
        Me.TxtHorarioFin.Size = New System.Drawing.Size(225, 20)
        Me.TxtHorarioFin.TabIndex = 13
        '
        'btnAgregarEmpleadoNuevo
        '
        Me.btnAgregarEmpleadoNuevo.BackColor = System.Drawing.Color.Black
        Me.btnAgregarEmpleadoNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarEmpleadoNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAgregarEmpleadoNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnAgregarEmpleadoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarEmpleadoNuevo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpleadoNuevo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarEmpleadoNuevo.Location = New System.Drawing.Point(431, 344)
        Me.btnAgregarEmpleadoNuevo.Name = "btnAgregarEmpleadoNuevo"
        Me.btnAgregarEmpleadoNuevo.Size = New System.Drawing.Size(225, 43)
        Me.btnAgregarEmpleadoNuevo.TabIndex = 39
        Me.btnAgregarEmpleadoNuevo.Text = "Registrar"
        Me.btnAgregarEmpleadoNuevo.UseVisualStyleBackColor = False
        '
        'FrmAgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 457)
        Me.Controls.Add(Me.btnAgregarEmpleadoNuevo)
        Me.Controls.Add(Me.TxtHorarioFin)
        Me.Controls.Add(Me.TxtHorarioInicio)
        Me.Controls.Add(Me.TxtEspecialidad)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmAgregarEmpleado"
        Me.Text = "FrmAgregarEmpleado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtEspecialidad As TextBox
    Friend WithEvents TxtHorarioInicio As TextBox
    Friend WithEvents TxtHorarioFin As TextBox
    Friend WithEvents btnAgregarEmpleadoNuevo As Button
End Class
