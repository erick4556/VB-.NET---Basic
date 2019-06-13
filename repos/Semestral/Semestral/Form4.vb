Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Form4
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim sql As String

    Dim poliza, valter1, letra As Double
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=sql;database=bdseguros"
            conexion.Open()
            MsgBox("Conectado!!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        Try
            If Me.ValidateChildren And terreno.Text <> String.Empty And valm2.Text <> String.Empty And plazop.Text <> String.Empty Then

                sql = "INSERT INTO terreno (cedula,terreno,valm2,valter,polizaviv,plazop,letram) VALUES (@cedula,@terreno,@valm2,@valter,@polizaviv,@plazop,@letram)"

                comandos = New MySqlCommand(sql, conexion)

                comandos.Parameters.AddWithValue("@cedula", Form1.cedula.Text)
                comandos.Parameters.AddWithValue("@terreno", terreno.Text)
                comandos.Parameters.AddWithValue("@valm2", valm2.Text)
                comandos.Parameters.AddWithValue("@valter", valter1)
                comandos.Parameters.AddWithValue("@polizaviv", poliza)
                comandos.Parameters.AddWithValue("@plazop", plazop.Text)
                comandos.Parameters.AddWithValue("@letram", letra)

                comandos.ExecuteNonQuery()
                MsgBox("Datos Guardados!!")


                MessageBox.Show("Datos registrados correctamente", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Llene todos los campos", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception

            MsgBox("PROBLEMA DE CONEXION A BASE DE DATOS = " & ex.Message)

        End Try


    End Sub

    Private Sub valm2_TextChanged(sender As Object, e As EventArgs) Handles valm2.TextChanged

        valter1 = terreno.Text * Val(valm2.Text)

        valter.Text = valter1

        poliza = valter.Text * 0.8

        polizaviv.Text = Format(poliza, "$##,##0.00")

    End Sub


    Private Sub plazop_TextChanged(sender As Object, e As EventArgs) Handles plazop.TextChanged

        If Val(plazop.Text) >= 1 And Val(plazop.Text) <= 24 Then
            enviar.Enabled = True
            letra = poliza / Val(plazop.Text)
            letram.Text = Format(poliza / Val(plazop.Text), "$##,##0.00")
        Else
            enviar.Enabled = False
            letram.Text = "$0.00"
        End If



    End Sub


    Private Sub terreno_Validating(sender As Object, e As CancelEventArgs) Handles terreno.Validating
        validar(terreno)
    End Sub

    Private Sub valm2_Validating(sender As Object, e As CancelEventArgs) Handles valm2.Validating
        validar(valm2)
    End Sub

    Private Sub plazop_Validating(sender As Object, e As CancelEventArgs) Handles plazop.Validating
        validar(plazop)
    End Sub


    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Hide()
        Form3.Show()

    End Sub

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