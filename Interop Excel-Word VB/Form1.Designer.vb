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
        Me.button2 = New System.Windows.Forms.Button()
        Me.Btn_Directorio = New System.Windows.Forms.Button()
        Me.Tbx_Directorio = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Tbx_Texto = New System.Windows.Forms.TextBox()
        Me.Tbx_Nombre = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.Blue
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(236, 314)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(326, 81)
        Me.button2.TabIndex = 17
        Me.button2.Text = "Generar Archivo Word"
        Me.button2.UseVisualStyleBackColor = False
        '
        'Btn_Directorio
        '
        Me.Btn_Directorio.BackColor = System.Drawing.Color.Silver
        Me.Btn_Directorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Directorio.Location = New System.Drawing.Point(626, 178)
        Me.Btn_Directorio.Name = "Btn_Directorio"
        Me.Btn_Directorio.Size = New System.Drawing.Size(36, 29)
        Me.Btn_Directorio.TabIndex = 16
        Me.Btn_Directorio.Text = "..."
        Me.Btn_Directorio.UseVisualStyleBackColor = False
        '
        'Tbx_Directorio
        '
        Me.Tbx_Directorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Directorio.Location = New System.Drawing.Point(339, 178)
        Me.Tbx_Directorio.MaxLength = 200
        Me.Tbx_Directorio.Name = "Tbx_Directorio"
        Me.Tbx_Directorio.Size = New System.Drawing.Size(281, 29)
        Me.Tbx_Directorio.TabIndex = 15
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(135, 180)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(194, 25)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Carpeta de destino"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(156, 129)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(177, 25)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Texto del archivo"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(135, 71)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(198, 25)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Nombre del archivo"
        '
        'Tbx_Texto
        '
        Me.Tbx_Texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Texto.Location = New System.Drawing.Point(339, 127)
        Me.Tbx_Texto.MaxLength = 200
        Me.Tbx_Texto.Name = "Tbx_Texto"
        Me.Tbx_Texto.Size = New System.Drawing.Size(281, 29)
        Me.Tbx_Texto.TabIndex = 11
        '
        'Tbx_Nombre
        '
        Me.Tbx_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Nombre.Location = New System.Drawing.Point(339, 69)
        Me.Tbx_Nombre.MaxLength = 60
        Me.Tbx_Nombre.Name = "Tbx_Nombre"
        Me.Tbx_Nombre.Size = New System.Drawing.Size(281, 29)
        Me.Tbx_Nombre.TabIndex = 10
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(236, 227)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(326, 81)
        Me.button1.TabIndex = 9
        Me.button1.Text = "Generar Archivo Excel"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.Btn_Directorio)
        Me.Controls.Add(Me.Tbx_Directorio)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Tbx_Texto)
        Me.Controls.Add(Me.Tbx_Nombre)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents Btn_Directorio As Button
    Private WithEvents Tbx_Directorio As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Tbx_Texto As TextBox
    Private WithEvents Tbx_Nombre As TextBox
    Private WithEvents button1 As Button
End Class
