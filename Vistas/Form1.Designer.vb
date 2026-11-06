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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPesoSalida = New System.Windows.Forms.TextBox()
        Me.txtGlEntrega = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPesoEntrada = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtNumeroTransporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPortWeight = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 449)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblFechaEntrada)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtPedido)
        Me.Panel3.Controls.Add(Me.btnRegistrar)
        Me.Panel3.Controls.Add(Me.lblReloj)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TxtPesoSalida)
        Me.Panel3.Controls.Add(Me.txtGlEntrega)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TxtProveedor)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TxtPesoEntrada)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 378)
        Me.Panel3.TabIndex = 1
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrada.Location = New System.Drawing.Point(161, 202)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(0, 20)
        Me.lblFechaEntrada.TabIndex = 53
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 38)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 20)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Pedido"
        '
        'txtPedido
        '
        Me.txtPedido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.Location = New System.Drawing.Point(165, 164)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.ReadOnly = True
        Me.txtPedido.Size = New System.Drawing.Size(140, 26)
        Me.txtPedido.TabIndex = 7
        Me.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegistrar.Location = New System.Drawing.Point(522, 320)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(181, 38)
        Me.btnRegistrar.TabIndex = 14
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'lblReloj
        '
        Me.lblReloj.AutoSize = True
        Me.lblReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.Color.Red
        Me.lblReloj.Location = New System.Drawing.Point(549, 17)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(50, 20)
        Me.lblReloj.TabIndex = 48
        Me.lblReloj.Text = "Reloj"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(44, 199)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 20)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Fecha"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(240, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(199, 25)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "UNIDADES DIESEL"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(461, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Salida"
        '
        'TxtPesoSalida
        '
        Me.TxtPesoSalida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPesoSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPesoSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPesoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesoSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtPesoSalida.Location = New System.Drawing.Point(429, 91)
        Me.TxtPesoSalida.Name = "TxtPesoSalida"
        Me.TxtPesoSalida.ReadOnly = True
        Me.TxtPesoSalida.Size = New System.Drawing.Size(140, 26)
        Me.TxtPesoSalida.TabIndex = 38
        Me.TxtPesoSalida.TabStop = False
        Me.TxtPesoSalida.Text = "0"
        Me.TxtPesoSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGlEntrega
        '
        Me.txtGlEntrega.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtGlEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGlEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlEntrega.Location = New System.Drawing.Point(365, 242)
        Me.txtGlEntrega.Name = "txtGlEntrega"
        Me.txtGlEntrega.ReadOnly = True
        Me.txtGlEntrega.Size = New System.Drawing.Size(204, 26)
        Me.txtGlEntrega.TabIndex = 12
        Me.txtGlEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(192, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 25)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Entrada"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Proveedor"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(165, 132)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.ReadOnly = True
        Me.TxtProveedor.Size = New System.Drawing.Size(303, 26)
        Me.TxtProveedor.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Peso"
        '
        'TxtPesoEntrada
        '
        Me.TxtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPesoEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPesoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPesoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesoEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtPesoEntrada.Location = New System.Drawing.Point(165, 91)
        Me.TxtPesoEntrada.Name = "TxtPesoEntrada"
        Me.TxtPesoEntrada.ReadOnly = True
        Me.TxtPesoEntrada.Size = New System.Drawing.Size(140, 26)
        Me.TxtPesoEntrada.TabIndex = 9
        Me.TxtPesoEntrada.TabStop = False
        Me.TxtPesoEntrada.Text = "0"
        Me.TxtPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Galones Entregados"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtNumeroTransporte)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 71)
        Me.Panel2.TabIndex = 0
        '
        'TxtNumeroTransporte
        '
        Me.TxtNumeroTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumeroTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroTransporte.Location = New System.Drawing.Point(233, 27)
        Me.TxtNumeroTransporte.Name = "TxtNumeroTransporte"
        Me.TxtNumeroTransporte.Size = New System.Drawing.Size(159, 26)
        Me.TxtNumeroTransporte.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Placa Camión:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(553, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Configuracion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SerialPortWeight
        '
        Me.SerialPortWeight.PortName = "COM4"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 449)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Diesel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtNumeroTransporte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SerialPortWeight As IO.Ports.SerialPort
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPesoSalida As TextBox
    Friend WithEvents txtGlEntrega As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPesoEntrada As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblReloj As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblFechaEntrada As Label
End Class
