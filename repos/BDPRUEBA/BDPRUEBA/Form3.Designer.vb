<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.n = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.view = New System.Windows.Forms.DataGridView()
        Me.data = New System.Windows.Forms.Button()
        Me.regresar = New System.Windows.Forms.Button()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'n
        '
        Me.n.AutoSize = True
        Me.n.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n.Location = New System.Drawing.Point(82, 179)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(111, 27)
        Me.n.TabIndex = 0
        Me.n.Text = "Nombre: "
        '
        'direccion
        '
        Me.direccion.AutoSize = True
        Me.direccion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(82, 271)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(125, 27)
        Me.direccion.TabIndex = 1
        Me.direccion.Text = "Direccion: "
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(258, 179)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(178, 34)
        Me.nombre.TabIndex = 2
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(258, 264)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(178, 34)
        Me.address.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar: "
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(258, 102)
        Me.buscar.Multiline = True
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(178, 34)
        Me.buscar.TabIndex = 5
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(476, 99)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(132, 38)
        Me.search.TabIndex = 6
        Me.search.Text = "&Buscar"
        Me.search.UseVisualStyleBackColor = True
        '
        'view
        '
        Me.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.view.Location = New System.Drawing.Point(132, 318)
        Me.view.Name = "view"
        Me.view.RowTemplate.Height = 24
        Me.view.Size = New System.Drawing.Size(476, 223)
        Me.view.TabIndex = 7
        '
        'data
        '
        Me.data.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Location = New System.Drawing.Point(654, 98)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(132, 38)
        Me.data.TabIndex = 8
        Me.data.Text = "&Data"
        Me.data.UseVisualStyleBackColor = True
        '
        'regresar
        '
        Me.regresar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresar.Location = New System.Drawing.Point(291, 574)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(132, 38)
        Me.regresar.TabIndex = 9
        Me.regresar.Text = "&Regresar"
        Me.regresar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 684)
        Me.Controls.Add(Me.regresar)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.n)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents n As Label
    Friend WithEvents direccion As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents search As Button
    Friend WithEvents view As DataGridView
    Friend WithEvents data As Button
    Friend WithEvents regresar As Button
End Class
