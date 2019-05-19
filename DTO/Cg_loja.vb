Public Class Cg_loja

    Dim _id_loja As Integer
    Dim _sigla As String
    Dim _nome As String
    Dim _endereco As String
    Dim _complemento As String
    Dim _cep As String
    Dim _cidade As String
    Dim _bairro As String
    Dim _uf As String
    Dim _id_tipo_local As Integer
    Dim _id_responsavel As Integer
    Dim _user_ins As Integer
    Dim _data_ins As Date
    Dim _user_upd As Integer
    Dim _data_upd As Date
    Dim _codigo As String
    Dim _telefone As String
    Dim _celular As String
    Dim _loja_fisica As Boolean
    Dim _parceria As Boolean
    Dim _id_area As String
    Dim _id_empresa As Integer
    Dim _id_tipo_local_estoque As Integer
    Dim _telefone2 As String
    Dim _celular2 As String
    Dim _celular3 As String
    Dim _celular4 As String
    Dim _celular5 As String
    Dim _celular6 As String
    Dim _inativo As Boolean
    Dim _ultima_atualizacao As Date
    Dim _inicio_vigencia As Date
    Dim _final_vigencia As Date?

    Property Id_Tipo_Local_Estoque() As Integer
        Get
            Return _id_tipo_local_estoque
        End Get
        Set(ByVal value As Integer)
            _id_tipo_local_estoque = value
        End Set
    End Property

    Property Id_empresa() As Integer
        Get
            Return _id_empresa
        End Get
        Set(ByVal value As Integer)
            _id_empresa = value
        End Set
    End Property

    Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Property Telefone As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Property Celular As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property

    Property Id_loja() As Integer
        Get
            Return _id_loja
        End Get
        Set(ByVal value As Integer)
            _id_loja = value
        End Set
    End Property

    Property Sigla() As String
        Get
            Return _sigla
        End Get
        Set(ByVal value As String)
            _sigla = value
        End Set
    End Property

    Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Property Endereco() As String
        Get
            Return _endereco
        End Get
        Set(ByVal value As String)
            _endereco = value
        End Set
    End Property

    Property Complemento() As String
        Get
            Return _complemento
        End Get
        Set(ByVal value As String)
            _complemento = value
        End Set
    End Property

    Property Cep() As String
        Get
            Return _cep
        End Get
        Set(ByVal value As String)
            _cep = value
        End Set
    End Property

    Property Cidade() As String
        Get
            Return _cidade
        End Get
        Set(ByVal value As String)
            _cidade = value
        End Set
    End Property

    Property Bairro() As String
        Get
            Return _bairro
        End Get
        Set(ByVal value As String)
            _bairro = value
        End Set
    End Property

    Property Uf() As String
        Get
            Return _uf
        End Get
        Set(ByVal value As String)
            _uf = value
        End Set
    End Property

    Property Id_tipo_local() As Integer
        Get
            Return _id_tipo_local
        End Get
        Set(ByVal value As Integer)
            _id_tipo_local = value
        End Set
    End Property

    Property Id_responsavel() As Integer
        Get
            Return _id_responsavel
        End Get
        Set(ByVal value As Integer)
            _id_responsavel = value
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

    Property LojaFisica() As Boolean
        Get
            Return _loja_fisica
        End Get
        Set(ByVal value As Boolean)
            _loja_fisica = value
        End Set
    End Property

    Property Parceria() As Boolean
        Get
            Return _parceria
        End Get
        Set(ByVal value As Boolean)
            _parceria = value
        End Set
    End Property

    Property IdArea() As String
        Get
            Return _id_area
        End Get
        Set(ByVal value As String)
            _id_area = value
        End Set
    End Property

    Property Telefone2() As String
        Get
            Return _telefone2
        End Get
        Set(ByVal value As String)
            _telefone2 = value
        End Set
    End Property

    Property Celular2() As String
        Get
            Return _celular2
        End Get
        Set(ByVal value As String)
            _celular2 = value
        End Set
    End Property

    Property Celular3() As String
        Get
            Return _celular3
        End Get
        Set(ByVal value As String)
            _celular3 = value
        End Set
    End Property

    Property Celular4() As String
        Get
            Return _celular4
        End Get
        Set(ByVal value As String)
            _celular4 = value
        End Set
    End Property

    Property Celular5() As String
        Get
            Return _celular5
        End Get
        Set(ByVal value As String)
            _celular5 = value
        End Set
    End Property

    Property Celular6() As String
        Get
            Return _celular6
        End Get
        Set(ByVal value As String)
            _celular6 = value
        End Set
    End Property

    Property Inativo() As Boolean
        Get
            Return _inativo
        End Get
        Set(ByVal value As Boolean)
            _inativo = value
        End Set
    End Property

    Property Ultima_atualizacao() As Date
        Get
            Return _ultima_atualizacao
        End Get
        Set(ByVal value As Date)
            _ultima_atualizacao = value
        End Set
    End Property

    Property Inicio_vigencia() As Date
        Get
            Return _inicio_vigencia
        End Get
        Set(ByVal value As Date)
            _inicio_vigencia = value
        End Set
    End Property
    Property Final_vigencia() As Date?
        Get
            Return _final_vigencia
        End Get
        Set(ByVal value As Date?)
            _final_vigencia = value
        End Set
    End Property
End Class
