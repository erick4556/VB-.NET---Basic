Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=sql;database=visual"
            conexion.Open()
            MsgBox("Conectado!!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        Try
            comandos = New MySqlCommand("INSERT INTO registro(nombre,direccion)" & Chr(13) &
                                        "VALUES(@nombre,@direccion)", conexion)
            'Agregar los valores'
            comandos.Parameters.AddWithValue("@nombre", nombre.Text)
            comandos.Parameters.AddWithValue("@direccion", direccion.Text)
            'Lo siguiente es para que solo envie los datos, no necesitamos que retorne algun dato'
            comandos.ExecuteNonQuery()

            MsgBox("Datos Guardados!!")

            nombre.Text = ""
            direccion.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub regres_Click(sender As Object, e As EventArgs) Handles regres.Click
        Me.Hide()
        Form4.Show()

    End Sub
End Class
