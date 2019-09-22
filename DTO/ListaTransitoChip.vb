Public Class ListaTransitoChip
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
    Private _id_local As String
    Public Property IdLocalEstoque() As String
        Get
            Return _id_local
        End Get
        Set(ByVal value As String)
            _id_local = value
        End Set
    End Property
    Private _id_empresa As String
    Public Property IdEmpresa() As String
        Get
            Return _id_empresa
        End Get
        Set(ByVal value As String)
            _id_empresa = value
        End Set
    End Property
    Private _is_sales_order As String
    Public Property SalesOrder() As String
        Get
            Return _is_sales_order
        End Get
        Set(ByVal value As String)
            _is_sales_order = value
        End Set
    End Property
    Public Sub New(ByVal p_idchip As String, ByVal p_simid As String, ByVal p_id_operadora As String,
                   ByVal p_desc_operadora As String, ByVal p_qtde As Integer, ByVal p_valor As String,
                   ByVal p_id_local As String, ByVal p_id_empresa As String, ByVal p_sales_order As String)

        Me.IdChip = p_idchip
        Me.SIMID = p_simid
        Me.IdOperadora = p_id_operadora
        Me.DescOperadora = p_desc_operadora
        Me.Qtde = p_qtde
        Me.Valor = p_valor
        Me.IdLocalEstoque = p_id_local
        Me.IdEmpresa = p_id_empresa
        Me.SalesOrder = p_sales_order


    End Sub

    Public Sub New()

    End Sub
End Class
