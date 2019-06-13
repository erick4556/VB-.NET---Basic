Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Form5
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim sql As String

    Dim poliza, letra As Double


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            If Me.ValidateChildren And aauto.Text <> String.Empty And placa.Text <> String.Empty And valauto.Text <> String.Empty And plazop.Text <> String.Empty Then


                sql = "INSERT INTO auto (cedula,aauto,placa,valauto,poliauto,plazop,letramen) VALUES (@cedula,@aauto,@placa,@valauto,@poliauto,@plazop,@letramen)"

                comandos = New MySqlCommand(sql, conexion)

                comandos.Parameters.AddWithValue("@cedula", Form1.cedula.Text)
                comandos.Parameters.AddWithValue("@aauto", aauto.Text)
                comandos.Parameters.AddWithValue("@placa", placa.Text)
                comandos.Parameters.AddWithValue("@valauto", valauto.Text)
                comandos.Parameters.AddWithValue("@poliauto", poliza)
                comandos.Parameters.AddWithValue("@plazop", plazop.Text)
                comandos.Parameters.AddWithValue("@letramen", letra)

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


    Private Sub aauto_TextChanged(sender As Object, e As EventArgs) Handles aauto.TextChanged

        If Val(aauto.Text) >= 2007 And Val(aauto.Text) <= 2017 Then
            enviar.Enabled = True
        Else
            enviar.Enabled = False


        End If

    End Sub

    Private Sub valauto_TextChanged(sender As Object, e As EventArgs) Handles valauto.TextChanged

        poliza = Val(valauto.Text) * 0.4

        poliauto.Text = Format(poliza, "$##,##0.00")

    End Sub



    Private Sub plazop_TextChanged(sender As Object, e As EventArgs) Handles plazop.TextChanged

        If Val(plazop.Text) >= 1 And Val(plazop.Text) <= 8 Then
            enviar.Enabled = True
            letra = poliza / Val(plazop.Text)
            letram.Text = Format(poliza / Val(plazop.Text), "$##,##0.00")
        Else
            enviar.Enabled = False
            letram.Text = "$0.00"
        End If



    End Sub



    Private Sub aauto_Validating(sender As Object, e As CancelEventArgs) Handles aauto.Validating
        validar(aauto)
    End Sub

    Private Sub placa_Validating(sender As Object, e As CancelEventArgs) Handles placa.Validating
        validar(placa)
    End Sub

    Private Sub valauto_Validating(sender As Object, e As CancelEventArgs) Handles valauto.Validating
        validar(valauto)
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