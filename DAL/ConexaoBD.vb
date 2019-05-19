Imports System.Configuration


Public Class ConexaoBD

    Shared _connectionString As String
    Shared _providerName As String

    Public Shared Sub getAcesso(ByVal tipoAcesso As String)

        Try
            Select Case tipoAcesso
                Case "MySQL"
                    _connectionString = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ConnectionString
                    _providerName = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ProviderName
                Case "SQLServer"
                    'If Environment.UserDomainName = "VMWIN7" Then 'AMBIENTE DE DEV
                    '    _connectionString = ConfigurationManager.ConnectionStrings("SQLServerConnectionString").ConnectionString
                    'Else 'SERVIDOR - LISBOA
                    '    _connectionString = ConfigurationManager.ConnectionStrings("SQLServerConnectionString2").ConnectionString
                    'End If
                    _connectionString = Conexao()
                    _providerName = ConfigurationManager.ConnectionStrings("SQLServerConnectionString").ProviderName
            End Select

        Catch ex As Exception
            Throw New Exception("Falha ao acessar a string de conexão")

        End Try
    End Sub

    Public Shared Function ConnectiontString() As String
        Return _connectionString
    End Function

    Public Shared Function ProviderName() As String
        Return _providerName
    End Function

End Class
