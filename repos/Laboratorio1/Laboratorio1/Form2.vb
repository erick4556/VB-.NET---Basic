Public Class Form2



    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles mensaje.MouseEnter
        mensaje.Visible = True

    End Sub


    Private Sub mensaje_MouseLeave(sender As Object, e As EventArgs) Handles mensaje.MouseLeave
        mensaje.Visible = False

    End Sub



    Private Sub vermensaje_MouseLeave(sender As Object, e As EventArgs) Handles vermensaje.MouseLeave
        mensaje.Visible = False
    End Sub

    Private Sub vermensaje_MouseEnter(sender As Object, e As EventArgs) Handles vermensaje.MouseEnter
        mensaje.Visible = True
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mensaje.Visible = False
        usuario.Text = Lab1.txtusuario.Text

    End Sub

    Private Sub avan_Click(sender As Object, e As EventArgs) Handles avan.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class