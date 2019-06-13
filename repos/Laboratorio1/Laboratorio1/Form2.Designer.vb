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
        Me.mensaje = New System.Windows.Forms.Label()
        Me.vermensaje = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.Label()
        Me.avan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.mensaje.Location = New System.Drawing.Point(68, 129)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(592, 40)
        Me.mensaje.TabIndex = 0
        Me.mensaje.Text = "Bienvenido al sistema de desarrollo 8"
        '
        'vermensaje
        '
        Me.vermensaje.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vermensaje.Location = New System.Drawing.Point(66, 219)
        Me.vermensaje.Name = "vermensaje"
        Me.vermensaje.Size = New System.Drawing.Size(133, 35)
        Me.vermensaje.TabIndex = 1
        Me.vermensaje.Text = "&Ver Mensaje"
        Me.vermensaje.UseVisualStyleBackColor = True
        '
        'cerrar
        '
        Me.cerrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.Location = New System.Drawing.Point(262, 219)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(139, 35)
        Me.cerrar.TabIndex = 2
        Me.cerrar.Text = "&Cerrar"
        Me.cerrar.UseVisualStyleBackColor = True
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(529, 13)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(15, 22)
        Me.usuario.TabIndex = 3
        Me.usuario.Text = "."
        '
        'avan
        '
        Me.avan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avan.Location = New System.Drawing.Point(162, 308)
        Me.avan.Name = "avan"
        Me.avan.Size = New System.Drawing.Size(139, 35)
        Me.avan.TabIndex = 4
        Me.avan.Text = "&Avanzar"
        Me.avan.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(761, 408)
        Me.Controls.Add(Me.avan)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.vermensaje)
        Me.Controls.Add(Me.mensaje)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mensaje As Label
    Friend WithEvents vermensaje As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents usuario As Label
    Friend WithEvents avan As Button
End Class
