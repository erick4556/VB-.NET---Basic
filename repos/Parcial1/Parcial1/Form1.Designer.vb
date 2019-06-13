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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.placa = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.profesion = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.enviar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Placa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Profesión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(302, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'placa
        '
        Me.placa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placa.Location = New System.Drawing.Point(429, 131)
        Me.placa.Multiline = True
        Me.placa.Name = "placa"
        Me.placa.Size = New System.Drawing.Size(202, 29)
        Me.placa.TabIndex = 5
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(429, 206)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(202, 29)
        Me.nombre.TabIndex = 6
        '
        'profesion
        '
        Me.profesion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profesion.Location = New System.Drawing.Point(429, 283)
        Me.profesion.Multiline = True
        Me.profesion.Name = "profesion"
        Me.profesion.Size = New System.Drawing.Size(202, 29)
        Me.profesion.TabIndex = 7
        '
        'telefono
        '
        Me.telefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(429, 357)
        Me.telefono.Multiline = True
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(202, 29)
        Me.telefono.TabIndex = 8
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(429, 429)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(202, 29)
        Me.email.TabIndex = 9
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'enviar
        '
        Me.enviar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(306, 512)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(114, 44)
        Me.enviar.TabIndex = 10
        Me.enviar.Text = "&Enviar"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(480, 512)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(114, 44)
        Me.limpiar.TabIndex = 11
        Me.limpiar.Text = "&Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Facturación en Línea"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(848, 776)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.profesion)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.placa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents placa As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents profesion As TextBox
    Friend WithEvents telefono As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents enviar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents Label6 As Label
End Class
