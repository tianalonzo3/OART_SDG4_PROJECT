Imports Microsoft.Data.SqlClient
Public Class DBConnection

    Public Shared ConnectionString As String =
        "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentResourceTrackerDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function

End Class