Public Class Cg_pedidovenda

    Dim _id_pedido As Integer
    Dim _status_pedido As String
    Dim _id_cliente As Integer
    Dim _previsao_entrega As Date
    Dim _data_baixa As Date?
    Dim _tot_qtde_original As Integer
    Dim _tot_qtde_entregar As Integer
    Dim _obs As String

    Property Id_pedido() As Integer
        Get
            Return _id_pedido
        End Get
        Set(ByVal value As Integer)
            _id_pedido = value
        End Set
    End Property

    Property Status_pedido() As String
        Get
            Return _status_pedido
        End Get
        Set(ByVal value As String)
            _status_pedido = value
        End Set
    End Property

    Property Id_cliente() As Integer
        Get
            Return _id_cliente
        End Get
        Set(ByVal value As Integer)
            _id_cliente = value
        End Set
    End Property

    Property Previsao_entrega() As Date
        Get
            Return _previsao_entrega
        End Get
        Set(ByVal value As Date)
            _previsao_entrega = value
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

    Property Tot_qtde_original() As Integer
        Get
            Return _tot_qtde_original
        End Get
        Set(ByVal value As Integer)
            _tot_qtde_original = value
        End Set
    End Property

    Property Tot_qtde_entregar() As Integer
        Get
            Return _tot_qtde_entregar
        End Get
        Set(ByVal value As Integer)
            _tot_qtde_entregar = value
        End Set
    End Property

    Property Obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property
End Class
