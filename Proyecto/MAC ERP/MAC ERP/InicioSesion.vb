Public Class InicioSesion

    Private Sub cbMostrarContraseña_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMostrarContraseña.CheckedChanged
        If txtContraseña.UseSystemPasswordChar = True Then
            txtContraseña.UseSystemPasswordChar = False
        ElseIf txtContraseña.UseSystemPasswordChar = False Then
            txtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnCambiarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarContraseña.Click
        CambiarContraseña.ShowDialog()
    End Sub

    Private Sub btnNuevaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaEmpresa.Click
        NuevaEmpresa.ShowDialog()
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        MenuEmpresa.ShowDialog()
    End Sub

    Private Sub inicio()
        Dim nombreUsuario As String = txtUsuario.Text
        Dim sql As String = "Select nick from Usuario where nick like'" + nombreUsuario + "'"

    End Sub

End Class
