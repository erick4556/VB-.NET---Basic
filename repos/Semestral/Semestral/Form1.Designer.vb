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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tipoempresa = New System.Windows.Forms.ComboBox()
        Me.naseg = New System.Windows.Forms.PictureBox()
        Me.fedpa = New System.Windows.Forms.PictureBox()
        Me.inseg = New System.Windows.Forms.PictureBox()
        Me.assa = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.viviimage = New System.Windows.Forms.PictureBox()
        Me.autoimage = New System.Windows.Forms.PictureBox()
        Me.vidaimage = New System.Windows.Forms.PictureBox()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.enviar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.masculino = New System.Windows.Forms.RadioButton()
        Me.femenino = New System.Windows.Forms.RadioButton()
        Me.vivienda = New System.Windows.Forms.CheckBox()
        Me.automovil = New System.Windows.Forms.CheckBox()
        Me.vida = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.naseg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fedpa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inseg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.assa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viviimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.autoimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vidaimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cedula
        '
        Me.cedula.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedula.Location = New System.Drawing.Point(560, 180)
        Me.cedula.Multiline = True
        Me.cedula.Name = "cedula"
        Me.cedula.Size = New System.Drawing.Size(333, 36)
        Me.cedula.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(233, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ingrese  su cedula : "
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(560, 279)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(333, 36)
        Me.nombre.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ingrese  su nombre : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 33)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ingrese sexo : "
        '
        'direccion
        '
        Me.direccion.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(560, 473)
        Me.direccion.Multiline = True
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(333, 36)
        Me.direccion.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 33)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Ingrese  su dirección: "
        '
        'telefono
        '
        Me.telefono.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(560, 565)
        Me.telefono.Multiline = True
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(333, 36)
        Me.telefono.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 564)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 33)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ingrese  su télefono : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1003, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 28)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Tipo de empresa:"
        '
        'tipoempresa
        '
        Me.tipoempresa.AutoCompleteCustomSource.AddRange(New String() {"Privada", "Gobierno", "Independiente"})
        Me.tipoempresa.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipoempresa.FormattingEnabled = True
        Me.tipoempresa.Items.AddRange(New Object() {"Nacional de Seguros", "Fedpa", "Internacional de Seguros", "Assa"})
        Me.tipoempresa.Location = New System.Drawing.Point(1243, 178)
        Me.tipoempresa.Name = "tipoempresa"
        Me.tipoempresa.Size = New System.Drawing.Size(176, 35)
        Me.tipoempresa.TabIndex = 23
        '
        'naseg
        '
        Me.naseg.Image = CType(resources.GetObject("naseg.Image"), System.Drawing.Image)
        Me.naseg.Location = New System.Drawing.Point(1243, 230)
        Me.naseg.Name = "naseg"
        Me.naseg.Size = New System.Drawing.Size(266, 217)
        Me.naseg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.naseg.TabIndex = 25
        Me.naseg.TabStop = False
        '
        'fedpa
        '
        Me.fedpa.Image = CType(resources.GetObject("fedpa.Image"), System.Drawing.Image)
        Me.fedpa.Location = New System.Drawing.Point(1243, 230)
        Me.fedpa.Name = "fedpa"
        Me.fedpa.Size = New System.Drawing.Size(266, 217)
        Me.fedpa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fedpa.TabIndex = 26
        Me.fedpa.TabStop = False
        '
        'inseg
        '
        Me.inseg.Image = CType(resources.GetObject("inseg.Image"), System.Drawing.Image)
        Me.inseg.Location = New System.Drawing.Point(1243, 230)
        Me.inseg.Name = "inseg"
        Me.inseg.Size = New System.Drawing.Size(266, 217)
        Me.inseg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.inseg.TabIndex = 27
        Me.inseg.TabStop = False
        '
        'assa
        '
        Me.assa.Image = CType(resources.GetObject("assa.Image"), System.Drawing.Image)
        Me.assa.Location = New System.Drawing.Point(1243, 230)
        Me.assa.Name = "assa"
        Me.assa.Size = New System.Drawing.Size(266, 217)
        Me.assa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.assa.TabIndex = 28
        Me.assa.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1003, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 28)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Tipo de seguro:"
        '
        'viviimage
        '
        Me.viviimage.Image = CType(resources.GetObject("viviimage.Image"), System.Drawing.Image)
        Me.viviimage.Location = New System.Drawing.Point(1243, 476)
        Me.viviimage.Name = "viviimage"
        Me.viviimage.Size = New System.Drawing.Size(266, 217)
        Me.viviimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.viviimage.TabIndex = 33
        Me.viviimage.TabStop = False
        '
        'autoimage
        '
        Me.autoimage.Image = CType(resources.GetObject("autoimage.Image"), System.Drawing.Image)
        Me.autoimage.Location = New System.Drawing.Point(1557, 473)
        Me.autoimage.Name = "autoimage"
        Me.autoimage.Size = New System.Drawing.Size(266, 217)
        Me.autoimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.autoimage.TabIndex = 34
        Me.autoimage.TabStop = False
        '
        'vidaimage
        '
        Me.vidaimage.Image = CType(resources.GetObject("vidaimage.Image"), System.Drawing.Image)
        Me.vidaimage.Location = New System.Drawing.Point(1243, 732)
        Me.vidaimage.Name = "vidaimage"
        Me.vidaimage.Size = New System.Drawing.Size(266, 217)
        Me.vidaimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vidaimage.TabIndex = 35
        Me.vidaimage.TabStop = False
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(766, 741)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(130, 44)
        Me.limpiar.TabIndex = 37
        Me.limpiar.Text = "&Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'enviar
        '
        Me.enviar.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(560, 741)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(113, 44)
        Me.enviar.TabIndex = 36
        Me.enviar.Text = "&Enviar"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'masculino
        '
        Me.masculino.AutoSize = True
        Me.masculino.BackColor = System.Drawing.Color.Transparent
        Me.masculino.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masculino.Location = New System.Drawing.Point(560, 376)
        Me.masculino.Name = "masculino"
        Me.masculino.Size = New System.Drawing.Size(140, 32)
        Me.masculino.TabIndex = 38
        Me.masculino.TabStop = True
        Me.masculino.Text = "Masculino"
        Me.masculino.UseVisualStyleBackColor = False
        '
        'femenino
        '
        Me.femenino.AutoSize = True
        Me.femenino.BackColor = System.Drawing.Color.Transparent
        Me.femenino.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femenino.Location = New System.Drawing.Point(744, 376)
        Me.femenino.Name = "femenino"
        Me.femenino.Size = New System.Drawing.Size(139, 32)
        Me.femenino.TabIndex = 39
        Me.femenino.TabStop = True
        Me.femenino.Text = "Femenino"
        Me.femenino.UseVisualStyleBackColor = False
        '
        'vivienda
        '
        Me.vivienda.AutoSize = True
        Me.vivienda.BackColor = System.Drawing.Color.Transparent
        Me.vivienda.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vivienda.Location = New System.Drawing.Point(1008, 530)
        Me.vivienda.Name = "vivienda"
        Me.vivienda.Size = New System.Drawing.Size(127, 32)
        Me.vivienda.TabIndex = 40
        Me.vivienda.Text = "Vivienda"
        Me.vivienda.UseVisualStyleBackColor = False
        '
        'automovil
        '
        Me.automovil.AutoSize = True
        Me.automovil.BackColor = System.Drawing.Color.Transparent
        Me.automovil.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.automovil.Location = New System.Drawing.Point(1008, 599)
        Me.automovil.Name = "automovil"
        Me.automovil.Size = New System.Drawing.Size(144, 32)
        Me.automovil.TabIndex = 41
        Me.automovil.Text = "Automovil"
        Me.automovil.UseVisualStyleBackColor = False
        '
        'vida
        '
        Me.vida.AutoSize = True
        Me.vida.BackColor = System.Drawing.Color.Transparent
        Me.vida.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vida.Location = New System.Drawing.Point(1008, 675)
        Me.vida.Name = "vida"
        Me.vida.Size = New System.Drawing.Size(83, 32)
        Me.vida.TabIndex = 42
        Me.vida.Text = "Vida"
        Me.vida.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(515, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(561, 39)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Formulario de agregar nuevo cliente"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.vida)
        Me.Controls.Add(Me.automovil)
        Me.Controls.Add(Me.vivienda)
        Me.Controls.Add(Me.femenino)
        Me.Controls.Add(Me.masculino)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.vidaimage)
        Me.Controls.Add(Me.autoimage)
        Me.Controls.Add(Me.viviimage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.assa)
        Me.Controls.Add(Me.inseg)
        Me.Controls.Add(Me.fedpa)
        Me.Controls.Add(Me.naseg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tipoempresa)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cedula)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.naseg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fedpa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inseg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.assa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viviimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.autoimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vidaimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cedula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents telefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tipoempresa As ComboBox
    Friend WithEvents naseg As PictureBox
    Friend WithEvents fedpa As PictureBox
    Friend WithEvents inseg As PictureBox
    Friend WithEvents assa As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents viviimage As PictureBox
    Friend WithEvents autoimage As PictureBox
    Friend WithEvents vidaimage As PictureBox
    Friend WithEvents limpiar As Button
    Friend WithEvents enviar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents femenino As RadioButton
    Friend WithEvents masculino As RadioButton
    Friend WithEvents vivienda As CheckBox
    Friend WithEvents automovil As CheckBox
    Friend WithEvents vida As CheckBox
    Friend WithEvents Label7 As Label
End Class
