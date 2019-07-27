Public Class TrocaSenha

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Valida a senha e persiste no banco de dados
        If validarSenha() Then
            efetuaTrocaSenha()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Desfaz a ação e fecha a tela sem salvar
        Me.Close()

    End Sub

    Private Function validarSenha() As Boolean
        Dim bll As New BLL.GlobalBLL
        Dim intRetorno As Integer
        intRetorno = bll.validaLoginBLL(ACE_NOME_USUARIO, txtSenhaAtual.Text, Publico.Nome_empresa)

        If intRetorno < 0 Then
            MessageBox.Show("Senha Atual informada é inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Trim(txtNovaSenha.Text) <> Trim(txtConfirmaSenha.Text) Then
            MessageBox.Show("Nova senha informada é diferente da senha confirmada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub efetuaTrocaSenha()
        Dim bllglobal As New BLL.GlobalBLL
        Dim cmdsql As String

        cmdsql = "EXEC spTrocaSenhaUser "
        cmdsql += "@ID_USUARIO = " & ACE_CODIGO.ToString & ", "
        cmdsql += "@NOVA_SENHA = '" & Trim(txtNovaSenha.Text) & "' "

        Try
            bllglobal.GravarGenericoBLL(cmdsql)
            MessageBox.Show("Senha substituída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TrocaSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Trocar senha para Empresa " & Publico.Nome_empresa
    End Sub
End Class