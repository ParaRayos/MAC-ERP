<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuEmpresa
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
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.Location = New System.Drawing.Point(12, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(100, 100)
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.BackColor = System.Drawing.Color.Honeydew
        Me.txtNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(194, 12)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.ReadOnly = True
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(346, 31)
        Me.txtNombreEmpresa.TabIndex = 2
        Me.txtNombreEmpresa.Text = "NOMBRE EJEMPLO"
        Me.txtNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.Location = New System.Drawing.Point(687, 12)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(27, 13)
        Me.lblSalir.TabIndex = 3
        Me.lblSalir.Text = "Salir"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(627, 12)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(735, 406)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblSalir)
        Me.Controls.Add(Me.txtNombreEmpresa)
        Me.Controls.Add(Me.pbLogo)
        Me.Name = "MenuEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuEmpresa"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombreEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents lblSalir As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
