Imports MySql.Data.MySqlClient
Public Class Form9

    Dim str As String = "server=localhost; uid=root; pwd=sql; database=bdseguros"
    Dim con As New MySqlConnection(str)
    Dim poliza, valter1, letra As Double
    Dim cedula1 As String



    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()


    End Sub

    Sub load()
        Dim query As String = "select * from terreno"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        terreno.Clear()
        valm2.Clear()
        valter.Text = "XXXX"
        polizaviv.Text = "XXXX"
        plazop.Clear()
        letram.Text = "XXXX"
        cedula1 = ""


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            terreno.Text = row.Cells(2).Value.ToString()
            valm2.Text = row.Cells(3).Value.ToString()
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

            cmd.CommandText = "update terreno set terreno=@terreno, valm2=@valm2, valter=@valter,polizaviv=@polizaviv,plazop=@plazop,letram=@letram where cedula=@cedula;"

            cmd.Parameters.AddWithValue("@cedula", cedula1)
            cmd.Parameters.AddWithValue("@terreno", terreno.Text)
            cmd.Parameters.AddWithValue("@valm2", valm2.Text)
            cmd.Parameters.AddWithValue("@valter", valter1)
            cmd.Parameters.AddWithValue("@polizaviv", poliza)
            cmd.Parameters.AddWithValue("@plazop", plazop.Text)
            cmd.Parameters.AddWithValue("@letram", letra)

            cmd.ExecuteNonQuery()
            load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub valm2_TextChanged(sender As Object, e As EventArgs) Handles valm2.TextChanged

        valter1 = terreno.Text * Val(valm2.Text)

        valter.Text = valter1

        poliza = valter.Text * 0.8

        polizaviv.Text = Format(poliza, "$##,##0.00")

    End Sub


    Private Sub plazop_TextChanged(sender As Object, e As EventArgs) Handles plazop.TextChanged

        If Val(plazop.Text) >= 1 And Val(plazop.Text) <= 24 Then

            letra = poliza / Val(plazop.Text)
            letram.Text = Format(poliza / Val(plazop.Text), "$##,##0.00")
        Else

            letram.Text = "$0.00"
        End If



    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from terreno where cedula=@cedula;"
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
            adapater = New MySqlDataAdapter("select * from terreno where cedula like '%" & txtsearch.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
            terreno.Clear()
            valm2.Clear()
            valter.Text = "XXXX"
            polizaviv.Text = "XXXX"
            plazop.Clear()
            letram.Text = "XXXX"
            cedula1 = ""
        Catch ex As Exception

        End Try


    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Hide()
        Form7.Show()

    End Sub

End Class