Imports System.ComponentModel

Public Class Form1
    Dim salmensual As Double
    Public cappago As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If nombre.Text = "" And cedula.Text = "" And telefono.Text = "" And email.Text = "" And cotizacion.Text = "" Then
            enviar.Enabled = False
        End If


    End Sub

    Private Sub nombre_Validating(sender As Object, e As CancelEventArgs) Handles nombre.Validating

        validar(nombre)


    End Sub



    Private Sub cedula_Validating(sender As Object, e As CancelEventArgs) Handles cedula.Validating

        validar(cedula)

    End Sub


    Private Sub telefono_Validating(sender As Object, e As CancelEventArgs) Handles telefono.Validating

        validar(telefono)


    End Sub

    Private Sub email_Validating(sender As Object, e As CancelEventArgs) Handles email.Validating
        validar(email)

    End Sub

    Private Sub cotizacion_Validating(sender As Object, e As CancelEventArgs) Handles cotizacion.Validating
        validar(cotizacion)

    End Sub

    Private Sub salario_Validating(sender As Object, e As CancelEventArgs) Handles salario.Validating
        validar(salario)

    End Sub


    Private Sub salario_TextChanged(sender As Object, e As EventArgs) Handles salario.TextChanged
        salmensual = Val(salario.Text)
        If salmensual >= 850 And salmensual <= 3000 Then
            enviar.Enabled = True

        Else
            enviar.Enabled = False
        End If

    End Sub

    Private Sub tipempresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipoempresa.SelectedIndexChanged

        If tipoempresa.SelectedIndex = 0 Then
            cappago = Val(salario.Text) * 0.2


        ElseIf tipoempresa.SelectedIndex = 1 Then
            cappago = Val(salario.Text) * 0.35


        ElseIf tipoempresa.SelectedIndex = 2 Then
            cappago = Val(salario.Text) * 0.5

        End If


    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click

        nombre.Clear()
        cedula.Clear()
        telefono.Clear()
        email.Clear()
        cotizacion.Clear()
        salario.Clear()
        tipoempresa.Text = ""

    End Sub

    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        Me.Hide()
        Form2.Show()
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


