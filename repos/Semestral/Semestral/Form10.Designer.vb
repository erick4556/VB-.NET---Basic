<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.letram = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.plazop = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.poliauto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.valauto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.placa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.aauto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Tabla Auto"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(63, 496)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1111, 252)
        Me.DataGridView1.TabIndex = 51
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(426, 445)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(139, 30)
        Me.txtsearch.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(253, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Buscar por Cedula"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(824, 441)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 48
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(726, 441)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(632, 441)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'letram
        '
        Me.letram.AutoSize = True
        Me.letram.BackColor = System.Drawing.Color.Transparent
        Me.letram.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letram.Location = New System.Drawing.Point(422, 369)
        Me.letram.Name = "letram"
        Me.letram.Size = New System.Drawing.Size(54, 24)
        Me.letram.TabIndex = 77
        Me.letram.Text = "XXXX"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(269, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 24)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Letra Mensual: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(582, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 24)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "meses"
        '
        'plazop
        '
        Me.plazop.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plazop.Location = New System.Drawing.Point(426, 322)
        Me.plazop.Multiline = True
        Me.plazop.Name = "plazop"
        Me.plazop.Size = New System.Drawing.Size(139, 30)
        Me.plazop.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 24)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Plazo de pago:"
        '
        'poliauto
        '
        Me.poliauto.AutoSize = True
        Me.poliauto.BackColor = System.Drawing.Color.Transparent
        Me.poliauto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poliauto.Location = New System.Drawing.Point(422, 285)
        Me.poliauto.Name = "poliauto"
        Me.poliauto.Size = New System.Drawing.Size(54, 24)
        Me.poliauto.TabIndex = 85
        Me.poliauto.Text = "XXXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Poliza de auto:"
        '
        'valauto
        '
        Me.valauto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valauto.Location = New System.Drawing.Point(426, 236)
        Me.valauto.Multiline = True
        Me.valauto.Name = "valauto"
        Me.valauto.Size = New System.Drawing.Size(139, 30)
        Me.valauto.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Valor del auto  : "
        '
        'placa
        '
        Me.placa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placa.Location = New System.Drawing.Point(426, 185)
        Me.placa.Multiline = True
        Me.placa.Name = "placa"
        Me.placa.Size = New System.Drawing.Size(139, 30)
        Me.placa.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Placa  : "
        '
        'aauto
        '
        Me.aauto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aauto.Location = New System.Drawing.Point(426, 133)
        Me.aauto.Multiline = True
        Me.aauto.Name = "aauto"
        Me.aauto.Size = New System.Drawing.Size(139, 30)
        Me.aauto.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(275, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 24)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Año del auto  : "
        '
        'atras
        '
        Me.atras.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.Location = New System.Drawing.Point(1120, 1)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(139, 51)
        Me.atras.TabIndex = 89
        Me.atras.Text = "&Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1260, 760)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.plazop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.poliauto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.valauto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.placa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.aauto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.letram)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "Form10"
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
    Friend WithEvents letram As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents plazop As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents poliauto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents valauto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents placa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents aauto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents atras As Button
End Class
