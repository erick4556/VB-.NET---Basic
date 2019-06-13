<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvalor1 = New System.Windows.Forms.TextBox()
        Me.simbolo = New System.Windows.Forms.Label()
        Me.txtvalor2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resulta = New System.Windows.Forms.Label()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboperaciones = New System.Windows.Forms.ComboBox()
        Me.errorpro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.avan = New System.Windows.Forms.Button()
        CType(Me.errorpro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(34, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operaciones Arítmetica"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(386, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(311, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor 1:"
        '
        'txtvalor1
        '
        Me.txtvalor1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor1.Location = New System.Drawing.Point(187, 97)
        Me.txtvalor1.Multiline = True
        Me.txtvalor1.Name = "txtvalor1"
        Me.txtvalor1.Size = New System.Drawing.Size(261, 35)
        Me.txtvalor1.TabIndex = 3
        '
        'simbolo
        '
        Me.simbolo.AutoSize = True
        Me.simbolo.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simbolo.Location = New System.Drawing.Point(65, 172)
        Me.simbolo.Name = "simbolo"
        Me.simbolo.Size = New System.Drawing.Size(20, 29)
        Me.simbolo.TabIndex = 4
        Me.simbolo.Text = "."
        '
        'txtvalor2
        '
        Me.txtvalor2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor2.Location = New System.Drawing.Point(187, 243)
        Me.txtvalor2.Multiline = True
        Me.txtvalor2.Name = "txtvalor2"
        Me.txtvalor2.Size = New System.Drawing.Size(261, 35)
        Me.txtvalor2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valor 2:"
        '
        'resulta
        '
        Me.resulta.AutoSize = True
        Me.resulta.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resulta.Location = New System.Drawing.Point(39, 386)
        Me.resulta.Name = "resulta"
        Me.resulta.Size = New System.Drawing.Size(128, 27)
        Me.resulta.TabIndex = 8
        Me.resulta.Text = "Resultado:"
        '
        'txtresultado
        '
        Me.txtresultado.Enabled = False
        Me.txtresultado.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresultado.Location = New System.Drawing.Point(187, 382)
        Me.txtresultado.Multiline = True
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(261, 35)
        Me.txtresultado.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "="
        '
        'cboperaciones
        '
        Me.cboperaciones.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboperaciones.FormattingEnabled = True
        Me.cboperaciones.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicación", "División", "Limpiar", "Salir"})
        Me.cboperaciones.Location = New System.Drawing.Point(511, 172)
        Me.cboperaciones.Name = "cboperaciones"
        Me.cboperaciones.Size = New System.Drawing.Size(242, 32)
        Me.cboperaciones.TabIndex = 10
        '
        'errorpro
        '
        Me.errorpro.ContainerControl = Me
        '
        'avan
        '
        Me.avan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avan.Location = New System.Drawing.Point(527, 376)
        Me.avan.Name = "avan"
        Me.avan.Size = New System.Drawing.Size(212, 49)
        Me.avan.TabIndex = 11
        Me.avan.Text = "&Avanzar"
        Me.avan.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.avan)
        Me.Controls.Add(Me.cboperaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resulta)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtvalor2)
        Me.Controls.Add(Me.simbolo)
        Me.Controls.Add(Me.txtvalor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.errorpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtvalor1 As TextBox
    Friend WithEvents simbolo As Label
    Friend WithEvents txtvalor2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents resulta As Label
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboperaciones As ComboBox
    Friend WithEvents errorpro As ErrorProvider
    Friend WithEvents avan As Button
End Class
