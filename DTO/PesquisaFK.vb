'!' PAULO EDUARDO DEVIDE
'!' 02/ago/16
'!' Classe DTO para a tela de Pesquisa Dinamica
'!' Parametros para a tela


Public Class PesquisaFK
    Private _Tabela As String
    Public Property Tabela() As String
        Get
            Return _Tabela
        End Get
        Set(ByVal value As String)
            _Tabela = value
        End Set
    End Property

    Private _CampoId As String
    Public Property CampoId() As String
        Get
            Return _CampoId
        End Get
        Set(ByVal value As String)
            _CampoId = value
        End Set
    End Property

    Private _CampoDesc As String
    Public Property CampoDesc() As String
        Get
            Return _CampoDesc
        End Get
        Set(ByVal value As String)
            _CampoDesc = value
        End Set
    End Property

    Private _TxtId As String
    Public Property TxtId() As String
        Get
            Return _TxtId
        End Get
        Set(ByVal value As String)
            _TxtId = value
        End Set
    End Property

    Private _TxtDesc As String
    Public Property TxtDesc() As String
        Get
            Return _TxtDesc
        End Get
        Set(ByVal value As String)
            _TxtDesc = value
        End Set
    End Property

    Private _tituloTela As String
    Public Property TituloTela() As String
        Get
            Return _tituloTela
        End Get
        Set(ByVal value As String)
            _tituloTela = value
        End Set
    End Property

    Private _labelBuscaId As String
    Public Property LabelBuscaId() As String
        Get
            Return _labelBuscaId
        End Get
        Set(ByVal value As String)
            _labelBuscaId = value
        End Set
    End Property

    Private _labelBuscaDesc As String
    Public Property LabelBuscaDesc() As String
        Get
            Return _labelBuscaDesc
        End Get
        Set(ByVal value As String)
            _labelBuscaDesc = value
        End Set
    End Property

    Private _comandoSQL As String
    Public Property ComandoSQL() As String
        Get
            Return _comandoSQL
        End Get
        Set(ByVal value As String)
            _comandoSQL = value
        End Set
    End Property

    Private _filtroSQL As String
    Public Property FiltroSQL() As String
        Get
            Return _filtroSQL
        End Get
        Set(ByVal value As String)
            _filtroSQL = value
        End Set
    End Property

    Private _lista_campos As String
    Public Property ListaCampos() As String
        Get
            Return _lista_campos
        End Get
        Set(ByVal value As String)
            _lista_campos = value
        End Set
    End Property

    Private _colunas_filtro As String
    Public Property ColunasFiltro() As String
        Get
            Return _colunas_filtro
        End Get
        Set(ByVal value As String)
            _colunas_filtro = value
        End Set
    End Property

    Private _id_empresa as Integer
    Property Id_empresa() As Integer
        Get
            Return _id_empresa
        End Get
        Set(ByVal value As Integer)
            _id_empresa = value
        End Set
    End Property

    Private _orderByQuery As String
    Public Property OrderByQuery() As String
        Get
            Return _orderByQuery
        End Get
        Set(ByVal value As String)
            _orderByQuery = value
        End Set
    End Property
End Class
