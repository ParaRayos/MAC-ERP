Public Class CambiarContraseña

    Private Sub cb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.CheckedChanged
        If txtContraseñaAntigua.UseSystemPasswordChar = True Then
            txtContraseñaAntigua.UseSystemPasswordChar = False
        ElseIf txtContraseñaAntigua.UseSystemPasswordChar = False Then
            txtContraseñaAntigua.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.CheckedChanged
        If txtContraseñaNueva1.UseSystemPasswordChar = True Then
            txtContraseñaNueva1.UseSystemPasswordChar = False
        ElseIf txtContraseñaNueva1.UseSystemPasswordChar = False Then
            txtContraseñaNueva1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb3.CheckedChanged
        If txtContraseñaNueva2.UseSystemPasswordChar = True Then
            txtContraseñaNueva2.UseSystemPasswordChar = False
        ElseIf txtContraseñaNueva2.UseSystemPasswordChar = False Then
            txtContraseñaNueva2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBorrarCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCampos.Click
        txtContraseñaAntigua.Text = ""
        txtContraseñaNueva1.Text = ""
        txtContraseñaNueva2.Text = ""
        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        txtContraseñaAntigua.BackColor = Color.White
        txtContraseñaNueva1.BackColor = Color.White
        txtContraseñaNueva2.BackColor = Color.White
    End Sub

    Public Sub cambiarContraseña()
        'If contraseñaSql = txtContraseñaAntigua.Text
        If Not txtContraseñaAntigua.Text = txtContraseñaNueva1.Text Then
            If txtContraseñaNueva1.Text = txtContraseñaNueva2.Text Then
                'update contraseña
            Else
                txtContraseñaNueva1.BackColor = Color.Salmon
                txtContraseñaNueva2.BackColor = Color.Salmon
                MessageBox.Show("Las contraseñas no coinciden", "INFORMACION", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("La contraseña nueva no puede ser igual a la antigua", "INFORMACION", MessageBoxButtons.OK)
        End If
        'Else 
        '    txtContraseñaAntigua.BackColor = Color.Salmon
        '    MessageBox.Show("La contraseña no coincide con la guardada", "INFORMACION", MessageBoxButtons.OK)
    End Sub

    Private Sub btnCambiarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarContraseña.Click
        cambiarContraseña()
    End Sub

    Private Sub CambiarContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class