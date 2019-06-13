
Imports System.ComponentModel

Public Class Form1


    Private Sub placa_Validating(sender As Object, e As CancelEventArgs) Handles placa.Validating
        ''   If placa.Text = "" Then
        validar(placa)
        '      enviar.Enabled = False
        ' Else
        'enviar.Enabled = True
        ' End If

    End Sub

    Private Sub profesion_Validating(sender As Object, e As CancelEventArgs) Handles profesion.Validating
        '   If profesion.Text = "" Then
        validar(profesion)
        '      enviar.Enabled = False
        ' Else
        'enviar.Enabled = True
        ' End If

    End Sub

    Private Sub nombre_Validating(sender As Object, e As CancelEventArgs) Handles nombre.Validating
        ' If nombre.Text = "" Then
        validar(nombre)
        '    enviar.Enabled = False
        'Else
        'enviar.Enabled = True
        'End If

    End Sub

    Private Sub telefono_Validating(sender As Object, e As CancelEventArgs) Handles telefono.Validating
        ' If telefono.Text = "" Then
        validar(telefono)
        '    enviar.Enabled = False
        ' Else
        'enviar.Enabled = True
        'End If

    End Sub

    Private Sub email_Validating(sender As Object, e As CancelEventArgs) Handles email.Validating
        '  If email.Text = "" Then
        validar(email)
        '     enviar.Enabled = False
        ' Else
        'enviar.Enabled = True
        'End If

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        placa.Clear()
        nombre.Clear()
        profesion.Clear()
        telefono.Clear()
        email.Clear()

    End Sub

    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        Try
            If Me.ValidateChildren And placa.Text <> String.Empty And nombre.Text <> String.Empty And profesion.Text <> String.Empty And telefono.Text <> String.Empty And email.Text <> String.Empty Then
                MessageBox.Show("Datos registrados correctamente", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form2.Show()
            Else
                MessageBox.Show("Llene todos los campos", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Función que utilizo para usar el errorprovider con todos los campos.
    Public Sub validar(ByVal ParamArray caja() As TextBox)
        For i = 0 To caja.Length - 1
            If caja(i).Text.Length = 0 Then
                ErrorProvider.SetError(caja(i), "Debe llenar este campo!!")
            Else
                ErrorProvider.SetError(caja(i), "")
            End If
        Next
    End Sub


End Class
