Module Module2

    Dim arrprod(3, 3) As Double
    Dim f, c As Integer
    Dim sumatotal, valor As Double
    Dim totdisp(3), totcomb(3) As Double
    Dim tabdisp(3) As String
    Dim tabcomb(4) As String

    Dim impmencomb, impmaycomb, impmendisp, impmaydisp

    Sub main()

        tabdisp(0) = "Accell"
        tabdisp(1) = "Texaco"
        tabdisp(2) = "Delta"
        tabcomb(0) = "91 Oct"
        tabcomb(1) = "95 Oct"
        tabcomb(2) = "Diesel R"
        tabcomb(3) = "Total Disp"

        valor = 500

        For f = 0 To 2
            For c = 0 To 2
                arrprod(f, c) = valor + 500
                totdisp(f) = totdisp(f) + arrprod(f, c)
                totcomb(c) = totcomb(c) + arrprod(f, c)

                sumatotal = sumatotal + arrprod(f, c)

                valor = valor + 500

            Next c
        Next f

        'Imprimir el arreglo lleno....'
        Console.WriteLine()
        Console.WriteLine("                 DISTRIBUIDORA DE COMBUSTIBLES LA RENDIDORA, S.A")
        Console.WriteLine("                              REPORTE DE VENTAS")
        Console.WriteLine()
        Console.WriteLine("PROGRAMADOR POR: ERICK CEDEÑO                 CÉDULA: 4-785-373")
        Console.WriteLine()
        Console.Write("Dispensadores")

        For c = 0 To 3
            Console.Write("    " & tabcomb(c))
        Next

        Console.WriteLine()

        For f = 0 To 2
            Console.Write(tabdisp(f) & "           ")
            For c = 0 To 2
                Console.Write(arrprod(f, c) & "       ")
            Next c

            Console.WriteLine(totdisp(f))

        Next f

        Console.Write("Total Comb:      ")

        'IMPRIMIR TOTALES DE COLUMNAS'
        For c = 0 To 2
            Console.Write(totcomb(c) & "      ")
        Next c

        Console.WriteLine(sumatotal)

        Console.WriteLine()

        'Dispensadora de menor ventas!!!'

        If totdisp(0) < totdisp(1) And totdisp(0) < totdisp(2) Then

            impmendisp = totdisp(0) * 0.1375

            Console.WriteLine("La dispesandora de menor ventas es  " & tabdisp(0) & " por un valor de " & totdisp(0))
            Console.WriteLine("Incentivo de la venta es " & impmendisp)

        ElseIf totdisp(1) < totdisp(0) And totdisp(1) < totdisp(2) Then

            impmendisp = totdisp(1) * 0.1375

            Console.WriteLine("La dispesandora de menor ventas es  " & tabdisp(1) & " por un valor de " & totdisp(1))
            Console.WriteLine("Incentivo de la venta es " & impmendisp)

        ElseIf totdisp(2) < totdisp(0) And totdisp(2) < totdisp(1) Then

            impmendisp = totdisp(2) * 0.1375

            Console.WriteLine("La dispesandora de menor ventas es  " & tabdisp(2) & " por un valor de " & totdisp(2))
            Console.WriteLine("Incentivo de la venta es " & impmendisp)

        End If

        Console.WriteLine()

        'El combustible de menor venta'

        If totcomb(0) < totcomb(1) And totcomb(0) < totcomb(2) Then

            impmencomb = totcomb(0) * 0.1525

            Console.WriteLine("El combustible de menor ventas es " & tabcomb(0) & " por un valor de " & totcomb(0))
            Console.WriteLine("Incentivo de la venta es " & impmencomb)

        ElseIf totcomb(1) < totcomb(0) And totcomb(1) < totcomb(2) Then

            impmencomb = totcomb(1) * 0.1525

            Console.WriteLine("El combustible de menor ventas es " & tabcomb(1) & " por un valor de " & totcomb(1))
            Console.WriteLine("Incentivo de la venta es " & impmencomb)

        ElseIf totcomb(2) < totcomb(0) And totcomb(2) < totcomb(1) Then

            impmencomb = totcomb(2) * 0.1525

            Console.WriteLine("El combustible de menor ventas es " & tabcomb(2) & " por un valor de " & totcomb(2))
            Console.WriteLine("Incentivo de la venta es " & impmencomb)

        End If

        Console.WriteLine()

        'Dispensadora de mayor ventas!!!'

        If totdisp(0) > totdisp(1) And totdisp(0) > totdisp(2) Then

            impmaydisp = totdisp(0) * 0.3125

            Console.WriteLine("La dispesandora de mayor ventas es  " & tabdisp(0) & " por un valor de " & totdisp(0))
            Console.WriteLine("Incentivo de la venta es " & impmaydisp)

        ElseIf totdisp(1) > totdisp(0) And totdisp(1) > totdisp(2) Then

            impmaydisp = totdisp(1) * 0.3125

            Console.WriteLine("La dispesandora de mayor ventas es  " & tabdisp(1) & " por un valor de " & totdisp(1))
            Console.WriteLine("Incentivo de la venta es " & impmaydisp)

        ElseIf totdisp(2) > totdisp(0) And totdisp(2) > totdisp(1) Then

            impmaydisp = totdisp(2) * 0.3125

            Console.WriteLine("La dispesandora de mayor ventas es  " & tabdisp(2) & " por un valor de " & totdisp(2))
            Console.WriteLine("Incentivo de la venta es " & impmaydisp)

        End If

        Console.WriteLine()

        'El combustible de mayor venta'

        If totcomb(0) > totcomb(1) And totcomb(0) > totcomb(2) Then

            impmaycomb = totcomb(0) * 0.2375

            Console.WriteLine("El combustible de mayor ventas es " & tabcomb(0) & " por un valor de " & totcomb(0))
            Console.WriteLine("Incentivo de la venta es " & impmaycomb)

        ElseIf totcomb(1) > totcomb(0) And totcomb(1) > totcomb(2) Then

            impmaycomb = totcomb(1) * 0.2375

            Console.WriteLine("El combustible de mayor ventas es " & tabcomb(1) & " por un valor de " & totcomb(1))
            Console.WriteLine("Incentivo de la venta es " & impmaycomb)

        ElseIf totcomb(2) > totcomb(0) And totcomb(2) > totcomb(1) Then

            impmaycomb = totcomb(2) * 0.2375

            Console.WriteLine("El combustible de mayor ventas es " & tabcomb(2) & " por un valor de " & totcomb(2))
            Console.WriteLine("Incentivo de la venta es " & impmaycomb)

        End If

        Console.ReadLine()

    End Sub
End Module
