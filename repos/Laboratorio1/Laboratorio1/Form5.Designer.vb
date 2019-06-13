<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.activar = New System.Windows.Forms.Button()
        Me.desactivar = New System.Windows.Forms.Button()
        Me.avan = New System.Windows.Forms.Button()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(396, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Uso del Picture Box"
        '
        'imagen
        '
        Me.imagen.Image = CType(resources.GetObject("imagen.Image"), System.Drawing.Image)
        Me.imagen.Location = New System.Drawing.Point(266, 41)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(523, 337)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 1
        Me.imagen.TabStop = False
        '
        'activar
        '
        Me.activar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activar.Location = New System.Drawing.Point(479, 395)
        Me.activar.Name = "activar"
        Me.activar.Size = New System.Drawing.Size(146, 49)
        Me.activar.TabIndex = 2
        Me.activar.Text = "Activar"
        Me.activar.UseVisualStyleBackColor = True
        '
        'desactivar
        '
        Me.desactivar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desactivar.Location = New System.Drawing.Point(479, 395)
        Me.desactivar.Name = "desactivar"
        Me.desactivar.Size = New System.Drawing.Size(146, 49)
        Me.desactivar.TabIndex = 3
        Me.desactivar.Text = "Desactivar"
        Me.desactivar.UseVisualStyleBackColor = True
        '
        'avan
        '
        Me.avan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avan.Location = New System.Drawing.Point(453, 466)
        Me.avan.Name = "avan"
        Me.avan.Size = New System.Drawing.Size(212, 49)
        Me.avan.TabIndex = 6
        Me.avan.Text = "&Avanzar"
        Me.avan.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 527)
        Me.Controls.Add(Me.avan)
        Me.Controls.Add(Me.desactivar)
        Me.Controls.Add(Me.activar)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents imagen As PictureBox
    Friend WithEvents activar As Button
    Friend WithEvents desactivar As Button
    Friend WithEvents avan As Button
End Class
