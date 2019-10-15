Public Class ListaTransfEquipamento
    Private _id_equip As String
    Public Property IdEquipamento() As String
        Get
            Return _id_equip
        End Get
        Set(ByVal value As String)
            _id_equip = value
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
    Private _desc_equip As String
    Public Property DescEquipamento() As String
        Get
            Return _desc_equip
        End Get
        Set(ByVal value As String)
            _desc_equip = value
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
    Private _qtde As String
    Public Property Qtde() As String
        Get
            Return _qtde
        End Get
        Set(ByVal value As String)
            _qtde = value
        End Set
    End Property
    Private _valor As String
    Public Property Valor() As String
        Get
            Return _valor
        End Get
        Set(ByVal value As String)
            _valor = value
        End Set
    End Property

End Class
