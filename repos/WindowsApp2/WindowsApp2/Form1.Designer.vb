<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.opciones = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.valor3 = New System.Windows.Forms.TextBox()
        Me.valor2 = New System.Windows.Forms.TextBox()
        Me.valor1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'resultado
        '
        Me.resultado.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(333, 409)
        Me.resultado.Multiline = True
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(208, 35)
        Me.resultado.TabIndex = 20
        '
        'opciones
        '
        Me.opciones.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opciones.FormattingEnabled = True
        Me.opciones.Items.AddRange(New Object() {"Calcular la positiva", "Calcular la negativa"})
        Me.opciones.Location = New System.Drawing.Point(675, 138)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(218, 29)
        Me.opciones.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 27)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Resultado: "
        '
        'valor3
        '
        Me.valor3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor3.Location = New System.Drawing.Point(333, 309)
        Me.valor3.Multiline = True
        Me.valor3.Name = "valor3"
        Me.valor3.Size = New System.Drawing.Size(208, 35)
        Me.valor3.TabIndex = 17
        '
        'valor2
        '
        Me.valor2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor2.Location = New System.Drawing.Point(333, 219)
        Me.valor2.Multiline = True
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(208, 35)
        Me.valor2.TabIndex = 16
        '
        'valor1
        '
        Me.valor1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor1.Location = New System.Drawing.Point(333, 138)
        Me.valor1.Multiline = True
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(208, 35)
        Me.valor1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 27)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Ingresa numero 3: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 27)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ingresa numero 2: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 27)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ingresa numero 1: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 28)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Laboratorio 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 500)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.valor3)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resultado As TextBox
    Friend WithEvents opciones As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents valor3 As TextBox
    Friend WithEvents valor2 As TextBox
    Friend WithEvents valor1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
