<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfirmarCita
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TxtIdReserva = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmarReserva = New System.Windows.Forms.Button()
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(291, 124)
        Me.DataGridView1.TabIndex = 17
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(309, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(106, 24)
        Me.lblNombre.TabIndex = 19
        Me.lblNombre.Text = "ID Reserva:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtIdReserva
        '
        Me.TxtIdReserva.Location = New System.Drawing.Point(310, 89)
        Me.TxtIdReserva.Name = "TxtIdReserva"
        Me.TxtIdReserva.Size = New System.Drawing.Size(225, 20)
        Me.TxtIdReserva.TabIndex = 20
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(310, 139)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(225, 20)
        Me.TxtEstado.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(309, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Estado:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnConfirmarReserva
        '
        Me.btnConfirmarReserva.BackColor = System.Drawing.Color.Black
        Me.btnConfirmarReserva.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfirmarReserva.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnConfirmarReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarReserva.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarReserva.ForeColor = System.Drawing.Color.White
        Me.btnConfirmarReserva.Location = New System.Drawing.Point(313, 175)
        Me.btnConfirmarReserva.Name = "btnConfirmarReserva"
        Me.btnConfirmarReserva.Size = New System.Drawing.Size(214, 41)
        Me.btnConfirmarReserva.TabIndex = 39
        Me.btnConfirmarReserva.Text = "Cambiar estado"
        Me.btnConfirmarReserva.UseVisualStyleBackColor = False
        '
        'FrmConfirmarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConfirmarReserva)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIdReserva)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FrmConfirmarCita"
        Me.Text = "FrmConfirmarCita"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombre As Label
    Friend WithEvents TxtIdReserva As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirmarReserva As Button
End Class
