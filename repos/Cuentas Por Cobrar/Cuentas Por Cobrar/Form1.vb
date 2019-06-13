Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()


    End Sub
    Private Sub clientes_Click(sender As Object, e As EventArgs) Handles clientes.Click
        Form2.Show()
    End Sub

    Private Sub ventas_Click(sender As Object, e As EventArgs) Handles ventas.Click
        Form3.Show()
    End Sub

    Private Sub pasgos_Click(sender As Object, e As EventArgs) Handles pasgos.Click
        Form4.Show()

    End Sub
End Class
