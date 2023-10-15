Public Class Formmenu
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim dtproducto As New DataTable
    Dim dtventa As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Fc As New Formcategorias
        Fc.Show()
    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(90, 68)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(87, 64)
    End Sub

    Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
        Panel3.Size = New Size(90, 68)
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel3.Size = New Size(87, 64)
    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(90, 68)
    End Sub

    Private Sub Panel5_MouseHover(sender As Object, e As EventArgs) Handles Panel5.MouseHover
        Panel5.Size = New Size(90, 68)
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(87, 64)
    End Sub

    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave
        Panel5.Size = New Size(87, 64)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Formcategorias.Show()
    End Sub
    Public cantp As Int32
    Public cantv As Int32
    Public cantt As Int32
    Private Sub Formmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fp As New Fproducto
        dtproducto = fp.mostrar_producto()
        cantp = dtproducto.Rows.Count
        lblcantpro.Text = cantp

        Dim fv As New Fventa
        dtventa = fv.ver_ventas
        cantp = dtventa.Rows.Count
        lblcantv.Text = cantp

        Try
            dtventa = fv.total_ventas()

            lbltotal.Text = Convert.ToString(dtventa.Rows(0)("total"))
        Catch ex As Exception
            lbltotal.Text = "0"
        End Try

    End Sub

    Private Sub Panel17_MouseHover(sender As Object, e As EventArgs) Handles Panel17.MouseHover
        Panel17.Size = New Size(36, 35)
    End Sub

    Private Sub Panel16_MouseHover(sender As Object, e As EventArgs) Handles Panel16.MouseHover
        Panel16.Size = New Size(36, 35)
    End Sub

    Private Sub Panel17_MouseLeave(sender As Object, e As EventArgs) Handles Panel17.MouseLeave
        Panel17.Size = New Size(33, 33)
    End Sub

    Private Sub Panel16_MouseLeave(sender As Object, e As EventArgs) Handles Panel16.MouseLeave
        Panel16.Size = New Size(33, 33)
    End Sub

    Private Sub Panel17_Click(sender As Object, e As EventArgs) Handles Panel17.Click
        Dim ex = MessageBox.Show("¿Seguro que desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (ex = vbYes) Then
            Login1.Show()
            Me.Hide()

        Else

        End If
    End Sub

    Private Sub Panel16_Click(sender As Object, e As EventArgs) Handles Panel16.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Formmenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Formmenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click

        If (btncreacuent.Visible = False) Then
            btncreacuent.Visible = True
            btnlistacuenta.Visible = True
            btncreacuent.Enabled = True
            btnlistacuenta.Enabled = True

            Label14.Visible = True
            Label7.Visible = True
        Else
            btncreacuent.Visible = False
            btnlistacuenta.Visible = False
            btncreacuent.Enabled = False
            btnlistacuenta.Enabled = False

            Label14.Visible = False
            Label7.Visible = False
        End If
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Formproducto.Show()
    End Sub



    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Formcliente.Show()
    End Sub



    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub btncreacuent_Click(sender As Object, e As EventArgs) Handles btncreacuent.Click
        FormVenta.Show()
        btncreacuent.Visible = False
        btnlistacuenta.Visible = False
        btncreacuent.Enabled = False
        btnlistacuenta.Enabled = False
        Label14.Visible = False
        Label7.Visible = False
    End Sub

    Private Sub btnlistacuenta_Click_1(sender As Object, e As EventArgs) Handles btnlistacuenta.Click
        FormlistaVentas.Show()
        btncreacuent.Visible = False
        btnlistacuenta.Visible = False
        btncreacuent.Enabled = False
        btnlistacuenta.Enabled = False
        Label14.Visible = False
        Label7.Visible = False
    End Sub

    Private Sub Panel19_Click(sender As Object, e As EventArgs) Handles Panel19.Click
        Dim fp As New Fproducto
        dtproducto = fp.mostrar_producto()
        cantp = dtproducto.Rows.Count
        lblcantpro.Text = cantp

        Dim fv As New Fventa
        dtventa = fv.ver_ventas
        cantp = dtventa.Rows.Count
        lblcantv.Text = cantp

        Try
            dtventa = fv.total_ventas()
            lbltotal.Text = Convert.ToString(dtventa.Rows(0)("total"))
        Catch ex As Exception
            lbltotal.Text = "0"
        End Try


    End Sub

    Private Sub Formmenu_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
End Class