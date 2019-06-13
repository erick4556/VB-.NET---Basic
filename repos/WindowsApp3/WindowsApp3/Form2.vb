Imports System.ComponentModel

Public Class Form2



    Private Sub txtcliente_Validating(sender As Object, e As CancelEventArgs) Handles txtcliente.Validating
        If txtcliente.Text = "" Then
            ErrorProvider1.SetError(txtcliente, "Error en el nombre")
        Else
            ErrorProvider1.SetError(txtcliente, "")
        End If
    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        If chlaptop.Checked Then
            txtlinea1.Text = txtcant1.Text * 395.0
            txtcantotal.Text = Val(txtcantotal.Text) + Val(txtcant1.Text)
            txttotal.Text = Val(txtlinea1.Text) + Val(txttotal.Text)
        End If

        If chtablet.Checked Then
            txtlinea2.Text = txtcant2.Text * 175.0
            txtcantotal.Text = Val(txtcantotal.Text) + Val(txtcant2.Text)
            txttotal.Text = Val(txtlinea2.Text) + Val(txttotal.Text)
        End If

        If chs8.Checked Then
            txtlinea3.Text = txtcant3.Text * 500
            txtcantotal.Text = Val(txtcantotal.Text) + Val(txtcant3.Text)
            txttotal.Text = Val(txtlinea3.Text) + Val(txttotal.Text)
        End If

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Close()

    End Sub

    Private Sub chlaptop_CheckedChanged(sender As Object, e As EventArgs) Handles chlaptop.CheckedChanged
        If chlaptop.Checked Then
            txtlinea1.Text = txtcant1.Text * 395.0
            txtcantotal.Text = Val(txtcantotal.Text) + Val(txtcant1.Text)
            txttotal.Text = Val(txtlinea1.Text) + Val(txttotal.Text)


        Else
            txtcantotal.Text = txtcantotal.Text - txtcant1.Text
            txttotal.Text = txttotal.Text - txtlinea1.Text
            txtcant1.Clear()
            txtlinea1.Clear()
        End If
    End Sub

    Private Sub chtablet_CheckedChanged(sender As Object, e As EventArgs) Handles chtablet.CheckedChanged
        If chtablet.Checked Then
            txtlinea2.Text = txtcant2.Text * 175.0
            txtcantotal.Text = Val(txtcantotal.Text) + Val(txtcant2.Text)
            txttotal.Text = Val(txtlinea2.Text) + Val(txttotal.Text)
        Else
            txtcantotal.Text = txtcantotal.Text - txtcant2.Text
            txttotal.Text = txttotal.Text - txtlinea2.Text
            txtcant2.Clear()
            txtlinea2.Clear()

        End If
    End Sub

    Private Sub chs8_CheckedChanged(sender As Object, e As EventArgs) Handles chs8.CheckedChanged
        If chs8.Checked Then
            txtlinea3.Text = txtcant3.Text * 500
            txtcantotal.Text = Val(txtcantotal.Text) + Val(txtcant3.Text)
            txttotal.Text = Val(txtlinea3.Text) + Val(txttotal.Text)
        Else
            txtcantotal.Text = txtcantotal.Text - txtcant3.Text
            txttotal.Text = txttotal.Text - txtlinea3.Text
            txtcant3.Clear()
            txtlinea3.Clear()
        End If
    End Sub
End Class