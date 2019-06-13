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
        Me.terreno = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.automovil = New System.Windows.Forms.Button()
        Me.vida = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'terreno
        '
        Me.terreno.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terreno.Location = New System.Drawing.Point(195, 300)
        Me.terreno.Name = "terreno"
        Me.terreno.Size = New System.Drawing.Size(238, 104)
        Me.terreno.TabIndex = 38
        Me.terreno.Text = "&Terreno"
        Me.terreno.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(440, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(391, 39)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Eliga la opción de seguro"
        '
        'automovil
        '
        Me.automovil.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.automovil.Location = New System.Drawing.Point(526, 300)
        Me.automovil.Name = "automovil"
        Me.automovil.Size = New System.Drawing.Size(238, 104)
        Me.automovil.TabIndex = 46
        Me.automovil.Text = "&Automovil"
        Me.automovil.UseVisualStyleBackColor = True
        '
        'vida
        '
        Me.vida.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vida.Location = New System.Drawing.Point(856, 300)
        Me.vida.Name = "vida"
        Me.vida.Size = New System.Drawing.Size(238, 104)
        Me.vida.TabIndex = 47
        Me.vida.Text = "&Vida"
        Me.vida.UseVisualStyleBackColor = True
        '
        'atras
        '
        Me.atras.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.Location = New System.Drawing.Point(1103, 1)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(139, 51)
        Me.atras.TabIndex = 48
        Me.atras.Text = "&Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1239, 780)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.vida)
        Me.Controls.Add(Me.automovil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.terreno)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents terreno As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents automovil As Button
    Friend WithEvents vida As Button
    Friend WithEvents atras As Button
End Class
