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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cerrar1 = New System.Windows.Forms.Button()
        Me.cerrar2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cerrar los dos formularios y cerrar la aplicacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cerrar solamente este formulario"
        '
        'cerrar1
        '
        Me.cerrar1.Location = New System.Drawing.Point(102, 136)
        Me.cerrar1.Name = "cerrar1"
        Me.cerrar1.Size = New System.Drawing.Size(75, 23)
        Me.cerrar1.TabIndex = 2
        Me.cerrar1.Text = "salir1"
        Me.cerrar1.UseVisualStyleBackColor = True
        '
        'cerrar2
        '
        Me.cerrar2.Location = New System.Drawing.Point(102, 275)
        Me.cerrar2.Name = "cerrar2"
        Me.cerrar2.Size = New System.Drawing.Size(75, 23)
        Me.cerrar2.TabIndex = 3
        Me.cerrar2.Text = "salir2"
        Me.cerrar2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 388)
        Me.Controls.Add(Me.cerrar2)
        Me.Controls.Add(Me.cerrar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cerrar1 As Button
    Friend WithEvents cerrar2 As Button
End Class
