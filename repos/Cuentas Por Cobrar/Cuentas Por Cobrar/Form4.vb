Imports MySql.Data.MySqlClient
Public Class Form4
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim consulta As String
        Dim lista As Byte
        Dim restant As Double
        Try

            Dim conexion As New MySqlConnectionStringBuilder()
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = "sql"
            conexion.Database = "cuentasXpagar"
            Dim adaptador As MySqlDataAdapter
            Dim datos As DataSet
            Dim con As New MySqlConnection(conexion.ToString())
            If codigo.Text <> "" Then
                consulta = "SELECT * FROM ventas WHERE codigo = '" + codigo.Text + "' "
                adaptador = New MySqlDataAdapter(consulta, conexion.ToString)
                datos = New DataSet
                adaptador.Fill(datos, "ventas")
                lista = datos.Tables("ventas").Rows.Count

                If lista <> 0 Then
                    'Detalles Cliente'
                    nombre.Text = datos.Tables("ventas").Rows(0).Item("nombre")
                    email.Text = datos.Tables("ventas").Rows(0).Item("email")
                    cedula.Text = datos.Tables("ventas").Rows(0).Item("cedula")
                    descripcion.Text = datos.Tables("ventas").Rows(0).Item("descripcion")
                    fecha.Text = datos.Tables("ventas").Rows(0).Item("fecha")
                    nom_articulo.Text = datos.Tables("ventas").Rows(0).Item("nom_articulo")
                    codigo_sin.Text = datos.Tables("ventas").Rows(0).Item("codigo")


                    'Detalles de la Factura(pagos)'

                    total_pagar.Text = datos.Tables("ventas").Rows(0).Item("total_pagar")
                    total_pagado.Text = datos.Tables("ventas").Rows(0).Item("total_pagado")

                    restant = (Val(total_pagar.Text) - Val(total_pagado.Text))


                    restante.Text = restant

                Else
                    MsgBox("NO SE ENCONTRARON REGISTROS")
                End If

            End If
        Catch ex As Exception

            MsgBox("ERROR DE CONEXION A BASE DE DATOS = " & ex.Message)

        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim conexion As New MySqlConnectionStringBuilder()
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = "sql"
            conexion.Database = "cuentasXpagar"
            Dim con As New MySqlConnection(conexion.ToString())
            Dim actualizar As String
            Dim comandos As MySqlCommand
            Dim total As Double
            total = Val(total_pagado.Text) + Val(pago.Text)
            con.Open()
            actualizar = "UPDATE ventas SET total_pagado ='" + total.ToString + "' WHERE codigo ='" + codigo_sin.Text + "' "
            comandos = New MySqlCommand(actualizar, con)

            comandos.ExecuteNonQuery()
            con.Close()
            MsgBox("Registro De Pago Exitoso!!!")
            Form1.Show()


        Catch ex As Exception

            MsgBox("ERROR DE CONEXION A BASE DE DATOS = " & ex.Message)

        End Try
    End Sub
End Class