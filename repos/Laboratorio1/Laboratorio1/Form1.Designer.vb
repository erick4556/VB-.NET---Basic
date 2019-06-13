<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.inicializar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTRADA Y CONTROL DE USUARIOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de usuario: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clave de usuario: "
        '
        'txtusuario
        '
        Me.txtusuario.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(289, 98)
        Me.txtusuario.MaxLength = 15
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(271, 34)
        Me.txtusuario.TabIndex = 3
        '
        'txtclave
        '
        Me.txtclave.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(289, 171)
        Me.txtclave.MaxLength = 15
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(271, 34)
        Me.txtclave.TabIndex = 4
        '
        'aceptar
        '
        Me.aceptar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.Location = New System.Drawing.Point(213, 265)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(109, 42)
        Me.aceptar.TabIndex = 5
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'inicializar
        '
        Me.inicializar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicializar.Location = New System.Drawing.Point(381, 265)
        Me.inicializar.Name = "inicializar"
        Me.inicializar.Size = New System.Drawing.Size(135, 42)
        Me.inicializar.TabIndex = 6
        Me.inicializar.Text = "Inicializar"
        Me.inicializar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.Location = New System.Drawing.Point(569, 265)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(122, 42)
        Me.salir.TabIndex = 7
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Lab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(952, 532)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.inicializar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Lab1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents aceptar As Button
    Friend WithEvents inicializar As Button
    Friend WithEvents salir As Button
End Class
