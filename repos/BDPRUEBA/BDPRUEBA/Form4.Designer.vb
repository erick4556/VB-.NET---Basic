<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.insertar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.ver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'insertar
        '
        Me.insertar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(188, 185)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(186, 49)
        Me.insertar.TabIndex = 0
        Me.insertar.Text = "&Insertar"
        Me.insertar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(511, 185)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(186, 49)
        Me.eliminar.TabIndex = 1
        Me.eliminar.Text = "&Acciones"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(188, 310)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(186, 49)
        Me.buscar.TabIndex = 2
        Me.buscar.Text = "&Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'ver
        '
        Me.ver.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ver.Location = New System.Drawing.Point(511, 310)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(186, 49)
        Me.ver.TabIndex = 3
        Me.ver.Text = "&Ver registros"
        Me.ver.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 570)
        Me.Controls.Add(Me.ver)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.insertar)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents insertar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents buscar As Button
    Friend WithEvents ver As Button
End Class
