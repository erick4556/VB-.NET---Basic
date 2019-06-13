Module Module2
    Dim numero As Integer
    Dim nombre As String

    Sub main()

        numero = InputBox("Entre un valor del 1 al 9")

        Select Case numero
            Case 1
                MsgBox("Permite leer algunos datos")
                nombre = InputBox("Entrese su nombre y apellido...")
                Console.WriteLine("Bienvenido....." & nombre)
                Console.ReadLine()
            Case 2 To 4
                MsgBox("Valores en bloque o rango de procesos..... 2 a 4")

            Case 5 To 7
                MsgBox("Valores en bloque o rango de procesos..... 5 a 7")

            Case 8, 9
                MsgBox("Valores en bloque o rango de procesos..... 8 a 9")

            Case Else

                MsgBox("El número no está dentro de las opciones")

        End Select

    End Sub



End Module
