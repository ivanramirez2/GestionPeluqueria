<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarCliente
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
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.Eliminar_Cliente_Sin_Pagar = New System.Windows.Forms.Button()
        Me.TxtNombreCliente2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreCliente.Location = New System.Drawing.Point(36, 260)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(225, 20)
        Me.TxtNombreCliente.TabIndex = 17
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(36, 233)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(144, 24)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre cliente:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(31, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(597, 145)
        Me.DataGridView1.TabIndex = 15
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarCliente.BackColor = System.Drawing.Color.Black
        Me.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.Color.White
        Me.btnEliminarCliente.Location = New System.Drawing.Point(36, 286)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(183, 39)
        Me.btnEliminarCliente.TabIndex = 39
        Me.btnEliminarCliente.Text = "Eliminar cliente"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'Eliminar_Cliente_Sin_Pagar
        '
        Me.Eliminar_Cliente_Sin_Pagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Eliminar_Cliente_Sin_Pagar.BackColor = System.Drawing.Color.Black
        Me.Eliminar_Cliente_Sin_Pagar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Eliminar_Cliente_Sin_Pagar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.Eliminar_Cliente_Sin_Pagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Eliminar_Cliente_Sin_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_Cliente_Sin_Pagar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Cliente_Sin_Pagar.ForeColor = System.Drawing.Color.White
        Me.Eliminar_Cliente_Sin_Pagar.Location = New System.Drawing.Point(358, 300)
        Me.Eliminar_Cliente_Sin_Pagar.Name = "Eliminar_Cliente_Sin_Pagar"
        Me.Eliminar_Cliente_Sin_Pagar.Size = New System.Drawing.Size(225, 39)
        Me.Eliminar_Cliente_Sin_Pagar.TabIndex = 42
        Me.Eliminar_Cliente_Sin_Pagar.Text = "Eliminar Cliente"
        Me.Eliminar_Cliente_Sin_Pagar.UseVisualStyleBackColor = False
        '
        'TxtNombreCliente2
        '
        Me.TxtNombreCliente2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreCliente2.Location = New System.Drawing.Point(358, 260)
        Me.TxtNombreCliente2.Name = "TxtNombreCliente2"
        Me.TxtNombreCliente2.Size = New System.Drawing.Size(225, 20)
        Me.TxtNombreCliente2.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(358, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nombre cliente (2 meses sin pagar):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmEliminarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Eliminar_Cliente_Sin_Pagar)
        Me.Controls.Add(Me.TxtNombreCliente2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.TxtNombreCliente)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmEliminarCliente"
        Me.Text = "FrmEliminarCliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents Eliminar_Cliente_Sin_Pagar As Button
    Friend WithEvents TxtNombreCliente2 As TextBox
    Friend WithEvents Label1 As Label
End Class
