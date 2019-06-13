Public Class Form1
    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        lbentrada.Items.Add(txtdatos.Text)
        txtdatos.Clear()
    End Sub

    Private Sub copiar_Click(sender As Object, e As EventArgs) Handles copiar.Click
        lbsalida.Items.Add(lbentrada.SelectedItem)
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        lbsalida.Items.Remove(lbsalida.SelectedItem)
    End Sub

    Private Sub avan_Click(sender As Object, e As EventArgs) Handles avan.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class
