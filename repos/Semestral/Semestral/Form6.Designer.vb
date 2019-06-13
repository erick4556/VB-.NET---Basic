<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.edad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.valaseg = New System.Windows.Forms.TextBox()
        Me.polivida = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.plazop = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.letram = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.enviar = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(553, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 39)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Vida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 33)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Ingrese la edad  : "
        '
        'edad
        '
        Me.edad.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edad.Location = New System.Drawing.Point(429, 246)
        Me.edad.Multiline = True
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(193, 36)
        Me.edad.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 33)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Valor a asegurar : "
        '
        'valaseg
        '
        Me.valaseg.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valaseg.Location = New System.Drawing.Point(438, 380)
        Me.valaseg.Multiline = True
        Me.valaseg.Name = "valaseg"
        Me.valaseg.Size = New System.Drawing.Size(193, 36)
        Me.valaseg.TabIndex = 49
        '
        'polivida
        '
        Me.polivida.AutoSize = True
        Me.polivida.BackColor = System.Drawing.Color.Transparent
        Me.polivida.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.polivida.Location = New System.Drawing.Point(394, 448)
        Me.polivida.Name = "polivida"
        Me.polivida.Size = New System.Drawing.Size(23, 33)
        Me.polivida.TabIndex = 55
        Me.polivida.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(171, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 33)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Poliza de vida:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(571, 533)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 33)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "meses"
        '
        'plazop
        '
        Me.plazop.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plazop.Location = New System.Drawing.Point(400, 530)
        Me.plazop.Multiline = True
        Me.plazop.Name = "plazop"
        Me.plazop.Size = New System.Drawing.Size(152, 36)
        Me.plazop.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 33)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Plazo de pago:"
        '
        'letram
        '
        Me.letram.AutoSize = True
        Me.letram.BackColor = System.Drawing.Color.Transparent
        Me.letram.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letram.Location = New System.Drawing.Point(413, 620)
        Me.letram.Name = "letram"
        Me.letram.Size = New System.Drawing.Size(23, 33)
        Me.letram.TabIndex = 67
        Me.letram.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 620)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 33)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Letra Mensual: "
        '
        'enviar
        '
        Me.enviar.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(560, 699)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(113, 44)
        Me.enviar.TabIndex = 68
        Me.enviar.Text = "&Enviar"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'atras
        '
        Me.atras.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.Location = New System.Drawing.Point(560, 778)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(113, 44)
        Me.atras.TabIndex = 69
        Me.atras.Text = "&Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(629, 33)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Valor Base de la Suma a Asegurar B/.55,000.00"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(1211, 834)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.letram)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.plazop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.polivida)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.valaseg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.edad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents edad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents valaseg As TextBox
    Friend WithEvents polivida As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents plazop As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents letram As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents enviar As Button
    Friend WithEvents atras As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label2 As Label
End Class
