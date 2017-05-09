Public Class Productos
    Dim numeroSelecciones As Double

    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click
        numeroSelecciones = DataGridView1.SelectedRows.Count
        If numeroSelecciones = 0 Then
            AñadirProducto.Show()
        Else
            MessageBox.Show("Tiene algún producto seleccionado. Quite la selección para poder añadir un nuevo producto.", "INFORMACION", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        numeroSelecciones = DataGridView1.SelectedRows.Count
        If numeroSelecciones > 0 Then
            MessageBox.Show("Se eliminarán los productos seleccionados. ¿Quiere continuar?.", "INFORMACION", MessageBoxButtons.OKCancel)
        Else
            MessageBox.Show("No tiene ningún producto seleccionado.", "INFORMACION", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        numeroSelecciones = DataGridView1.SelectedRows.Count
        If numeroSelecciones = 1 Then
            ModificarProducto.Show()
        ElseIf numeroSelecciones > 1 Then
            MessageBox.Show("Tiene más de un producto seleccionado.", "INFORMACION", MessageBoxButtons.OK)
        ElseIf numeroSelecciones = 0 Then
            MessageBox.Show("Seleccione algún producto para modificar.", "INFORMACION", MessageBoxButtons.OK)
        End If
    End Sub
End Class