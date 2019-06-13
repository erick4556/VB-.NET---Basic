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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdatos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbentrada = New System.Windows.Forms.ListBox()
        Me.lbsalida = New System.Windows.Forms.ListBox()
        Me.enviar = New System.Windows.Forms.Button()
        Me.copiar = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.avan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Box"
        '
        'txtdatos
        '
        Me.txtdatos.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatos.Location = New System.Drawing.Point(221, 118)
        Me.txtdatos.Multiline = True
        Me.txtdatos.Name = "txtdatos"
        Me.txtdatos.Size = New System.Drawing.Size(250, 30)
        Me.txtdatos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Escriba los datos:"
        '
        'lbentrada
        '
        Me.lbentrada.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbentrada.FormattingEnabled = True
        Me.lbentrada.ItemHeight = 27
        Me.lbentrada.Location = New System.Drawing.Point(39, 199)
        Me.lbentrada.Name = "lbentrada"
        Me.lbentrada.Size = New System.Drawing.Size(314, 274)
        Me.lbentrada.TabIndex = 3
        '
        'lbsalida
        '
        Me.lbsalida.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsalida.FormattingEnabled = True
        Me.lbsalida.ItemHeight = 27
        Me.lbsalida.Location = New System.Drawing.Point(463, 199)
        Me.lbsalida.Name = "lbsalida"
        Me.lbsalida.Size = New System.Drawing.Size(323, 274)
        Me.lbsalida.TabIndex = 4
        '
        'enviar
        '
        Me.enviar.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(519, 118)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(145, 36)
        Me.enviar.TabIndex = 5
        Me.enviar.Text = "&Enviar"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'copiar
        '
        Me.copiar.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copiar.Location = New System.Drawing.Point(39, 500)
        Me.copiar.Name = "copiar"
        Me.copiar.Size = New System.Drawing.Size(145, 36)
        Me.copiar.TabIndex = 6
        Me.copiar.Text = "&Copiar"
        Me.copiar.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(463, 500)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(145, 36)
        Me.borrar.TabIndex = 7
        Me.borrar.Text = "&Borrar"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'avan
        '
        Me.avan.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avan.Location = New System.Drawing.Point(306, 557)
        Me.avan.Name = "avan"
        Me.avan.Size = New System.Drawing.Size(145, 36)
        Me.avan.TabIndex = 8
        Me.avan.Text = "&Avanzar"
        Me.avan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 605)
        Me.Controls.Add(Me.avan)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.copiar)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.lbsalida)
        Me.Controls.Add(Me.lbentrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdatos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtdatos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbentrada As ListBox
    Friend WithEvents lbsalida As ListBox
    Friend WithEvents enviar As Button
    Friend WithEvents copiar As Button
    Friend WithEvents borrar As Button
    Friend WithEvents avan As Button
End Class
