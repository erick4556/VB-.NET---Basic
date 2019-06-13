<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.view = New System.Windows.Forms.DataGridView()
        Me.regres = New System.Windows.Forms.Button()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Todos los registros"
        '
        'view
        '
        Me.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.view.Location = New System.Drawing.Point(160, 132)
        Me.view.Name = "view"
        Me.view.RowTemplate.Height = 24
        Me.view.Size = New System.Drawing.Size(511, 262)
        Me.view.TabIndex = 1
        '
        'regres
        '
        Me.regres.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regres.Location = New System.Drawing.Point(313, 421)
        Me.regres.Name = "regres"
        Me.regres.Size = New System.Drawing.Size(166, 36)
        Me.regres.TabIndex = 15
        Me.regres.Text = "&Regresar"
        Me.regres.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 511)
        Me.Controls.Add(Me.regres)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents view As DataGridView
    Friend WithEvents regres As Button
End Class
