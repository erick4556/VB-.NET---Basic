Public Class Form2
    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Me.Hide()
        Form7.Show()

    End Sub
End Class