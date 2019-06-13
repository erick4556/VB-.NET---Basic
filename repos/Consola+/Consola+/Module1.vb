Module Module1
    Dim nombre As String
    Dim Valor As Double

    Sub Main()
        Console.Write("Hola")
        Console.WriteLine()

        Console.Write("Ejemplo de Impresion..... " & "   " & ".....continuacion")

        nombre = InputBox("Entre su nombre....")
        Console.WriteLine()
        MsgBox("El nombre leído es: " & nombre & "  y es Administrador del Sistema.....")
        Valor = InputBox("Entre un valor")
        Console.WriteLine()
        Console.WriteLine("El valor leído es: " & Valor)

        'Detiene la pantalla'
        Console.ReadLine()


    End Sub

End Module
