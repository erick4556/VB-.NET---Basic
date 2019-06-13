<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.aceite = New System.Windows.Forms.CheckBox()
        Me.correas = New System.Windows.Forms.CheckBox()
        Me.aline = New System.Windows.Forms.CheckBox()
        Me.revisado = New System.Windows.Forms.CheckBox()
        Me.piezas = New System.Windows.Forms.CheckBox()
        Me.total = New System.Windows.Forms.Label()
        Me.final = New System.Windows.Forms.Label()
        Me.env = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.efectivo = New System.Windows.Forms.RadioButton()
        Me.cheque = New System.Windows.Forms.RadioButton()
        Me.tarjeta = New System.Windows.Forms.RadioButton()
        Me.canace = New System.Windows.Forms.TextBox()
        Me.cantcorr = New System.Windows.Forms.TextBox()
        Me.canalin = New System.Windows.Forms.TextBox()
        Me.canrev = New System.Windows.Forms.TextBox()
        Me.canpiez = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pasajeros = New System.Windows.Forms.PictureBox()
        Me.pickup = New System.Windows.Forms.PictureBox()
        Me.sedan = New System.Windows.Forms.PictureBox()
        Me.taxi = New System.Windows.Forms.PictureBox()
        CType(Me.pasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pickup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sedan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taxi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(419, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(261, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'combo
        '
        Me.combo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo.FormattingEnabled = True
        Me.combo.Items.AddRange(New Object() {"Sedan", "Camionetas/Pick Up's", "Taxis", "Pasajeros"})
        Me.combo.Location = New System.Drawing.Point(457, 95)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(196, 31)
        Me.combo.TabIndex = 1
        '
        'aceite
        '
        Me.aceite.AutoSize = True
        Me.aceite.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceite.Location = New System.Drawing.Point(162, 95)
        Me.aceite.Name = "aceite"
        Me.aceite.Size = New System.Drawing.Size(186, 27)
        Me.aceite.TabIndex = 2
        Me.aceite.Text = "Cambio de aceite"
        Me.aceite.UseVisualStyleBackColor = True
        '
        'correas
        '
        Me.correas.AutoSize = True
        Me.correas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correas.Location = New System.Drawing.Point(162, 165)
        Me.correas.Name = "correas"
        Me.correas.Size = New System.Drawing.Size(172, 27)
        Me.correas.TabIndex = 3
        Me.correas.Text = "Cambio correas"
        Me.correas.UseVisualStyleBackColor = True
        '
        'aline
        '
        Me.aline.AutoSize = True
        Me.aline.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aline.Location = New System.Drawing.Point(162, 240)
        Me.aline.Name = "aline"
        Me.aline.Size = New System.Drawing.Size(143, 27)
        Me.aline.TabIndex = 4
        Me.aline.Text = "Alineamiento"
        Me.aline.UseVisualStyleBackColor = True
        '
        'revisado
        '
        Me.revisado.AutoSize = True
        Me.revisado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.revisado.Location = New System.Drawing.Point(162, 313)
        Me.revisado.Name = "revisado"
        Me.revisado.Size = New System.Drawing.Size(198, 27)
        Me.revisado.TabIndex = 5
        Me.revisado.Text = "Revisado Vehicular"
        Me.revisado.UseVisualStyleBackColor = True
        '
        'piezas
        '
        Me.piezas.AutoSize = True
        Me.piezas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piezas.Location = New System.Drawing.Point(159, 384)
        Me.piezas.Name = "piezas"
        Me.piezas.Size = New System.Drawing.Size(189, 27)
        Me.piezas.TabIndex = 6
        Me.piezas.Text = "Cambio de piezas"
        Me.piezas.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(33, 493)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(12, 17)
        Me.total.TabIndex = 7
        Me.total.Text = "."
        '
        'final
        '
        Me.final.AutoSize = True
        Me.final.Location = New System.Drawing.Point(159, 493)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(12, 17)
        Me.final.TabIndex = 8
        Me.final.Text = "."
        '
        'env
        '
        Me.env.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.env.Location = New System.Drawing.Point(109, 512)
        Me.env.Name = "env"
        Me.env.Size = New System.Drawing.Size(108, 37)
        Me.env.TabIndex = 9
        Me.env.Text = "&Enviar"
        Me.env.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(270, 512)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(108, 37)
        Me.limpiar.TabIndex = 10
        Me.limpiar.Text = "&Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'efectivo
        '
        Me.efectivo.AutoSize = True
        Me.efectivo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efectivo.Location = New System.Drawing.Point(468, 412)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(101, 27)
        Me.efectivo.TabIndex = 11
        Me.efectivo.TabStop = True
        Me.efectivo.Text = "Efectivo"
        Me.efectivo.UseVisualStyleBackColor = True
        '
        'cheque
        '
        Me.cheque.AutoSize = True
        Me.cheque.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheque.Location = New System.Drawing.Point(468, 473)
        Me.cheque.Name = "cheque"
        Me.cheque.Size = New System.Drawing.Size(98, 27)
        Me.cheque.TabIndex = 12
        Me.cheque.TabStop = True
        Me.cheque.Text = "Cheque"
        Me.cheque.UseVisualStyleBackColor = True
        '
        'tarjeta
        '
        Me.tarjeta.AutoSize = True
        Me.tarjeta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarjeta.Location = New System.Drawing.Point(468, 535)
        Me.tarjeta.Name = "tarjeta"
        Me.tarjeta.Size = New System.Drawing.Size(91, 27)
        Me.tarjeta.TabIndex = 13
        Me.tarjeta.TabStop = True
        Me.tarjeta.Text = "Tarjeta"
        Me.tarjeta.UseVisualStyleBackColor = True
        '
        'canace
        '
        Me.canace.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canace.Location = New System.Drawing.Point(35, 95)
        Me.canace.Name = "canace"
        Me.canace.Size = New System.Drawing.Size(100, 30)
        Me.canace.TabIndex = 14
        '
        'cantcorr
        '
        Me.cantcorr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantcorr.Location = New System.Drawing.Point(35, 165)
        Me.cantcorr.Name = "cantcorr"
        Me.cantcorr.Size = New System.Drawing.Size(100, 30)
        Me.cantcorr.TabIndex = 15
        '
        'canalin
        '
        Me.canalin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canalin.Location = New System.Drawing.Point(35, 240)
        Me.canalin.Name = "canalin"
        Me.canalin.Size = New System.Drawing.Size(100, 30)
        Me.canalin.TabIndex = 16
        '
        'canrev
        '
        Me.canrev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canrev.Location = New System.Drawing.Point(32, 310)
        Me.canrev.Name = "canrev"
        Me.canrev.Size = New System.Drawing.Size(100, 30)
        Me.canrev.TabIndex = 17
        '
        'canpiez
        '
        Me.canpiez.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canpiez.Location = New System.Drawing.Point(32, 382)
        Me.canpiez.Name = "canpiez"
        Me.canpiez.Size = New System.Drawing.Size(100, 30)
        Me.canpiez.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Cantidad Servicio"
        '
        'pasajeros
        '
        Me.pasajeros.Image = CType(resources.GetObject("pasajeros.Image"), System.Drawing.Image)
        Me.pasajeros.Location = New System.Drawing.Point(419, 149)
        Me.pasajeros.Name = "pasajeros"
        Me.pasajeros.Size = New System.Drawing.Size(305, 244)
        Me.pasajeros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pasajeros.TabIndex = 20
        Me.pasajeros.TabStop = False
        '
        'pickup
        '
        Me.pickup.Image = CType(resources.GetObject("pickup.Image"), System.Drawing.Image)
        Me.pickup.Location = New System.Drawing.Point(419, 149)
        Me.pickup.Name = "pickup"
        Me.pickup.Size = New System.Drawing.Size(305, 244)
        Me.pickup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pickup.TabIndex = 21
        Me.pickup.TabStop = False
        '
        'sedan
        '
        Me.sedan.Image = CType(resources.GetObject("sedan.Image"), System.Drawing.Image)
        Me.sedan.Location = New System.Drawing.Point(419, 149)
        Me.sedan.Name = "sedan"
        Me.sedan.Size = New System.Drawing.Size(305, 244)
        Me.sedan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.sedan.TabIndex = 22
        Me.sedan.TabStop = False
        '
        'taxi
        '
        Me.taxi.Image = CType(resources.GetObject("taxi.Image"), System.Drawing.Image)
        Me.taxi.Location = New System.Drawing.Point(419, 149)
        Me.taxi.Name = "taxi"
        Me.taxi.Size = New System.Drawing.Size(305, 244)
        Me.taxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.taxi.TabIndex = 23
        Me.taxi.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(832, 715)
        Me.Controls.Add(Me.taxi)
        Me.Controls.Add(Me.sedan)
        Me.Controls.Add(Me.pickup)
        Me.Controls.Add(Me.pasajeros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.canpiez)
        Me.Controls.Add(Me.canrev)
        Me.Controls.Add(Me.canalin)
        Me.Controls.Add(Me.cantcorr)
        Me.Controls.Add(Me.canace)
        Me.Controls.Add(Me.tarjeta)
        Me.Controls.Add(Me.cheque)
        Me.Controls.Add(Me.efectivo)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.env)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.piezas)
        Me.Controls.Add(Me.revisado)
        Me.Controls.Add(Me.aline)
        Me.Controls.Add(Me.correas)
        Me.Controls.Add(Me.aceite)
        Me.Controls.Add(Me.combo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pickup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sedan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taxi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents combo As ComboBox
    Friend WithEvents aceite As CheckBox
    Friend WithEvents correas As CheckBox
    Friend WithEvents aline As CheckBox
    Friend WithEvents revisado As CheckBox
    Friend WithEvents piezas As CheckBox
    Friend WithEvents total As Label
    Friend WithEvents final As Label
    Friend WithEvents env As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents efectivo As RadioButton
    Friend WithEvents cheque As RadioButton
    Friend WithEvents tarjeta As RadioButton
    Friend WithEvents canace As TextBox
    Friend WithEvents cantcorr As TextBox
    Friend WithEvents canalin As TextBox
    Friend WithEvents canrev As TextBox
    Friend WithEvents canpiez As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pasajeros As PictureBox
    Friend WithEvents pickup As PictureBox
    Friend WithEvents sedan As PictureBox
    Friend WithEvents taxi As PictureBox
End Class
