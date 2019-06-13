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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtcant1 = New System.Windows.Forms.TextBox()
        Me.txtcant2 = New System.Windows.Forms.TextBox()
        Me.txtcant3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chs8 = New System.Windows.Forms.CheckBox()
        Me.chtablet = New System.Windows.Forms.CheckBox()
        Me.chlaptop = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcantotal = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtlinea3 = New System.Windows.Forms.TextBox()
        Me.txtlinea2 = New System.Windows.Forms.TextBox()
        Me.txtlinea1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calcular = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Uso y aplicaciones del objeto checkbox"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del cliente: "
        '
        'txtcliente
        '
        Me.txtcliente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(323, 92)
        Me.txtcliente.Multiline = True
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(261, 27)
        Me.txtcliente.TabIndex = 2
        '
        'txtcant1
        '
        Me.txtcant1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcant1.Location = New System.Drawing.Point(71, 196)
        Me.txtcant1.Multiline = True
        Me.txtcant1.Name = "txtcant1"
        Me.txtcant1.Size = New System.Drawing.Size(138, 27)
        Me.txtcant1.TabIndex = 3
        '
        'txtcant2
        '
        Me.txtcant2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcant2.Location = New System.Drawing.Point(71, 273)
        Me.txtcant2.Multiline = True
        Me.txtcant2.Name = "txtcant2"
        Me.txtcant2.Size = New System.Drawing.Size(138, 27)
        Me.txtcant2.TabIndex = 4
        '
        'txtcant3
        '
        Me.txtcant3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcant3.Location = New System.Drawing.Point(71, 348)
        Me.txtcant3.Multiline = True
        Me.txtcant3.Name = "txtcant3"
        Me.txtcant3.Size = New System.Drawing.Size(138, 27)
        Me.txtcant3.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chs8)
        Me.GroupBox1.Controls.Add(Me.chtablet)
        Me.GroupBox1.Controls.Add(Me.chlaptop)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(323, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 214)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Multiples opciones"
        '
        'chs8
        '
        Me.chs8.AutoSize = True
        Me.chs8.Location = New System.Drawing.Point(18, 180)
        Me.chs8.Name = "chs8"
        Me.chs8.Size = New System.Drawing.Size(56, 26)
        Me.chs8.TabIndex = 2
        Me.chs8.Text = "S8"
        Me.chs8.UseVisualStyleBackColor = True
        '
        'chtablet
        '
        Me.chtablet.AutoSize = True
        Me.chtablet.Location = New System.Drawing.Point(18, 107)
        Me.chtablet.Name = "chtablet"
        Me.chtablet.Size = New System.Drawing.Size(89, 26)
        Me.chtablet.TabIndex = 1
        Me.chtablet.Text = "Tablet"
        Me.chtablet.UseVisualStyleBackColor = True
        '
        'chlaptop
        '
        Me.chlaptop.AutoSize = True
        Me.chlaptop.Location = New System.Drawing.Point(18, 43)
        Me.chlaptop.Name = "chlaptop"
        Me.chlaptop.Size = New System.Drawing.Size(97, 26)
        Me.chlaptop.TabIndex = 0
        Me.chlaptop.Text = "Laptop"
        Me.chlaptop.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cant."
        '
        'txtcantotal
        '
        Me.txtcantotal.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantotal.Location = New System.Drawing.Point(71, 419)
        Me.txtcantotal.Multiline = True
        Me.txtcantotal.Name = "txtcantotal"
        Me.txtcantotal.Size = New System.Drawing.Size(138, 27)
        Me.txtcantotal.TabIndex = 8
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(672, 419)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(138, 27)
        Me.txttotal.TabIndex = 12
        '
        'txtlinea3
        '
        Me.txtlinea3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlinea3.Location = New System.Drawing.Point(672, 348)
        Me.txtlinea3.Multiline = True
        Me.txtlinea3.Name = "txtlinea3"
        Me.txtlinea3.Size = New System.Drawing.Size(138, 27)
        Me.txtlinea3.TabIndex = 11
        '
        'txtlinea2
        '
        Me.txtlinea2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlinea2.Location = New System.Drawing.Point(672, 273)
        Me.txtlinea2.Multiline = True
        Me.txtlinea2.Name = "txtlinea2"
        Me.txtlinea2.Size = New System.Drawing.Size(138, 27)
        Me.txtlinea2.TabIndex = 10
        '
        'txtlinea1
        '
        Me.txtlinea1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlinea1.Location = New System.Drawing.Point(672, 196)
        Me.txtlinea1.Multiline = True
        Me.txtlinea1.Name = "txtlinea1"
        Me.txtlinea1.Size = New System.Drawing.Size(138, 27)
        Me.txtlinea1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(697, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "T x Linea"
        '
        'calcular
        '
        Me.calcular.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcular.Location = New System.Drawing.Point(194, 507)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(149, 50)
        Me.calcular.TabIndex = 14
        Me.calcular.Text = "&Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(396, 507)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(149, 50)
        Me.btn2.TabIndex = 15
        Me.btn2.Text = "&Limpiar"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(596, 507)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(149, 50)
        Me.btn3.TabIndex = 16
        Me.btn3.Text = "&Salir"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(960, 605)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtlinea3)
        Me.Controls.Add(Me.txtlinea2)
        Me.Controls.Add(Me.txtlinea1)
        Me.Controls.Add(Me.txtcantotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtcant3)
        Me.Controls.Add(Me.txtcant2)
        Me.Controls.Add(Me.txtcant1)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents txtcant1 As TextBox
    Friend WithEvents txtcant2 As TextBox
    Friend WithEvents txtcant3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chs8 As CheckBox
    Friend WithEvents chtablet As CheckBox
    Friend WithEvents chlaptop As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcantotal As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtlinea3 As TextBox
    Friend WithEvents txtlinea2 As TextBox
    Friend WithEvents txtlinea1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents calcular As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
