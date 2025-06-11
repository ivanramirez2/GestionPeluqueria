<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasClientes
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
        Me.grpConsultas = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.grpConsultas.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpConsultas
        '
        Me.grpConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.grpConsultas.Controls.Add(Me.btnConsultar)
        Me.grpConsultas.Controls.Add(Me.cmbTipoConsulta)
        Me.grpConsultas.Controls.Add(Me.dtpFechaInicio)
        Me.grpConsultas.Controls.Add(Me.dtpFechaFin)
        Me.grpConsultas.ForeColor = System.Drawing.SystemColors.Control
        Me.grpConsultas.Location = New System.Drawing.Point(12, 35)
        Me.grpConsultas.Name = "grpConsultas"
        Me.grpConsultas.Size = New System.Drawing.Size(712, 252)
        Me.grpConsultas.TabIndex = 0
        Me.grpConsultas.TabStop = False
        Me.grpConsultas.Text = "Consultas"
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.BackColor = System.Drawing.Color.Black
        Me.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(269, 176)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(158, 43)
        Me.btnConsultar.TabIndex = 40
        Me.btnConsultar.Text = "Consultar cliente"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'cmbTipoConsulta
        '
        Me.cmbTipoConsulta.FormattingEnabled = True
        Me.cmbTipoConsulta.Items.AddRange(New Object() {"Usuarios creados entre dos fechas", "Usuarios existentes", "Usuarios conectados este mes", "Usuarios borrados", "Usuarios activos"})
        Me.cmbTipoConsulta.Location = New System.Drawing.Point(16, 34)
        Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
        Me.cmbTipoConsulta.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoConsulta.TabIndex = 3
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(220, 34)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(480, 31)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 2
        '
        'dgvResultados
        '
        Me.dgvResultados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(12, 293)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.Size = New System.Drawing.Size(719, 150)
        Me.dgvResultados.TabIndex = 5
        '
        'FrmConsultasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.grpConsultas)
        Me.Name = "FrmConsultasClientes"
        Me.Text = "FrmConsultasClientes"
        Me.grpConsultas.ResumeLayout(False)
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpConsultas As GroupBox
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents cmbTipoConsulta As ComboBox
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents btnConsultar As Button
End Class
