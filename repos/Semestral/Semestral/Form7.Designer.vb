<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.BtnAuto = New System.Windows.Forms.Button()
        Me.BtnPoliza = New System.Windows.Forms.Button()
        Me.BtnTerreno = New System.Windows.Forms.Button()
        Me.BtnVida = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAuto
        '
        Me.BtnAuto.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAuto.Location = New System.Drawing.Point(259, 366)
        Me.BtnAuto.Name = "BtnAuto"
        Me.BtnAuto.Size = New System.Drawing.Size(238, 104)
        Me.BtnAuto.TabIndex = 38
        Me.BtnAuto.Text = "&Auto"
        Me.BtnAuto.UseVisualStyleBackColor = True
        '
        'BtnPoliza
        '
        Me.BtnPoliza.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPoliza.Location = New System.Drawing.Point(259, 171)
        Me.BtnPoliza.Name = "BtnPoliza"
        Me.BtnPoliza.Size = New System.Drawing.Size(238, 104)
        Me.BtnPoliza.TabIndex = 39
        Me.BtnPoliza.Text = "&Poliza"
        Me.BtnPoliza.UseVisualStyleBackColor = True
        '
        'BtnTerreno
        '
        Me.BtnTerreno.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTerreno.Location = New System.Drawing.Point(679, 171)
        Me.BtnTerreno.Name = "BtnTerreno"
        Me.BtnTerreno.Size = New System.Drawing.Size(238, 104)
        Me.BtnTerreno.TabIndex = 40
        Me.BtnTerreno.Text = "&Terreno"
        Me.BtnTerreno.UseVisualStyleBackColor = True
        '
        'BtnVida
        '
        Me.BtnVida.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVida.Location = New System.Drawing.Point(679, 366)
        Me.BtnVida.Name = "BtnVida"
        Me.BtnVida.Size = New System.Drawing.Size(238, 104)
        Me.BtnVida.TabIndex = 41
        Me.BtnVida.Text = "&Vida"
        Me.BtnVida.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 43)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Seleccione una tabla"
        '
        'atras
        '
        Me.atras.Font = New System.Drawing.Font("Imprint MT Shadow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.Location = New System.Drawing.Point(1059, 1)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(139, 51)
        Me.atras.TabIndex = 49
        Me.atras.Text = "&Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1199, 543)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnVida)
        Me.Controls.Add(Me.BtnTerreno)
        Me.Controls.Add(Me.BtnPoliza)
        Me.Controls.Add(Me.BtnAuto)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAuto As Button
    Friend WithEvents BtnPoliza As Button
    Friend WithEvents BtnTerreno As Button
    Friend WithEvents BtnVida As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents atras As Button
End Class
