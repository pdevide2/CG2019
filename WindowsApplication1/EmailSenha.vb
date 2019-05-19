Public Class EmailSenha
    Dim arrayFiles() As String = {""}
    Dim intDica As Integer = 0

    Private Sub chkExibir_CheckedChanged(sender As Object, e As EventArgs) Handles chkExibir.CheckedChanged
        If chkExibir.Checked = True Then
            txtPalavra.PasswordChar = ""
        Else
            txtPalavra.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim strSenha As String = ""
        Try
            If String.IsNullOrEmpty(txtEmailDestino.Text) Then
                Throw New Exception("Obrigatório informar um e-mail válido!")
            End If
            strSenha = BuscaSenha(txtLogin.Text, txtPalavra.Text)
            If Not String.IsNullOrEmpty(strSenha) Then
                EnviarGMail(txtEmailDestino.Text, "Lembrete da Senha", _
                            "Prezado usuário, a senha solicitada é: " & strSenha, arrayFiles)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function BuscaSenha(ByVal _login As String, ByVal _palavra_chave As String) As String

        Dim sqlEmpty As String, sql As String = "", strRetorno As String = ""

        If String.IsNullOrEmpty(_login) Then
            MessageBox.Show("Obrigatório informar o Login para buscar a senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BuscaSenha = ""
            Exit Function
        End If

        If String.IsNullOrEmpty(_palavra_chave) Then
            MessageBox.Show("Obrigatório informar a Palavra Chave para validar o Login!", _
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BuscaSenha = ""
            Exit Function
        End If

        sqlEmpty = "SELECT ISNULL(DBO.fx_Desencriptar(SENHA),'') AS SENHA, " & _
                    "ISNULL(PALAVRA_CHAVE,'') AS PALAVRA_CHAVE, ISNULL(ID_PERGUNTA,0) AS ID_PERGUNTA, " & _
                    "ID_USUARIO, LOGIN FROM CG_USUARIO WHERE LOGIN = '{0}'"

        'Dim strXml = TxtToString(_filename)
        sql = sqlEmpty
        sql = String.Format(sql, _login)

        Dim bllGlobal As New BLL.GlobalBLL

        Dim dt As DataTable
        dt = bllGlobal.SqlExecDT(sql)

        If dt.Rows.Count > 0 Then
            intDica = dt(0)("ID_PERGUNTA")

            If String.IsNullOrEmpty(dt(0)("PALAVRA_CHAVE")) Then
                If MessageBox.Show("Atenção! Palavra chave não cadastrada." & Chr(13) & _
                                    "Ela é necessária caso necessite recuperar a senha!" & Chr(13) & _
                                    "Deseja cadastrar agora?", _
                                    "Aviso", MessageBoxButtons.YesNo, _
                                    MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    Dim frm As New frmCadPalavra(dt(0)("ID_USUARIO"))
                    frm.ShowDialog()
                    BuscaSenha = ""
                    Exit Function
                End If
            End If

            'Compara a palavra chave informada pelo usuário, se estiver correta,
            'retorna a Senha pesquisada para o usuário por e-mail
            If Trim(UCase(_palavra_chave)) = Trim(UCase(dt(0)("PALAVRA_CHAVE"))) Then
                strRetorno = dt(0)("SENHA")
                BuscaSenha = strRetorno
            Else
                BuscaSenha = ""
                MessageBox.Show("Palavra Chave informada incorreta!", "Aviso", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If

        Else
            MessageBox.Show("Login informado não foi localizado no Sistema CG!", "Aviso", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            BuscaSenha = ""
            Exit Function
        End If

        Return strRetorno

    End Function

    Private Sub btnDica_Click(sender As Object, e As EventArgs) Handles btnDica.Click

        MostraDica()

    End Sub

    Private Sub MostraDica()

        If String.IsNullOrEmpty(txtLogin.Text) Then
            MessageBox.Show("Obrigatório informar o Login!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim listaDica() As String = {"Qual o nome de sua banda favorita?", _
                                        "Qual o nome de seu animal de estimação?", _
                                        "Qual é o time que você torce?", _
                                        "Qual é a sua cor preferida?", _
                                        "Qual é a sua comida predileta?"}

        Dim sqlEmpty As String, sql As String, strPalavra As String, intUsuario As Integer

        sqlEmpty = "SELECT ISNULL(DBO.fx_Desencriptar(SENHA),'') AS SENHA, " & _
                     "ISNULL(PALAVRA_CHAVE,'') AS PALAVRA_CHAVE, ISNULL(ID_PERGUNTA,0) AS ID_PERGUNTA " & _
                     ",ID_USUARIO, LOGIN FROM CG_USUARIO WHERE LOGIN = '{0}'"

        'Dim strXml = TxtToString(_filename)
        sql = sqlEmpty
        sql = String.Format(sql, txtLogin.Text)

        Dim bllGlobal As New BLL.GlobalBLL

        Dim dt As DataTable
        dt = bllGlobal.SqlExecDT(sql)

        If dt.Rows.Count > 0 Then
            intDica = dt(0)("ID_PERGUNTA")
            strPalavra = dt(0)("PALAVRA_CHAVE")
            intUsuario = dt(0)("ID_USUARIO")
            If String.IsNullOrEmpty(strPalavra) Then
                If MessageBox.Show("Atenção! Palavra chave não cadastrada." & Chr(13) & _
                                    "Ela é necessária caso necessite recuperar a senha!" & Chr(13) & _
                                    "Deseja cadastrar agora?", _
                                    "Aviso", MessageBoxButtons.YesNo, _
                                    MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    Dim frm As New frmCadPalavra(intUsuario)
                    frm.ShowDialog()

                End If
            End If
            If intDica > 0 Then
                Dim i As Byte
                For i = 0 To 4
                    If i + 1 = intDica Then
                        MessageBox.Show(listaDica(i).ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                Next
            End If
        End If

    End Sub
End Class