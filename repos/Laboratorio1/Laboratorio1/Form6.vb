Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Apagamos todas las imagenes.
        pblaptop.Visible = False
        pbtablet.Visible = False
        pbs8.Visible = False
        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            pblaptop.Visible = True
            pbtablet.Visible = False
            pbs8.Visible = False

        End If
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            pbtablet.Visible = True
            pbs8.Visible = False
            pblaptop.Visible = False
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked Then
            pbs8.Visible = True
            pbtablet.Visible = False
            pblaptop.Visible = False
        End If
    End Sub
End Class