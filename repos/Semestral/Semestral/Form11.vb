Imports MySql.Data.MySqlClient
Public Class Form11

    Dim str As String = "server=localhost; uid=root; pwd=sql; database=bdseguros"
    Dim con As New MySqlConnection(str)
    Dim cedula1 As String
    Dim poliza, letra As Double

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Sub load()
        Dim query As String = "select * from vida"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        edad.Clear()
        valaseg.Clear()
        polivida.Text = "XXXX"
        plazop.Clear()
        letram.Text = "XXXX"
        cedula1 = ""


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            edad.Text = row.Cells(2).Value.ToString()
            valaseg.Text = row.Cells(3).Value.ToString()
            plazop.Text = row.Cells(5).Value.ToString()
            cedula1 = row.Cells(1).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()

            cmd.CommandText = "update vida set edad=@edad, valaseg=@valaseg, polivida=@polivida,plazop=@plazop,letramen=@letramen where cedula=@cedula;"

            cmd.Parameters.AddWithValue("@cedula", cedula1)
            cmd.Parameters.AddWithValue("@edad", edad.Text)
            cmd.Parameters.AddWithValue("@valaseg", valaseg.Text)
            cmd.Parameters.AddWithValue("@polivida", poliza)
            cmd.Parameters.AddWithValue("@plazop", plazop.Text)
            cmd.Parameters.AddWithValue("@letramen", letra)


            cmd.ExecuteNonQuery()

            load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from vida where cedula=@cedula;"
            cmd.Parameters.AddWithValue("@cedula", cedula1)
            cmd.ExecuteNonQuery()
            load()
        Catch ex As Exception

        End Try
    End Sub






    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        Dim adapater As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapater = New MySqlDataAdapter("select * from vida where cedula like '%" & txtsearch.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

            edad.Clear()
            valaseg.Clear()
            polivida.Text = "XXXX"
            plazop.Clear()
            letram.Text = "XXXX"
            letram.Text = "XXXX"
            cedula1 = ""

        Catch ex As Exception

        End Try


    End Sub





    Private Sub edad_TextChanged(sender As Object, e As EventArgs) Handles edad.TextChanged
        If Val(edad.Text) >= 18 Then
            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If
    End Sub


    Private Sub valaseg_TextChanged(sender As Object, e As EventArgs) Handles valaseg.TextChanged


        If edad.Text >= 18 And edad.Text <= 30 Then

            poliza = Val(valaseg.Text) * 0.81

            polivida.Text = Format(poliza, "$##,##0.00")

        ElseIf edad.Text >= 31 And edad.Text <= 45 Then

            poliza = Val(valaseg.Text) * 0.73

            polivida.Text = Format(poliza, "$##,##0.00")

        ElseIf edad.Text >= 46 And edad.Text <= 57 Then

            poliza = Val(valaseg.Text) * 0.62

            polivida.Text = Format(poliza, "$##,##0.00")

        ElseIf edad.Text > 57 Then

            poliza = Val(valaseg.Text) * 0.44

            polivida.Text = Format(poliza, "$##,##0.00")

        End If

    End Sub


    Private Sub plazop_TextChanged(sender As Object, e As EventArgs) Handles plazop.TextChanged

        If Val(plazop.Text) >= 1 And Val(plazop.Text) <= 24 Then
            btnUpdate.Enabled = True
            letra = poliza / Val(plazop.Text)
            letram.Text = Format(poliza / Val(plazop.Text), "$##,##0.00")
        Else
            btnUpdate.Enabled = False
            letram.Text = "$0.00"
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form7.Show()

    End Sub


End Class