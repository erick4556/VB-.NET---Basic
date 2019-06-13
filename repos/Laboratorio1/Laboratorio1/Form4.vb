Imports System.ComponentModel

Public Class Form4
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cboperaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboperaciones.SelectedIndexChanged
        If cboperaciones.SelectedIndex = 0 Then

            txtresultado.Text = Val(txtvalor1.Text) + Val(txtvalor2.Text)
            simbolo.Text = "+"

        End If

        If cboperaciones.SelectedIndex = 1 Then
            txtresultado.Text = txtvalor1.Text - txtvalor2.Text
            simbolo.Text = "-"
        End If

        If cboperaciones.SelectedIndex = 2 Then
            txtresultado.Text = txtvalor1.Text * txtvalor2.Text
            simbolo.Text = "*"
        End If

        If cboperaciones.SelectedIndex = 3 Then
            If Val(txtvalor2.Text) <> 0 Then
                txtresultado.Text = txtvalor1.Text / txtvalor2.Text
            Else
                MsgBox("Su valor es incorrecto")
            End If

            simbolo.Text = "/"

        End If

        If cboperaciones.SelectedIndex = 4 Then
            txtresultado.Clear()
            txtvalor1.Clear()
            txtvalor2.Clear()
            simbolo.Text = ""
        End If

        If cboperaciones.SelectedIndex = 5 Then
            Close()
        End If


    End Sub


    Private Sub txtvalor1_Validating(sender As Object, e As CancelEventArgs) Handles txtvalor1.Validating
        If txtvalor1.Text = "" Then
            errorpro.SetError(txtvalor1, "Error en el valor...")
            e.Cancel = True
        Else
            errorpro.SetError(txtvalor1, "")
            e.Cancel = False
        End If

    End Sub

    Private Sub txtvalor2_Validating(sender As Object, e As CancelEventArgs) Handles txtvalor2.Validating
        If txtvalor1.Text = "" Then
            errorpro.SetError(txtvalor2, "Error en el valor...")
            e.Cancel = True
        Else
            errorpro.SetError(txtvalor2, "")
            e.Cancel = False
        End If
    End Sub

    Private Sub avan_Click(sender As Object, e As EventArgs) Handles avan.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class