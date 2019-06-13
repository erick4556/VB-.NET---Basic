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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.terreno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.valm2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.valter = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.polizaviv = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.plazop = New System.Windows.Forms.TextBox()
        Me.letram = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.enviar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(515, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 39)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Terreno"
        '
        'terreno
        '
        Me.terreno.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terreno.Location = New System.Drawing.Point(546, 226)
        Me.terreno.Multiline = True
        Me.terreno.Name = "terreno"
        Me.terreno.Size = New System.Drawing.Size(193, 36)
        Me.terreno.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 33)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Ingrese su tamaño  : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(745, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 33)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "m2"
        '
        'valm2
        '
        Me.valm2.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valm2.Location = New System.Drawing.Point(546, 318)
        Me.valm2.Multiline = True
        Me.valm2.Name = "valm2"
        Me.valm2.Size = New System.Drawing.Size(191, 36)
        Me.valm2.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 33)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Ingrese valor del m2 : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(412, 33)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Valor aproximado del terreno: "
        '
        'valter
        '
        Me.valter.AutoSize = True
        Me.valter.BackColor = System.Drawing.Color.Transparent
        Me.valter.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valter.Location = New System.Drawing.Point(540, 400)
        Me.valter.Name = "valter"
        Me.valter.Size = New System.Drawing.Size(23, 33)
        Me.valter.TabIndex = 51
        Me.valter.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 485)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 33)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Poliza de vivienda:"
        '
        'polizaviv
        '
        Me.polizaviv.AutoSize = True
        Me.polizaviv.BackColor = System.Drawing.Color.Transparent
        Me.polizaviv.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.polizaviv.Location = New System.Drawing.Point(540, 485)
        Me.polizaviv.Name = "polizaviv"
        Me.polizaviv.Size = New System.Drawing.Size(23, 33)
        Me.polizaviv.TabIndex = 53
        Me.polizaviv.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 565)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 33)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Plazo de pago:"
        '
        'plazop
        '
        Me.plazop.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plazop.Location = New System.Drawing.Point(546, 566)
        Me.plazop.Multiline = True
        Me.plazop.Name = "plazop"
        Me.plazop.Size = New System.Drawing.Size(152, 36)
        Me.plazop.TabIndex = 55
        '
        'letram
        '
        Me.letram.AutoSize = True
        Me.letram.BackColor = System.Drawing.Color.Transparent
        Me.letram.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letram.Location = New System.Drawing.Point(558, 650)
        Me.letram.Name = "letram"
        Me.letram.Size = New System.Drawing.Size(23, 33)
        Me.letram.TabIndex = 57
        Me.letram.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(303, 650)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 33)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Letra Mensual: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(743, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 33)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(721, 569)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 33)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "meses"
        '
        'enviar
        '
        Me.enviar.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(481, 745)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(113, 44)
        Me.enviar.TabIndex = 60
        Me.enviar.Text = "&Enviar"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'atras
        '
        Me.atras.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.Location = New System.Drawing.Point(481, 827)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(113, 44)
        Me.atras.TabIndex = 67
        Me.atras.Text = "&Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Semestral.My.Resources.Resources.fondo4
        Me.ClientSize = New System.Drawing.Size(1192, 883)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.letram)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.plazop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.polizaviv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.valter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.valm2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.terreno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents terreno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents valm2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents valter As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents polizaviv As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents plazop As TextBox
    Friend WithEvents letram As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents enviar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents atras As Button
End Class
