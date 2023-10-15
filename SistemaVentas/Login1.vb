Public Class Login1
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Login1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Login1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub Login1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Panel16_Click(sender As Object, e As EventArgs) Handles Panel16.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtcontra.Text <> String.Empty And txtusuario.Text <> String.Empty) Then
            Dim dtusuario As New DataTable
            Dim fu As New Fusuario
            dtusuario = fu.validar_usuario(txtusuario.Text, txtcontra.Text)

            If (dtusuario.Rows.Count <> 0) Then
                Dim nivel As String
                nivel = dtusuario.Rows(0)("tipo_usuario")
                If (nivel.Equals("Administrador")) Then
                    MessageBox.Show("Bienvenido usuario " + txtusuario.Text, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    txtcontra.Clear()
                    txtusuario.Clear()
                    Formmenu.Show()
                Else
                    MessageBox.Show("Error al entrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Eror al entrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
                MessageBox.Show("Complete todos los datos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub cbverclave_CheckedChanged(sender As Object, e As EventArgs) Handles cbverclave.CheckedChanged
        If (cbverclave.Checked = True) Then
            txtcontra.UseSystemPasswordChar = False
        Else
            txtcontra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Login1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Clear()
        txtcontra.Clear()

    End Sub
End Class