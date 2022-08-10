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
        Me.salir1 = New System.Windows.Forms.Button()
        Me.salir2 = New System.Windows.Forms.Button()
        Me.texto1 = New System.Windows.Forms.Label()
        Me.texto2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'salir1
        '
        Me.salir1.Location = New System.Drawing.Point(111, 127)
        Me.salir1.Name = "salir1"
        Me.salir1.Size = New System.Drawing.Size(75, 23)
        Me.salir1.TabIndex = 4
        Me.salir1.Text = "Salir"
        Me.salir1.UseVisualStyleBackColor = True
        '
        'salir2
        '
        Me.salir2.Location = New System.Drawing.Point(111, 261)
        Me.salir2.Name = "salir2"
        Me.salir2.Size = New System.Drawing.Size(75, 23)
        Me.salir2.TabIndex = 5
        Me.salir2.Text = "Salir"
        Me.salir2.UseVisualStyleBackColor = True
        '
        'texto1
        '
        Me.texto1.AutoSize = True
        Me.texto1.Location = New System.Drawing.Point(50, 78)
        Me.texto1.Name = "texto1"
        Me.texto1.Size = New System.Drawing.Size(224, 13)
        Me.texto1.TabIndex = 6
        Me.texto1.Text = "Cerrar los dos formularios y cerrar la aplicacion"
        '
        'texto2
        '
        Me.texto2.AutoSize = True
        Me.texto2.Location = New System.Drawing.Point(72, 220)
        Me.texto2.Name = "texto2"
        Me.texto2.Size = New System.Drawing.Size(157, 13)
        Me.texto2.TabIndex = 7
        Me.texto2.Text = "Cerrar solamente este formulario"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 371)
        Me.Controls.Add(Me.texto2)
        Me.Controls.Add(Me.texto1)
        Me.Controls.Add(Me.salir2)
        Me.Controls.Add(Me.salir1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salir1 As Button
    Friend WithEvents salir2 As Button
    Friend WithEvents texto1 As Label
    Friend WithEvents texto2 As Label
End Class
