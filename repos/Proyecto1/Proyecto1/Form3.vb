Public Class Form3
    Dim salario As Double
    Dim valprestamo As Double


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        salario = Val(Form1.salario.Text)
        valprestamo = Val(Form2.valprestamo.Text)

        nombre.Text = Form1.nombre.Text
        cedula.Text = Form1.cedula.Text
        telefono.Text = Form1.telefono.Text
        email.Text = Form1.email.Text
        cotizacion.Text = Form1.cotizacion.Text
        salmen.Text = Format(salario, "$##,##0.00")
        empresa.Text = Form1.tipoempresa.Text
        prestamo.Text = Format(valprestamo, "$##,##0.00")
        plazo.Text = Form2.plazo.Text
        interes.Text = Format(Form2.interestot, "$##,##0.00")
        valcomision.Text = Format(Form2.valcomision, "$##,##0.00")
        deudtotal.Text = Format(Form2.deudto, "$##,##0.00")
        letramen.Text = Format(Form2.letramen, "$##,##0.00")

    End Sub


    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Close()
    End Sub

End Class