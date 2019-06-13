Public Class Form2
    Dim desc As Double
    Dim ace, corr, alin, rev, piez As Double
    Public a, b, c, d, f As Integer
    Public valto, valfin, itbms, recargo, descuento, other1, other2, other3, other4, other5 As Double
    Public cabace, cabcorr, ali, revis, cabapiez As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pasajeros.Visible = False
        taxi.Visible = False
        sedan.Visible = False
        pickup.Visible = False


    End Sub

    Private Sub canace_TextChanged(sender As Object, e As EventArgs) Handles canace.TextChanged
        a = Val(canace.Text)
        If correas.Checked And aline.Checked And piezas.Checked And revisado.Checked Then
            canace.Enabled = False
            aceite.Enabled = False
        Else
            If a > 0 And a <= 1 Then
                aceite.Enabled = True
            Else
                aceite.Enabled = False
            End If

        End If

    End Sub

    Private Sub cantcorr_TextChanged(sender As Object, e As EventArgs) Handles cantcorr.TextChanged
        b = Val(cantcorr.Text)
        If aceite.Checked And aline.Checked And piezas.Checked And revisado.Checked Then
            cantcorr.Enabled = False
            correas.Enabled = False
        Else
            If b > 0 And b <= 4 Then
                correas.Enabled = True
            Else
                correas.Enabled = False
            End If
        End If

    End Sub


    Private Sub canalin_TextChanged(sender As Object, e As EventArgs) Handles canalin.TextChanged
        c = Val(canalin.Text)
        If aceite.Checked And correas.Checked And piezas.Checked And revisado.Checked Then
            canalin.Enabled = False
            aline.Enabled = False
        Else
            If c > 0 And c <= 1 Then
                aline.Enabled = True
            Else
                aline.Enabled = False
            End If
        End If

    End Sub

    Private Sub canrev_TextChanged(sender As Object, e As EventArgs) Handles canrev.TextChanged
        d = Val(canrev.Text)
        If aceite.Checked And correas.Checked And aline.Checked And piezas.Checked Then
            canrev.Enabled = False
            revisado.Enabled = False
        Else

            If d > 0 And d <= 1 Then
                revisado.Enabled = True
            Else
                revisado.Enabled = False
            End If
        End If

    End Sub


    Private Sub canpiez_TextChanged(sender As Object, e As EventArgs) Handles canpiez.TextChanged
        f = Val(canpiez.Text)
        If aceite.Checked And correas.Checked And aline.Checked And revisado.Checked Then
            canpiez.Enabled = False
            piezas.Enabled = False
        Else
            If f > 0 And f <= 5 Then
                piezas.Enabled = True
            Else
                piezas.Enabled = False
            End If
        End If

    End Sub


    Private Sub aceite_CheckedChanged(sender As Object, e As EventArgs) Handles aceite.CheckedChanged
        cabace = "Cambio de aceite"

        If aceite.Checked Then

            valto = canace.Text * 15

            other1 = canace.Text * 15

            total.Text = valto + Val(total.Text)

        Else
            total.Text = total.Text - valto
        End If




    End Sub



    Private Sub correas_CheckedChanged(sender As Object, e As EventArgs) Handles correas.CheckedChanged
        cabcorr = "Cambio de correas"

        If correas.Checked Then

            valto = cantcorr.Text * 25

            other2 = cantcorr.Text * 25

            total.Text = valto + Val(total.Text)
        Else
            total.Text = total.Text - valto

        End If



    End Sub

    Private Sub aline_CheckedChanged(sender As Object, e As EventArgs) Handles aline.CheckedChanged

        ali = "Alineamiento"

        If aline.Checked Then
            valto = canalin.Text * 30

            other3 = canalin.Text * 30

            total.Text = valto + Val(total.Text)
        Else
            total.Text = total.Text - valto

        End If



    End Sub


    Private Sub revisado_CheckedChanged(sender As Object, e As EventArgs) Handles revisado.CheckedChanged
        revis = "Revisado Vehicular"

        If revisado.Checked Then

            valto = canrev.Text * 40

            other4 = canrev.Text * 40

            total.Text = valto + Val(total.Text)
        Else
            total.Text = total.Text - valto

        End If


    End Sub

    Private Sub piezas_CheckedChanged(sender As Object, e As EventArgs) Handles piezas.CheckedChanged

        cabapiez = "Cambio de piezas"

        If piezas.Checked Then

            valto = canpiez.Text * 35

            other5 = canpiez.Text * 35

            total.Text = valto + Val(total.Text)
        Else
            total.Text = total.Text - valto

        End If


    End Sub

    Private Sub combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo.SelectedIndexChanged
        If combo.SelectedIndex = 0 Then
            pasajeros.Visible = False
            taxi.Visible = False
            sedan.Visible = True
            pickup.Visible = False
            desc = 0.025

        ElseIf combo.SelectedIndex = 1 Then
            pasajeros.Visible = False
            taxi.Visible = False
            sedan.Visible = False
            pickup.Visible = True
            desc = 0.03

        ElseIf combo.SelectedIndex = 2 Then
            pasajeros.Visible = True
            taxi.Visible = True
            sedan.Visible = False
            pickup.Visible = False
            desc = 0.035

        ElseIf combo.SelectedIndex = 3 Then
            pasajeros.Visible = True
            taxi.Visible = False
            sedan.Visible = False
            pickup.Visible = False
            desc = 0.05

        End If
    End Sub



    Private Sub efectivo_CheckedChanged(sender As Object, e As EventArgs) Handles efectivo.CheckedChanged
        If efectivo.Checked Then
            itbms = total.Text * 0.07
            valfin = total.Text * 1.07
            final.Text = valfin
        End If
    End Sub


    Private Sub cheque_CheckedChanged(sender As Object, e As EventArgs) Handles cheque.CheckedChanged
        If cheque.Checked Then
            'itbms = total.Text * 0.07
            descuento = total.Text * desc
            valfin = (total.Text - descuento) * 1.07
            itbms = valfin * 0.07
            'valfin = (total.Text - (total.Text * desc)) * 1.07
            final.Text = valfin
        End If
    End Sub

    Private Sub tarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles tarjeta.CheckedChanged
        If tarjeta.Checked Then
            ' itbms = total.Text * 0.07
            recargo = total.Text * 0.0575
            descuento = total.Text * desc
            valfin = ((total.Text - descuento) + recargo) * 1.07
            itbms = valfin * 0.07
            ' valfin = (Val(total.Text) + (total.Text * 0.0575)) * 1.07
            final.Text = valfin
        End If
    End Sub





    Private Sub env_Click(sender As Object, e As EventArgs) Handles env.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        canace.Clear()
        cantcorr.Clear()
        canalin.Clear()
        canrev.Clear()
        canpiez.Clear()



        combo.Text = ""
        efectivo.Checked = False
        cheque.Checked = False
        tarjeta.Checked = False

        aline.Checked = False
        aceite.Checked = False
        correas.Checked = False
        revisado.Checked = False
        piezas.Checked = False

    End Sub

End Class