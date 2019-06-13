<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.Label()
        Me.n = New System.Windows.Forms.Label()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.regres = New System.Windows.Forms.Button()
        Me.actualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar: "
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(506, 125)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(132, 38)
        Me.search.TabIndex = 12
        Me.search.Text = "&Buscar"
        Me.search.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(288, 128)
        Me.buscar.Multiline = True
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(178, 34)
        Me.buscar.TabIndex = 11
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(288, 290)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(178, 34)
        Me.address.TabIndex = 10
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(288, 205)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(178, 34)
        Me.nombre.TabIndex = 9
        '
        'direccion
        '
        Me.direccion.AutoSize = True
        Me.direccion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(120, 297)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(125, 27)
        Me.direccion.TabIndex = 8
        Me.direccion.Text = "Direccion: "
        '
        'n
        '
        Me.n.AutoSize = True
        Me.n.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n.Location = New System.Drawing.Point(120, 205)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(111, 27)
        Me.n.TabIndex = 7
        Me.n.Text = "Nombre: "
        '
        'eliminar
        '
        Me.eliminar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(506, 205)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(132, 38)
        Me.eliminar.TabIndex = 13
        Me.eliminar.Text = "&Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'regres
        '
        Me.regres.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regres.Location = New System.Drawing.Point(367, 393)
        Me.regres.Name = "regres"
        Me.regres.Size = New System.Drawing.Size(166, 36)
        Me.regres.TabIndex = 14
        Me.regres.Text = "&Regresar"
        Me.regres.UseVisualStyleBackColor = True
        '
        'actualizar
        '
        Me.actualizar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actualizar.Location = New System.Drawing.Point(506, 287)
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Size = New System.Drawing.Size(132, 38)
        Me.actualizar.TabIndex = 15
        Me.actualizar.Text = "&Actualizar"
        Me.actualizar.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 630)
        Me.Controls.Add(Me.actualizar)
        Me.Controls.Add(Me.regres)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents search As Button
    Friend WithEvents buscar As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents direccion As Label
    Friend WithEvents n As Label
    Friend WithEvents eliminar As Button
    Friend WithEvents regres As Button
    Friend WithEvents actualizar As Button
End Class
