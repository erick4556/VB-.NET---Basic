Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim c As Double
    Dim b1, r2 As Double

    Private Sub opciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles opciones.SelectedIndexChanged
        b = Val(valor2.Text) * Val(valor2.Text)
        b1 = Val(valor2.Text)
        a = Val(valor1.Text)
        c = Val(valor3.Text)

        If opciones.SelectedIndex = 0 Then

            r2 = Math.Sqrt(b - 4 * (a * c))
            resultado.Text = (-1 * b1 + r2) / (2 * a)


        ElseIf opciones.SelectedIndex = 1 Then

            r2 = Math.Sqrt(b + 4 * (a * c))
            resultado.Text = ((-1 * b1) - r2) / (2 * a)

        End If

    End Sub
End Class
