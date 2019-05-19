Imports System.Diagnostics
Imports System.ComponentModel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ImportarCadastroLoja
    Public podeAbrir As Boolean = False
    'variavel flagAcao o Default é readonly, após verificar permissão no módulo pode mudar para Limpar (0)
    Public flagAcao As Integer = Operacao.Leitura
    Dim _acao As Integer
    Dim _acesso As String
    Public Enum Operacao

        Limpar = 0
        Novo = 1
        Alterar = 2
        Excluir = 3
        Consulta = 4
        Leitura = 5

    End Enum
    Public Property Acao() As Integer
        Get
            Return _acao
        End Get
        Set(ByVal value As Integer)
            _acao = value
        End Set
    End Property
    Public Property Acesso() As String
        Get
            Return _acesso
        End Get
        Set(ByVal value As String)
            _acesso = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoginCG() 'Carrega variavel Friend ACE_CODIGO pelo Setting ID_USER
        ' Add any initialization after the InitializeComponent() call.
        podeAbrir = permissaoTela(ACE_MODULO, ACE_CODIGO)


    End Sub
    Public Function permissaoTela(ByVal intModulo As Integer, ByVal intUsuario As Integer) As Boolean
        flagAcao = Operacao.Limpar
        'Dim strPermissao As String = ""
        'strPermissao = verPermissao(intModulo, intUsuario)

        'Me.Acesso = strPermissao

        'If strPermissao = "S" Then
        '    MessageBox.Show("Usuário sem permissão de acesso neste módulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'ElseIf strPermissao = "L" Then
        '    flagAcao = Operacao.Leitura
        'ElseIf strPermissao = "G" Then
        '    flagAcao = Operacao.Limpar
        'Else
        '    MessageBox.Show("Configurações de permissão para este módulo não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False

        'End If
        Me.Acao = flagAcao
        Return True
    End Function
    Function verPermissao(ByVal modulo As Integer, ByVal usuario As Integer) As String

        Dim retorno As String
        Dim oBLL As New BLL.GlobalBLL

        retorno = oBLL.getPermissaoBLL(modulo, usuario)
        Return retorno

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strfilename As String = ""
        ofd.FileName = strfilename
        Try
            If Not Directory.Exists("C:\TEMP2\") Then
                Directory.CreateDirectory("C:\TEMP2")
            End If

            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                strfilename = Trim(ofd.FileName)
                MessageBox.Show(strfilename, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Seleção de Planilha Excel cancelado pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strfilename = ""
                txtFile.Text = ""
            End If
            If Not String.IsNullOrEmpty(strfilename) Then
                txtFile.Text = strfilename
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFile.Text = ""
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ExportarPlanilha()

    End Sub

    Private Sub ExportarPlanilha()
        Try
            If Not Directory.Exists("C:\TEMP2\") Then
                Directory.CreateDirectory("C:\TEMP2")
            End If

            Dim arqOrigem As String = My.Settings.DIRHOME & "CG\CG\Modelos\MODELO_CADASTRO_LOJAS.xlsx"
            Dim arqDestino As String = "C:\TEMP2\MODELO_CADASTRO_LOJAS_" & ProtocoloNumero() & ".xlsx"
            My.Computer.FileSystem.CopyFile(arqOrigem, arqDestino)

            'Abre a planilha Excel gerada para o usuário preencher
            Process.Start("Excel.exe", arqDestino)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ImportarPlanilha()
        Try
            If Not Directory.Exists("C:\TEMP2\") Then
                Directory.CreateDirectory("C:\TEMP2")
            End If

            If String.IsNullOrEmpty(Trim(txtFile.Text)) Then
                MessageBox.Show("Selecione uma planilha para importar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim xl As New Excel.Application
            Dim xlw As Excel.Workbook

            xlw = xl.Workbooks.Open(Trim(txtFile.Text))
            xlw.Worksheets.Select(1)

            'COLUNA CONTEUDO
            '====== ====================
            'A      CODIGO	
            'B      SIGLA	
            'C      NOME	
            'D      ENDERECO	
            'E      COMPLEMENTO	
            'F      CEP	
            'G      CIDADE	
            'H      BAIRRO	
            'I      UF	
            'J      ALOCACAO	
            'K      RESPONSAVEL	
            'L      TELEFONE FIXO	
            'M      CELULAR/WHATSAPP
            'N      AREA
            '0      LOJA FISICA
            'P      PARCERIA

            Dim strDados As New ArrayList

            'Declaração de variaveis para armazenar conteudo do excel

            Dim celulas(16) As String
            'Posição dos Elementos do Array
            '00 - Codigo
            '01 - Sigla
            '02 - Nome
            '03 - Endereco
            '04 - Complemento
            '05 - Cep
            '06 - Cidade
            '07 - Bairro
            '08 - UF
            '09 - Alocacao
            '10 - Responsavel 
            '11 - Telefone
            '12 - Celular
            '13 - Area
            '14 - Loja Fisica
            '15 - Parceria

            '*****
            '* Le a Planilha Excel até encontrar um CODIGO nulo
            '* carrega para um ArrayList e depois valida e popula 
            '* o DataGridView, se não encontrar importa, caso
            '* contrário da mensagem de erro e não importa a Linha
            '*/
            Dim linha As Integer = 2

            Dim ixx As Integer = 0
            For ixx = 1 To 16
                If String.IsNullOrEmpty(xlw.Application.Cells(linha, ixx).Value) Then
                    celulas(ixx - 1) = ""
                Else
                    celulas(ixx - 1) = xlw.Application.Cells(linha, ixx).Value.ToString
                End If
            Next

            While Len(Trim(celulas(0))) > 0

                strDados.Add({celulas(0), _
                              celulas(1), _
                              celulas(2), _
                              celulas(3), _
                              celulas(4), _
                              celulas(5), _
                              celulas(6), _
                              celulas(7), _
                              celulas(8), _
                              celulas(9), _
                              celulas(10), _
                              celulas(11), _
                              celulas(12), _
                              celulas(13), _
                              celulas(14), _
                              celulas(15)})

                linha = linha + 1

                If String.IsNullOrEmpty(xlw.Application.Cells(linha, 1).Value) Then
                    celulas(0) = ""
                Else
                    lblMensagem.Text = "Lendo linha " & linha & " Código: " & celulas(0)

                    For ixx = 1 To 16
                        If String.IsNullOrEmpty(xlw.Application.Cells(linha, ixx).Value) Then
                            celulas(ixx - 1) = ""
                        Else
                            celulas(ixx - 1) = xlw.Application.Cells(linha, ixx).Value.ToString
                        End If
                    Next

                End If


            End While

            lblMensagem.Text = "."

            xlw.Close(False)
            xl.Quit()

            'Kill Process
            MataProcessoExcel()

            xl = Nothing
            xlw = Nothing

            GC.Collect()

            Popula_Grid(strDados)
            'Persiste os dados no banco de dados SQL
            Gravar()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub FormataGrid()

        Dim colCodigo As DataGridViewTextBoxColumn
        Dim colSigla As DataGridViewTextBoxColumn
        Dim colNome As DataGridViewTextBoxColumn
        Dim colEndereco As DataGridViewTextBoxColumn
        Dim colComplemento As DataGridViewTextBoxColumn
        Dim colCep As DataGridViewTextBoxColumn
        Dim colCidade As DataGridViewTextBoxColumn
        Dim colBairro As DataGridViewTextBoxColumn
        Dim colUf As DataGridViewTextBoxColumn
        Dim colAlocacao As DataGridViewTextBoxColumn
        Dim colResponsavel As DataGridViewTextBoxColumn
        Dim colTelefone As DataGridViewTextBoxColumn
        Dim colCelular As DataGridViewTextBoxColumn
        Dim colStatus As DataGridViewTextBoxColumn
        Dim colObs As DataGridViewTextBoxColumn
        Dim colArea As DataGridViewTextBoxColumn
        Dim colLojaFisica As DataGridViewTextBoxColumn
        Dim colParceria As DataGridViewTextBoxColumn


        ' Coluna colAlocacao
        colAlocacao = New DataGridViewTextBoxColumn
        colAlocacao.HeaderText = "Alocacao"
        colAlocacao.Name = "ALOCACAO"
        colAlocacao.Width = 100

        ' Coluna colBairro
        colBairro = New DataGridViewTextBoxColumn
        colBairro.HeaderText = "Bairro"
        colBairro.Name = "BAIRRO"
        colBairro.Width = 100

        ' Coluna colCelular
        colCelular = New DataGridViewTextBoxColumn
        colCelular.HeaderText = "Celular"
        colCelular.Name = "CELULAR"
        colCelular.Width = 100

        ' Coluna colCep
        colCep = New DataGridViewTextBoxColumn
        colCep.HeaderText = "Cep"
        colCep.Name = "CEP"
        colCep.Width = 100

        ' Coluna colCidade
        colCidade = New DataGridViewTextBoxColumn
        colCidade.HeaderText = "Cidade"
        colCidade.Name = "CIDADE"
        colCidade.Width = 100

        ' Coluna colCodigo
        colCodigo = New DataGridViewTextBoxColumn
        colCodigo.HeaderText = "Codigo"
        colCodigo.Name = "CODIGO"
        colCodigo.Width = 100

        ' Coluna colComplemento
        colComplemento = New DataGridViewTextBoxColumn
        colComplemento.HeaderText = "Complemento"
        colComplemento.Name = "COMPLEMENTO"
        colComplemento.Width = 100

        ' Coluna colEndereco
        colEndereco = New DataGridViewTextBoxColumn
        colEndereco.HeaderText = "Endereco"
        colEndereco.Name = "ENDERECO"
        colEndereco.Width = 100

        ' Coluna colNome
        colNome = New DataGridViewTextBoxColumn
        colNome.HeaderText = "Nome"
        colNome.Name = "NOME"
        colNome.Width = 100

        ' Coluna colObs
        colObs = New DataGridViewTextBoxColumn
        colObs.HeaderText = "Obs"
        colObs.Name = "OBS"
        colObs.Width = 100

        ' Coluna colResponsavel
        colResponsavel = New DataGridViewTextBoxColumn
        colResponsavel.HeaderText = "Responsavel"
        colResponsavel.Name = "RESPONSAVEL"
        colResponsavel.Width = 100

        ' Coluna colSigla
        colSigla = New DataGridViewTextBoxColumn
        colSigla.HeaderText = "Sigla"
        colSigla.Name = "SIGLA"
        colSigla.Width = 100

        ' Coluna colStatus
        colStatus = New DataGridViewTextBoxColumn
        colStatus.HeaderText = "Status"
        colStatus.Name = "STATUS"
        colStatus.Width = 100

        ' Coluna colTelefone
        colTelefone = New DataGridViewTextBoxColumn
        colTelefone.HeaderText = "Telefone"
        colTelefone.Name = "TELEFONE"
        colTelefone.Width = 100

        ' Coluna colUf
        colUf = New DataGridViewTextBoxColumn
        colUf.HeaderText = "Uf"
        colUf.Name = "UF"
        colUf.Width = 100

        colArea = New DataGridViewTextBoxColumn
        colArea.HeaderText = "Área"
        colArea.Name = "ID_AREA"
        colArea.Width = 130

        colLojaFisica = New DataGridViewTextBoxColumn
        colLojaFisica.HeaderText = "Loja Fisica?"
        colLojaFisica.Name = "LOJA_FISICA"
        colLojaFisica.Width = 100

        colParceria = New DataGridViewTextBoxColumn
        colParceria.HeaderText = "Parceria?"
        colParceria.Name = "PARCERIA"
        colParceria.Width = 100

        'Reset no Grid
        dgvDados.DataSource = Nothing
        dgvDados.Rows.Clear()
        'Reset nas colunas do Grid
        dgvDados.ColumnCount = 0
        'Modifica o Default de AutoGenerate de True para False (Montagem Manual de Colunas)
        dgvDados.AutoGenerateColumns = False

        'Adicionar estas colunas para a coleçao do DataGridView
        dgvDados.Columns.AddRange(New DataGridViewColumn() {colCodigo, _
                                                            colSigla, _
                                                            colNome, _
                                                            colEndereco, _
                                                            colComplemento, _
                                                            colCep, _
                                                            colCidade, _
                                                            colBairro, _
                                                            colUf, _
                                                            colAlocacao, _
                                                            colResponsavel, _
                                                            colTelefone, _
                                                            colCelular, _
                                                            colArea, _
                                                            colLojaFisica, _
                                                            colParceria, _
                                                            colStatus, _
                                                            colObs})

        For ixx = 0 To 17
            dgvDados.Columns(ixx).ReadOnly = True 'Todas as colunas Textbox são ReadOnly
        Next

        dgvDados.AllowUserToAddRows = False     'bloqueia adição de novas linhas
        dgvDados.AllowUserToDeleteRows = False  'bloqueia exclusão de linhas
        dgvDados.AutoResizeColumns()            'Autofit nas colunas para Exibição

        dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDados.MultiSelect = False
        dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDados.AllowUserToResizeColumns = False
        dgvDados.EnableHeadersVisualStyles = False

    End Sub

    Private Sub ImportarCadastroChip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormataGrid()
    End Sub

    Private Sub Popula_Grid(ByVal arrayPlanilha As ArrayList)
        Try

            'Le os dados da lista de array e converte tudo para String, coluna por coluna e 
            'armazena no array de Strings strLinha, que posteriormente será adicionado no Grid
            Dim strLinha As String()

            Dim _id_loja As String
            Dim _Codigo As String
            Dim _Sigla As String
            Dim _Nome As String
            Dim _Endereco As String
            Dim _Complemento As String
            Dim _Cep As String
            Dim _Cidade As String
            Dim _Bairro As String
            Dim _Uf As String
            Dim _Alocacao As String
            Dim _Responsavel As String
            Dim _Telefone As String
            Dim _Celular As String
            Dim _Status As String
            Dim _Obs As String

            Dim _Area As String
            Dim _Loja_Fisica As String
            Dim _Parceria As String


            Dim _id_alocacao As String
            Dim _id_responsavel As String
            Dim _id_area As String

            For ixx = 0 To arrayPlanilha.Count - 1

                Dim myRow As ArrayList, comandoSQL As String


                comandoSQL = "select ID_LOJA, Codigo, Sigla, Nome, Endereco, Complemento, Cep, Cidade, "
                comandoSQL += "Bairro, Uf, ID_TIPO_LOCAL, ID_RESPONSAVEL, Telefone, Celular "
                comandoSQL += "from cg_loja where CODIGO = '" & arrayPlanilha(ixx)(0) & "'"

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

                If myRow.Count > 0 Then

                    _id_loja = myRow(0)(0).ToString
                    _Codigo = myRow(0)(1).ToString
                    _Sigla = myRow(0)(2).ToString
                    _Nome = myRow(0)(3).ToString
                    _Endereco = myRow(0)(4).ToString
                    _Complemento = myRow(0)(5).ToString
                    _Cep = myRow(0)(6).ToString
                    _Cidade = myRow(0)(7).ToString
                    _Bairro = myRow(0)(8).ToString
                    _Uf = myRow(0)(9).ToString
                    _Alocacao = myRow(0)(10).ToString
                    _Responsavel = myRow(0)(11).ToString
                    _Telefone = myRow(0)(12).ToString
                    _Celular = myRow(0)(13).ToString

                    _Area = ""
                    _Loja_Fisica = ""
                    _Parceria = ""

                    _Status = "EXISTE"
                    _Obs = "ATUALIZAR CADASTRO"

                Else

                    _Status = "NOVO"
                    _Obs = String.Empty

                    'myRow = Nothing

                    ''pega somente a parte do ID, exemplo: "1-BAR" retorna "1"
                    '_id_alocacao = arrayPlanilha(ixx)(9)
                    '_id_alocacao = _id_alocacao.Substring(0, _id_alocacao.IndexOf("|"))

                    'comandoSQL = "select ID_ALOCACAO, DESC_ALOCACAO from cg_alocacao  "
                    'comandoSQL += "WHERE ID_ALOCACAO = " & _id_alocacao

                    'myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                    'If myRow.Count > 0 Then
                    '    '_idOperadora = myRow(0)(0).ToString
                    'Else
                    '    _Status = "ERRO"
                    '    _Obs = "ALOCAÇÃO NÃO CADASTRADA!"
                    'End If

                    'myRow = Nothing

                    ''pega somente a parte do ID, exemplo: "11-PEDRO" retorna "11"
                    '_id_responsavel = arrayPlanilha(ixx)(10)
                    '_id_responsavel = _id_responsavel.Substring(0, _id_responsavel.IndexOf("|"))

                    'comandoSQL = "SELECT ID_RESPONSAVEL, NOME, APELIDO FROM CG_RESPONSAVEL "
                    'comandoSQL += "WHERE ID_RESPONSAVEL = " & _id_responsavel

                    'myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                    'If myRow.Count > 0 Then
                    '    _Nome = myRow(0)(1).ToString
                    'Else
                    '    _Status = "ERRO"
                    '    _Obs = "RESPONSAVEL NÃO CADASTRADO"
                    'End If

                    '_id_loja = ""
                    '_Codigo = arrayPlanilha(ixx)(0).ToString
                    '_Sigla = arrayPlanilha(ixx)(1).ToString
                    '_Nome = arrayPlanilha(ixx)(2).ToString
                    '_Endereco = arrayPlanilha(ixx)(3).ToString
                    '_Complemento = arrayPlanilha(ixx)(4).ToString
                    '_Cep = arrayPlanilha(ixx)(5).ToString
                    '_Cidade = arrayPlanilha(ixx)(6).ToString
                    '_Bairro = arrayPlanilha(ixx)(7).ToString
                    '_Uf = arrayPlanilha(ixx)(8).ToString
                    '_Alocacao = arrayPlanilha(ixx)(9).ToString
                    '_Responsavel = arrayPlanilha(ixx)(10).ToString
                    '_Telefone = arrayPlanilha(ixx)(11).ToString
                    '_Celular = arrayPlanilha(ixx)(12).ToString

                End If

                '/////
                '// VALIDA INFORMAÇÕES DA PLANILHA PARA INCLUSÃO E ALTERAÇÃO
                '//
                '

                myRow = Nothing

                'pega somente a parte do ID, exemplo: "1-BAR" retorna "1"
                _id_alocacao = arrayPlanilha(ixx)(9)
                _id_alocacao = _id_alocacao.Substring(0, _id_alocacao.IndexOf("|"))

                comandoSQL = "select ID_ALOCACAO, DESC_ALOCACAO from cg_alocacao  "
                comandoSQL += "WHERE ID_ALOCACAO = " & _id_alocacao

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                If myRow.Count > 0 Then
                    '_idOperadora = myRow(0)(0).ToString
                Else
                    _Status = "ERRO"
                    _Obs = "ALOCAÇÃO NÃO CADASTRADA!"
                End If

                myRow = Nothing

                'pega somente a parte do ID, exemplo: "11-PEDRO" retorna "11"
                _id_responsavel = arrayPlanilha(ixx)(10)
                _id_responsavel = _id_responsavel.Substring(0, _id_responsavel.IndexOf("|"))

                comandoSQL = "SELECT ID_RESPONSAVEL, NOME, APELIDO FROM CG_RESPONSAVEL "
                comandoSQL += "WHERE ID_RESPONSAVEL = " & _id_responsavel

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                If myRow.Count > 0 Then
                    _Nome = myRow(0)(1).ToString
                Else
                    _Status = "ERRO"
                    _Obs = "RESPONSAVEL NÃO CADASTRADO"
                End If

                myRow = Nothing
                _id_area = arrayPlanilha(ixx)(13).ToString
                _id_area = _id_area.Substring(0, _id_area.IndexOf("|"))

                comandoSQL = "SELECT ID_AREA, DESC_AREA, ID_RESPONSAVEL FROM CG_AREA "
                comandoSQL += "WHERE ID_AREA = " & _id_area & " AND ID_EMPRESA = " & Publico.Id_empresa

                myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)

                If myRow.Count > 0 Then
                    '_Nome = myRow(0)(1).ToString
                Else
                    _Status = "ERRO"
                    _Obs = "ÁREA NÃO CADASTRADA"
                End If


                _id_loja = ""
                _Codigo = arrayPlanilha(ixx)(0).ToString
                _Sigla = arrayPlanilha(ixx)(1).ToString
                _Nome = arrayPlanilha(ixx)(2).ToString
                _Endereco = arrayPlanilha(ixx)(3).ToString
                _Complemento = arrayPlanilha(ixx)(4).ToString
                _Cep = arrayPlanilha(ixx)(5).ToString
                _Cidade = arrayPlanilha(ixx)(6).ToString
                _Bairro = arrayPlanilha(ixx)(7).ToString
                _Uf = arrayPlanilha(ixx)(8).ToString
                _Alocacao = arrayPlanilha(ixx)(9).ToString
                _Responsavel = arrayPlanilha(ixx)(10).ToString
                _Telefone = arrayPlanilha(ixx)(11).ToString
                _Celular = arrayPlanilha(ixx)(12).ToString

                _Area = arrayPlanilha(ixx)(13).ToString
                _Loja_Fisica = arrayPlanilha(ixx)(14).ToString
                _Parceria = arrayPlanilha(ixx)(15).ToString

                strLinha = {_Codigo, _
                            _Sigla, _
                            _Nome, _
                            _Endereco, _
                            _Complemento, _
                            _Cep, _
                            _Cidade, _
                            _Bairro, _
                            _Uf, _
                            _Alocacao, _
                            _Responsavel, _
                            _Telefone, _
                            _Celular, _
                            _Area, _
                            _Loja_Fisica, _
                            _Parceria, _
                            _Status, _
                            _Obs}

                'strLinha = {_idChip, _
                '            arrayPlanilha(ixx)(0), _
                '            _idOperadora, _
                '            arrayPlanilha(ixx)(1), _
                '            arrayPlanilha(ixx)(2), _
                '            _nome, _
                '            arrayPlanilha(ixx)(3), _
                '            _status, _
                '            _obs}

                dgvDados.Rows.Add(strLinha)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ImportarPlanilha()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportaExcel(dgvDados, "LOG_IMPORT_CHIP")
    End Sub

    Public Sub Gravar()
        'MyBase.Gravar(acao)
        Dim bllGlobal As New BLL.GlobalBLL

        Dim bllLoja As New BLL.LojaBLL
        Dim objLoja As New DTO.Cg_loja
        Dim blnErro As Boolean
        Dim KeyId As Integer
        blnErro = True

        Try

            For Each row As DataGridViewRow In dgvDados.Rows

                If Not row.IsNewRow Then

                    'Carrega os dados no objeto Model para passagem de parametro
                    lblMensagem.Text = "Aguarde atualizando banco de dados..."
                    If Trim(row.Cells(16).Value) = "NOVO" Then

                        KeyId = bllGlobal.NovaChaveBLL("CG_LOJA")
                        objLoja.Id_loja = KeyId 'CInt(row.Cells(0).Value)

                        objLoja.Codigo = row.Cells(0).Value
                        objLoja.Sigla = row.Cells(1).Value
                        objLoja.Nome = row.Cells(2).Value
                        objLoja.Endereco = row.Cells(3).Value
                        objLoja.Complemento = row.Cells(4).Value
                        objLoja.Cep = row.Cells(5).Value
                        objLoja.Cidade = row.Cells(6).Value
                        objLoja.Bairro = row.Cells(7).Value
                        objLoja.Uf = row.Cells(8).Value

                        Dim _id_alocacao As String = ""
                        _id_alocacao = row.Cells(9).Value
                        _id_alocacao = _id_alocacao.Substring(0, _id_alocacao.IndexOf("|"))

                        objLoja.Id_tipo_local = CInt(_id_alocacao)

                        Dim _id_responsavel As String = ""

                        _id_responsavel = row.Cells(10).Value
                        _id_responsavel = _id_responsavel.Substring(0, _id_responsavel.IndexOf("|"))

                        objLoja.Id_responsavel = CInt(_id_responsavel)
                        objLoja.Telefone = row.Cells(11).Value
                        objLoja.Celular = row.Cells(12).Value

                        Dim _id_area As String
                        _id_area = row.Cells("ID_AREA").Value
                        _id_area = _id_area.Substring(0, _id_area.IndexOf("|"))

                        objLoja.IdArea = _id_area

                        objLoja.LojaFisica = IIf(row.Cells("LOJA_FISICA").Value = "SIM", True, False)
                        objLoja.Parceria = IIf(row.Cells("PARCERIA").Value = "SIM", True, False)

                        objLoja.User_ins = ACE_CODIGO
                        objLoja.Data_ins = Hoje()
                        objLoja.User_upd = ACE_CODIGO
                        objLoja.Data_upd = Hoje()

                        objLoja.Id_Tipo_Local_Estoque = 10 'tipo de loja de usuário - fixo = 10
                        objLoja.Id_empresa = Publico.Id_empresa 'id_empresa que estiver logado

                        bllLoja.GravarBLL(1, objLoja) 'insert
                        row.Cells(17).Value = "GRAVADO COM SUCESSO"
                    End If

                    If Trim(row.Cells(16).Value) = "EXISTE" Then
                        Dim myRow As ArrayList, comandoSQL As String
                        myRow = Nothing

                        comandoSQL = "select ID_LOJA, CODIGO from CG_LOJA "
                        comandoSQL += "WHERE CODIGO = '" & row.Cells(0).Value & "' "

                        myRow = BLL.GlobalBLL.PesquisarFkListaBLL(comandoSQL)
                        If myRow.Count > 0 Then
                            KeyId = myRow(0)(0).ToString
                        Else
                            KeyId = -1
                        End If

                        If KeyId > 0 Then '//CHAVE VALIDA

                            'KeyId = CInt(row.Cells("ID_LOJA").Value) 'bllGlobal.NovaChaveBLL("CG_LOJA")
                            objLoja.Id_loja = KeyId 'CInt(row.Cells(0).Value)

                            objLoja.Codigo = row.Cells(0).Value
                            objLoja.Sigla = row.Cells(1).Value
                            objLoja.Nome = row.Cells(2).Value
                            objLoja.Endereco = row.Cells(3).Value
                            objLoja.Complemento = row.Cells(4).Value
                            objLoja.Cep = row.Cells(5).Value
                            objLoja.Cidade = row.Cells(6).Value
                            objLoja.Bairro = row.Cells(7).Value
                            objLoja.Uf = row.Cells(8).Value

                            Dim _id_alocacao As String = ""
                            _id_alocacao = row.Cells(9).Value
                            _id_alocacao = _id_alocacao.Substring(0, _id_alocacao.IndexOf("|"))

                            objLoja.Id_tipo_local = CInt(_id_alocacao)

                            Dim _id_responsavel As String = ""

                            _id_responsavel = row.Cells(10).Value
                            _id_responsavel = _id_responsavel.Substring(0, _id_responsavel.IndexOf("|"))

                            objLoja.Id_responsavel = CInt(_id_responsavel)
                            objLoja.Telefone = row.Cells(11).Value
                            objLoja.Celular = row.Cells(12).Value

                            Dim _id_area As String
                            _id_area = row.Cells("ID_AREA").Value
                            _id_area = _id_area.Substring(0, _id_area.IndexOf("|"))

                            objLoja.IdArea = _id_area

                            '////
                            '// funçao para pegar o responsável da área e atribuir
                            '// para o objeto objLoja.Id_responsavel
                            '
                            Dim _resp_area As String
                            _resp_area = AtualizaResponsavel(_id_area)

                            If Not String.IsNullOrEmpty(_resp_area) Then
                                objLoja.Id_responsavel = CInt(_resp_area)
                            End If

                            objLoja.LojaFisica = IIf(row.Cells("LOJA_FISICA").Value = "SIM", True, False)
                            objLoja.Parceria = IIf(row.Cells("PARCERIA").Value = "SIM", True, False)


                            objLoja.User_ins = ACE_CODIGO
                            objLoja.Data_ins = Hoje()
                            objLoja.User_upd = ACE_CODIGO
                            objLoja.Data_upd = Hoje()

                            objLoja.Id_Tipo_Local_Estoque = 10 'tipo de loja de usuário - fixo = 10
                            objLoja.Id_empresa = Publico.Id_empresa 'id_empresa que estiver logado

                            bllLoja.GravarBLL(2, objLoja) 'UPDATE
                            row.Cells(17).Value = "ATUALIZADO COM SUCESSO"
                        End If

                    End If

                End If

            Next
            'MessageBox.Show(IIf(acao = Operacao.Alterar, "Registro modificado", "Registro incluído") & " com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'flagAcao = Operacao.Consulta
            lblMensagem.Text = "."

        Catch ex As Exception
            MessageBox.Show("Erro ao gravar cadastro: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try

    End Sub
    Private Function AtualizaResponsavel(ByVal pIdArea As String) As String
        Dim retorno As String = ""
        Try
            Dim bllGlobal As New BLL.GlobalBLL
            'Dim sql As String = "SELECT A.ID_RESPONSAVEL, B.NOME FROM CG_AREA A INNER JOIN CG_RESPONSAVEL B " & _
            '                    "ON B.ID_RESPONSAVEL = A.ID_RESPONSAVEL WHERE A.ID_AREA  = " & pIdArea

            Dim sql As String = "SELECT A.ID_RESPONSAVEL, B.NOME FROM CG_AREA A INNER JOIN CG_RESPONSAVEL B " & _
                    "ON B.ID_RESPONSAVEL = A.ID_RESPONSAVEL WHERE A.ID_AREA  = " & pIdArea & _
                    " AND A.ID_EMPRESA = " & Publico.Id_empresa

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)

            If dt.Rows.Count > 0 Then

                retorno = dt(0)("ID_RESPONSAVEL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return retorno

    End Function

End Class