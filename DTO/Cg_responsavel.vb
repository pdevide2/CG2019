Public Class Cg_responsavel	Dim _id_responsavel As Integer	Dim _nome As String	Dim _apelido As String	Dim _email As String	Dim _celular As String	Dim _whatsapp As String	Dim _id_cargo As Integer	Dim _user_ins As Integer	Dim _data_ins As Date	Dim _user_upd As Integer	Dim _data_upd As Date	Dim _id_empresa as Integer	Property Id_empresa() As Integer		Get			Return _id_empresa		End Get		Set(ByVal value As Integer)			_id_empresa = value		End Set	End Property	Property Id_responsavel() As Integer		Get			Return _id_responsavel		End Get		Set(ByVal value As Integer)			_id_responsavel = value		End Set	End Property	Property Nome() As String		Get			Return _nome		End Get		Set(ByVal value As String)			_nome = value		End Set	End Property	Property Apelido() As String		Get			Return _apelido		End Get		Set(ByVal value As String)			_apelido = value		End Set	End Property	Property Email() As String		Get			Return _email		End Get		Set(ByVal value As String)			_email = value		End Set	End Property	Property Celular() As String		Get			Return _celular		End Get		Set(ByVal value As String)			_celular = value		End Set	End Property	Property Whatsapp() As String		Get			Return _whatsapp		End Get		Set(ByVal value As String)			_whatsapp = value		End Set	End Property	Property Id_cargo() As Integer		Get			Return _id_cargo		End Get		Set(ByVal value As Integer)			_id_cargo = value		End Set	End Property	Property User_ins() As Integer		Get			Return _user_ins		End Get		Set(ByVal value As Integer)			_user_ins = value		End Set	End Property	Property Data_ins() As Date		Get			Return _data_ins		End Get		Set(ByVal value As Date)			_data_ins = value		End Set	End Property	Property User_upd() As Integer		Get			Return _user_upd		End Get		Set(ByVal value As Integer)			_user_upd = value		End Set	End Property	Property Data_upd() As Date		Get			Return _data_upd		End Get		Set(ByVal value As Date)			_data_upd = value		End Set	End PropertyEnd Class