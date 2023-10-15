Imports System.Data.SqlClient
Public Class Fproducto
    Inherits Conexion

    Public Function ingresa_producto(cod As String, nom As String, prec As Decimal, stock As Int16, codcat As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_producto", cod)
        cmd.Parameters.AddWithValue("@nombre", nom)
        cmd.Parameters.AddWithValue("@precio", prec)
        cmd.Parameters.AddWithValue("@stock", stock)
        cmd.Parameters.AddWithValue("@cod_categoria", codcat)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_producto(cod As String, nom As String, prec As Decimal, stock As Int16, codcat As String) As Boolean
        conectado()
        cmd = New SqlCommand("edita_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_producto", cod)
        cmd.Parameters.AddWithValue("@nombre", nom)
        cmd.Parameters.AddWithValue("@precio", prec)
        cmd.Parameters.AddWithValue("@stock", stock)
        cmd.Parameters.AddWithValue("@cod_categoria", codcat)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimina_producto(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_producto", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_producto() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_producto(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function


End Class
