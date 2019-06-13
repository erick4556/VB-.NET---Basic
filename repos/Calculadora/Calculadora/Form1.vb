Public Class Form1

    Dim operacion As String
    Dim val_resul As Nullable(Of Double) = Nothing 'Va aceptar valores nulos y va hacer de tipo doble. Nothing es que inicialmente va a valer nada.
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim preoperador As Boolean 'Para que nos indique cuando se oprimio un operador. 


    Private Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "1" 'Concatena lo que esta en el contenido de nuestra caja de texto con un 1.
    End Sub

    Private Sub cero_Click(sender As Object, e As EventArgs) Handles cero.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "0"
    End Sub

    Private Sub dos_Click(sender As Object, e As EventArgs) Handles dos.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "2"
    End Sub

    Private Sub tres_Click(sender As Object, e As EventArgs) Handles tres.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "3"
    End Sub

    Private Sub cuatro_Click(sender As Object, e As EventArgs) Handles cuatro.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "4"
    End Sub

    Private Sub cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "5"
    End Sub

    Private Sub seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "6"
    End Sub

    Private Sub siete_Click(sender As Object, e As EventArgs) Handles siete.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "7"
    End Sub

    Private Sub ocho_Click(sender As Object, e As EventArgs) Handles ocho.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "8"
    End Sub

    Private Sub nueve_Click(sender As Object, e As EventArgs) Handles nueve.Click
        EvaluarRestrConcat()
        TextResultado.Text &= "9"
    End Sub

    Private Sub punto_Click(sender As Object, e As EventArgs) Handles punto.Click
        EvaluarRestrConcat()
        If InStr(TextResultado.Text, ".", CompareMethod.Text) = 0 Then 'Cuando no encuentra punto, devuelve un 0
            TextResultado.Text &= "."
        End If

    End Sub

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        HazOperacion()
        operacion = "+" 'Para cuando vaya al case haga la comparación.
    End Sub

    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        HazOperacion()
        operacion = "-"
    End Sub

    Private Sub mult_Click(sender As Object, e As EventArgs) Handles mult.Click
        HazOperacion()
        operacion = "*"
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        HazOperacion()
        operacion = "/"
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextResultado.Text = "0"
        valor2 = Nothing
        val_resul = Nothing

    End Sub

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click
        HazOperacion()
        operacion = ""
    End Sub

    Public Sub HazOperacion()
        preoperador = True
        valor2 = Val(TextResultado.Text) 'Esta función Val recibe lo que ingresamos en la caja de texto.
        If val_resul IsNot Nothing Then
            Select Case operacion
                Case "+"
                    val_resul = val_resul + valor2
                Case "-"
                    val_resul = val_resul - valor2
                Case "*"
                    val_resul = val_resul * valor2
                Case "/"
                    val_resul = val_resul / valor2

            End Select
            TextResultado.Text = val_resul 'Imprime el resultado en la caja de texto.
        Else
            val_resul = valor2
        End If

    End Sub

    Public Sub EvaluarRestrConcat()
        If preoperador = True Then
            TextResultado.Text = ""
            preoperador = False
        ElseIf TextResultado.Text = "0" Then
            TextResultado.Text = ""
        End If
    End Sub

End Class
