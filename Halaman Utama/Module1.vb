Imports System.Data.Odbc
Module Module1
    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public sql1 As String


    Public Sub Koneksi()
        sql1 = "Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;database=pembayaran_spp;port=3306"
        Conn = New OdbcConnection(sql1)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
