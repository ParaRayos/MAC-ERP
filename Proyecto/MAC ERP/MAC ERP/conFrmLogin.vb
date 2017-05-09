Module conFrmLogin
    Sub conGFocusCont(ByVal camb As TextBox)
        If camb.UseSystemPasswordChar = False Then
            camb.ForeColor = Color.Black
            camb.Text = ""
            camb.UseSystemPasswordChar = True
        End If
    End Sub

    Sub conValiCont(ByVal camb As TextBox, ByVal cam2 As Control)
        If camb.Text.Equals("") Then
            cam2.Focus()
            camb.ForeColor = Color.DarkGray
            camb.UseSystemPasswordChar = False
            camb.Text = "Introduce tu contraseña."
        End If
    End Sub

    Sub conGFocusUsu(ByVal camb As TextBox)
        If camb.Text.Equals("Introduce tu usuario o email.") Then
            camb.ForeColor = Color.Black
            camb.Text = ""
        End If
    End Sub

    Sub conValiUsu(ByVal camb As TextBox)
        If camb.Text.Equals("") Then
            camb.ForeColor = Color.DarkGray
            camb.Text = "Introduce tu usuario o email."
        End If
    End Sub
    Sub conTecl(e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(32)) And Not (e.KeyChar = Chr(34) Or e.KeyChar = Chr(39) Or e.KeyChar = Chr(61)) Then

        Else
            e.Handled = True
        End If
    End Sub

    Sub validarDatos(ByVal Usuario As String, ByVal Contraseña As String)
        Dim us As String = Usuario.ToUpper
        Dim co As String = Contraseña.ToUpper
        If us.Contains("(") Or us.Contains(")") Or us.Contains("'") Or us.Contains(Chr(34)) Or us.Contains(" LIKE") Or us.Contains(" AND") Or us.Contains("=") Or us.Contains(" IS") Or us.Contains(" IN") Or us.Contains("<") Or us.Contains(">") Or us.Contains(" EXISTS") Or us.Contains(" NOT") Or us.Contains(" BETWEEN") Then
            MessageBox.Show("No cuela")
        End If
        If co.Contains("(") Or co.Contains(")") Or co.Contains("'") Or co.Contains(Chr(34)) Or co.Contains(" LIKE") Or co.Contains(" AND") Or co.Contains("=") Or co.Contains(" IS") Or co.Contains(" IN") Or co.Contains("<") Or co.Contains(">") Or co.Contains(" EXISTS") Or co.Contains(" NOT") Or co.Contains(" BETWEEN") Then
            MessageBox.Show("No cuela")
        End If
    End Sub
End Module
