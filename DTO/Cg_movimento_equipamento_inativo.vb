Public Class Cg_movimento_equipamento_inativo    Dim _id_romaneio As Integer    Dim _data_movto As Date    Dim _id_responsavel As Integer    Dim _id_loja_origem As Integer    Dim _id_loja_destino As Integer    Dim _tipo_op As String    Dim _user_ins As Integer    Dim _data_ins As Date    Dim _user_upd As Integer    Dim _data_upd As Date    Dim _qtd_recebida As Integer    Dim _qtd_total As Integer    Property Id_romaneio() As Integer        Get            Return _id_romaneio        End Get        Set(ByVal value As Integer)            _id_romaneio = value        End Set    End Property    Property Data_movto() As Date        Get            Return _data_movto        End Get        Set(ByVal value As Date)            _data_movto = value        End Set    End Property    Property Id_responsavel() As Integer        Get            Return _id_responsavel        End Get        Set(ByVal value As Integer)            _id_responsavel = value        End Set    End Property    Property Id_loja_origem() As Integer        Get            Return _id_loja_origem        End Get        Set(ByVal value As Integer)            _id_loja_origem = value        End Set    End Property    Property Id_loja_destino() As Integer        Get            Return _id_loja_destino        End Get        Set(ByVal value As Integer)            _id_loja_destino = value        End Set    End Property    Property Tipo_op() As String        Get            Return _tipo_op        End Get        Set(ByVal value As String)            _tipo_op = value        End Set    End Property    Property User_ins() As Integer        Get            Return _user_ins        End Get        Set(ByVal value As Integer)            _user_ins = value        End Set    End Property    Property Data_ins() As Date        Get            Return _data_ins        End Get        Set(ByVal value As Date)            _data_ins = value        End Set    End Property    Property User_upd() As Integer        Get            Return _user_upd        End Get        Set(ByVal value As Integer)            _user_upd = value        End Set    End Property    Property Data_upd() As Date        Get            Return _data_upd        End Get        Set(ByVal value As Date)            _data_upd = value        End Set    End Property    Property Qtd_recebida() As Integer        Get            Return _qtd_recebida        End Get        Set(ByVal value As Integer)            _qtd_recebida = value        End Set    End Property    Property Qtd_total() As Integer        Get            Return _qtd_total        End Get        Set(ByVal value As Integer)            _qtd_total = value        End Set    End PropertyEnd Class