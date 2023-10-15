Imports System.Data.SqlClient
Imports System.Data
Public Class Fusuario
    Inherits Conexion

    Public Function validar_usuario(us As String, pass As String) As DataTable
        conectado()
        cmd = New SqlCommand("validar_usuario", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@usuario", us)
        cmd.Parameters.AddWithValue("@contraseña", pass)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt

    End Function

End Class
