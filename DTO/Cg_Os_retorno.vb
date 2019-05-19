Public Class Cg_os_retorno
    Dim _id_os As Integer
    Dim _item_id As Integer
    Dim _id_equipamento As Integer
    Dim _data_retorno As String
    Dim _desc_defeito As String
    Dim _conserto_ok As Boolean
    Dim _nf_fornec As String
    Dim _serie_nf_fornec As String
    Dim _emissao_nf_fornec As String
    Dim _obs_retorno As String
    Dim _id_responsavel_ret As Integer
    Dim _user_upd As Integer
    Dim _data_upd As Date
    Dim _garantia As Boolean
    Dim _valor_conserto As Double
    Dim _config_garantia As Boolean
    Dim _qtde_dias_garantia As Integer
    Dim _data_inicio_garantia As Date
    Dim _data_termino_garantia As Date
    Dim _laudo As Boolean
    Dim _outros As Boolean
    Dim _motivo_outros As String
    Dim _tabela_servicos As String

    Property Id_os() As Integer
        Get
            Return _id_os
        End Get
        Set(ByVal value As Integer)
            _id_os = value
        End Set
    End Property

    Property Item_id() As Integer
        Get
            Return _item_id
        End Get
        Set(ByVal value As Integer)
            _item_id = value
        End Set
    End Property

    Property Id_equipamento() As Integer
        Get
            Return _id_equipamento
        End Get
        Set(ByVal value As Integer)
            _id_equipamento = value
        End Set
    End Property

    Property Data_retorno() As String
        Get
            Return _data_retorno
        End Get
        Set(ByVal value As String)
            _data_retorno = value
        End Set
    End Property

    Property Desc_defeito() As String
        Get
            Return _desc_defeito
        End Get
        Set(ByVal value As String)
            _desc_defeito = value
        End Set
    End Property

    Property Conserto_ok() As Boolean
        Get
            Return _conserto_ok
        End Get
        Set(ByVal value As Boolean)
            _conserto_ok = value
        End Set
    End Property

    Property Nf_fornec() As String
        Get
            Return _nf_fornec
        End Get
        Set(ByVal value As String)
            _nf_fornec = value
        End Set
    End Property

    Property Serie_nf_fornec() As String
        Get
            Return _serie_nf_fornec
        End Get
        Set(ByVal value As String)
            _serie_nf_fornec = value
        End Set
    End Property

    Property Emissao_nf_fornec() As String
        Get
            Return _emissao_nf_fornec
        End Get
        Set(ByVal value As String)
            _emissao_nf_fornec = value
        End Set
    End Property

    Property Obs_retorno() As String
        Get
            Return _obs_retorno
        End Get
        Set(ByVal value As String)
            _obs_retorno = value
        End Set
    End Property

    Property Id_responsavel_ret() As Integer
        Get
            Return _id_responsavel_ret
        End Get
        Set(ByVal value As Integer)
            _id_responsavel_ret = value
        End Set
    End Property

    Property User_upd() As Integer
        Get
            Return _user_upd
        End Get
        Set(ByVal value As Integer)
            _user_upd = value
        End Set
    End Property

    Property Data_upd() As Date
        Get
            Return _data_upd
        End Get
        Set(ByVal value As Date)
            _data_upd = value
        End Set
    End Property

    Property Garantia() As Boolean
        Get
            Return _garantia
        End Get
        Set(ByVal value As Boolean)
            _garantia = value
        End Set
    End Property

    Property Valor_Conserto() As Double
        Get
            Return _valor_conserto
        End Get
        Set(ByVal value As Double)
            _valor_conserto = value
        End Set
    End Property
    Property Config_Garantia() As Boolean
        Get
            Return _config_garantia
        End Get
        Set(ByVal value As Boolean)
            _config_garantia = value
        End Set
    End Property
    Property Qtde_Dias_Garantia() As Integer
        Get
            Return _qtde_dias_garantia
        End Get
        Set(ByVal value As Integer)
            _qtde_dias_garantia = value
        End Set
    End Property
    Property Data_Inicio_Garantia() As Date
        Get
            Return _data_inicio_garantia
        End Get
        Set(ByVal value As Date)
            _data_inicio_garantia = value
        End Set
    End Property
    Property Data_Termino_Garantia() As Date
        Get
            Return _data_termino_garantia
        End Get
        Set(ByVal value As Date)
            _data_termino_garantia = value
        End Set
    End Property
    Property Laudo() As Boolean
        Get
            Return _laudo
        End Get
        Set(ByVal value As Boolean)
            _laudo = value
        End Set
    End Property
    Property Outros() As Boolean
        Get
            Return _outros
        End Get
        Set(ByVal value As Boolean)
            _outros = value
        End Set
    End Property
    Property Motivo_Outros() As String
        Get
            Return _motivo_outros
        End Get
        Set(ByVal value As String)
            _motivo_outros = value
        End Set
    End Property
    Property TabelaServicos() As String
        Get
            Return _tabela_servicos
        End Get
        Set(ByVal value As String)
            _tabela_servicos = value
        End Set
    End Property


End Class
