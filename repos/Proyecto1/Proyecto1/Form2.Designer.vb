<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.grupobox = New System.Windows.Forms.GroupBox()
        Me.plazo = New System.Windows.Forms.ComboBox()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.limp = New System.Windows.Forms.Button()
        Me.env = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.autos = New System.Windows.Forms.PictureBox()
        Me.estudios = New System.Windows.Forms.PictureBox()
        Me.turismo = New System.Windows.Forms.PictureBox()
        Me.viviendas = New System.Windows.Forms.PictureBox()
        Me.person = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.valprestamo = New System.Windows.Forms.TextBox()
        Me.regres = New System.Windows.Forms.Button()
        Me.grupobox.SuspendLayout()
        CType(Me.autos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.turismo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viviendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.person, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupobox
        '
        Me.grupobox.BackColor = System.Drawing.Color.Transparent
        Me.grupobox.Controls.Add(Me.plazo)
        Me.grupobox.Controls.Add(Me.rb5)
        Me.grupobox.Controls.Add(Me.rb4)
        Me.grupobox.Controls.Add(Me.rb3)
        Me.grupobox.Controls.Add(Me.rb2)
        Me.grupobox.Controls.Add(Me.rb1)
        Me.grupobox.Controls.Add(Me.limp)
        Me.grupobox.Controls.Add(Me.env)
        Me.grupobox.Controls.Add(Me.Label3)
        Me.grupobox.Controls.Add(Me.autos)
        Me.grupobox.Controls.Add(Me.estudios)
        Me.grupobox.Controls.Add(Me.turismo)
        Me.grupobox.Controls.Add(Me.viviendas)
        Me.grupobox.Controls.Add(Me.person)
        Me.grupobox.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupobox.Location = New System.Drawing.Point(398, 305)
        Me.grupobox.Name = "grupobox"
        Me.grupobox.Size = New System.Drawing.Size(1343, 585)
        Me.grupobox.TabIndex = 0
        Me.grupobox.TabStop = False
        Me.grupobox.Text = "Tipos de prestamos"
        '
        'plazo
        '
        Me.plazo.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plazo.FormattingEnabled = True
        Me.plazo.Items.AddRange(New Object() {"18 meses" & Global.Microsoft.VisualBasic.ChrW(9), "36 meses", "50 meses", "60 meses"})
        Me.plazo.Location = New System.Drawing.Point(929, 91)
        Me.plazo.Name = "plazo"
        Me.plazo.Size = New System.Drawing.Size(243, 35)
        Me.plazo.TabIndex = 28
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.BackColor = System.Drawing.Color.Transparent
        Me.rb5.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb5.Location = New System.Drawing.Point(42, 313)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(81, 28)
        Me.rb5.TabIndex = 27
        Me.rb5.TabStop = True
        Me.rb5.Text = "Autos"
        Me.rb5.UseVisualStyleBackColor = False
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.BackColor = System.Drawing.Color.Transparent
        Me.rb4.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.Location = New System.Drawing.Point(42, 250)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(104, 28)
        Me.rb4.TabIndex = 26
        Me.rb4.TabStop = True
        Me.rb4.Text = "Estudios"
        Me.rb4.UseVisualStyleBackColor = False
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.BackColor = System.Drawing.Color.Transparent
        Me.rb3.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(42, 195)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(106, 28)
        Me.rb3.TabIndex = 25
        Me.rb3.TabStop = True
        Me.rb3.Text = "Turismo"
        Me.rb3.UseVisualStyleBackColor = False
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.BackColor = System.Drawing.Color.Transparent
        Me.rb2.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(42, 143)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(114, 28)
        Me.rb2.TabIndex = 24
        Me.rb2.TabStop = True
        Me.rb2.Text = "Viviendas"
        Me.rb2.UseVisualStyleBackColor = False
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.BackColor = System.Drawing.Color.Transparent
        Me.rb1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(42, 91)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(122, 28)
        Me.rb1.TabIndex = 23
        Me.rb1.TabStop = True
        Me.rb1.Text = "Personales"
        Me.rb1.UseVisualStyleBackColor = False
        '
        'limp
        '
        Me.limp.Location = New System.Drawing.Point(700, 434)
        Me.limp.Name = "limp"
        Me.limp.Size = New System.Drawing.Size(106, 50)
        Me.limp.TabIndex = 20
        Me.limp.Text = "&Limpiar"
        Me.limp.UseVisualStyleBackColor = True
        '
        'env
        '
        Me.env.Location = New System.Drawing.Point(372, 434)
        Me.env.Name = "env"
        Me.env.Size = New System.Drawing.Size(106, 50)
        Me.env.TabIndex = 19
        Me.env.Text = "&Enviar"
        Me.env.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(937, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Plazo de pago (meses) : "
        '
        'autos
        '
        Me.autos.Image = CType(resources.GetObject("autos.Image"), System.Drawing.Image)
        Me.autos.Location = New System.Drawing.Point(403, 41)
        Me.autos.Name = "autos"
        Me.autos.Size = New System.Drawing.Size(367, 346)
        Me.autos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.autos.TabIndex = 9
        Me.autos.TabStop = False
        '
        'estudios
        '
        Me.estudios.Image = CType(resources.GetObject("estudios.Image"), System.Drawing.Image)
        Me.estudios.Location = New System.Drawing.Point(420, 41)
        Me.estudios.Name = "estudios"
        Me.estudios.Size = New System.Drawing.Size(350, 347)
        Me.estudios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.estudios.TabIndex = 8
        Me.estudios.TabStop = False
        '
        'turismo
        '
        Me.turismo.Image = CType(resources.GetObject("turismo.Image"), System.Drawing.Image)
        Me.turismo.Location = New System.Drawing.Point(420, 42)
        Me.turismo.Name = "turismo"
        Me.turismo.Size = New System.Drawing.Size(350, 346)
        Me.turismo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.turismo.TabIndex = 7
        Me.turismo.TabStop = False
        '
        'viviendas
        '
        Me.viviendas.Image = CType(resources.GetObject("viviendas.Image"), System.Drawing.Image)
        Me.viviendas.Location = New System.Drawing.Point(420, 41)
        Me.viviendas.Name = "viviendas"
        Me.viviendas.Size = New System.Drawing.Size(350, 346)
        Me.viviendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.viviendas.TabIndex = 6
        Me.viviendas.TabStop = False
        '
        'person
        '
        Me.person.Image = CType(resources.GetObject("person.Image"), System.Drawing.Image)
        Me.person.Location = New System.Drawing.Point(420, 41)
        Me.person.Name = "person"
        Me.person.Size = New System.Drawing.Size(350, 347)
        Me.person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.person.TabIndex = 5
        Me.person.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1327, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(364, 30)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(393, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(869, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Su préstamo no debe ser menor a 1000.00 dolares ni mayor a 5000.00 dolares."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(393, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese el valor del préstamo: "
        '
        'valprestamo
        '
        Me.valprestamo.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valprestamo.Location = New System.Drawing.Point(781, 202)
        Me.valprestamo.Multiline = True
        Me.valprestamo.Name = "valprestamo"
        Me.valprestamo.Size = New System.Drawing.Size(342, 36)
        Me.valprestamo.TabIndex = 4
        '
        'regres
        '
        Me.regres.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regres.Location = New System.Drawing.Point(914, 909)
        Me.regres.Name = "regres"
        Me.regres.Size = New System.Drawing.Size(131, 50)
        Me.regres.TabIndex = 21
        Me.regres.Text = "&Regresar"
        Me.regres.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1494, 1045)
        Me.Controls.Add(Me.regres)
        Me.Controls.Add(Me.valprestamo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.grupobox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.grupobox.ResumeLayout(False)
        Me.grupobox.PerformLayout()
        CType(Me.autos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.turismo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viviendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.person, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grupobox As GroupBox
    Friend WithEvents person As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents viviendas As PictureBox
    Friend WithEvents autos As PictureBox
    Friend WithEvents estudios As PictureBox
    Friend WithEvents turismo As PictureBox
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Friend WithEvents valprestamo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents env As Button
    Friend WithEvents regres As Button
    Friend WithEvents limp As Button
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents plazo As ComboBox
End Class
