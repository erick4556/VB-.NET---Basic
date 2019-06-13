<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.idproduct = New System.Windows.Forms.Label()
        Me.producto = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.Label()
        Me.costounitario = New System.Windows.Forms.Label()
        Me.tipocompra = New System.Windows.Forms.Label()
        Me.totalcompra = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ruc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.div = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.fax = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tipproveedor = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.Button()
        Me.gridview = New System.Windows.Forms.DataGridView()
        Me.view = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nom2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.email2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nomartic = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cantidad2 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.fecha2 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.totalpagar = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.totalpagado = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.gridview2 = New System.Windows.Forms.DataGridView()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.resta = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.resta2 = New System.Windows.Forms.Label()
        CType(Me.gridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(451, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consolidacion de Cuentas"
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(335, 114)
        Me.search.Multiline = True
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(192, 31)
        Me.search.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(43, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese id Proveedor: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(43, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(43, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 520)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Id de Producto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(492, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Producto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(492, 450)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 29)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Cantidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(492, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 29)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Costo Unitario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(819, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 29)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Tipo de Compra:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(815, 525)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 29)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Total de Compra:"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.Black
        Me.nombre.Location = New System.Drawing.Point(161, 263)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(19, 27)
        Me.nombre.TabIndex = 11
        Me.nombre.Text = "."
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.Black
        Me.fecha.Location = New System.Drawing.Point(138, 450)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(19, 27)
        Me.fecha.TabIndex = 12
        Me.fecha.Text = "."
        '
        'idproduct
        '
        Me.idproduct.AutoSize = True
        Me.idproduct.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idproduct.ForeColor = System.Drawing.Color.Black
        Me.idproduct.Location = New System.Drawing.Point(239, 522)
        Me.idproduct.Name = "idproduct"
        Me.idproduct.Size = New System.Drawing.Size(19, 27)
        Me.idproduct.TabIndex = 13
        Me.idproduct.Text = "."
        '
        'producto
        '
        Me.producto.AutoSize = True
        Me.producto.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.producto.ForeColor = System.Drawing.Color.Black
        Me.producto.Location = New System.Drawing.Point(624, 265)
        Me.producto.Name = "producto"
        Me.producto.Size = New System.Drawing.Size(19, 27)
        Me.producto.TabIndex = 14
        Me.producto.Text = "."
        '
        'cantidad
        '
        Me.cantidad.AutoSize = True
        Me.cantidad.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.ForeColor = System.Drawing.Color.Black
        Me.cantidad.Location = New System.Drawing.Point(624, 451)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(19, 27)
        Me.cantidad.TabIndex = 15
        Me.cantidad.Text = "."
        '
        'costounitario
        '
        Me.costounitario.AutoSize = True
        Me.costounitario.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costounitario.ForeColor = System.Drawing.Color.Black
        Me.costounitario.Location = New System.Drawing.Point(684, 522)
        Me.costounitario.Name = "costounitario"
        Me.costounitario.Size = New System.Drawing.Size(19, 27)
        Me.costounitario.TabIndex = 16
        Me.costounitario.Text = "."
        '
        'tipocompra
        '
        Me.tipocompra.AutoSize = True
        Me.tipocompra.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipocompra.ForeColor = System.Drawing.Color.Black
        Me.tipocompra.Location = New System.Drawing.Point(1029, 455)
        Me.tipocompra.Name = "tipocompra"
        Me.tipocompra.Size = New System.Drawing.Size(19, 27)
        Me.tipocompra.TabIndex = 17
        Me.tipocompra.Text = "."
        '
        'totalcompra
        '
        Me.totalcompra.AutoSize = True
        Me.totalcompra.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcompra.ForeColor = System.Drawing.Color.Black
        Me.totalcompra.Location = New System.Drawing.Point(1032, 527)
        Me.totalcompra.Name = "totalcompra"
        Me.totalcompra.Size = New System.Drawing.Size(19, 27)
        Me.totalcompra.TabIndex = 18
        Me.totalcompra.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(43, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 29)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Cuentas por Pagar"
        '
        'ruc
        '
        Me.ruc.AutoSize = True
        Me.ruc.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ruc.ForeColor = System.Drawing.Color.Black
        Me.ruc.Location = New System.Drawing.Point(124, 328)
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(19, 27)
        Me.ruc.TabIndex = 21
        Me.ruc.Text = "."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(43, 328)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 29)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "RUC:"
        '
        'div
        '
        Me.div.AutoSize = True
        Me.div.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.div.ForeColor = System.Drawing.Color.Black
        Me.div.Location = New System.Drawing.Point(113, 389)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(19, 27)
        Me.div.TabIndex = 23
        Me.div.Text = "."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(43, 387)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 29)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "DIV:"
        '
        'telefono
        '
        Me.telefono.AutoSize = True
        Me.telefono.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.ForeColor = System.Drawing.Color.Black
        Me.telefono.Location = New System.Drawing.Point(617, 330)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(19, 27)
        Me.telefono.TabIndex = 25
        Me.telefono.Text = "."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(492, 326)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 29)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Telefono:"
        '
        'fax
        '
        Me.fax.AutoSize = True
        Me.fax.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fax.ForeColor = System.Drawing.Color.Black
        Me.fax.Location = New System.Drawing.Point(559, 389)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(19, 27)
        Me.fax.TabIndex = 27
        Me.fax.Text = "."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(492, 387)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 29)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Fax:"
        '
        'direccion
        '
        Me.direccion.AutoSize = True
        Me.direccion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.ForeColor = System.Drawing.Color.Black
        Me.direccion.Location = New System.Drawing.Point(949, 267)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(19, 27)
        Me.direccion.TabIndex = 29
        Me.direccion.Text = "."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(819, 265)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 29)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Direccion:"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.Location = New System.Drawing.Point(914, 329)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(19, 27)
        Me.email.TabIndex = 31
        Me.email.Text = "."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(819, 329)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 29)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Email:"
        '
        'tipproveedor
        '
        Me.tipproveedor.AutoSize = True
        Me.tipproveedor.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipproveedor.ForeColor = System.Drawing.Color.Black
        Me.tipproveedor.Location = New System.Drawing.Point(1069, 387)
        Me.tipproveedor.Name = "tipproveedor"
        Me.tipproveedor.Size = New System.Drawing.Size(19, 27)
        Me.tipproveedor.TabIndex = 33
        Me.tipproveedor.Text = "."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(819, 386)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(232, 29)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Tipo de Proveedor:"
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(559, 111)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(144, 36)
        Me.buscar.TabIndex = 34
        Me.buscar.Text = "&Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'gridview
        '
        Me.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridview.Location = New System.Drawing.Point(36, 245)
        Me.gridview.Name = "gridview"
        Me.gridview.RowTemplate.Height = 24
        Me.gridview.Size = New System.Drawing.Size(1223, 333)
        Me.gridview.TabIndex = 35
        '
        'view
        '
        Me.view.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view.Location = New System.Drawing.Point(719, 111)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(144, 36)
        Me.view.TabIndex = 36
        Me.view.Text = "&View"
        Me.view.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(31, 608)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(238, 29)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Cuentas por Cobrar"
        '
        'nom2
        '
        Me.nom2.AutoSize = True
        Me.nom2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom2.ForeColor = System.Drawing.Color.Black
        Me.nom2.Location = New System.Drawing.Point(176, 717)
        Me.nom2.Name = "nom2"
        Me.nom2.Size = New System.Drawing.Size(19, 27)
        Me.nom2.TabIndex = 39
        Me.nom2.Text = "."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(58, 717)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 29)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Nombre:"
        '
        'email2
        '
        Me.email2.AutoSize = True
        Me.email2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email2.ForeColor = System.Drawing.Color.Black
        Me.email2.Location = New System.Drawing.Point(153, 768)
        Me.email2.Name = "email2"
        Me.email2.Size = New System.Drawing.Size(19, 27)
        Me.email2.TabIndex = 41
        Me.email2.Text = "."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(58, 767)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 29)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Email:"
        '
        'nomartic
        '
        Me.nomartic.AutoSize = True
        Me.nomartic.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomartic.ForeColor = System.Drawing.Color.Black
        Me.nomartic.Location = New System.Drawing.Point(569, 719)
        Me.nomartic.Name = "nomartic"
        Me.nomartic.Size = New System.Drawing.Size(19, 27)
        Me.nomartic.TabIndex = 43
        Me.nomartic.Text = "."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(330, 717)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(239, 29)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Numero de articulo:"
        '
        'precio
        '
        Me.precio.AutoSize = True
        Me.precio.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio.ForeColor = System.Drawing.Color.Black
        Me.precio.Location = New System.Drawing.Point(429, 770)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(19, 27)
        Me.precio.TabIndex = 45
        Me.precio.Text = "."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(330, 768)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 29)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Precio:"
        '
        'codigo
        '
        Me.codigo.AutoSize = True
        Me.codigo.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo.ForeColor = System.Drawing.Color.Black
        Me.codigo.Location = New System.Drawing.Point(757, 719)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(19, 27)
        Me.codigo.TabIndex = 47
        Me.codigo.Text = "."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(639, 719)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 29)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "Codigo:"
        '
        'descripcion
        '
        Me.descripcion.AutoSize = True
        Me.descripcion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.ForeColor = System.Drawing.Color.Black
        Me.descripcion.Location = New System.Drawing.Point(802, 766)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(19, 27)
        Me.descripcion.TabIndex = 49
        Me.descripcion.Text = "."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(639, 766)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(157, 29)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Descripcion:"
        '
        'cantidad2
        '
        Me.cantidad2.AutoSize = True
        Me.cantidad2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad2.ForeColor = System.Drawing.Color.Black
        Me.cantidad2.Location = New System.Drawing.Point(1047, 716)
        Me.cantidad2.Name = "cantidad2"
        Me.cantidad2.Size = New System.Drawing.Size(19, 27)
        Me.cantidad2.TabIndex = 51
        Me.cantidad2.Text = "."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(935, 715)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(123, 29)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Cantidad:"
        '
        'fecha2
        '
        Me.fecha2.AutoSize = True
        Me.fecha2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha2.ForeColor = System.Drawing.Color.Black
        Me.fecha2.Location = New System.Drawing.Point(1039, 763)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(19, 27)
        Me.fecha2.TabIndex = 53
        Me.fecha2.Text = "."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(935, 762)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(89, 29)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "Fecha:"
        '
        'totalpagar
        '
        Me.totalpagar.AutoSize = True
        Me.totalpagar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpagar.ForeColor = System.Drawing.Color.Black
        Me.totalpagar.Location = New System.Drawing.Point(954, 640)
        Me.totalpagar.Name = "totalpagar"
        Me.totalpagar.Size = New System.Drawing.Size(19, 27)
        Me.totalpagar.TabIndex = 55
        Me.totalpagar.Text = "."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(780, 639)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(168, 29)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "Total a pagar:"
        '
        'totalpagado
        '
        Me.totalpagado.AutoSize = True
        Me.totalpagado.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpagado.ForeColor = System.Drawing.Color.Black
        Me.totalpagado.Location = New System.Drawing.Point(954, 683)
        Me.totalpagado.Name = "totalpagado"
        Me.totalpagado.Size = New System.Drawing.Size(19, 27)
        Me.totalpagado.TabIndex = 57
        Me.totalpagado.Text = "."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(782, 683)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(170, 29)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "Total Pagado:"
        '
        'gridview2
        '
        Me.gridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridview2.Location = New System.Drawing.Point(28, 640)
        Me.gridview2.Name = "gridview2"
        Me.gridview2.RowTemplate.Height = 24
        Me.gridview2.Size = New System.Drawing.Size(1237, 213)
        Me.gridview2.TabIndex = 58
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(1411, 549)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(169, 29)
        Me.Label31.TabIndex = 59
        Me.Label31.Text = "CXP - CXC =  "
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resta.ForeColor = System.Drawing.Color.Black
        Me.resta.Location = New System.Drawing.Point(1569, 549)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(20, 29)
        Me.resta.TabIndex = 60
        Me.resta.Text = "."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(1294, 495)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(416, 29)
        Me.Label32.TabIndex = 61
        Me.Label32.Text = "Resta con abono hecho en ventas. "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(1294, 640)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(408, 29)
        Me.Label33.TabIndex = 63
        Me.Label33.Text = "Resta sin abono hecho en ventas. "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(1411, 694)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(169, 29)
        Me.Label34.TabIndex = 62
        Me.Label34.Text = "CXP - CXC =  "
        '
        'resta2
        '
        Me.resta2.AutoSize = True
        Me.resta2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resta2.ForeColor = System.Drawing.Color.Black
        Me.resta2.Location = New System.Drawing.Point(1569, 694)
        Me.resta2.Name = "resta2"
        Me.resta2.Size = New System.Drawing.Size(20, 29)
        Me.resta2.TabIndex = 64
        Me.resta2.Text = "."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.resta2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.gridview2)
        Me.Controls.Add(Me.totalpagado)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.totalpagar)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.cantidad2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.nomartic)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.email2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.nom2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.gridview)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.tipproveedor)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.fax)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.div)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ruc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.totalcompra)
        Me.Controls.Add(Me.tipocompra)
        Me.Controls.Add(Me.costounitario)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.producto)
        Me.Controls.Add(Me.idproduct)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents nombre As Label
    Friend WithEvents fecha As Label
    Friend WithEvents idproduct As Label
    Friend WithEvents producto As Label
    Friend WithEvents cantidad As Label
    Friend WithEvents costounitario As Label
    Friend WithEvents tipocompra As Label
    Friend WithEvents totalcompra As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ruc As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents div As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents telefono As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents fax As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents direccion As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents email As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tipproveedor As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents buscar As Button
    Friend WithEvents gridview As DataGridView
    Friend WithEvents view As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents nom2 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents email2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents nomartic As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents precio As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents codigo As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents descripcion As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cantidad2 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents fecha2 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents totalpagar As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents totalpagado As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents gridview2 As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents resta As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents resta2 As Label
End Class
