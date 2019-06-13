Public Class Form1

    Dim sal As Double
    Dim tot As Double
    Dim b20, b10, b5, b1, b050, b025, b010, b005, b001 As Integer



    Private Sub salario_TextChanged(sender As Object, e As EventArgs) Handles salario.TextChanged
        sal = Val(salario.Text)



        cant_20.Text = Int(sal / 20)
        cant_10.Text = Int((sal - (cant_20.Text * 20)) / 10)
        cant_5.Text = Int((sal - ((cant_20.Text * 20) + (cant_10.Text * 10))) / 5)
        cant_1.Text = Int((sal - ((cant_20.Text * 20) + (cant_10.Text * 10) + (cant_5.Text * 5))) / 1)

        cant_050.Text = Int((sal - ((cant_20.Text * 20) + (cant_10.Text * 10) + (cant_5.Text * 5) + (cant_1.Text * 1))) / 0.5)
        cant_025.Text = Int((sal - ((cant_20.Text * 20) + (cant_10.Text * 10) + (cant_5.Text * 5) + (cant_1.Text * 1) + (cant_050.Text * 0.5))) / 0.25)
        cant_010.Text = Int((sal - ((cant_20.Text * 20) + (cant_10.Text * 10) + (cant_5.Text * 5) + (cant_1.Text * 1) + (cant_050.Text * 0.5) + (cant_025.Text * 0.25))) / 0.1)
        cant_005.Text = Int((sal - ((cant_20.Text * 20) + (cant_10.Text * 10) + (cant_5.Text * 5) + (cant_1.Text * 1) + (cant_050.Text * 0.5) + (cant_025.Text * 0.25) + (cant_010.Text * 0.1))) / 0.05)
        cant_001.Text = FormatNumber((sal - ((cant_20.Text * 20) + (cant_10.Text * 10) + (cant_5.Text * 5) + (cant_1.Text * 1) + (cant_050.Text * 0.5) + (cant_025.Text * 0.25) + (cant_010.Text * 0.1) + (cant_005.Text * 0.05))) / 0.01, "00")


        mul_20.Text = cant_20.Text * 20
        mul_10.Text = cant_10.Text * 10
        mul_5.Text = cant_5.Text * 5
        mul_1.Text = cant_1.Text * 1

        mul_050.Text = cant_050.Text * 0.5
        mul_025.Text = cant_025.Text * 0.25
        mul_010.Text = cant_010.Text * 0.1
        mul_005.Text = cant_005.Text * 0.05
        mul_001.Text = cant_001.Text * 0.01

        tot = Val(mul_20.Text) + Val(mul_10.Text) + Val(mul_5.Text) + Val(mul_1.Text) + Val(mul_001.Text) + Val(mul_005.Text) + Val(mul_010.Text) + Val(mul_025.Text) + Val(mul_050.Text)

        total.Text = Format(tot, "$##,##0.00")


    End Sub



    Private Sub bill_20_TextChanged(sender As Object, e As EventArgs) Handles bill_20.TextChanged
        b20 = Val(bill_20.Text)
        mul_20.Text = b20 * 20

        total.Text = Val(mul_20.Text) + Val(total.Text)

    End Sub



    Private Sub bill_5_TextChanged(sender As Object, e As EventArgs) Handles bill_5.TextChanged
        b5 = Val(bill_5.Text)
        mul_5.Text = b5 * 5

        total.Text = Val(mul_5.Text) + Val(total.Text)

    End Sub

    Private Sub bill_1_TextChanged(sender As Object, e As EventArgs) Handles bill_1.TextChanged
        b1 = Val(bill_1.Text)
        mul_1.Text = b1 * 1

        total.Text = Val(mul_1.Text) + Val(total.Text)

    End Sub

    Private Sub bill_10_TextChanged(sender As Object, e As EventArgs) Handles bill_10.TextChanged
        b10 = Val(bill_10.Text)

        mul_10.Text = b10 * 10

        total.Text = Val(mul_10.Text) + Val(total.Text)

    End Sub


    Private Sub bill_050_TextChanged(sender As Object, e As EventArgs) Handles bill_050.TextChanged
        b050 = Val(bill_050.Text)

        mul_050.Text = b050 * 0.5

        total.Text = Val(mul_050.Text) + Val(total.Text)

    End Sub


    Private Sub bill_025_TextChanged(sender As Object, e As EventArgs) Handles bill_025.TextChanged

        b025 = Val(bill_025.Text)

        mul_025.Text = b025 * 0.25

        total.Text = Val(mul_025.Text) + Val(total.Text)

    End Sub

    Private Sub bill_010_TextChanged(sender As Object, e As EventArgs) Handles bill_010.TextChanged

        b010 = Val(bill_010.Text)

        mul_010.Text = b010 * 0.1

        total.Text = Val(mul_010.Text) + Val(total.Text)

    End Sub

    Private Sub bill_005_TextChanged(sender As Object, e As EventArgs) Handles bill_005.TextChanged
        b005 = Val(bill_005.Text)

        mul_005.Text = b005 * 0.05

        total.Text = Val(mul_005.Text) + Val(total.Text)
    End Sub





    Private Sub bill_001_TextChanged(sender As Object, e As EventArgs) Handles bill_001.TextChanged
        b001 = Val(bill_001.Text)

        mul_001.Text = b001 * 0.01

        total.Text = Val(mul_001.Text) + Val(total.Text)
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        bill_20.Clear()
        bill_10.Clear()
        bill_5.Clear()
        bill_1.Clear()
        bill_050.Clear()
        bill_025.Clear()
        bill_010.Clear()
        bill_005.Clear()
        bill_001.Clear()

    End Sub

End Class
