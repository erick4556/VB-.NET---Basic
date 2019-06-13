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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.enviar = New System.Windows.Forms.Button()
        Me.regres = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion: "
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(201, 85)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(194, 27)
        Me.nombre.TabIndex = 2
        '
        'direccion
        '
        Me.direccion.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(201, 156)
        Me.direccion.Multiline = True
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(194, 30)
        Me.direccion.TabIndex = 3
        '
        'enviar
        '
        Me.enviar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(205, 242)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(166, 36)
        Me.enviar.TabIndex = 4
        Me.enviar.Text = "&Guardar"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'regres
        '
        Me.regres.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regres.Location = New System.Drawing.Point(205, 340)
        Me.regres.Name = "regres"
        Me.regres.Size = New System.Drawing.Size(166, 36)
        Me.regres.TabIndex = 5
        Me.regres.Text = "&Regresar"
        Me.regres.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 532)
        Me.Controls.Add(Me.regres)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents enviar As Button
    Friend WithEvents regres As Button
End Class
