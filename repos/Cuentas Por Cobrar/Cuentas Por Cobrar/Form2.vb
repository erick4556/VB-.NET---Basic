Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub crear_Click(sender As Object, e As EventArgs) Handles crear.Click
        Try
            If nombre.Text <> "" And cedula.Text <> "" And email.Text <> "" And telefono.Text <> "" And direccion.Text <> "" Then
                Dim sql As String
                Dim id As Integer
                Dim comando As MySqlCommand
                Dim conexion As New MySqlConnectionStringBuilder()
                conexion.Server = "localhost"
                conexion.UserID = "root"
                conexion.Password = "sql"
                conexion.Database = "cuentasXpagar"
                Dim con As New MySqlConnection(conexion.ToString())


                con.Open()
                sql = "INSERT INTO clientes (nombre,cedula,email,telefono,direccion) VALUES(@nombre,@cedula,@email,@telefono,@direccion)"
                comando = New MySqlCommand(sql, con)
                '  id = 1
                ' comando.Parameters.AddWithValue("@id_cliente", id)

                comando.Parameters.AddWithValue("@nombre", nombre.Text)
                comando.Parameters.AddWithValue("@cedula", cedula.Text)
                comando.Parameters.AddWithValue("@email", email.Text)
                comando.Parameters.AddWithValue("@telefono", telefono.Text)
                comando.Parameters.AddWithValue("@direccion", direccion.Text)
                comando.ExecuteNonQuery()
                Form1.Show()
            Else
                MsgBox("LLENAR TODOS LOS CAMPOS")
                'MsgBox("NOS CONECTAMOS PAPU")'
            End If

        Catch ex As Exception

            MsgBox("ERROR DE CONEXION A BASE DE DATOS = " & ex.Message)

        End Try
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Form1.Show()

    End Sub
End Class