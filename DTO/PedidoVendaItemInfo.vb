Public Class PedidoVendaItemInfo
    Private _idPedido As Integer
    Public Property Id_Pedido() As Integer
        Get
            Return _idPedido
        End Get
        Set(ByVal value As Integer)
            _idPedido = value
        End Set
    End Property
    Private _idEquipamento As Integer
    Public Property Id_Equipamento() As Integer
        Get
            Return _idEquipamento
        End Get
        Set(ByVal value As Integer)
            _idEquipamento = value
        End Set
    End Property
    Private _idCliente As Integer
    Public Property Id_Cliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private _StatusItem As Integer
    Public Property StatusItem() As Integer
        Get
            Return _StatusItem
        End Get
        Set(ByVal value As Integer)
            _StatusItem = value
        End Set
    End Property

    Private _nome As String
    Public Property NomeCliente() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property
    Private _descEquipto As String
    Public Property DescEquipamento() As String
        Get
            Return _descEquipto
        End Get
        Set(ByVal value As String)
            _descEquipto = value
        End Set
    End Property
    Private _descTipo As String
    Public Property DescTipoEquipamento() As String
        Get
            Return _descTipo
        End Get
        Set(ByVal value As String)
            _descTipo = value
        End Set
    End Property
End Class
