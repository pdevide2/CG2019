Public Class Cg_follow_up	Dim _id_os As Integer	Dim _protocolo As String	Dim _data_hora As Date	Dim _texto As String	Dim _user_ins As Integer	Dim _data_ins As Date	Dim _user_upd As Integer	Dim _data_upd As Date
    Dim _id_empresa As Integer
    Dim _lido As Boolean


    Property Id_empresa() As Integer		Get			Return _id_empresa		End Get		Set(ByVal value As Integer)			_id_empresa = value		End Set	End Property	Property Id_os() As Integer		Get			Return _id_os		End Get		Set(ByVal value As Integer)			_id_os = value		End Set	End Property	Property Protocolo() As String		Get			Return _protocolo		End Get		Set(ByVal value As String)			_protocolo = value		End Set	End Property	Property Data_hora() As Date		Get			Return _data_hora		End Get		Set(ByVal value As Date)			_data_hora = value		End Set	End Property	Property Texto() As String		Get			Return _texto		End Get		Set(ByVal value As String)			_texto = value		End Set	End Property	Property User_ins() As Integer		Get			Return _user_ins		End Get		Set(ByVal value As Integer)			_user_ins = value		End Set	End Property	Property Data_ins() As Date		Get			Return _data_ins		End Get		Set(ByVal value As Date)			_data_ins = value		End Set	End Property	Property User_upd() As Integer		Get			Return _user_upd		End Get		Set(ByVal value As Integer)			_user_upd = value		End Set	End Property	Property Data_upd() As Date		Get			Return _data_upd		End Get		Set(ByVal value As Date)			_data_upd = value		End Set	End Property    Property Lido() As Boolean
        Get
            Return _lido
        End Get
        Set(ByVal value As Boolean)
            _lido = value
        End Set
    End PropertyEnd Class