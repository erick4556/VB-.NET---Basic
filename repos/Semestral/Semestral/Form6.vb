Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Form6
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim sql As String

    Dim poliza, letra As Double
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            If Me.ValidateChildren And edad.Text <> String.Empty And valaseg.Text <> String.Empty And plazop.Text <> String.Empty Then


                sql = "INSERT INTO vida (cedula,edad,valaseg,polivida,plazop,letramen) VALUES (@cedula,@edad,@valaseg,@polivida,@plazop,@letramen)"

                comandos = New MySqlCommand(sql, conexion)

                comandos.Parameters.AddWithValue("@cedula", Form1.cedula.Text)
                comandos.Parameters.AddWithValue("@edad", edad.Text)
                comandos.Parameters.AddWithValue("@valaseg", valaseg.Text)
                comandos.Parameters.AddWithValue("@polivida", poliza)
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

    Private Sub edad_TextChanged(sender As Object, e As EventArgs) Handles edad.TextChanged
        If Val(edad.Text) >= 18 Then
            enviar.Enabled = True
        Else
            enviar.Enabled = False
        End If
    End Sub


    Private Sub valaseg_TextChanged(sender As Object, e As EventArgs) Handles valaseg.TextChanged

        If Val(valaseg.Text) >= 55000 Then
            enviar.Enabled = True
        Else
            enviar.Enabled = False
        End If

        If edad.Text >= 18 And edad.Text <= 30 Then

            poliza = Val(valaseg.Text) * 0.81

            polivida.Text = Format(poliza, "$##,##0.00")

        ElseIf edad.Text >= 31 And edad.Text <= 45 Then

            poliza = Val(valaseg.Text) * 0.73

            polivida.Text = Format(poliza, "$##,##0.00")

        ElseIf edad.Text >= 46 And edad.Text <= 57 Then

            poliza = Val(valaseg.Text) * 0.62

            polivida.Text = Format(poliza, "$##,##0.00")

        ElseIf edad.Text > 57 Then

            poliza = Val(valaseg.Text) * 0.44

            polivida.Text = Format(poliza, "$##,##0.00")

        End If

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

    Private Sub edad_Validating(sender As Object, e As CancelEventArgs) Handles edad.Validating
        validar(edad)
    End Sub

    Private Sub valaseg_Validating(sender As Object, e As CancelEventArgs) Handles valaseg.Validating
        validar(valaseg)
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