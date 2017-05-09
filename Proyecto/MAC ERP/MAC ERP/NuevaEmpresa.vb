Public Class NuevaEmpresa

    Private Sub btnBorrarCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCajas.Click
        txtCif.Text = ""
        txtNombre.Text = ""
        txtLocalidad.Text = ""
        txtProvincia.Text = ""
        txtPais.Text = ""
        txtCodPostal.Text = ""
        txtSector.Text = ""
    End Sub
End Class