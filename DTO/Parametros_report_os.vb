Public Class Parametros_report_os

    Private _os_id As String
    Public Property OS_Id() As String
        Get
            Return _os_id
        End Get
        Set(ByVal value As String)
            _os_id = value
        End Set
    End Property

    Private _data As String
    Public Property Data() As String
        Get
            Return _data
        End Get
        Set(ByVal value As String)
            _data = value
        End Set
    End Property

    Private _responsavel As String
    Public Property Responsavel() As String
        Get
            Return _responsavel
        End Get
        Set(ByVal value As String)
            _responsavel = value
        End Set
    End Property

    Private _loja As String
    Public Property Loja() As String
        Get
            Return _loja
        End Get
        Set(ByVal value As String)
            _loja = value
        End Set
    End Property

    Private _fornecedor As String
    Public Property Fornecedor() As String
        Get
            Return _fornecedor
        End Get
        Set(ByVal value As String)
            _fornecedor = value
        End Set
    End Property

    Private _nf As String
    Public Property NF() As String
        Get
            Return _nf
        End Get
        Set(ByVal value As String)
            _nf = value
        End Set
    End Property

    Private _serie_nf As String
    Public Property SerieNF() As String
        Get
            Return _serie_nf
        End Get
        Set(ByVal value As String)
            _serie_nf = value
        End Set
    End Property

    Private _emissao As String
    Public Property Emissao() As String
        Get
            Return _emissao
        End Get
        Set(ByVal value As String)
            _emissao = value
        End Set
    End Property

    Private _gerar_PDF As Boolean
    Public Property GerarPDF() As Boolean
        Get
            Return _gerar_PDF
        End Get
        Set(ByVal value As Boolean)
            _gerar_PDF = value
        End Set
    End Property

End Class
