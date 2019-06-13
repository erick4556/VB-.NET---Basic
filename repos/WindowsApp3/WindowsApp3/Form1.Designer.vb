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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtmensaje = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbs8 = New System.Windows.Forms.PictureBox()
        Me.pbtablet = New System.Windows.Forms.PictureBox()
        Me.pblaptop = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbs8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbtablet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblaptop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmensaje
        '
        Me.txtmensaje.AutoSize = True
        Me.txtmensaje.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmensaje.Location = New System.Drawing.Point(29, 460)
        Me.txtmensaje.Name = "txtmensaje"
        Me.txtmensaje.Size = New System.Drawing.Size(72, 24)
        Me.txtmensaje.TabIndex = 9
        Me.txtmensaje.Text = "Label2"
        Me.txtmensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 314)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.ForeColor = System.Drawing.Color.Lime
        Me.rb3.Location = New System.Drawing.Point(7, 207)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(60, 31)
        Me.rb3.TabIndex = 2
        Me.rb3.TabStop = True
        Me.rb3.Text = "S8"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rb2.Location = New System.Drawing.Point(7, 129)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(99, 31)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "Tablet"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(7, 45)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(106, 31)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Laptop"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(241, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Uso y aplicación del objeto radio button"
        '
        'pbs8
        '
        Me.pbs8.Image = CType(resources.GetObject("pbs8.Image"), System.Drawing.Image)
        Me.pbs8.Location = New System.Drawing.Point(558, 139)
        Me.pbs8.Name = "pbs8"
        Me.pbs8.Size = New System.Drawing.Size(409, 297)
        Me.pbs8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbs8.TabIndex = 12
        Me.pbs8.TabStop = False
        '
        'pbtablet
        '
        Me.pbtablet.Image = CType(resources.GetObject("pbtablet.Image"), System.Drawing.Image)
        Me.pbtablet.Location = New System.Drawing.Point(558, 139)
        Me.pbtablet.Name = "pbtablet"
        Me.pbtablet.Size = New System.Drawing.Size(409, 297)
        Me.pbtablet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbtablet.TabIndex = 11
        Me.pbtablet.TabStop = False
        '
        'pblaptop
        '
        Me.pblaptop.Image = CType(resources.GetObject("pblaptop.Image"), System.Drawing.Image)
        Me.pblaptop.Location = New System.Drawing.Point(558, 139)
        Me.pblaptop.Name = "pblaptop"
        Me.pblaptop.Size = New System.Drawing.Size(409, 297)
        Me.pblaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblaptop.TabIndex = 10
        Me.pblaptop.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 539)
        Me.Controls.Add(Me.pbs8)
        Me.Controls.Add(Me.pbtablet)
        Me.Controls.Add(Me.pblaptop)
        Me.Controls.Add(Me.txtmensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbs8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbtablet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblaptop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmensaje As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents pbs8 As PictureBox
    Friend WithEvents pbtablet As PictureBox
    Friend WithEvents pblaptop As PictureBox
End Class
