Public Class ListaItensOS
    Private _id_os As String
    Public Property IdOS() As String
        Get
            Return _id_os
        End Get
        Set(ByVal value As String)
            _id_os = value
        End Set
    End Property
    Private _item_id As String
    Public Property ItemId() As String
        Get
            Return _item_id
        End Get
        Set(ByVal value As String)
            _item_id = value
        End Set
    End Property
    Private _id_equipamento As String
    Public Property IdEquipamento() As String
        Get
            Return _id_equipamento
        End Get
        Set(ByVal value As String)
            _id_equipamento = value
        End Set
    End Property
    Private _desc_equip As String
    Public Property DescEquipamento() As String
        Get
            Return _desc_equip
        End Get
        Set(ByVal value As String)
            _desc_equip = value
        End Set
    End Property
    Private _serie As String
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property
    Private _modelo As String
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property
    Private _prev_retorno As String
    Public Property PrevisaoRetorno() As String
        Get
            Return _prev_retorno
        End Get
        Set(ByVal value As String)
            _prev_retorno = value
        End Set
    End Property
    Private _desc_defeito As String
    Public Property DescDefeito() As String
        Get
            Return _desc_defeito
        End Get
        Set(ByVal value As String)
            _desc_defeito = value
        End Set
    End Property
    Private _conserto_ok As String
    Public Property ConsertoOk() As String
        Get
            Return _conserto_ok
        End Get
        Set(ByVal value As String)
            _conserto_ok = value
        End Set
    End Property
    Private _id_tipo_equip As String
    Public Property IdTipoEquip() As String
        Get
            Return _id_tipo_equip
        End Get
        Set(ByVal value As String)
            _id_tipo_equip = value
        End Set
    End Property
    Private _desc_tipo_equip As String
    Public Property DescTipoEquipamento() As String
        Get
            Return _desc_tipo_equip
        End Get
        Set(ByVal value As String)
            _desc_tipo_equip = value
        End Set
    End Property
    Private _garantia As String
    Public Property Garantia() As String
        Get
            Return _garantia
        End Get
        Set(ByVal value As String)
            _garantia = value
        End Set
    End Property
    Private _id_ocorrencia As String
    Public Property IdOcorrencia() As String
        Get
            Return _id_ocorrencia
        End Get
        Set(ByVal value As String)
            _id_ocorrencia = value
        End Set
    End Property
    Private _desc_ocorrencia As String
    Public Property DescOcorrencia() As String
        Get
            Return _desc_ocorrencia
        End Get
        Set(ByVal value As String)
            _desc_ocorrencia = value
        End Set
    End Property
    Private _id_tabela As String
    Public Property IdTabela() As String
        Get
            Return _id_tabela
        End Get
        Set(ByVal value As String)
            _id_tabela = value
        End Set
    End Property

End Class
