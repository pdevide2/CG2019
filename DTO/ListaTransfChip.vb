Public Class ListaTransfChip
    Private _id_chip As String
    Public Property IdChip() As String
        Get
            Return _id_chip
        End Get
        Set(ByVal value As String)
            _id_chip = value
        End Set
    End Property
    Private _simid As String
    Public Property SIMID() As String
        Get
            Return _simid
        End Get
        Set(ByVal value As String)
            _simid = value
        End Set
    End Property
    Private _id_operadora As String
    Public Property IdOperadora() As String
        Get
            Return _id_operadora
        End Get
        Set(ByVal value As String)
            _id_operadora = value
        End Set
    End Property
    Private _desc_operadora As String
    Public Property DescOperadora() As String
        Get
            Return _desc_operadora
        End Get
        Set(ByVal value As String)
            _desc_operadora = value
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
