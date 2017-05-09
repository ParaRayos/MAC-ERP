<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarContraseña
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContraseñaAntigua = New System.Windows.Forms.TextBox()
        Me.txtContraseñaNueva1 = New System.Windows.Forms.TextBox()
        Me.txtContraseñaNueva2 = New System.Windows.Forms.TextBox()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.btnBorrarCampos = New System.Windows.Forms.Button()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Antigua"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nueva Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repita Contraseña"
        '
        'txtContraseñaAntigua
        '
        Me.txtContraseñaAntigua.Location = New System.Drawing.Point(256, 41)
        Me.txtContraseñaAntigua.Name = "txtContraseñaAntigua"
        Me.txtContraseñaAntigua.Size = New System.Drawing.Size(170, 20)
        Me.txtContraseñaAntigua.TabIndex = 3
        Me.txtContraseñaAntigua.UseSystemPasswordChar = True
        '
        'txtContraseñaNueva1
        '
        Me.txtContraseñaNueva1.Location = New System.Drawing.Point(256, 101)
        Me.txtContraseñaNueva1.Name = "txtContraseñaNueva1"
        Me.txtContraseñaNueva1.Size = New System.Drawing.Size(170, 20)
        Me.txtContraseñaNueva1.TabIndex = 4
        Me.txtContraseñaNueva1.UseSystemPasswordChar = True
        '
        'txtContraseñaNueva2
        '
        Me.txtContraseñaNueva2.Location = New System.Drawing.Point(256, 163)
        Me.txtContraseñaNueva2.Name = "txtContraseñaNueva2"
        Me.txtContraseñaNueva2.Size = New System.Drawing.Size(170, 20)
        Me.txtContraseñaNueva2.TabIndex = 5
        Me.txtContraseñaNueva2.UseSystemPasswordChar = True
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(256, 218)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(170, 23)
        Me.btnCambiarContraseña.TabIndex = 6
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'btnBorrarCampos
        '
        Me.btnBorrarCampos.Location = New System.Drawing.Point(46, 218)
        Me.btnBorrarCampos.Name = "btnBorrarCampos"
        Me.btnBorrarCampos.Size = New System.Drawing.Size(153, 23)
        Me.btnBorrarCampos.TabIndex = 7
        Me.btnBorrarCampos.Text = "Borrar Campos"
        Me.btnBorrarCampos.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(433, 43)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(15, 14)
        Me.cb1.TabIndex = 8
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(433, 106)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(15, 14)
        Me.cb2.TabIndex = 9
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(433, 169)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(15, 14)
        Me.cb3.TabIndex = 10
        Me.cb3.UseVisualStyleBackColor = True
        '
        'CambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(475, 263)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.btnBorrarCampos)
        Me.Controls.Add(Me.btnCambiarContraseña)
        Me.Controls.Add(Me.txtContraseñaNueva2)
        Me.Controls.Add(Me.txtContraseñaNueva1)
        Me.Controls.Add(Me.txtContraseñaAntigua)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CambiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CambiarContraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaAntigua As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseñaNueva1 As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseñaNueva2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarContraseña As System.Windows.Forms.Button
    Friend WithEvents btnBorrarCampos As System.Windows.Forms.Button
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
End Class
