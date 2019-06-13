Public Class Lab1

    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("EJECUCIÓN DE LA APLICACIÓN DE USUARIO")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtclave_TextChanged(sender As Object, e As EventArgs) Handles txtclave.TextChanged

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        'End
        Me.Close()  'Este cierra el formulario y me deja en el anterior.
    End Sub

    Private Sub inicializar_Click(sender As Object, e As EventArgs) Handles inicializar.Click
        txtclave.Text = ""
        txtusuario.Clear()

    End Sub

    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click

        '  i = i + 1
        If txtusuario.Text = "Sam" Or txtusuario.Text = "SAM" Then

            If txtclave.Text = "12345" Then

                MsgBox("Usuario aceptado")
                Form2.Show()
                Me.Visible = False


            Else

                MsgBox("Contrasexa inválida")
                i = i + 1
                If i = 3 Then
                    MsgBox("Fallaste 3 veces")
                    End
                End If
            End If

        Else

            MsgBox("Usuario incorrecto")
            i = i + 1

        End If
        If i = 3 Then
            MsgBox("Fallaste 3 veces")
            End
        End If
    End Sub
End Class
