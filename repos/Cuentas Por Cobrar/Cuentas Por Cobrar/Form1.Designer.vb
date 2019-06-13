<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clientes = New System.Windows.Forms.Button()
        Me.ventas = New System.Windows.Forms.Button()
        Me.devoluciones = New System.Windows.Forms.Button()
        Me.pasgos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cuentas Por Cobrar"
        '
        'clientes
        '
        Me.clientes.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.clientes.BackgroundImage = CType(resources.GetObject("clientes.BackgroundImage"), System.Drawing.Image)
        Me.clientes.Location = New System.Drawing.Point(139, 79)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(267, 182)
        Me.clientes.TabIndex = 0
        Me.clientes.UseVisualStyleBackColor = False
        '
        'ventas
        '
        Me.ventas.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ventas.BackgroundImage = CType(resources.GetObject("ventas.BackgroundImage"), System.Drawing.Image)
        Me.ventas.Location = New System.Drawing.Point(139, 293)
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(267, 182)
        Me.ventas.TabIndex = 2
        Me.ventas.UseVisualStyleBackColor = False
        '
        'devoluciones
        '
        Me.devoluciones.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.devoluciones.BackgroundImage = CType(resources.GetObject("devoluciones.BackgroundImage"), System.Drawing.Image)
        Me.devoluciones.Location = New System.Drawing.Point(444, 293)
        Me.devoluciones.Name = "devoluciones"
        Me.devoluciones.Size = New System.Drawing.Size(267, 182)
        Me.devoluciones.TabIndex = 3
        Me.devoluciones.UseVisualStyleBackColor = False
        '
        'pasgos
        '
        Me.pasgos.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pasgos.BackgroundImage = CType(resources.GetObject("pasgos.BackgroundImage"), System.Drawing.Image)
        Me.pasgos.Location = New System.Drawing.Point(444, 79)
        Me.pasgos.Name = "pasgos"
        Me.pasgos.Size = New System.Drawing.Size(267, 182)
        Me.pasgos.TabIndex = 1
        Me.pasgos.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(838, 504)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.devoluciones)
        Me.Controls.Add(Me.ventas)
        Me.Controls.Add(Me.pasgos)
        Me.Controls.Add(Me.clientes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents clientes As Button
    Friend WithEvents ventas As Button
    Friend WithEvents devoluciones As Button
    Friend WithEvents pasgos As Button
End Class
