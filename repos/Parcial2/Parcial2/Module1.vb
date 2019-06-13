Module Module1
    Dim semana(4) As String
    Dim f, c As Integer
    Dim arrcan(4) As Double
    Dim arrpre(4) As Double
    Dim arrven(4) As Double
    Dim otros(3) As String

    Dim sumacan, sumapre, ventot As Double


    Sub Main()

        otros(0) = "Dia"
        otros(1) = "Cantidad"
        otros(2) = "Precio"
        otros(3) = "Valor Venta"

        'Dia de semanas'
        semana(0) = "Lunes    "
        semana(1) = "Martes   "
        semana(2) = "Miercoles"
        semana(3) = "Jueves   "
        semana(4) = "Viernes  "

        arrcan(0) = 785
        arrcan(1) = 437
        arrcan(2) = 869
        arrcan(3) = 658
        arrcan(4) = 584

        arrpre(0) = 35.5
        arrpre(1) = 39.95
        arrpre(2) = 29.99
        arrpre(3) = 41.25
        arrpre(4) = 45.77

        ventot = 0
        sumacan = 0
        sumapre = 0

        For f = 0 To 4

            arrven(f) = arrpre(f) * arrcan(f)
            ventot += arrven(f)

        Next f

        Console.WriteLine()
        Console.WriteLine("                             EMPRESA EDITORIAL DE LIBROS, S.A")
        Console.WriteLine("                              IMFORME DE VENTA SEMANAL")
        Console.WriteLine("                              30 OCTUBRE DE 2017")
        Console.WriteLine()
        Console.WriteLine("PROGRAMADOR POR: ERICK CEDEÑO                 CÉDULA: 4-785-373")
        Console.WriteLine()

        For f = 0 To 3
            Console.Write(otros(f) & "       ")
        Next f

        Console.WriteLine()

        For f = 0 To 4
            Console.WriteLine(semana(f) & "     " & arrcan(f) & "       " & arrpre(f) & "         " & arrven(f))
            sumacan += arrcan(f)
            sumapre += arrpre(f)
        Next f

        Console.WriteLine()

        Console.WriteLine("Totales     " & sumacan & "       " & sumapre & "       " & ventot)

        Console.WriteLine()

        'Dia de mayor venta'

        If arrven(0) > arrven(1) And arrven(0) > arrven(2) And arrven(0) > arrven(3) And arrven(0) > arrven(4) Then

            Console.WriteLine("El dia de mayor venta es  " & semana(0) & " por un valor de " & arrven(0))

        ElseIf arrven(1) > arrven(0) And arrven(1) > arrven(2) And arrven(1) > arrven(3) And arrven(1) > arrven(4) Then

            Console.WriteLine("El dia de mayor venta es  " & semana(1) & " por un valor de " & arrven(1))

        ElseIf arrven(2) > arrven(0) And arrven(2) > arrven(1) And arrven(2) > arrven(3) And arrven(2) > arrven(4) Then

            Console.WriteLine("El dia de mayor venta es  " & semana(2) & " por un valor de " & arrven(2))

        ElseIf arrven(3) > arrven(0) And arrven(3) > arrven(1) And arrven(3) > arrven(2) And arrven(3) > arrven(4) Then

            Console.WriteLine("El dia de mayor venta es  " & semana(3) & " por un valor de " & arrven(3))

        ElseIf arrven(4) > arrven(0) And arrven(4) > arrven(1) And arrven(4) > arrven(2) And arrven(4) > arrven(3) Then

            Console.WriteLine("El dia de mayor venta es  " & semana(4) & " por un valor de " & arrven(4))

        End If

        'Dia menor venta'

        Console.WriteLine()

        If arrven(0) < arrven(1) And arrven(0) < arrven(2) And arrven(0) < arrven(3) And arrven(0) < arrven(4) Then

            Console.WriteLine("El dia de menor venta es  " & semana(0) & " por un valor de " & arrven(0))

        ElseIf arrven(1) < arrven(0) And arrven(1) < arrven(2) And arrven(1) < arrven(3) And arrven(1) < arrven(4) Then

            Console.WriteLine("El dia de menor venta es  " & semana(1) & " por un valor de " & arrven(1))

        ElseIf arrven(2) < arrven(0) And arrven(2) < arrven(1) And arrven(2) < arrven(3) And arrven(2) < arrven(4) Then

            Console.WriteLine("El dia de menor venta es  " & semana(2) & " por un valor de " & arrven(2))

        ElseIf arrven(3) < arrven(0) And arrven(3) < arrven(1) And arrven(3) < arrven(2) And arrven(3) < arrven(4) Then

            Console.WriteLine("El dia de menor venta es  " & semana(3) & " por un valor de " & arrven(3))

        ElseIf arrven(4) < arrven(0) And arrven(4) < arrven(1) And arrven(4) < arrven(2) And arrven(4) < arrven(3) Then

            Console.WriteLine("El dia de mayor venta es  " & semana(4) & " por un valor de " & arrven(4))

        End If

        'Dia de mayor cantidad'


        Console.WriteLine()


        If arrcan(0) > arrcan(1) And arrcan(0) > arrcan(2) And arrcan(0) > arrcan(3) And arrcan(0) > arrcan(4) Then

            Console.WriteLine("El dia de mayor cantidad es  " & semana(0) & " por un valor de " & arrcan(0))

        ElseIf arrcan(1) > arrcan(0) And arrcan(1) > arrcan(2) And arrcan(1) > arrcan(3) And arrcan(1) > arrcan(4) Then

            Console.WriteLine("El dia de mayor cantidad es  " & semana(1) & " por un valor de " & arrcan(1))

        ElseIf arrcan(2) > arrcan(0) And arrcan(2) > arrcan(1) And arrcan(2) > arrcan(3) And arrcan(2) > arrcan(4) Then

            Console.WriteLine("El dia de mayor cantidad es  " & semana(2) & " por un valor de " & arrcan(2))

        ElseIf arrcan(3) > arrcan(0) And arrcan(3) > arrcan(1) And arrcan(3) > arrcan(2) And arrcan(3) > arrcan(4) Then

            Console.WriteLine("El dia de mayor cantidad es  " & semana(3) & " por un valor de " & arrcan(3))

        ElseIf arrcan(4) > arrcan(0) And arrcan(4) > arrcan(1) And arrcan(4) > arrcan(2) And arrcan(4) > arrcan(3) Then

            Console.WriteLine("El dia de mayor cantidad es  " & semana(4) & " por un valor de " & arrcan(4))
        End If

        'Dia de menor cantidad'


        Console.WriteLine()


        If arrcan(0) < arrcan(1) And arrcan(0) < arrcan(2) And arrcan(0) < arrcan(3) And arrcan(0) < arrcan(4) Then

            Console.WriteLine("El dia de menor cantidad es  " & semana(0) & " por un valor de " & arrcan(0))

        ElseIf arrcan(1) < arrcan(0) And arrcan(1) < arrcan(2) And arrcan(1) < arrcan(3) And arrcan(1) < arrcan(4) Then

            Console.WriteLine("El dia de menor cantidad es  " & semana(1) & " por un valor de " & arrcan(1))

        ElseIf arrcan(2) < arrcan(0) And arrcan(2) < arrcan(1) And arrcan(2) < arrcan(3) And arrcan(2) < arrcan(4) Then

            Console.WriteLine("El dia de menor cantidad es  " & semana(2) & " por un valor de " & arrcan(2))

        ElseIf arrcan(3) < arrcan(0) And arrcan(3) < arrcan(1) And arrcan(3) < arrcan(2) And arrcan(3) < arrcan(4) Then

            Console.WriteLine("El dia de menor cantidad es  " & semana(3) & " por un valor de " & arrcan(3))

        ElseIf arrcan(4) < arrcan(0) And arrcan(4) < arrcan(1) And arrcan(4) < arrcan(2) And arrcan(4) < arrcan(3) Then

            Console.WriteLine("El dia de menor cantidad es  " & semana(4) & " por un valor de " & arrcan(4))

        End If

        Console.ReadLine()

    End Sub

End Module
