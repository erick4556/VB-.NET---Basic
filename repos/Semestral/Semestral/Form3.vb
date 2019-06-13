Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Form1.vivienda.Checked And Form1.automovil.Checked And Form1.vida.Checked Then
            terreno.Enabled = True
            automovil.Enabled = True
            vida.Enabled = True

        ElseIf Form1.vivienda.Checked And Form1.automovil.Checked Then
            terreno.Enabled = True
            automovil.Enabled = True
            vida.Enabled = False

        ElseIf Form1.vivienda.Checked And Form1.vida.Checked Then
            terreno.Enabled = True
            automovil.Enabled = False
            vida.Enabled = True

        ElseIf Form1.automovil.Checked And Form1.vida.Checked Then
            terreno.Enabled = False
            automovil.Enabled = True
            vida.Enabled = True

        ElseIf Form1.vivienda.Checked Then
            terreno.Enabled = True
            automovil.Enabled = False
            vida.Enabled = False

        ElseIf Form1.automovil.Checked Then
            terreno.Enabled = False
            automovil.Enabled = True
            vida.Enabled = False

        ElseIf Form1.vida.Checked Then
            terreno.Enabled = False
            automovil.Enabled = False
            vida.Enabled = True



        End If

    End Sub

    Private Sub terreno_Click(sender As Object, e As EventArgs) Handles terreno.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub automovil_Click(sender As Object, e As EventArgs) Handles automovil.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub vida_Click(sender As Object, e As EventArgs) Handles vida.Click
        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class