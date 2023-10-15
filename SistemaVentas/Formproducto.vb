Public Class Formproducto
    Dim dtcategoria As DataTable
    Dim dtproducto As DataTable
    Private Sub Formproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcategoria()
        bloqueacajas(False)
        mostrar_producto()
        limpiar()


    End Sub


    Public Sub llenarcategoria()
        Dim c As New Fcategoria
        dtcategoria = c.mostrar_categoria()
        cbcategoria.DataSource = dtcategoria
        cbcategoria.DisplayMember = "descripcion"
        cbcategoria.ValueMember = "Codigo Categoria"
    End Sub

    Public Sub mostrar_producto()
        Dim c As New Fproducto
        dtproducto = c.mostrar_producto
        dgvproucto.DataSource = dtproducto
        Dim fil As Int32
        fil = dgvproucto.RowCount - 1
        For i = 0 To fil
            If (dgvproucto.Item(3, i).Value < 10) Then
                dgvproucto.Rows(i).DefaultCellStyle.BackColor = Color.Red
            Else

            End If

        Next
    End Sub
    Sub nuevo()
        btncancelar.Enabled = True
        btnguardar.Enabled = True
        limpiar()
        bloqueacajas(True)
    End Sub
    Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txtprecio.Clear()
        txtstock.Value = 0
    End Sub
    Sub cancelar()
        btnnuevo.Enabled = True
        btnguardar.Enabled = False
        btneliminar.Enabled = False
        btncancelar.Enabled = False
        btnmodificar.Enabled = False
        limpiar()
        bloqueacajas(False)
    End Sub

    Sub bloqueacajas(va As Boolean)
        txtnombre.Enabled = va
        txtprecio.Enabled = va
        txtstock.Enabled = va
        cbcategoria.Enabled = va

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim fp As New Fproducto
        If (txtnombre.Text <> String.Empty And txtprecio.Text <> String.Empty And txtstock.Value <> 0 And cbcategoria.Text <> String.Empty) Then

            Try
                If (txtcodigo.Text <> String.Empty) Then

                    If (fp.edita_producto(txtcodigo.Text, txtnombre.Text, txtprecio.Text, txtstock.Value, cbcategoria.SelectedValue) = True) Then
                        MessageBox.Show("Producto editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cancelar()
                        mostrar_producto()
                    Else
                        MessageBox.Show("Error al Modificar el Producto")
                    End If
                Else

                    If (fp.ingresa_producto(txtcodigo.Text, txtnombre.Text, txtprecio.Text, txtstock.Value, cbcategoria.SelectedValue) = True) Then
                        MessageBox.Show("Producto registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cancelar()
                        mostrar_producto()
                    Else
                        MessageBox.Show("Error al registrar el Producto")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Verifique si el precio esta bien escrito ejemplo: 5,10", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try



        Else
            MessageBox.Show("Complete todos los datos")
        End If

    End Sub

    Private Sub dgvproucto_DoubleClick(sender As Object, e As EventArgs) Handles dgvproucto.DoubleClick
        txtcodigo.Text = dgvproucto.CurrentRow.Cells("cod_producto").Value
        txtnombre.Text = dgvproucto.CurrentRow.Cells("nombre").Value
        txtprecio.Text = dgvproucto.CurrentRow.Cells("precio").Value
        txtstock.Value = dgvproucto.CurrentRow.Cells("stock").Value
        cbcategoria.Text = dgvproucto.CurrentRow.Cells("cod_categoria").Value

        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        btnguardar.Enabled = True
        btneliminar.Enabled = False
        bloqueacajas(True)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New Fproducto
        If (c.elimina_producto(txtcodigo.Text) = True) Then
            MessageBox.Show("Producto Eliminado Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_producto()
        Else
            MessageBox.Show("Error al eliminar el Producto")
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar_producto()
    End Sub
    Sub buscar_producto()
        Dim fp As New Fproducto
        dtproducto = fp.buscar_producto(txtbuscar.Text)
        dgvproucto.DataSource = dtproducto
        Dim fil As Int32
        fil = dgvproucto.RowCount - 1
        For i = 0 To fil
            If (dgvproucto.Item(3, i).Value < 10) Then
                dgvproucto.Rows(i).DefaultCellStyle.BackColor = Color.Red
            Else

            End If

        Next
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgvproucto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproucto.CellContentClick

    End Sub
End Class