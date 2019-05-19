Public Class Cg_pedidovenda_itens

    Dim _id_pedido As Integer
    Dim _id_equipamento As Integer
    Dim _qtde As Integer
    Dim _preco_venda As Decimal
    Dim _status_item As Integer
    Dim _data_baixa As Date?
    Dim _cancel As Boolean


    Property Id_pedido() As Integer
        Get
            Return _id_pedido
        End Get
        Set(ByVal value As Integer)
            _id_pedido = value
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

    Property Qtde() As Integer
        Get
            Return _qtde
        End Get
        Set(ByVal value As Integer)
            _qtde = value
        End Set
    End Property

    Property Preco_venda() As Decimal
        Get
            Return _preco_venda
        End Get
        Set(ByVal value As Decimal)
            _preco_venda = value
        End Set
    End Property

    Property Status_item() As Integer
        Get
            Return _status_item
        End Get
        Set(ByVal value As Integer)
            _status_item = value
        End Set
    End Property

    Property Data_baixa() As Date?
        Get
            Return _data_baixa
        End Get
        Set(ByVal value As Date?)
            _data_baixa = value
        End Set
    End Property


    Property Cancel() As Boolean
        Get
            Return _cancel
        End Get
        Set(ByVal value As Boolean)
            _cancel = value
        End Set
    End Property


End Class
