Public Class Form4
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class