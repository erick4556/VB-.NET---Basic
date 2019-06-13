Imports MySql.Data.MySqlClient
Public Class Form5
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim consulta As String
    Dim lista As Byte

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=sql;database=visual"
            conexion.Open()
            MsgBox("Conectado!!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If buscar.Text <> "" Then
            consulta = "select * from registro where id= '" & buscar.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "registro")
            lista = datos.Tables("registro").Rows.Count

        End If

        If lista <> 0 Then
            nombre.Text = datos.Tables("registro").Rows(0).Item("nombre")
            address.Text = datos.Tables("registro").Rows(0).Item("direccion")
        Else
            MsgBox("Datos no encontrados")

        End If
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim elim As String
        Dim si As Byte

        si = MsgBox("Desea eliminar?", vbYesNo, "Eliminar")

        If si = 6 Then
            elim = "delete from registro where id = '" & buscar.Text & "'"
            comandos = New MySqlCommand(elim, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Eliminado")

            buscar.Clear()
            nombre.Clear()
            address.Clear()

        End If

    End Sub

    Private Sub regres_Click(sender As Object, e As EventArgs) Handles regres.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        Dim update As String

        update = "update registro set nombre = '" & nombre.Text & "', direccion = '" & address.Text & "' where id = '" & buscar.Text & "'"

        comandos = New MySqlCommand(update, conexion)

        comandos.ExecuteNonQuery()

        MsgBox("Registro actualizado")

        buscar.Clear()
        nombre.Clear()
        address.Clear()

    End Sub
End Class