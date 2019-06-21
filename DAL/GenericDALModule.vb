Module GenericDALModule
    Function Conexao()

        Dim strconn As String = String.Empty
        If Environment.UserDomainName = "WIN-6D553OEIVVL" Then
            'strconn = "Server=VMWIN7;Database=dbCG;Trusted_Connection=True;"
            strconn = "Data Source=.\SQL2017DEV;Initial Catalog=dbCG;Persist Security Info=True;User ID=USER_CG;Password=c102030@"
        Else
            'strconn = "Server=LISBOA;Database=dbCG;Trusted_Connection=True;"
            strconn = "Data Source=LISBOA;Initial Catalog=dbCG;Persist Security Info=True;User ID=USER_CG;Password=c102030@"
        End If
        Return strconn
    End Function
End Module
