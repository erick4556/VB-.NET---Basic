Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=sql;database=cuentasxpagar"
            conexion.Open()
            MsgBox("Conectado!!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim consulta As String
        Dim lista As Byte

        If search.Text <> "" Then

            consulta = "select * from proveedores where idproveedor= '" & search.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)

            datos = New DataSet

            adaptador.Fill(datos, "proveedores")

            lista = datos.Tables("proveedores").Rows.Count

        End If

        If lista <> 0 Then
            nombre.Text = datos.Tables("proveedores").Rows(0).Item("nombre")
            ruc.Text = datos.Tables("proveedores").Rows(0).Item("RUC")
            div.Text = datos.Tables("proveedores").Rows(0).Item("DV")
            telefono.Text = datos.Tables("proveedores").Rows(0).Item("telefono")
            fax.Text = datos.Tables("proveedores").Rows(0).Item("fax")
            direccion.Text = datos.Tables("proveedores").Rows(0).Item("direccion")
            email.Text = datos.Tables("proveedores").Rows(0).Item("email")
            tipproveedor.Text = datos.Tables("proveedores").Rows(0).Item("tipoProveedor")
        Else
            MsgBox("Datos no encontrados")

        End If

        'Compras'

        If search.Text <> "" Then

            consulta = "select * from compras where idproveedor= '" & search.Text & "'"

            adaptador = New MySqlDataAdapter(consulta, conexion)

            datos = New DataSet

            adaptador.Fill(datos, "compras")

            lista = datos.Tables("compras").Rows.Count

        End If

        If lista <> 0 Then
            fecha.Text = datos.Tables("compras").Rows(0).Item("fecha")
            idproduct.Text = datos.Tables("compras").Rows(0).Item("idProducto")
            producto.Text = datos.Tables("compras").Rows(0).Item("producto")
            cantidad.Text = datos.Tables("compras").Rows(0).Item("cantidad")
            costounitario.Text = datos.Tables("compras").Rows(0).Item("costoUnitario")
            tipocompra.Text = datos.Tables("compras").Rows(0).Item("tipoCompra")
            totalcompra.Text = datos.Tables("compras").Rows(0).Item("totalCompra")

        Else
            MsgBox("Datos no encontrados")

        End If

        'Resta con abono'

        If search.Text <> "" Then
            consulta = "select c.totalCompra - (v.total_pagar - v.total_pagado) from compras c inner join ventas v where idproveedor= '" & search.Text & "' and c.cxc = v.cxp"

            adaptador = New MySqlDataAdapter(consulta, conexion)

            datos = New DataSet

            adaptador.Fill(datos, "compras")

            lista = datos.Tables("compras").Rows.Count

            If lista <> 0 Then
                resta.Text = datos.Tables("compras").Rows(0).Item("c.totalCompra - (v.total_pagar - v.total_pagado)")
            End If

        End If

        'Resta sin abono'

        If search.Text <> "" Then
            consulta = "select c.totalCompra - v.total_pagar  from compras c inner join ventas v where idproveedor= '" & search.Text & "' and c.cxc = v.cxp"

            adaptador = New MySqlDataAdapter(consulta, conexion)

            datos = New DataSet

            adaptador.Fill(datos, "compras")

            lista = datos.Tables("compras").Rows.Count

            If lista <> 0 Then
                resta2.Text = datos.Tables("compras").Rows(0).Item("c.totalCompra - v.total_pagar")
            End If

        End If



    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        Dim consulta As String
        Dim consulta2 As String

        If search.Text <> "" Then

            'Inner join'
            consulta = "select p.nombre as Nombre,p.RUC as Ruc, p.DV as DV ,p.telefono as Telefono,p.fax as Fax,p.direccion as Direccion,
            p.email as Email,p.tipoProveedor as TipodeProveedor ,c.fecha as Fecha, c.idProducto as IdProducto,c.producto as Producto,
            c.cantidad as Cantidad, c.costoUnitario as CostxUni, c.totalCompra as TotalCompra, c.tipoCompra as TipoCompra
            from proveedores p inner join compras c on p.idproveedor = c.idproveedor inner join ventas
            where p.idproveedor= '" & search.Text & "' and c.cxc = ventas.cxp"


            adaptador = New MySqlDataAdapter(consulta, conexion)

            datos = New DataSet

            adaptador.Fill(datos, "proveedores")
            gridview.DataMember = datos.Tables(0).TableName
            gridview.DataSource = datos

        End If

        If search.Text <> "" Then

            consulta2 = "select v.nombre as Nombre, v.email as Email, v.nom_articulo as NumArticulo, v.precio as Precio, v.codigo as Codigo,
                v.descripcion as Descripcion, v.cantidad as Cantidad, v.fecha as Fecha, v.total_pagar as TotalPagar, v.total_pagado as TotalPagado
                from ventas v inner join compras c where v.id = '" & search.Text & "' and v.cxp = c.cxc"


            adaptador = New MySqlDataAdapter(consulta2, conexion)

            datos = New DataSet

            adaptador.Fill(datos, "ventas")

            gridview2.DataMember = datos.Tables(0).TableName
            gridview2.DataSource = datos



        End If


    End Sub

End Class
