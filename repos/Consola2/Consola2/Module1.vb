Module Module1
    Dim arreglo(3, 3) As Double
    Dim i, j As Integer
    Dim sumatotal, valor As Double
    Dim tc(3) As Double
    Dim tf(3) As Double
    Dim filas(3) As String
    Dim column(3) As String
    Sub Main()

        'Programación con Arreglos de dos dimensiones'
        'VALORES FIJOS DE LAS FILAS...'

        filas(0) = "Lunes"
        filas(1) = "Martes"
        filas(2) = "Miercoles"
        column(0) = "VentaA"
        column(1) = "VentaB"
        column(2) = "VentaC"
        valor = 5.0

        For i = 0 To 2
            For j = 0 To 2
                arreglo(i, j) = valor * 5
                tc(j) = tc(j) + arreglo(i, j)
                tf(j) = tf(j) + arreglo(i, j)
                sumatotal = sumatotal + arreglo(i, j)
            Next j
        Next i

        'Imprimir el arreglo lleno....'
        Console.WriteLine()
        Console.WriteLine("IMPRESIÓN DEL ARREGLO")

        For i = 0 To 2
            Console.Write("       " & column(i))

        Next i

        Console.WriteLine("    ")
        For i = 0 To 2
            Console.Write(filas(i) & "    ")
            For j = 0 To 2
                Console.Write(arreglo(i, j) & "     ")

            Next j
            Console.WriteLine(tf(1))
        Next i

        'IMPRIMIR TOTALES DE COLUMNAS'

        Console.Write("TOTALES:    ")

        For i = 0 To 2
            Console.Write(tc(1) & "     ")
        Next i

        Console.WriteLine(sumatotal)
        Console.ReadLine()

    End Sub

End Module
