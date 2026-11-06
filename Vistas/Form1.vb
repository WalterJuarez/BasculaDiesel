Imports System.Math

Public Class Form1

    Dim txtSiguiente(14) As TextBox
    Dim no_unidad As String = ""
    Dim Imprimir As Integer = 0
    Dim estadoG As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComPort.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNumeroTransporte.Select()



        Try
            SerialPortWeight.PortName = My.Settings.NombrePuerto
            SerialPortWeight.Open()
        Catch ex As Exception
            GuardarError("Error al abrir el puerto COM de la bascula. " & vbCrLf & vbCrLf & ex.ToString)
        End Try

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblReloj.Text = DateTime.Now.ToLongTimeString
        If SerialPortWeight.IsOpen Then
            Dim Texto As String = SerialPortWeight.ReadExisting
            Dim Nuevo As String = ""
            Dim Empieza As Integer = 0

            For i = 0 To Texto.Length - 1 Step 1
                If IsNumeric(Texto(i)) Then
                    If Empieza = 1 Then Nuevo += Texto(i)
                Else
                    If Empieza = 0 Then
                        Nuevo = ""
                        Empieza = 1
                    Else
                        If Nuevo <> "" Then
                            Empieza = 3
                            Exit For
                        End If
                    End If
                End If
            Next
            If TxtNumeroTransporte.Text <> "" Then
                If TxtPesoEntrada.ReadOnly = False Then TxtPesoEntrada.Text = Nuevo
                If TxtPesoSalida.ReadOnly = False Then TxtPesoSalida.Text = Nuevo
            Else
                TxtPesoEntrada.Text = Nuevo
                TxtPesoSalida.Text = Nuevo
            End If
        End If

    End Sub

    Private Sub TxtNumeroTransporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroTransporte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            'MsgBox("Hola")
            Buscar_Unidad()
        End If
    End Sub

    Private Sub Buscar_Unidad()
        Try
            Dim estado As String = getDato("select estado from entregas_diesel where placa = '" & TxtNumeroTransporte.Text & "' order by id desc limit 1;")

            If estado = 2 Then
                estadoG = 0
            Else
                estadoG = estado
            End If


            If estado = "1" Then
                Dim ds As DataSet = GetDs("select peso_entrada, proveedor, fecha_entrada, envio from entregas_diesel where placa = '" & TxtNumeroTransporte.Text & "' and estado = 1", cadenaB)
                With ds.Tables(0)
                    TxtPesoEntrada.Text = .Rows(0)(0).ToString
                    TxtProveedor.Text = .Rows(0)(1).ToString
                    lblFechaEntrada.Text = .Rows(0)(2).ToString
                    txtPedido.Text = .Rows(0)(3).ToString
                End With
                'MsgBox(FechaCorregida(DateTime.Now.ToLocalTime))
                Bloquear_interfaz(True, False)
                txtGlEntrega.Select()
                'no_unidad = TxtNumeroTransporte.Text
            Else

                Bloquear_interfaz(False, True)

                Limpiar()
            End If
        Catch e As Exception
        End Try
    End Sub

    Private Sub Bloquear_interfaz(eu As Boolean, su As Boolean)
        bloquea_entrada(eu)
        bloquea_salida(su)
    End Sub

    Public Sub bloquea_entrada(estado As Boolean)
        TxtPesoEntrada.ReadOnly = estado


        TxtProveedor.ReadOnly = estado
        txtPedido.ReadOnly = estado

    End Sub

    Private Sub bloquea_salida(estado As Boolean)

        txtGlEntrega.ReadOnly = estado

    End Sub

    Public Sub Limpiar()
        TxtPesoEntrada.Text = ""
        TxtProveedor.Text = ""
        lblFechaEntrada.Text = ""
        TxtPesoSalida.Text = ""
        txtGlEntrega.Text = ""
        txtPedido.Text = ""

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If estadoG = 0 Then
            registro_unidades(TxtNumeroTransporte.Text, TxtPesoEntrada.Text, TxtProveedor.Text, txtPedido.Text, lblFechaEntrada.Text)

            Limpiar()
        ElseIf estadoG = 1 Then

            Actualizar_unidad(TxtNumeroTransporte.Text, TxtPesoSalida.Text, txtPedido.Text, txtGlEntrega.Text)
            Limpiar()
        End If
    End Sub


End Class
