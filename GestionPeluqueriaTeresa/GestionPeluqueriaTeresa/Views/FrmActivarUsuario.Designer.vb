<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActivarUsuario
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
        Me.btnActivarUsuario = New System.Windows.Forms.Button()
        Me.TxtNombreUsuarioActivar = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActivarUsuario
        '
        Me.btnActivarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnActivarUsuario.BackColor = System.Drawing.Color.Black
        Me.btnActivarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnActivarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnActivarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnActivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivarUsuario.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnActivarUsuario.Location = New System.Drawing.Point(85, 323)
        Me.btnActivarUsuario.Name = "btnActivarUsuario"
        Me.btnActivarUsuario.Size = New System.Drawing.Size(183, 39)
        Me.btnActivarUsuario.TabIndex = 47
        Me.btnActivarUsuario.Text = "Activar usuario"
        Me.btnActivarUsuario.UseVisualStyleBackColor = False
        '
        'TxtNombreUsuarioActivar
        '
        Me.TxtNombreUsuarioActivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreUsuarioActivar.Location = New System.Drawing.Point(85, 297)
        Me.TxtNombreUsuarioActivar.Name = "TxtNombreUsuarioActivar"
        Me.TxtNombreUsuarioActivar.Size = New System.Drawing.Size(183, 20)
        Me.TxtNombreUsuarioActivar.TabIndex = 45
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(85, 270)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(160, 24)
        Me.lblNombre.TabIndex = 44
        Me.lblNombre.Text = "Nombre ususario:"
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
        Me.DataGridView1.Location = New System.Drawing.Point(80, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(597, 145)
        Me.DataGridView1.TabIndex = 43
        '
        'FrmActivarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnActivarUsuario)
        Me.Controls.Add(Me.TxtNombreUsuarioActivar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmActivarUsuario"
        Me.Text = "FrmActivarUsuario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnActivarUsuario As Button
    Friend WithEvents TxtNombreUsuarioActivar As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
