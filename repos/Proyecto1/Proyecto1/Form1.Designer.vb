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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.cedula = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.cotizacion = New System.Windows.Forms.TextBox()
        Me.salario = New System.Windows.Forms.TextBox()
        Me.tipoempresa = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.enviar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(845, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(721, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(427, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Financiera Mi Solución, S.A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingrese  su nombre : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(461, 533)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingrese  su email : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(461, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ingrese  su télefono : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(461, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 33)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ingrese  su cédula : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(461, 647)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(323, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Número de cotización : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(461, 757)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 33)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Salario mensual : "
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(838, 220)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(333, 36)
        Me.nombre.TabIndex = 8
        '
        'cedula
        '
        Me.cedula.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedula.Location = New System.Drawing.Point(838, 314)
        Me.cedula.Multiline = True
        Me.cedula.Name = "cedula"
        Me.cedula.Size = New System.Drawing.Size(333, 36)
        Me.cedula.TabIndex = 9
        '
        'telefono
        '
        Me.telefono.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(838, 420)
        Me.telefono.Multiline = True
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(333, 36)
        Me.telefono.TabIndex = 10
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(838, 530)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(333, 36)
        Me.email.TabIndex = 11
        '
        'cotizacion
        '
        Me.cotizacion.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cotizacion.Location = New System.Drawing.Point(838, 644)
        Me.cotizacion.Multiline = True
        Me.cotizacion.Name = "cotizacion"
        Me.cotizacion.Size = New System.Drawing.Size(333, 36)
        Me.cotizacion.TabIndex = 12
        '
        'salario
        '
        Me.salario.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salario.Location = New System.Drawing.Point(838, 754)
        Me.salario.Multiline = True
        Me.salario.Name = "salario"
        Me.salario.Size = New System.Drawing.Size(333, 36)
        Me.salario.TabIndex = 13
        '
        'tipoempresa
        '
        Me.tipoempresa.AutoCompleteCustomSource.AddRange(New String() {"Privada", "Gobierno", "Independiente"})
        Me.tipoempresa.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipoempresa.FormattingEnabled = True
        Me.tipoempresa.Items.AddRange(New Object() {"Privada", "Gobierno", "Independiente"})
        Me.tipoempresa.Location = New System.Drawing.Point(1264, 754)
        Me.tipoempresa.Name = "tipoempresa"
        Me.tipoempresa.Size = New System.Drawing.Size(176, 35)
        Me.tipoempresa.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1259, 706)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 28)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Tipo de empresa"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'enviar
        '
        Me.enviar.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(718, 878)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(113, 44)
        Me.enviar.TabIndex = 16
        Me.enviar.Text = "&Enviar"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'cerrar
        '
        Me.cerrar.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.Location = New System.Drawing.Point(1152, 878)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(113, 44)
        Me.cerrar.TabIndex = 17
        Me.cerrar.Text = "&Cerrar"
        Me.cerrar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(924, 878)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(130, 44)
        Me.limpiar.TabIndex = 18
        Me.limpiar.Text = "&Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1203, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(365, 30)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1319, 983)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tipoempresa)
        Me.Controls.Add(Me.salario)
        Me.Controls.Add(Me.cotizacion)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.cedula)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents cedula As TextBox
    Friend WithEvents telefono As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents cotizacion As TextBox
    Friend WithEvents salario As TextBox
    Friend WithEvents tipoempresa As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents enviar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
