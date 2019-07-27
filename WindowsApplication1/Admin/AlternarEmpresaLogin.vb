Public Class AlternarEmpresaLogin
    Private Sub AlternarEmpresaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulaComboEmpresa()
    End Sub
    Private Sub PopulaComboEmpresa()
        Dim sql = "select a.nome_empresa, a.sigla_empresa, a.id_empresa "
        sql += " from CG_EMPRESA a "
        sql += " inner join CG_EMPRESA_VS_USUARIOS b"
        sql += " on b.ID_EMPRESA = a.ID_EMPRESA"
        sql += " inner join CG_USUARIO c "
        sql += " on c.ID_USUARIO = b.ID_USUARIO"
        sql += " WHERE c.ID_USUARIO = " & Publico.Id_usuario

        Dim comandoSQL = sql
        Dim dt = BLL.GlobalBLL.PesquisarFkBLL(comandoSQL).Tables(0)
        cboEmpresa.DataSource = dt
        cboEmpresa.ValueMember = "sigla_empresa"
        cboEmpresa.DisplayMember = "sigla_empresa"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AlternarEmpresa()
        Me.Close()
    End Sub
    Private Sub AlternarEmpresa()
        SetDadosEmpresa()
    End Sub
    Private Sub SetDadosEmpresa()
        Dim sql As String

        sql = "Select dbo.Fx_desencriptar(senha) As senha2, "
        sql += "A.id_usuario, A.apelido, A.nome, A.cpf, A.rg, "
        sql += "A.email, A.telefone, A.whatsapp, A.cep, A.endereco, "
        sql += "A.complemento, A.cidade, A.bairro, A.uf, A.login, A.id_status, "
        sql += "A.palavra_chave, A.id_pergunta, B.id_empresa, C.sigla_empresa, B.id_perfil "
        sql += "From cg_usuario A "
        sql += "INNER Join cg_empresa_vs_usuarios B "
        sql += "On B.id_usuario = A.id_usuario "
        sql += "INNER Join cg_empresa C "
        sql += "On C.id_empresa = B.id_empresa "
        sql += "WHERE  A.id_usuario = " & Publico.Id_usuario
        sql += "   And C.sigla_empresa = '" & Trim(cboEmpresa.Text) & "'"

        Dim bll As New BLL.GlobalBLL
        Dim dt1 = bll.SqlExecDT(sql)
        If dt1.Rows.Count > 0 Then
            Publico.Id_empresa = CInt(dt1.Rows(0)("id_empresa"))
            Publico.Nome_empresa = dt1.Rows(0)("sigla_empresa").ToString
            Publico.Id_Perfil = dt1.Rows(0)("id_perfil")
        Else
            MessageBox.Show("Sem acesso permitido na empresa selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        dt1 = Nothing
    End Sub
End Class