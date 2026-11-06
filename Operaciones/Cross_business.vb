
Imports MySql.Data.MySqlClient

Module Cross_business

    Public Function FechaCorregida(fecha As String) As String
        Dim feh As DateTime = fecha
        Return feh.ToString("yyy-MM-dd HH:mm:ss")
    End Function

    Public Function getDato(query As String) As String
        Dim dato As String = ""
        Try
            conexionB.Close()
            conexionB.Open()

            Dim comm As New MySqlCommand(query, conexionB)
            If IsDBNull(comm.ExecuteScalar) Then
                dato = ""
            Else
                dato = comm.ExecuteScalar()
            End If
        Catch ex As Exception
            GuardarError(ex.ToString & vbCrLf & query)
        End Try
        Return dato
    End Function

    Public Sub GuardarError(dato As String)
        MessageBox.Show(dato, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Try
            Dim query As String = "INSERT INTO ERRORES_BASCULA(DESCRIPCION) VALUES ('" & dato & "');"
            Dim comm As New MySqlCommand(query, conexionB)

            conexionB.Open()
            comm.ExecuteNonQuery()
            conexionB.Close()

        Catch ex As Exception
        End Try
    End Sub

    Public Function registro_unidades(placa As String, pesoE As String, proveedor As String, pedidoE As String, fechaE As String) As Integer
        'If Val(pesoE) > 10 Then
        'este if es para poder evaluar que si exista un peso en la bascula
        Dim query As String = "insert into entregas_diesel( placa, fecha_entrada, envio, peso_entrada, proveedor, estado) 
                                values ('" & placa & "','" & FechaCorregida(DateAndTime.Now.ToLocalTime) & "', '" & pedidoE & "', '" & pesoE & "','" & proveedor & "',1);"
            Return Ejecutar_query_mysql(query)
        'End If

        Return 0
    End Function

    Public Function Actualizar_unidad(placa As String, pesoS As String, pedidoS As String, glPedido As String) As Integer
        Dim query As String
        Dim densidad As String = getDato("select densidad from dvn1_despachos order by consecutivo desc limit 1;")
        If Val(pesoS) > 10 Then
            query = "update entregas_diesel set fecha_salida = '" & FechaCorregida(DateAndTime.Now.ToLocalTime) & "',  peso_salida = '" & pesoS & "', galones_pedido = '" & glPedido & "' , densidad  = '" & densidad & "', galones_peso = (((peso_entrada - peso_salida)/3.7853)/" & densidad & "), estado = 2 where envio = '" & pedidoS & "' and estado = 1 and placa = '" & placa & "'"
            Return Ejecutar_query_mysql(query)
        Else
            MsgBox("" & vbCrLf & "No se puede registrar la salida, el peso es menor a 10 libras", MsgBoxStyle.Critical, "Error")
            Return 0
        End If
    End Function

    Public Function Ejecutar_query_mysql(query As String) As Integer
        Try
            Dim comm As New MySqlCommand(query, conexionB)
            comm.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            GuardarError(ex.ToString & vbCrLf & query)
        End Try
        Return 0
    End Function

End Module
