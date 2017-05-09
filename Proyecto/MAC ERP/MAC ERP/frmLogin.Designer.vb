<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.tbUsu = New System.Windows.Forms.TextBox()
        Me.tbCon = New System.Windows.Forms.TextBox()
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.lbReg = New System.Windows.Forms.LinkLabel()
        Me.lbEstilo = New System.Windows.Forms.Label()
        Me.rbMDI = New System.Windows.Forms.RadioButton()
        Me.rbSDI = New System.Windows.Forms.RadioButton()
        Me.llCamCon = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'tbUsu
        '
        Me.tbUsu.ForeColor = System.Drawing.Color.DarkGray
        Me.tbUsu.Location = New System.Drawing.Point(197, 127)
        Me.tbUsu.Name = "tbUsu"
        Me.tbUsu.Size = New System.Drawing.Size(164, 20)
        Me.tbUsu.TabIndex = 1
        Me.tbUsu.Text = "Introduce tu usuario o email."
        '
        'tbCon
        '
        Me.tbCon.ForeColor = System.Drawing.Color.DarkGray
        Me.tbCon.Location = New System.Drawing.Point(197, 171)
        Me.tbCon.Name = "tbCon"
        Me.tbCon.Size = New System.Drawing.Size(164, 20)
        Me.tbCon.TabIndex = 2
        Me.tbCon.Text = "Introduce tu contraseña."
        '
        'lbLogin
        '
        Me.lbLogin.AutoSize = True
        Me.lbLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLogin.Location = New System.Drawing.Point(219, 95)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(120, 20)
        Me.lbLogin.TabIndex = 0
        Me.lbLogin.Text = "Iniciar sesión:"
        '
        'btLogin
        '
        Me.btLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.Location = New System.Drawing.Point(197, 208)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(164, 23)
        Me.btLogin.TabIndex = 3
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lbReg
        '
        Me.lbReg.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lbReg.AutoSize = True
        Me.lbReg.Location = New System.Drawing.Point(18, 350)
        Me.lbReg.Name = "lbReg"
        Me.lbReg.Size = New System.Drawing.Size(251, 13)
        Me.lbReg.TabIndex = 7
        Me.lbReg.TabStop = True
        Me.lbReg.Text = "Registrar un nuevo autónomo, particular o empresa."
        Me.lbReg.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lbEstilo
        '
        Me.lbEstilo.AutoSize = True
        Me.lbEstilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstilo.Location = New System.Drawing.Point(21, 302)
        Me.lbEstilo.Name = "lbEstilo"
        Me.lbEstilo.Size = New System.Drawing.Size(183, 15)
        Me.lbEstilo.TabIndex = 4
        Me.lbEstilo.Text = "Estilo de la interfaz gráfica:"
        '
        'rbMDI
        '
        Me.rbMDI.AutoSize = True
        Me.rbMDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMDI.Location = New System.Drawing.Point(148, 324)
        Me.rbMDI.Name = "rbMDI"
        Me.rbMDI.Size = New System.Drawing.Size(48, 17)
        Me.rbMDI.TabIndex = 6
        Me.rbMDI.Text = "MDI"
        Me.rbMDI.UseVisualStyleBackColor = True
        '
        'rbSDI
        '
        Me.rbSDI.AutoSize = True
        Me.rbSDI.Checked = True
        Me.rbSDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSDI.Location = New System.Drawing.Point(24, 324)
        Me.rbSDI.Name = "rbSDI"
        Me.rbSDI.Size = New System.Drawing.Size(46, 17)
        Me.rbSDI.TabIndex = 5
        Me.rbSDI.TabStop = True
        Me.rbSDI.Text = "SDI"
        Me.rbSDI.UseVisualStyleBackColor = True
        '
        'llCamCon
        '
        Me.llCamCon.ActiveLinkColor = System.Drawing.Color.Blue
        Me.llCamCon.AutoSize = True
        Me.llCamCon.Location = New System.Drawing.Point(18, 375)
        Me.llCamCon.Name = "llCamCon"
        Me.llCamCon.Size = New System.Drawing.Size(104, 13)
        Me.llCamCon.TabIndex = 8
        Me.llCamCon.TabStop = True
        Me.llCamCon.Text = "Cambiar contraseña."
        Me.llCamCon.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 397)
        Me.Controls.Add(Me.llCamCon)
        Me.Controls.Add(Me.rbSDI)
        Me.Controls.Add(Me.rbMDI)
        Me.Controls.Add(Me.lbEstilo)
        Me.Controls.Add(Me.lbReg)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.lbLogin)
        Me.Controls.Add(Me.tbCon)
        Me.Controls.Add(Me.tbUsu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAC ERP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUsu As System.Windows.Forms.TextBox
    Friend WithEvents tbCon As System.Windows.Forms.TextBox
    Friend WithEvents lbLogin As System.Windows.Forms.Label
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents lbReg As System.Windows.Forms.LinkLabel
    Friend WithEvents lbEstilo As System.Windows.Forms.Label
    Friend WithEvents rbMDI As System.Windows.Forms.RadioButton
    Friend WithEvents rbSDI As System.Windows.Forms.RadioButton
    Friend WithEvents llCamCon As System.Windows.Forms.LinkLabel

End Class
