Imports MySql.Data.MySqlClient

Module ConexionesDB

    '---Conexion a Base de Datos y Bascula (Local) ---
    'Public cadenaB As String = "Database = inventarios; Port = 3306; Server = localhost; User Id = root; Password = gasautoremoto;"
    '---Conexion a servidor
    Public cadenaB As String = "Database = zetatanques; Port = 3306; Server = 10.24.10.210; User Id = granel_fel; Password = FEL.2019;"
    Public conexionB As New MySqlConnection(cadenaB)



    Public Function GetDs(query As String, cadenaC As String, Optional dataMember As String = "") As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(query, cadenaC)

        If dataMember <> "" Then
            da.Fill(ds, dataMember)
        Else
            da.Fill(ds)
        End If

        Return ds

    End Function

End Module
