<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtmensaje = New System.Windows.Forms.TextBox()
        Me.salida = New System.Windows.Forms.Label()
        Me.salida2 = New System.Windows.Forms.TextBox()
        Me.activar = New System.Windows.Forms.Button()
        Me.Provincia = New System.Windows.Forms.ComboBox()
        Me.avan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtmensaje
        '
        Me.txtmensaje.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmensaje.Location = New System.Drawing.Point(41, 52)
        Me.txtmensaje.Multiline = True
        Me.txtmensaje.Name = "txtmensaje"
        Me.txtmensaje.Size = New System.Drawing.Size(326, 37)
        Me.txtmensaje.TabIndex = 0
        '
        'salida
        '
        Me.salida.AutoSize = True
        Me.salida.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salida.Location = New System.Drawing.Point(37, 126)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(16, 24)
        Me.salida.TabIndex = 1
        Me.salida.Text = "."
        '
        'salida2
        '
        Me.salida2.Enabled = False
        Me.salida2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salida2.Location = New System.Drawing.Point(41, 190)
        Me.salida2.Multiline = True
        Me.salida2.Name = "salida2"
        Me.salida2.Size = New System.Drawing.Size(326, 37)
        Me.salida2.TabIndex = 2
        '
        'activar
        '
        Me.activar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activar.Location = New System.Drawing.Point(41, 291)
        Me.activar.Name = "activar"
        Me.activar.Size = New System.Drawing.Size(212, 49)
        Me.activar.TabIndex = 3
        Me.activar.Text = "&Activar"
        Me.activar.UseVisualStyleBackColor = True
        '
        'Provincia
        '
        Me.Provincia.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Provincia.FormattingEnabled = True
        Me.Provincia.Items.AddRange(New Object() {"Bocas del Toro", "Coclé", "Colón", "Chiriquí", "Darién", "Herrera", "Los Santos", "Panamá", "Veraguas", "Chorrera"})
        Me.Provincia.Location = New System.Drawing.Point(451, 58)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(208, 29)
        Me.Provincia.TabIndex = 4
        Me.Provincia.Text = "Eliga una Opción:"
        '
        'avan
        '
        Me.avan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avan.Location = New System.Drawing.Point(310, 291)
        Me.avan.Name = "avan"
        Me.avan.Size = New System.Drawing.Size(212, 49)
        Me.avan.TabIndex = 5
        Me.avan.Text = "&Avanzar"
        Me.avan.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 418)
        Me.Controls.Add(Me.avan)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.activar)
        Me.Controls.Add(Me.salida2)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.txtmensaje)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmensaje As TextBox
    Friend WithEvents salida As Label
    Friend WithEvents salida2 As TextBox
    Friend WithEvents activar As Button
    Friend WithEvents Provincia As ComboBox
    Friend WithEvents avan As Button
End Class
