Imports MySql.Data.MySqlClient

Public Class Form2

    Dim conexion As New MySqlConnection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=sql;database=visual"
            conexion.Open()
            MsgBox("Conectado!!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class