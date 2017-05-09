Public Class frmLogin
    Private Sub frmLogin_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.lbLogin.Focus()
    End Sub

    Private Sub tbUsu_GotFocus(sender As Object, e As System.EventArgs) Handles tbUsu.GotFocus
        conGFocusUsu(Me.tbUsu)
    End Sub

    Private Sub tbUsu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbUsu.KeyPress, tbCon.KeyPress
        conTecl(e)
    End Sub

    Private Sub tbUsu_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbUsu.Validating
        conValiUsu(Me.tbUsu)
    End Sub

    Private Sub tbCon_GotFocus(sender As Object, e As System.EventArgs) Handles tbCon.GotFocus
        conGFocusCont(Me.tbCon)
    End Sub

    Private Sub tbCon_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbCon.Validating
        conValiCont(Me.tbCon, Me.btLogin)
    End Sub

    Private Sub btLogin_Click(sender As System.Object, e As System.EventArgs) Handles btLogin.Click
        validarDatos(Me.tbUsu.Text, Me.tbCon.Text)
    End Sub
End Class
