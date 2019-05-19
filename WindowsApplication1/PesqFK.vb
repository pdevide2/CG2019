Public Class PesqFK
    Private _codigoSelecionado As String
    Public Property CodigoSelecionado() As String
        Get
            Return _codigoSelecionado
        End Get
        Set(ByVal value As String)
            _codigoSelecionado = value
        End Set
    End Property

    Private _descricaoSelecionada As String
    Public Property DescricaoSelecionada() As String
        Get
            Return _descricaoSelecionada
        End Get
        Set(ByVal value As String)
            _descricaoSelecionada = value
        End Set
    End Property

    Private _filtrosql As String
    Public Property FiltroSQL() As String
        Get
            Return _filtrosql
        End Get
        Set(ByVal value As String)
            _filtrosql = value
        End Set
    End Property
    Private _clicou As Integer
    Public Property Clicou() As String
        Get
            Return _clicou
        End Get
        Set(ByVal value As String)
            _clicou = value
        End Set
    End Property
    Private _pos_valida As Boolean
    Public Property PosValida() As Boolean
        Get
            Return _pos_valida
        End Get
        Set(ByVal value As Boolean)
            _pos_valida = value
        End Set
    End Property

    Dim _objModelFk As Object
    Public Overridable Property ObjModelFk() As Object
        Get
            Return _objModelFk
        End Get
        Set(ByVal value As Object)
            _objModelFk = value
        End Set
    End Property
    Private _labelPesqFK As String
    Public Overridable Property LabelPesqFK() As String
        Get
            Return _labelPesqFK
        End Get
        Set(ByVal value As String)
            _labelPesqFK = value
        End Set
    End Property
    Private _tabela As String
    Public Overridable Property Tabela() As String
        Get
            Return _tabela
        End Get
        Set(ByVal value As String)
            _tabela = value
        End Set
    End Property
    Private _view As String
    Public Overridable Property View() As String
        Get
            Return _view
        End Get
        Set(ByVal value As String)
            _view = value
        End Set
    End Property
    Private _campoId As String
    Public Overridable Property CampoId() As String
        Get
            Return _campoId
        End Get
        Set(ByVal value As String)
            _campoId = value
        End Set
    End Property
    Private _campoDesc As String
    Public Overridable Property CampoDesc() As String
        Get
            Return _campoDesc
        End Get
        Set(ByVal value As String)
            _campoDesc = value
        End Set
    End Property
    Private _listaCampos As String
    Public Overridable Property ListaCampos() As String
        Get
            Return _listaCampos
        End Get
        Set(ByVal value As String)
            _listaCampos = value
        End Set
    End Property
    Private _colunasFiltro As String
    Public Overridable Property ColunasFiltro() As String
        Get
            Return _colunasFiltro
        End Get
        Set(ByVal value As String)
            _colunasFiltro = value
        End Set
    End Property
    Private _labelBuscaId As String
    Public Overridable Property LabelBuscaId() As String
        Get
            Return _labelBuscaId
        End Get
        Set(ByVal value As String)
            _labelBuscaId = value
        End Set
    End Property
    Private _labelBuscaDesc As String
    Public Overridable Property LabelBuscaDesc() As String
        Get
            Return _labelBuscaDesc
        End Get
        Set(ByVal value As String)
            _labelBuscaDesc = value
        End Set
    End Property
    Private _tituloTela As String
    Public Overridable Property TituloTela() As String
        Get
            Return _tituloTela
        End Get
        Set(ByVal value As String)
            _tituloTela = value
        End Set
    End Property
    Public Overridable Sub btnPesq_Click(sender As Object, e As EventArgs) Handles btnPesq.Click
        Me.ObjModelFk = New DTO.PesquisaFK

        Me.ObjModelFk.Tabela = Me.Tabela
        Me.ObjModelFk.CampoId = Me.CampoId
        Me.ObjModelFk.CampoDesc = Me.CampoDesc
        Me.ObjModelFk.ListaCampos = Me.ListaCampos
        Me.ObjModelFk.ColunasFiltro = Me.ColunasFiltro ' ComboBox de filtros
        Me.ObjModelFk.LabelBuscaId = Me.LabelBuscaId
        Me.ObjModelFk.LabelBuscaDesc = Me.LabelBuscaDesc
        Me.ObjModelFk.TituloTela = Me.TituloTela
        Me.ObjModelFk.TxtId = "0"
        Me.ObjModelFk.TxtDesc = ""

        Me.CodigoSelecionado = ""
        Me.DescricaoSelecionada = ""

        'Monta o Comando SQL'
        Me.ObjModelFk.ComandoSQL = "Select " & Me.ObjModelFk.ListaCampos & _
                            " From " & Me.ObjModelFk.Tabela

        If String.IsNullOrEmpty(Me.FiltroSQL) Then
            Me.FiltroSQL = " WHERE (1=1) "
        End If
        Me.ObjModelFk.FiltroSQL = Me.FiltroSQL '" where (1=1) "

        PesquisaFK2(Me.ObjModelFk)

        Me.txtId.Text = Me.ObjModelFk.txtId.ToString
        Me.txtDesc.Text = Me.ObjModelFk.txtDesc

        Me.CodigoSelecionado = Me.ObjModelFk.txtId.ToString
        Me.DescricaoSelecionada = Me.ObjModelFk.txtDesc

        Me.Clicou += 1
        If Me.PosValida = True Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Public Overridable Sub PesquisaFK2(oPesqFk As DTO.PesquisaFK)
        'Chama uma tela de Pesquisa Dinamica
        'Para buscar e filtrar um registro de tabela estrangeira
        Dim frm As New PesquisaDinamica2(Me, oPesqFk)
        frm.Owner = Me.ParentForm
        frm.ShowDialog()
    End Sub

    Private Sub PesqFK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Clicou = 0
        Me.lblLabelFK.Text = Me.LabelPesqFK
    End Sub
End Class
