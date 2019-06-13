Imports MySql.Data.MySqlClient
Public Class Form3
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim consulta As String
    Dim lista As Byte


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub data_Click(sender As Object, e As EventArgs) Handles data.Click
        If buscar.Text <> "" Then
            consulta = "select * from registro where id= '" & buscar.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "registro")
            lista = datos.Tables("registro").Rows.Count

        End If

        If lista <> 0 Then
            view.DataSource = datos
            view.DataMember = "registro"
            'view.Refresh()
        Else
            MsgBox("Datos no encontrados")

        End If
    End Sub

    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Me.Hide()
        Form4.Show()

    End Sub
End Class