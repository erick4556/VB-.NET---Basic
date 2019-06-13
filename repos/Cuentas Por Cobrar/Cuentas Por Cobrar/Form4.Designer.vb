<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cedula_sin = New System.Windows.Forms.Label()
        Me.total_pagar = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total_pagado = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cedula = New System.Windows.Forms.Label()
        Me.nom_articulo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pago = New System.Windows.Forms.TextBox()
        Me.restante = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.codigo_sin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sección De Pagos (Factura)"
        '
        'Buscar
        '
        Me.Buscar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Location = New System.Drawing.Point(169, 103)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(119, 28)
        Me.Buscar.TabIndex = 16
        Me.Buscar.Text = "&Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(169, 77)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(119, 20)
        Me.codigo.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Ingresar Codigo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cedula_sin
        '
        Me.cedula_sin.AutoSize = True
        Me.cedula_sin.Font = New System.Drawing.Font("Modern No. 20", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedula_sin.Location = New System.Drawing.Point(580, 250)
        Me.cedula_sin.Name = "cedula_sin"
        Me.cedula_sin.Size = New System.Drawing.Size(2, 2)
        Me.cedula_sin.TabIndex = 25
        Me.cedula_sin.Text = "."
        '
        'total_pagar
        '
        Me.total_pagar.AutoSize = True
        Me.total_pagar.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_pagar.Location = New System.Drawing.Point(588, 215)
        Me.total_pagar.Name = "total_pagar"
        Me.total_pagar.Size = New System.Drawing.Size(14, 21)
        Me.total_pagar.TabIndex = 24
        Me.total_pagar.Text = "."
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(137, 297)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(14, 21)
        Me.email.TabIndex = 23
        Me.email.Text = "."
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(137, 215)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(14, 21)
        Me.nombre.TabIndex = 21
        Me.nombre.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(447, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = " Total Factura :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(316, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Detalles De Cliente y  Articulo"
        '
        'total_pagado
        '
        Me.total_pagado.AutoSize = True
        Me.total_pagado.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_pagado.Location = New System.Drawing.Point(588, 258)
        Me.total_pagado.Name = "total_pagado"
        Me.total_pagado.Size = New System.Drawing.Size(14, 21)
        Me.total_pagado.TabIndex = 28
        Me.total_pagado.Text = "."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(443, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 21)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = " Total Abonado :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Telefono :"
        '
        'cedula
        '
        Me.cedula.AutoSize = True
        Me.cedula.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedula.Location = New System.Drawing.Point(137, 258)
        Me.cedula.Name = "cedula"
        Me.cedula.Size = New System.Drawing.Size(14, 21)
        Me.cedula.TabIndex = 22
        Me.cedula.Text = "."
        '
        'nom_articulo
        '
        Me.nom_articulo.AutoSize = True
        Me.nom_articulo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_articulo.Location = New System.Drawing.Point(137, 328)
        Me.nom_articulo.Name = "nom_articulo"
        Me.nom_articulo.Size = New System.Drawing.Size(14, 21)
        Me.nom_articulo.TabIndex = 34
        Me.nom_articulo.Text = "."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(47, 328)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 21)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Articulo :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 358)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 21)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Descripción :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(64, 390)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 21)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Fecha :"
        '
        'descripcion
        '
        Me.descripcion.AutoSize = True
        Me.descripcion.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(137, 358)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(14, 21)
        Me.descripcion.TabIndex = 37
        Me.descripcion.Text = "."
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(137, 390)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(14, 21)
        Me.fecha.TabIndex = 38
        Me.fecha.Text = "."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(504, 164)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 25)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Detalles Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(591, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(2, 2)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(435, 328)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Abonar/Cancelar :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(591, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(2, 2)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(592, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 28)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "&Pagar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pago
        '
        Me.pago.Location = New System.Drawing.Point(592, 331)
        Me.pago.Name = "pago"
        Me.pago.Size = New System.Drawing.Size(161, 20)
        Me.pago.TabIndex = 40
        '
        'restante
        '
        Me.restante.AutoSize = True
        Me.restante.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restante.Location = New System.Drawing.Point(588, 297)
        Me.restante.Name = "restante"
        Me.restante.Size = New System.Drawing.Size(14, 21)
        Me.restante.TabIndex = 43
        Me.restante.Text = "."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 297)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 21)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = " Total Restante :"
        '
        'codigo_sin
        '
        Me.codigo_sin.AutoSize = True
        Me.codigo_sin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo_sin.Location = New System.Drawing.Point(137, 424)
        Me.codigo_sin.Name = "codigo_sin"
        Me.codigo_sin.Size = New System.Drawing.Size(14, 21)
        Me.codigo_sin.TabIndex = 45
        Me.codigo_sin.Text = "."
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(816, 502)
        Me.Controls.Add(Me.codigo_sin)
        Me.Controls.Add(Me.restante)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pago)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.nom_articulo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.total_pagado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cedula_sin)
        Me.Controls.Add(Me.total_pagar)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.cedula)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents codigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cedula_sin As Label
    Friend WithEvents total_pagar As Label
    Friend WithEvents email As Label
    Friend WithEvents nombre As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents total_pagado As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cedula As Label
    Friend WithEvents nom_articulo As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents descripcion As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pago As TextBox
    Friend WithEvents restante As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents codigo_sin As Label
End Class
