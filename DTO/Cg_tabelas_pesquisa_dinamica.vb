Public Class Cg_tabelas_pesquisa_dinamica	Dim _id_tabela As Integer	Dim _tabela As String	Dim _tipo_tabela As String	Property Id_tabela() As Integer		Get			Return _id_tabela		End Get		Set(ByVal value As Integer)			_id_tabela = value		End Set	End Property	Property Tabela() As String		Get			Return _tabela		End Get		Set(ByVal value As String)			_tabela = value		End Set	End Property	Property Tipo_tabela() As String		Get			Return _tipo_tabela		End Get		Set(ByVal value As String)			_tipo_tabela = value		End Set	End Property    Private _filtraPorEmpresa As Boolean
    Public Property Filtra_por_empresa() As Boolean
        Get
            Return _filtraPorEmpresa
        End Get
        Set(ByVal value As Boolean)
            _filtraPorEmpresa = value
        End Set
    End Property
End Class