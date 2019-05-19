Public Class PermissaoModulo
    Private _pesquisa As Boolean
    Public Property Pesquisa() As Boolean
        Get
            Return _pesquisa
        End Get
        Set(ByVal value As Boolean)
            _pesquisa = value
        End Set
    End Property
    Private _incluir As Boolean
    Public Property Incluir() As Boolean
        Get
            Return _incluir
        End Get
        Set(ByVal value As Boolean)
            _incluir = value
        End Set
    End Property
    Private _alterar As Boolean
    Public Property Alterar() As Boolean
        Get
            Return _alterar
        End Get
        Set(ByVal value As Boolean)
            _alterar = value
        End Set
    End Property
    Private _excluir As Boolean
    Public Property Excluir() As Boolean
        Get
            Return _excluir
        End Get
        Set(ByVal value As Boolean)
            _excluir = value
        End Set
    End Property

End Class
