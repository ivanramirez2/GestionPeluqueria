Imports MySql.Data.MySqlClient

Module ConexionDB
    ' Cadena de conexión a la base de datos
    Public conexion As New MySqlConnection("server=localhost;  port=3309;  database=peluqueriadb; user=root; password=RMcf1902.;")

    ' Función para abrir la conexión
    Public Function AbrirConexion() As Boolean
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
            Return False
        End Try
    End Function

    ' Función para cerrar la conexión
    Public Sub CerrarConexion()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Module
