Public Class Cg_AprovaPedidoVenda

    Dim _id_pedido As Integer
    Dim _id_equipamento As Integer
    Dim _status_item As Integer
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

    Property Status_item() As Integer
        Get
            Return _status_item
        End Get
        Set(ByVal value As Integer)
            _status_item = value
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
