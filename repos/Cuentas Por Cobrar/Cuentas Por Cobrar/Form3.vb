Imports MySql.Data.MySqlClient

Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()


    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim consulta As String
        Dim lista As Byte
        Try

            Dim conexion As New MySqlConnectionStringBuilder()
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = "sql"
            conexion.Database = "cuentasXpagar"
            Dim adaptador As MySqlDataAdapter
            Dim datos As DataSet
            Dim con As New MySqlConnection(conexion.ToString())
            If cedula.Text <> "" Then
                consulta = "SELECT * FROM clientes WHERE cedula = '" + cedula.Text + "' "
                adaptador = New MySqlDataAdapter(consulta, conexion.ToString)
                datos = New DataSet
                adaptador.Fill(datos, "clientes")
                lista = datos.Tables("clientes").Rows.Count

                If lista <> 0 Then
                    nombre.Text = datos.Tables("clientes").Rows(0).Item("nombre")
                    telefono.Text = datos.Tables("clientes").Rows(0).Item("telefono")
                    direccion.Text = datos.Tables("clientes").Rows(0).Item("direccion")
                    email.Text = datos.Tables("clientes").Rows(0).Item("email")
                    cedula_sin.Text = datos.Tables("clientes").Rows(0).Item("cedula")
                Else
                    MsgBox("NO SE ENCONTRARON REGISTROS")
                End If

            End If
        Catch ex As Exception

            MsgBox("ERROR DE CONEXION A BASE DE DATOS = " & ex.Message)

        End Try


    End Sub

    Private Sub crear_cargo_Click(sender As Object, e As EventArgs) Handles crear_cargo.Click
        Try
            If nom_articulo.Text <> "" And precio.Text <> "" And descripcion.Text <> "" And codigo.Text <> "" And fecha.Text <> "" And cantidad.Text <> "" Then
                Dim sql As String
                Dim total_pagar As Double
                Dim total_pagado As Double
                Dim id As Integer
                Dim comando As MySqlCommand
                Dim conexion As New MySqlConnectionStringBuilder()
                conexion.Server = "localhost"
                conexion.UserID = "root"
                conexion.Password = "sql"
                conexion.Database = "cuentasXpagar"
                Dim con As New MySqlConnection(conexion.ToString())


                con.Open()
                sql = "INSERT INTO ventas (nombre,cedula,email,nom_articulo,precio,codigo,descripcion,cantidad,fecha,total_pagar,total_pagado) VALUES(@nombre,@cedula,@email,@nom_articulo,@precio,@codigo,@descripcion,@cantidad,@fecha,@total_pagar,@total_pagado)"
                comando = New MySqlCommand(sql, con)
                id = 1
                comando.Parameters.AddWithValue("@id", id)

                comando.Parameters.AddWithValue("@nombre", nombre.Text)
                comando.Parameters.AddWithValue("@cedula", cedula_sin.Text)
                comando.Parameters.AddWithValue("@email", email.Text)

                comando.Parameters.AddWithValue("@nom_articulo", nom_articulo.Text)
                comando.Parameters.AddWithValue("@precio", precio.Text)
                comando.Parameters.AddWithValue("@codigo", codigo.Text)
                comando.Parameters.AddWithValue("@descripcion", descripcion.Text)
                comando.Parameters.AddWithValue("@cantidad", cantidad.Text)
                comando.Parameters.AddWithValue("@fecha", fecha.Text)
                total_pagar = Val(cantidad.Text) * Val(precio.Text)
                comando.Parameters.AddWithValue("@total_pagar", total_pagar)
                total_pagado = 0
                comando.Parameters.AddWithValue("@total_pagado", total_pagado)
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

    Private Sub cedula_TextChanged(sender As Object, e As EventArgs) Handles cedula.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class