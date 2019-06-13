Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub activar_Click(sender As Object, e As EventArgs) Handles activar.Click
        salida.Text = txtmensaje.Text
        salida.ForeColor = Color.DarkBlue

        salida2.Text = txtmensaje.Text
        salida2.BackColor = Color.Orange
        salida2.ForeColor = Color.White

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Provincia.SelectedIndexChanged
        If Provincia.SelectedIndex = 0 Then
            salida2.ForeColor = Color.Aqua
            salida2.Text = "LA ISLA COLÓN.... Y OTRAS"
            salida2.BackColor = Color.Blue

        ElseIf Provincia.SelectedIndex = 1 Then
            salida2.ForeColor = Color.Beige
            salida2.Text = "Penonomé y Aguadulce"
            salida2.BackColor = Color.Red

        ElseIf Provincia.SelectedIndex = 2 Then
            salida2.ForeColor = Color.Yellow
            salida2.Text = "Portobelo"
            salida2.BackColor = Color.Azure

        ElseIf Provincia.SelectedIndex = 3 Then
            salida2.ForeColor = Color.Red
            salida2.Text = "El país de Chiriquí"
            salida2.BackColor = Color.White

        ElseIf Provincia.SelectedIndex = 4 Then
            salida2.ForeColor = Color.Red
            salida2.Text = "Las Palmas"
            salida2.BackColor = Color.White

        ElseIf Provincia.SelectedIndex = 5 Then
            salida2.ForeColor = Color.Blue
            salida2.Text = "Chitre"
            salida2.BackColor = Color.LightYellow

        ElseIf Provincia.SelectedIndex = 6 Then
            salida2.ForeColor = Color.Yellow
            salida2.Text = "Las Tablas"
            salida2.BackColor = Color.Pink

        ElseIf Provincia.SelectedIndex = 7 Then
            salida2.ForeColor = Color.Red
            salida2.Text = "La Capital"
            salida2.BackColor = Color.Maroon

        ElseIf Provincia.SelectedIndex = 8 Then
            salida2.ForeColor = Color.Purple
            salida2.Text = "Santiago"
            salida2.BackColor = Color.White

        ElseIf Provincia.SelectedIndex = 9 Then
            salida2.ForeColor = Color.White
            salida2.Text = "La nueva provincia"
            salida2.BackColor = Color.Pink

        End If

        'Traer el nombre de la provincia
        'If Provincia.SelectedIndex = 1 Then
        '   salida2.Text = Provincia.SelectedItem
        'End If

    End Sub

    Private Sub avan_Click(sender As Object, e As EventArgs) Handles avan.Click
        Me.Hide()
        Form4.Show()

    End Sub
End Class