Public Class Cg_entrada_chip	Dim _id_romaneio As Integer	Dim _data_movto As Date	Dim _id_loja As Integer	Dim _user_ins As Integer	Dim _data_ins As Date	Dim _user_upd As Integer	Dim _data_upd As Date	Dim _id_empresa as Integer	Property Id_empresa() As Integer		Get			Return _id_empresa		End Get		Set(ByVal value As Integer)			_id_empresa = value		End Set	End Property	Property Id_romaneio() As Integer		Get			Return _id_romaneio		End Get		Set(ByVal value As Integer)			_id_romaneio = value		End Set	End Property	Property Data_movto() As Date		Get			Return _data_movto		End Get		Set(ByVal value As Date)			_data_movto = value		End Set	End Property	Property Id_loja() As Integer		Get			Return _id_loja		End Get		Set(ByVal value As Integer)			_id_loja = value		End Set	End Property	Property User_ins() As Integer		Get			Return _user_ins		End Get		Set(ByVal value As Integer)			_user_ins = value		End Set	End Property	Property Data_ins() As Date		Get			Return _data_ins		End Get		Set(ByVal value As Date)			_data_ins = value		End Set	End Property	Property User_upd() As Integer		Get			Return _user_upd		End Get		Set(ByVal value As Integer)			_user_upd = value		End Set	End Property	Property Data_upd() As Date		Get			Return _data_upd		End Get		Set(ByVal value As Date)			_data_upd = value		End Set	End PropertyEnd Class