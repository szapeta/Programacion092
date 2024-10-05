Imports System.Data.SqlClient

Public Class ConexionBD

    Public cadenaConexion As String = "Data Source=localhost;Initial Catalog=SistemaFacturas;Integrated Security=True"

    Public Function ObtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection(cadenaConexion)
        Return conexion
    End Function

    Public Sub AbirConexion(ByRef conexionEnviada As SqlConnection)
        Try
            If conexionEnviada.State <> ConnectionState.Open Then
                conexionEnviada.Open()
            End If
        Catch ex As Exception
            Console.WriteLine("Erro al abrir la conexion enviada" & ex.Message)
        End Try
    End Sub

    Public Sub CerrarConexion(ByRef conexionEnviada As SqlConnection)
        Try
            If conexionEnviada.State = ConnectionState.Open Then
                conexionEnviada.Close()
            End If
        Catch ex As Exception
            Console.WriteLine("No se pudo cerrar la conexion " & ex.Message)
        End Try
    End Sub

    Public Sub InsertarDatos(ByVal query As String)
        Dim conexion As SqlConnection = ObtenerConexion()
        Try
            AbirConexion(conexion)
            Dim comando As New SqlCommand(query, conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("no se pudo ejecutar el insert" & ex.Message)
        Finally
            CerrarConexion(conexion)
        End Try
    End Sub

    Public Sub Update(ByVal queryUpdate As String)
        'por completar
    End Sub

    Public Sub Delete(ByVal queryDelete As String)
        'por completar
    End Sub

    Public Function SelectQuery(ByVal querySelect As String) As DataTable
        Dim conexion As SqlConnection = ObtenerConexion()
        Dim data As New DataTable
        Try
            AbirConexion(conexion)
            Dim adaptador As New SqlDataAdapter(querySelect, conexion)
            adaptador.Fill(data)
        Catch ex As Exception
            Console.WriteLine("Error")
        Finally
            CerrarConexion(conexion)
        End Try

        Return data
    End Function
End Class
