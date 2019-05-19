Public Class OcorrenciaVsLoja
    Private _idLoja As Integer
    Public Property IdLoja() As String
        Get
            Return _idLoja
        End Get
        Set(ByVal value As String)
            _idLoja = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal _id_loja As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdLoja = _id_loja
    End Sub


    Private Sub OcorrenciaVsLoja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub inicio()
        Dim sql As String
        sql = "exec spBuscaOcorrencia_Loja @ID_LOJA = " & Me.IdLoja.ToString
        dgvDados.DataSource = BLL.GlobalBLL.PesquisarFkBLL(sql).Tables(0)
        dgvDados.AutoResizeColumns()
    End Sub

    Private Sub dgvDados_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellEnter
        txtIdOcorrencia.Text = dgvDados.CurrentRow.Cells("ID_OCORRENCIA").Value
        txtData.Text = dgvDados.CurrentRow.Cells("DATA_OCORRENCIA").Value
        txtDescricao.Text = dgvDados.CurrentRow.Cells("DESCRICAO").Value
        txtIdEquipamento.Text = dgvDados.CurrentRow.Cells("ID_EQUIPAMENTO").Value
        txtSerie.Text = dgvDados.CurrentRow.Cells("SERIE").Value
        txtDescEquipamento.Text = dgvDados.CurrentRow.Cells("DESC_EQUIPAMENTO").Value
        txtModelo.Text = dgvDados.CurrentRow.Cells("MODELO").Value
        txtOsVinculada.Text = dgvDados.CurrentRow.Cells("OS_VINCULADA").Value
        txtIdLoja.Text = dgvDados.CurrentRow.Cells("ID_LOJA").Value
        txtCodigoLoja.Text = dgvDados.CurrentRow.Cells("CODIGO").Value
        txtNomeLoja.Text = dgvDados.CurrentRow.Cells("NOME").Value
        txtHistorico.Text = dgvDados.CurrentRow.Cells("HISTORICO").Value
    End Sub
End Class