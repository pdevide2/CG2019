Public Class Cg_tipo_servico	Dim _id_tipo_servico As Integer	Dim _desc_tipo_servico As String	Dim _user_ins As Integer	Dim _data_ins As Date	Dim _user_upd As Integer	Dim _data_upd As Date	Dim _id_empresa as Integer	Property Id_empresa() As Integer		Get			Return _id_empresa		End Get		Set(ByVal value As Integer)			_id_empresa = value		End Set	End Property	Property Id_tipo_servico() As Integer		Get			Return _id_tipo_servico		End Get		Set(ByVal value As Integer)			_id_tipo_servico = value		End Set	End Property	Property Desc_tipo_servico() As String		Get			Return _desc_tipo_servico		End Get		Set(ByVal value As String)			_desc_tipo_servico = value		End Set	End Property	Property User_ins() As Integer		Get			Return _user_ins		End Get		Set(ByVal value As Integer)			_user_ins = value		End Set	End Property	Property Data_ins() As Date		Get			Return _data_ins		End Get		Set(ByVal value As Date)			_data_ins = value		End Set	End Property	Property User_upd() As Integer		Get			Return _user_upd		End Get		Set(ByVal value As Integer)			_user_upd = value		End Set	End Property	Property Data_upd() As Date		Get			Return _data_upd		End Get		Set(ByVal value As Date)			_data_upd = value		End Set	End PropertyEnd Class