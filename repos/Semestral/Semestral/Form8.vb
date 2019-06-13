Imports MySql.Data.MySqlClient
Public Class Form8
    Dim str As String = "server=localhost; uid=root; pwd=sql; database=bdseguros"
    Dim con As New MySqlConnection(str)
    Dim cedula1, id As String


    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load()

    End Sub
    Sub load()
        Dim query As String = "SELECT c_t.id,c.cedula, c.nombre,c.sexo , c.direccion, c.contacto, c.tipcomp , c_t.tiposeg 
                               From tabpoliza c
                               INNER JOIN cliente_tiposeg c_t  ON (c_t.cedula=c.cedula)  
                               ORDER by c_t.cedula"

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        nombre.Clear()
        sexo.Clear()
        direccion.Clear()
        telefono.Clear()
        tipo_empresa.Clear()
        tipo_seguro.Clear()

        cedula1 = ""
        id2.Text = ""


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            id2.Text = row.Cells(0).Value.ToString()
            cedula1 = row.Cells(1).Value.ToString()
            nombre.Text = row.Cells(2).Value.ToString()
            sexo.Text = row.Cells(3).Value.ToString()
            direccion.Text = row.Cells(4).Value.ToString()
            telefono.Text = row.Cells(5).Value.ToString()
            tipo_empresa.Text = row.Cells(6).Value.ToString()
            tipo_seguro.Text = row.Cells(7).Value.ToString()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As MySqlCommand
        Dim cmd2 As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd2 = con.CreateCommand()


            cmd.CommandText = " UPDATE tabpoliza 
                                SET  nombre=@nombre, sexo=@sexo ,direccion =@direccion , contacto=@telefono, tipcomp=@tipo_empresa   
                                 WHERE cedula=@cedula
                                
                               ;"
            cmd2.CommandText = " UPDATE cliente_tiposeg
                                SET  tiposeg=@tipo_seguro
                                 WHERE id=@id2 AND cedula=@cedula
                      
                               ;"


            cmd.Parameters.AddWithValue("@id2", id2.Text)
            cmd.Parameters.AddWithValue("@cedula", cedula1)
            cmd.Parameters.AddWithValue("@nombre", nombre.Text)
            cmd.Parameters.AddWithValue("@sexo", sexo.Text)
            cmd.Parameters.AddWithValue("@direccion", direccion.Text)
            cmd.Parameters.AddWithValue("@telefono", telefono.Text)
            cmd.Parameters.AddWithValue("@tipo_empresa", tipo_empresa.Text)
            cmd.Parameters.AddWithValue("@tipo_seguro", tipo_seguro.Text)

            cmd2.Parameters.AddWithValue("@id2", id2.Text)
            cmd2.Parameters.AddWithValue("@cedula", cedula1)
            cmd2.Parameters.AddWithValue("@tipo_seguro", tipo_seguro.Text)

            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from tabpoliza where cedula=@cedula;"
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
            adapater = New MySqlDataAdapter("SELECT c_t.id ,c.cedula, c.nombre,c.sexo , c.direccion, c.contacto, c.tipcomp , c_t.tiposeg 
                               From tabpoliza c
                               INNER JOIN cliente_tiposeg c_t  ON (c_t.cedula=c.cedula)  
                               where c.cedula like '%" & txtsearch.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
            nombre.Clear()
            sexo.Clear()
            direccion.Clear()
            telefono.Clear()
            tipo_empresa.Clear()
            tipo_seguro.Clear()

            cedula1 = ""
            id = ""
        Catch ex As Exception

        End Try


    End Sub


    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Hide()
        Form7.Show()

    End Sub


End Class