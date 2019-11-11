Public Class Cg_AprovaTransferenciaEmpresa
    Dim _id_romaneio As Integer
    Dim _id_item As Integer
    Dim _status_item As Integer
    Dim _tipoItem As Integer

    Property Id_romaneio() As Integer
        Get
            Return _id_romaneio
        End Get
        Set(ByVal value As Integer)
            _id_romaneio = value
        End Set
    End Property

    Property Id_item() As Integer
        Get
            Return _id_item
        End Get
        Set(ByVal value As Integer)
            _id_item = value
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

    Property TipoItem() As Integer
        Get
            Return _tipoItem
        End Get
        Set(ByVal value As Integer)
            _tipoItem = value
        End Set
    End Property

End Class
