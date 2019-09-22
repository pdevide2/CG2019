Public Class ListaTransitoEquipamento
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
    Public Sub New(ByVal p_idequip As String, ByVal p_serie As String, ByVal p_descequip As String,
                   ByVal p_modelo As String, ByVal p_qtde As Integer, ByVal p_valor As String,
                   ByVal p_id_local As String, ByVal p_id_empresa As String, ByVal p_sales_order As String)

        Me.IdEquipamento = p_idequip
        Me.Serie = p_serie
        Me.DescEquipamento = p_descequip
        Me.Modelo = p_modelo
        Me.Qtde = p_qtde
        Me.Valor = p_valor
        Me.IdLocalEstoque = p_id_local
        Me.IdEmpresa = p_id_empresa
        Me.SalesOrder = p_sales_order


    End Sub

    Public Sub New()
    End Sub
End Class
