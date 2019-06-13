Public Class Form3

    Dim valortotal As Double

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        valortotal = Val(Form2.total.Text)

        nombre.Text = Form1.nombre.Text
        placa.Text = Form1.placa.Text
        profesion.Text = Form1.profesion.Text
        telefono.Text = Form1.telefono.Text
        email.Text = Form1.email.Text
        carro.Text = Form2.combo.Text
        itbms.Text = Format(Form2.itbms, "$##,##0.00")
        descuento.Text = Format(Form2.descuento, "$##,##0.00")
        recargo.Text = Format(Form2.recargo, "$##,##0.00")
        valtot.Text = Format(valortotal, "$##,##0.00")
        valfinal.Text = Format(Form2.valfin, "$##,##0.00")
        tipcan.Text = Form2.a & "   " & Form2.cabace & "   " & Format(Form2.other1, "$##,##0.00")
        tipcan2.Text = Form2.b & "   " & Form2.cabcorr & "   " & Format(Form2.other2, "$##,##0.00")
        tipcan3.Text = Form2.c & "   " & Form2.ali & "   " & Format(Form2.other3, "$##,##0.00")
        tipcan4.Text = Form2.d & "   " & Form2.revis & "   " & Format(Form2.other4, "$##,##0.00")
        tipcan5.Text = Form2.f & "   " & Form2.cabapiez & "   " & Format(Form2.other5, "$##,##0.00")

    End Sub

End Class