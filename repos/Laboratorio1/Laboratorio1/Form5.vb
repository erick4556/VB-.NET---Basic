Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imagen.Visible = False
        '   desactivar.Visible = False
        '  activar.Visible = True
    End Sub

    Private Sub activar_Click(sender As Object, e As EventArgs) Handles activar.Click
        imagen.Visible = True
        desactivar.Visible = True
        activar.Visible = False
    End Sub

    Private Sub desactivar_Click(sender As Object, e As EventArgs) Handles desactivar.Click
        imagen.Visible = False
        desactivar.Visible = False
        activar.Visible = True
    End Sub

    Private Sub avan_Click(sender As Object, e As EventArgs) Handles avan.Click
        Me.Hide()
        Form6.Show()

    End Sub
End Class