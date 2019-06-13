Imports MySql.Data.MySqlClient
Public Class Form6
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim consulta As String

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=sql;database=visual"
            conexion.Open()
            MsgBox("Conectado!!")
            consulta = "select * from registro"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "registro")
            'Datasource para saber de donde estamos sacando los datos!!!
            view.DataSource = datos
            view.DataMember = "registro" 'Se va llenar de la tabla registro
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub regres_Click(sender As Object, e As EventArgs) Handles regres.Click
        Me.Hide()
        Form4.Show()

    End Sub
End Class