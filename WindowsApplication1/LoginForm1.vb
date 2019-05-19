Imports DTO
Imports BLL

Public Class LoginForm1

    Private _comandoSQL As String
    Public Property ComandoSQL() As String
        Get
            Return _comandoSQL
        End Get
        Set(ByVal value As String)
            _comandoSQL = value
        End Set
    End Property

    'Friend ACE_CODIGO As Integer = 0
    Dim intTry As Integer = 1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            LoginCG() 'Carrega a variavel ACE_CODIGO

            Dim bll As New BLL.GlobalBLL
            ACE_CODIGO = bll.validaLoginBLL(txtLogin.Text, txtSenha.Text, cboEmpresa.Text)
            ChangeAndPersistSettings(ACE_CODIGO)
            Publico.Id_usuario = ACE_CODIGO

            setLastUser(txtLogin.Text) 'guarda o nome do ultimo usuário que efetuou Login
            Publico.Nome_usuario = txtLogin.Text
            Publico.Nome_empresa = Trim(cboEmpresa.Text)

            'My.Settings.ID_USER = ACE_CODIGO
            If ACE_CODIGO > 0 Then
                'Dim frmMain As New WinCG.Principal
                'frmMain.Show()

                If Not VerificaPalavraChave(ACE_CODIGO) Then
                    If MessageBox.Show("Atenção! Palavra chave não cadastrada." & Chr(13) & _
                                    "Ela é necessária caso necessite recuperar a senha!" & Chr(13) & _
                                    "Deseja cadastrar agora?", _
                                    "Aviso", MessageBoxButtons.YesNo, _
                                    MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                        Dim frm As New frmCadPalavra(ACE_CODIGO)
                        frm.ShowDialog()

                    End If

                End If

                Me.Hide()
                'Grava os dados da empresa nas propriedades publicas
                SetDadosEmpresa()
                My.Forms.Principal.Show()
            End If

            intTry += 1

            If intTry < 4 Then
                Me.Text = "Login Sistema CG - (" & Convert.ToString(intTry) & "ª tentativa)"
            End If

            If intTry > 3 And ACE_CODIGO <= 0 Then
                Throw New Exception("Login ou Senha Inválidos. Acesso não Permitido ao Sistema CG!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End Try


    End Sub
    Private Sub SetDadosEmpresa()
        Dim sql As String
        sql = "EXEC spDadosLoginCG '" & Trim(txtLogin.Text) & "', '" & Trim(cboEmpresa.Text) & "'"
        Dim bll As New BLL.GlobalBLL
        Dim dt1 = bll.SqlExecDT(sql)
        If dt1.Rows.Count > 0 Then
            Publico.Id_empresa = CInt(dt1.Rows(0)("id_empresa"))
            Publico.Nome_empresa = dt1.Rows(0)("sigla_empresa").ToString
            Publico.Id_Perfil = dt1.Rows(0)("id_perfil")
        End If
        dt1 = Nothing
    End Sub
    Public Sub ChangeAndPersistSettings(ByVal _user As Integer)
        My.Settings.ID_USER = _user
        My.Settings.Save()
    End Sub
    Public Function GetDirhome() As String
        Dim correntdir = Environment.GetEnvironmentVariable("DIRETORIOCG")
        'MessageBox.Show(correntdir, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return correntdir
    End Function
    Public Sub setLastUser(ByVal _user As String)
        ACE_NOME_USUARIO = _user
        My.Settings.LASTUSER = _user
        My.Settings.DIRHOME = GetDirhome()
        My.Settings.Save()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Environment.Exit(0)
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login Sistema CG"
        txtLogin.Text = getLastUser()
        txtSenha.Text = String.Empty
        PopulaComboEmpresa()
    End Sub

    Private Function VerificaPalavraChave(ByVal _Id_user As Integer) As Boolean
        Dim blnRetorno As Boolean = False
        Try
            Dim sqlEmpty As String, sql As String = "", strPalavra As String = ""
            sqlEmpty = "select ISNULL(PALAVRA_CHAVE,'') AS PALAVRA_CHAVE from cg_usuario where ID_USUARIO = {0}"

            sql = sqlEmpty
            sql = String.Format(sql, _Id_user)

            Dim bllGlobal As New BLL.GlobalBLL

            Dim dt As DataTable
            dt = bllGlobal.SqlExecDT(sql)


            If dt.Rows.Count > 0 Then

                strPalavra = dt(0)("PALAVRA_CHAVE")
                If Not String.IsNullOrEmpty(strPalavra) Then
                    VerificaPalavraChave = True
                    blnRetorno = True
                End If

            End If
        Catch ex As Exception
            blnRetorno = False
            VerificaPalavraChave = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return blnRetorno
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New EmailSenha
        frm.ShowDialog()
        'EnviarGMail("pdevide@gmail.com", "Lembrete da Senha", "Lembrete da Senha do Sistema CG")
    End Sub

    Private Sub PopulaComboEmpresa()
        Dim sql = "select a.nome_empresa, a.sigla_empresa, a.id_empresa "
        sql += " from CG_EMPRESA a "
        sql += " inner join CG_EMPRESA_VS_USUARIOS b"
        sql += " on b.ID_EMPRESA = a.ID_EMPRESA"
        sql += " inner join CG_USUARIO c "
        sql += " on c.ID_USUARIO = b.ID_USUARIO"
        sql += " WHERE c.LOGIN = '" & txtLogin.Text & "'"

        Me.ComandoSQL = sql
        Dim dt = BLL.GlobalBLL.PesquisarFkBLL(Me.ComandoSQL).Tables(0)
        cboEmpresa.DataSource = dt
        cboEmpresa.ValueMember = "sigla_empresa"
        cboEmpresa.DisplayMember = "sigla_empresa"
    End Sub

    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged
        PopulaComboEmpresa()
    End Sub


End Class
