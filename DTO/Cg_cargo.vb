Public Class Cg_cargo

    Private _id_cargo As Integer
    Private _desc_cargo As String
    Dim _user_ins As Integer
    Dim _data_ins As Date
    Dim _user_upd As Integer
    Dim _data_upd As Date
    Dim _id_empresa As Integer

    Property Id_empresa() As Integer
        Get
            Return _id_empresa
        End Get
        Set(ByVal value As Integer)
            _id_empresa = value
        End Set
    End Property



    Property Id_cargo() As Integer
        Get
            Return _id_cargo
        End Get
        Set(ByVal value As Integer)
            _id_cargo = value
        End Set
    End Property

    Property Desc_cargo() As String
        Get
            Return _desc_cargo
        End Get
        Set(ByVal value As String)
            _desc_cargo = value
        End Set
    End Property

    Property User_ins() As Integer
        Get
            Return _user_ins
        End Get
        Set(ByVal value As Integer)
            _user_ins = value
        End Set
    End Property

    Property Data_ins() As Date
        Get
            Return _data_ins
        End Get
        Set(ByVal value As Date)
            _data_ins = value
        End Set
    End Property

    Property User_upd() As Integer
        Get
            Return _user_upd
        End Get
        Set(ByVal value As Integer)
            _user_upd = value
        End Set
    End Property

    Property Data_upd() As Date
        Get
            Return _data_upd
        End Get
        Set(ByVal value As Date)
            _data_upd = value
        End Set
    End Property


End Class
