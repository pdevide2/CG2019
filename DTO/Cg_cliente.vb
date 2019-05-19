Public Class Cg_cliente	Dim _id_cliente As Integer	Dim _sigla As String	Dim _nome As String	Dim _cep As String	Dim _endereco As String	Dim _complemento As String	Dim _cidade As String	Dim _bairro As String	Dim _uf As String	Dim _email As String	Dim _telefone1 As String	Dim _contato1 As String	Dim _telefone2 As String	Dim _contato2 As String	Dim _telefone3 As String	Dim _contato3 As String	Dim _telefone4 As String	Dim _contato4 As String	Dim _obs As String	Dim _cadastro As Date	Dim _ultima_atualizacao As Date
    Dim _id_empresa As Integer
    Dim _pfpj As Integer
    Dim _cpf_cnpj As String
    Dim _rg_ie As String

    Property Id_cliente() As Integer		Get			Return _id_cliente		End Get		Set(ByVal value As Integer)			_id_cliente = value		End Set	End Property	Property Sigla() As String		Get			Return _sigla		End Get		Set(ByVal value As String)			_sigla = value		End Set	End Property	Property Nome() As String		Get			Return _nome		End Get		Set(ByVal value As String)			_nome = value		End Set	End Property	Property Cep() As String		Get			Return _cep		End Get		Set(ByVal value As String)			_cep = value		End Set	End Property	Property Endereco() As String		Get			Return _endereco		End Get		Set(ByVal value As String)			_endereco = value		End Set	End Property	Property Complemento() As String		Get			Return _complemento		End Get		Set(ByVal value As String)			_complemento = value		End Set	End Property	Property Cidade() As String		Get			Return _cidade		End Get		Set(ByVal value As String)			_cidade = value		End Set	End Property	Property Bairro() As String		Get			Return _bairro		End Get		Set(ByVal value As String)			_bairro = value		End Set	End Property	Property Uf() As String		Get			Return _uf		End Get		Set(ByVal value As String)			_uf = value		End Set	End Property	Property Email() As String		Get			Return _email		End Get		Set(ByVal value As String)			_email = value		End Set	End Property	Property Telefone1() As String		Get			Return _telefone1		End Get		Set(ByVal value As String)			_telefone1 = value		End Set	End Property	Property Contato1() As String		Get			Return _contato1		End Get		Set(ByVal value As String)			_contato1 = value		End Set	End Property	Property Telefone2() As String		Get			Return _telefone2		End Get		Set(ByVal value As String)			_telefone2 = value		End Set	End Property	Property Contato2() As String		Get			Return _contato2		End Get		Set(ByVal value As String)			_contato2 = value		End Set	End Property	Property Telefone3() As String		Get			Return _telefone3		End Get		Set(ByVal value As String)			_telefone3 = value		End Set	End Property	Property Contato3() As String		Get			Return _contato3		End Get		Set(ByVal value As String)			_contato3 = value		End Set	End Property	Property Telefone4() As String		Get			Return _telefone4		End Get		Set(ByVal value As String)			_telefone4 = value		End Set	End Property	Property Contato4() As String		Get			Return _contato4		End Get		Set(ByVal value As String)			_contato4 = value		End Set	End Property	Property Obs() As String		Get			Return _obs		End Get		Set(ByVal value As String)			_obs = value		End Set	End Property	Property Cadastro() As Date		Get			Return _cadastro		End Get		Set(ByVal value As Date)			_cadastro = value		End Set	End Property	Property Ultima_atualizacao() As Date		Get			Return _ultima_atualizacao		End Get		Set(ByVal value As Date)			_ultima_atualizacao = value		End Set	End Property

    Property Id_empresa() As Integer
        Get
            Return _id_empresa
        End Get
        Set(ByVal value As Integer)
            _id_empresa = value
        End Set
    End Property    Property PfPj() As Integer
        Get
            Return _pfpj
        End Get
        Set(ByVal value As Integer)
            _pfpj = value
        End Set
    End Property

    Property CpfCnpj() As String
        Get
            Return _cpf_cnpj
        End Get
        Set(ByVal value As String)
            _cpf_cnpj = value
        End Set
    End Property

    Property RgIe() As String
        Get
            Return _rg_ie
        End Get
        Set(ByVal value As String)
            _rg_ie = value
        End Set
    End Property

End Class