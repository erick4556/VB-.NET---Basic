Public Class Form7
    Private Sub BtnPoliza_Click(sender As Object, e As EventArgs) Handles BtnPoliza.Click
        Me.Close()
        Form8.Show()

    End Sub
    Private Sub BtnTerreno_Click(sender As Object, e As EventArgs) Handles BtnTerreno.Click
        Me.Close()
        Form9.Show()
    End Sub
    Private Sub BtnAuto_Click(sender As Object, e As EventArgs) Handles BtnAuto.Click
        Me.Close()
        Form10.Show()

    End Sub

    Private Sub BtnVida_Click(sender As Object, e As EventArgs) Handles BtnVida.Click
        Me.Close()
        Form11.Show()

    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class