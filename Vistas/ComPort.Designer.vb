<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComPort
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPuertoActual = New System.Windows.Forms.Label()
        Me.BtnAceptarPuerto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbPuertos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(23, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Puerto Actual:"
        '
        'LblPuertoActual
        '
        Me.LblPuertoActual.AutoSize = True
        Me.LblPuertoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuertoActual.ForeColor = System.Drawing.Color.Navy
        Me.LblPuertoActual.Location = New System.Drawing.Point(157, 56)
        Me.LblPuertoActual.Name = "LblPuertoActual"
        Me.LblPuertoActual.Size = New System.Drawing.Size(62, 24)
        Me.LblPuertoActual.TabIndex = 8
        Me.LblPuertoActual.Text = "Actual"
        '
        'BtnAceptarPuerto
        '
        Me.BtnAceptarPuerto.BackColor = System.Drawing.Color.White
        Me.BtnAceptarPuerto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptarPuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptarPuerto.ForeColor = System.Drawing.Color.Navy
        Me.BtnAceptarPuerto.Location = New System.Drawing.Point(285, 100)
        Me.BtnAceptarPuerto.Name = "BtnAceptarPuerto"
        Me.BtnAceptarPuerto.Size = New System.Drawing.Size(123, 32)
        Me.BtnAceptarPuerto.TabIndex = 7
        Me.BtnAceptarPuerto.Text = "Aceptar"
        Me.BtnAceptarPuerto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Puerto Serial"
        '
        'CmbPuertos
        '
        Me.CmbPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPuertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPuertos.FormattingEnabled = True
        Me.CmbPuertos.Location = New System.Drawing.Point(161, 21)
        Me.CmbPuertos.Name = "CmbPuertos"
        Me.CmbPuertos.Size = New System.Drawing.Size(247, 32)
        Me.CmbPuertos.TabIndex = 5
        '
        'ComPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 154)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPuertoActual)
        Me.Controls.Add(Me.BtnAceptarPuerto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbPuertos)
        Me.Name = "ComPort"
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents LblPuertoActual As Label
    Friend WithEvents BtnAceptarPuerto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbPuertos As ComboBox
End Class
