Public Class Formcategorias

    Dim dtcategoria As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub
    Public Sub mostrar_categoria()
        Dim c As New Fcategoria
        dtcategoria = c.mostrar_categoria()
        dgvcategoria.DataSource = dtcategoria
    End Sub

    Private Sub Formcategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_categoria()
        cancelar()
    End Sub
    Sub cancelar()
        txtdes.Enabled = False
        btnnuevo.Enabled = True
        btnguardar.Enabled = False
        btneliminar.Enabled = False
        btncancelar.Enabled = False
        btnmodificar.Enabled = False
        limpiar()

    End Sub
    Sub limpiar()
        txtdes.Clear()
        txtcodigocat.Clear()
    End Sub
    Sub nuevo()
        txtdes.Enabled = True
        btncancelar.Enabled = True
        btnguardar.Enabled = True
        limpiar()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim c As New Fcategoria
        If (txtdes.Text <> String.Empty) Then

            If (txtcodigocat.Text <> String.Empty) Then
                If (c.edita_categoria(txtcodigocat.Text, txtdes.Text) = True) Then
                    MessageBox.Show("Categoria Modificada Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_categoria()
                Else
                    MessageBox.Show("Error al Modificarr la categoria")
                End If
            Else
                If (c.ingresa_categoria(txtcodigocat.Text, txtdes.Text) = True) Then
                    MessageBox.Show("Categoria Registrada Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_categoria()
                Else
                    MessageBox.Show("Error al registrar la categoria")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvcategoria_DoubleClick(sender As Object, e As EventArgs) Handles dgvcategoria.DoubleClick
        txtcodigocat.Text = dgvcategoria.CurrentRow.Cells("Codigo Categoria").Value
        txtdes.Text = dgvcategoria.CurrentRow.Cells("descripcion").Value
        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        btnguardar.Enabled = True
        btneliminar.Enabled = False
        txtdes.Enabled = True
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New Fcategoria
        If (c.elimina_categoria(txtcodigocat.Text) = True) Then
            MessageBox.Show("Categoria Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_categoria()
        Else
            MessageBox.Show("Error al eliminar la categoria")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim c As New Fcategoria
        dtcategoria = c.buscar_categoria(txtbuscar.Text)
        dgvcategoria.DataSource = dtcategoria
    End Sub
End Class
