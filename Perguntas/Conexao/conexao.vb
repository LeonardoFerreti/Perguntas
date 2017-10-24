Imports System.Configuration
Imports System.Data.SqlClient

Public Class conexao

    Private connectionString As String = ConfigurationManager.ConnectionStrings("conexao").ConnectionString

    'Consultas
    Public Function retornaDatatable(sql As String) As DataTable
        retornaDatatable = Nothing
        Using con As New SqlConnection(connectionString)
            con.Open()
            Using da As New SqlDataAdapter(sql, con)
                retornaDatatable = New DataTable()
                da.Fill(retornaDatatable)
            End Using
        End Using
        Return retornaDatatable
    End Function

    'Inserts, Updates e deletes
    'Executa um ou vários comandos na mesma transação SQL.
    Public Function ExecutaComando(sqlList As List(Of String)) As Boolean
        ExecutaComando = False
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction = connection.BeginTransaction

            command.Connection = connection
            command.Transaction = transaction

            Try
                For Each sql As String In sqlList
                    command.CommandText = sql
                    command.ExecuteNonQuery()
                Next
                transaction.Commit()
                ExecutaComando = True
            Catch ex As Exception
                transaction.Rollback()
                Throw
            End Try

        End Using
        Return ExecutaComando
    End Function


End Class
