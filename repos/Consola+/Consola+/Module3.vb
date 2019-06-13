Module Module3
    Dim nombre As String
    Dim cedula As String
    Dim sexo As Char
    Dim salario, segur, seguedu, impuest, totdeduc, salneto, salquin As Double

    Sub main()

        nombre = InputBox("Inrese su nombre...")
        cedula = InputBox("Ingrese cedula....")
        sexo = InputBox("Ingrese sexo F = Femenino o M = Masculino")
        salario = InputBox("Ingrese salario....")


        While (salario < 550 Or salario > 1200)
            MsgBox("Error de Salario.......")
            salario = InputBox("Ingrese salario....")
        End While


        segur = (salario / 2) * 0.0925
            seguedu = (salario / 2) * 0.0125

            Select Case sexo
            Case "F"
                impuest = (salario / 2) * 0.125
            Case "M"
                impuest = (salario / 2) * 0.1475

        End Select

            totdeduc = segur + seguedu + impuest


        salquin = salario / 2

        salneto = salquin - totdeduc




        Console.WriteLine("                      Empresa Mi Solición S.A")

        Console.ReadLine()

        Console.WriteLine("Programador: Erick                     Cedula: 4-785-373")

        Console.ReadLine()

        Console.WriteLine("Planilla Quincenal del 1 al 15 de octubre del 2017")

        Console.ReadLine()

        Console.WriteLine("Cedula      Nombre     Salario     Seg Soc    Seg Edu     Impr Rta     Sal Neto")

        Console.ReadLine()

        Console.WriteLine(cedula & "    " & nombre & "     " & salquin & "      " & segur & "     " & seguedu & "     " & impuest & "     " & salneto)

        Console.ReadLine()

    End Sub

End Module
