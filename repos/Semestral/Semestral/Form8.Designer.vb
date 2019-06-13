<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sexo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tipo_seguro = New System.Windows.Forms.TextBox()
        Me.tipo_empresa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.id2 = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tabla Poliza"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 598)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1111, 252)
        Me.DataGridView1.TabIndex = 51
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(434, 547)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(139, 30)
        Me.txtsearch.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(261, 553)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Buscar por Cedula"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(832, 543)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 48
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(734, 543)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(640, 543)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'telefono
        '
        Me.telefono.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(599, 281)
        Me.telefono.Multiline = True
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(188, 30)
        Me.telefono.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(395, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 24)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Ingrese  su télefono : "
        '
        'direccion
        '
        Me.direccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.Location = New System.Drawing.Point(599, 229)
        Me.direccion.Multiline = True
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(188, 30)
        Me.direccion.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(395, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 24)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Ingrese  su dirección: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 24)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Ingrese sexo : "
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(599, 123)
        Me.nombre.Multiline = True
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(188, 30)
        Me.nombre.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(406, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 24)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Ingrese  su nombre : "
        '
        'sexo
        '
        Me.sexo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexo.Location = New System.Drawing.Point(599, 174)
        Me.sexo.Multiline = True
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(188, 30)
        Me.sexo.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(441, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Tipo de seguro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(426, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 24)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Tipo de empresa:"
        '
        'tipo_seguro
        '
        Me.tipo_seguro.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo_seguro.Location = New System.Drawing.Point(599, 417)
        Me.tipo_seguro.Multiline = True
        Me.tipo_seguro.Name = "tipo_seguro"
        Me.tipo_seguro.Size = New System.Drawing.Size(188, 30)
        Me.tipo_seguro.TabIndex = 65
        '
        'tipo_empresa
        '
        Me.tipo_empresa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo_empresa.Location = New System.Drawing.Point(598, 333)
        Me.tipo_empresa.Multiline = True
        Me.tipo_empresa.Name = "tipo_empresa"
        Me.tipo_empresa.Size = New System.Drawing.Size(188, 30)
        Me.tipo_empresa.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(808, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 17)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "1. Nacional de Seguros "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(810, 420)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 17)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "1. Vivienda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(809, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 17)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "(Masculino,Femenino)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1000, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 17)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "2. Fedpa"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(808, 360)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(186, 17)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "3. Internacional de Seguros "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1000, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 17)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "4. Asssa"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(810, 446)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 17)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "2. Auto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(810, 472)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 17)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "3. Vida"
        '
        'id2
        '
        Me.id2.AutoSize = True
        Me.id2.Location = New System.Drawing.Point(1000, 154)
        Me.id2.Name = "id2"
        Me.id2.Size = New System.Drawing.Size(53, 17)
        Me.id2.TabIndex = 74
        Me.id2.Text = "XXXXX"
        '
        'atras
        '
        Me.atras.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.Location = New System.Drawing.Point(1133, -1)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(139, 51)
        Me.atras.TabIndex = 75
        Me.atras.Text = "&Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1274, 918)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.id2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tipo_seguro)
        Me.Controls.Add(Me.tipo_empresa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.sexo)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents telefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents sexo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tipo_seguro As TextBox
    Friend WithEvents tipo_empresa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents id2 As Label
    Friend WithEvents atras As Button
End Class
