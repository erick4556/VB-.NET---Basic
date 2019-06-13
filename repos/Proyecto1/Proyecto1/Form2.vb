Public Class Form2
    Dim vprest As Double

    Dim interes As Double

    Public valcomision As Double

    Public deudto As Double

    Public letramen As Double

    Dim plazopag As Integer

    Public interestot As Double

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        person.Visible = False
        viviendas.Visible = False
        turismo.Visible = False
        estudios.Visible = False
        autos.Visible = False

        If valprestamo.Text = "" Then
            grupobox.Enabled = False
        End If
    End Sub

    Private Sub valprestamo_TextChanged(sender As Object, e As EventArgs) Handles valprestamo.TextChanged
        vprest = Val(valprestamo.Text)


        valcomision = vprest * 0.1675


        If vprest >= 1000 And vprest <= 5000 Then
            grupobox.Enabled = True
        Else
            grupobox.Enabled = False

        End If

    End Sub


    Private Sub rb1_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            person.Visible = True
            viviendas.Visible = False
            turismo.Visible = False
            estudios.Visible = False
            autos.Visible = False

            interes = vprest * 0.0325
        End If
    End Sub

    Private Sub rb2_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            person.Visible = False
            viviendas.Visible = True
            turismo.Visible = False
            estudios.Visible = False
            autos.Visible = False

            interes = vprest * 0.0475

        End If
    End Sub

    Private Sub rb3_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked Then
            person.Visible = False
            viviendas.Visible = False
            turismo.Visible = True
            estudios.Visible = False
            autos.Visible = False

            interes = vprest * 0.055
        End If

    End Sub

    Private Sub rb4_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked Then
            person.Visible = False
            viviendas.Visible = False
            turismo.Visible = False
            estudios.Visible = True
            autos.Visible = False

            interes = vprest * 0.0675

        End If
    End Sub

    Private Sub rb5_CheckedChanged_1(sender As Object, e As EventArgs) Handles rb5.CheckedChanged
        If rb5.Checked Then
            person.Visible = False
            viviendas.Visible = False
            turismo.Visible = False
            estudios.Visible = False
            autos.Visible = True

            interes = vprest * 0.0725

        End If
    End Sub

    Private Sub plazo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles plazo.SelectedIndexChanged
        If plazo.SelectedIndex = 0 Then
            plazopag = 18

            interestot = interes * plazopag
            deudto = vprest + (interestot + valcomision)
            letramen = deudto / plazopag


        ElseIf plazo.SelectedIndex = 1 Then
            plazopag = 36

            interestot = interes * plazopag
            deudto = vprest + (interestot + valcomision)
            letramen = deudto / plazopag

        ElseIf plazo.SelectedIndex = 2 Then
            plazopag = 50

            interestot = interes * plazopag
            deudto = vprest + (interestot + valcomision)
            letramen = deudto / plazopag


        ElseIf plazo.SelectedIndex = 3 Then
            plazopag = 60

            interestot = interes * plazopag
            deudto = vprest + (interestot + valcomision)
            letramen = deudto / plazopag


        End If
    End Sub

    Private Sub limp_Click(sender As Object, e As EventArgs) Handles limp.Click

        valprestamo.Text = ""

        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
        rb4.Checked = False
        rb5.Checked = False
        plazo.Text = ""

    End Sub

    Private Sub regres_Click(sender As Object, e As EventArgs) Handles regres.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub env_Click(sender As Object, e As EventArgs) Handles env.Click
        If Form1.cappago >= letramen Then

            MsgBox("Felicidades su préstamos ha sido aprobado!!!")
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("NO tiene capacidad de pago!!!")
            Me.Hide()
            Form1.Show()
        End If
    End Sub


End Class