Public Class Cg_os	Dim _id_os As Integer	Dim _data_movto As Date	Dim _id_loja_origem As Integer	Dim _nf_transp As String	Dim _serie_nf_transp As String	Dim _emissao_nf_transp As Date	Dim _id_fornecedor As Integer	Dim _id_responsavel_ida As Integer	Dim _status_os As Integer	Dim _user_ins As Integer	Dim _data_ins As Date	Dim _user_upd As Integer	Dim _data_upd As Date
    Dim _id_empresa As Integer
    Dim _id_cliente As Integer?
    Dim _indica_os_cliente As Boolean

    Property Id_empresa() As Integer		Get			Return _id_empresa		End Get		Set(ByVal value As Integer)			_id_empresa = value		End Set	End Property	Property Id_os() As Integer		Get			Return _id_os		End Get		Set(ByVal value As Integer)			_id_os = value		End Set	End Property	Property Data_movto() As Date		Get			Return _data_movto		End Get		Set(ByVal value As Date)			_data_movto = value		End Set	End Property	Property Id_loja_origem() As Integer		Get			Return _id_loja_origem		End Get		Set(ByVal value As Integer)			_id_loja_origem = value		End Set	End Property	Property Nf_transp() As String		Get			Return _nf_transp		End Get		Set(ByVal value As String)			_nf_transp = value		End Set	End Property	Property Serie_nf_transp() As String		Get			Return _serie_nf_transp		End Get		Set(ByVal value As String)			_serie_nf_transp = value		End Set	End Property	Property Emissao_nf_transp() As Date		Get			Return _emissao_nf_transp		End Get		Set(ByVal value As Date)			_emissao_nf_transp = value		End Set	End Property	Property Id_fornecedor() As Integer		Get			Return _id_fornecedor		End Get		Set(ByVal value As Integer)			_id_fornecedor = value		End Set	End Property	Property Id_responsavel_ida() As Integer		Get			Return _id_responsavel_ida		End Get		Set(ByVal value As Integer)			_id_responsavel_ida = value		End Set	End Property	Property Status_os() As Integer		Get			Return _status_os		End Get		Set(ByVal value As Integer)			_status_os = value		End Set	End Property	Property User_ins() As Integer		Get			Return _user_ins		End Get		Set(ByVal value As Integer)			_user_ins = value		End Set	End Property	Property Data_ins() As Date		Get			Return _data_ins		End Get		Set(ByVal value As Date)			_data_ins = value		End Set	End Property	Property User_upd() As Integer		Get			Return _user_upd		End Get		Set(ByVal value As Integer)			_user_upd = value		End Set	End Property	Property Data_upd() As Date		Get			Return _data_upd		End Get		Set(ByVal value As Date)			_data_upd = value		End Set	End Property    Property Id_cliente() As Integer?
        Get
            Return _id_cliente
        End Get
        Set(ByVal value As Integer?)
            _id_cliente = value
        End Set
    End Property

    Property Indica_OS_Cliente() As Boolean
        Get
            Return _indica_os_cliente
        End Get
        Set(ByVal value As Boolean)
            _indica_os_cliente = value
        End Set
    End PropertyEnd Class