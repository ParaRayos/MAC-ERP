<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnNuevaEmpresa = New System.Windows.Forms.Button()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.cbMostrarContraseña = New System.Windows.Forms.CheckBox()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbMdi = New System.Windows.Forms.RadioButton()
        Me.rbSdi = New System.Windows.Forms.RadioButton()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(329, 57)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(242, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(329, 122)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(242, 20)
        Me.txtContraseña.TabIndex = 3
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(414, 201)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(157, 23)
        Me.btnInicio.TabIndex = 5
        Me.btnInicio.Text = "Iniciar Sesión"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnNuevaEmpresa
        '
        Me.btnNuevaEmpresa.Location = New System.Drawing.Point(75, 276)
        Me.btnNuevaEmpresa.Name = "btnNuevaEmpresa"
        Me.btnNuevaEmpresa.Size = New System.Drawing.Size(157, 23)
        Me.btnNuevaEmpresa.TabIndex = 6
        Me.btnNuevaEmpresa.Text = "Nueva Empresa"
        Me.btnNuevaEmpresa.UseVisualStyleBackColor = True
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(414, 276)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(157, 23)
        Me.btnCambiarContraseña.TabIndex = 7
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'cbMostrarContraseña
        '
        Me.cbMostrarContraseña.AutoSize = True
        Me.cbMostrarContraseña.Location = New System.Drawing.Point(579, 125)
        Me.cbMostrarContraseña.Name = "cbMostrarContraseña"
        Me.cbMostrarContraseña.Size = New System.Drawing.Size(135, 17)
        Me.cbMostrarContraseña.TabIndex = 8
        Me.cbMostrarContraseña.Text = "Mostrar contraseña"
        Me.cbMostrarContraseña.UseVisualStyleBackColor = True
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbSdi)
        Me.gbTipo.Controls.Add(Me.rbMdi)
        Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.Location = New System.Drawing.Point(75, 170)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(131, 100)
        Me.gbTipo.TabIndex = 9
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo Interfaz"
        '
        'rbMdi
        '
        Me.rbMdi.AutoSize = True
        Me.rbMdi.Checked = True
        Me.rbMdi.Location = New System.Drawing.Point(8, 31)
        Me.rbMdi.Name = "rbMdi"
        Me.rbMdi.Size = New System.Drawing.Size(56, 17)
        Me.rbMdi.TabIndex = 0
        Me.rbMdi.TabStop = True
        Me.rbMdi.Text = "MDI"
        Me.rbMdi.UseVisualStyleBackColor = True
        '
        'rbSdi
        '
        Me.rbSdi.AutoSize = True
        Me.rbSdi.Location = New System.Drawing.Point(8, 59)
        Me.rbSdi.Name = "rbSdi"
        Me.rbSdi.Size = New System.Drawing.Size(54, 17)
        Me.rbSdi.TabIndex = 1
        Me.rbSdi.Text = "SDI"
        Me.rbSdi.UseVisualStyleBackColor = True
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(717, 365)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.cbMostrarContraseña)
        Me.Controls.Add(Me.btnCambiarContraseña)
        Me.Controls.Add(Me.btnNuevaEmpresa)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnNuevaEmpresa As System.Windows.Forms.Button
    Friend WithEvents btnCambiarContraseña As System.Windows.Forms.Button
    Friend WithEvents cbMostrarContraseña As System.Windows.Forms.CheckBox
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbSdi As System.Windows.Forms.RadioButton
    Friend WithEvents rbMdi As System.Windows.Forms.RadioButton

End Class
