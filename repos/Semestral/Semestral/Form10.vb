Imports MySql.Data.MySqlClient
Public Class Form10

    Dim str As String = "server=localhost; uid=root; pwd=sql; database=bdseguros"
    Dim con As New MySqlConnection(str)
    Dim cedula1 As String
    Dim poliza, letra As Double

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub

    Sub load()
        Dim query As String = "select * from auto"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        aauto.Clear()
        placa.Clear()
        valauto.Clear()

        poliauto.Text = "XXXX"
        plazop.Clear()
        letram.Text = "XXXX"
        cedula1 = ""


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try




            aauto.Text = row.Cells(2).Value.ToString()
            placa.Text = row.Cells(3).Value.ToString()
            valauto.Text = row.Cells(4).Value.ToString()
            plazop.Text = row.Cells(6).Value.ToString()
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

            cmd.CommandText = "update auto set aauto=@aauto, placa=@placa, valauto=@valauto,poliauto=@poliauto,plazop=@plazop,letramen=@letramen where cedula=@cedula;"

            cmd.Parameters.AddWithValue("@cedula", cedula1)
            cmd.Parameters.AddWithValue("@aauto", aauto.Text)
            cmd.Parameters.AddWithValue("@placa", placa.Text)
            cmd.Parameters.AddWithValue("@valauto", valauto.Text)
            cmd.Parameters.AddWithValue("@poliauto", poliza)
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
            cmd.CommandText = "delete from auto where cedula=@cedula;"
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
            adapater = New MySqlDataAdapter("select * from auto where cedula like '%" & txtsearch.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
            aauto.Clear()
            placa.Clear()
            valauto.Clear()

            poliauto.Text = "XXXX"
            plazop.Clear()
            letram.Text = "XXXX"
            cedula1 = ""
        Catch ex As Exception

        End Try


    End Sub


    Private Sub aauto_TextChanged(sender As Object, e As EventArgs) Handles aauto.TextChanged

        If Val(aauto.Text) >= 2007 And Val(aauto.Text) <= 2017 Then
            btnUpdate.Enabled = True

        Else

            btnUpdate.Enabled = False

        End If
    End Sub

    Private Sub valauto_TextChanged(sender As Object, e As EventArgs) Handles valauto.TextChanged

        poliza = Val(valauto.Text) * 0.4

        poliauto.Text = Format(poliza, "$##,##0.00")

    End Sub


    Private Sub plazop_TextChanged(sender As Object, e As EventArgs) Handles plazop.TextChanged

        If Val(plazop.Text) >= 1 And Val(plazop.Text) <= 8 Then

            letra = poliza / Val(plazop.Text)
            letram.Text = Format(poliza / Val(plazop.Text), "$##,##0.00")
        Else

            letram.Text = "$0.00"
        End If


    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Hide()
        Form7.Show()

    End Sub


End Class