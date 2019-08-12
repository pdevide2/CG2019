CREATE PROCEDURE spDadosLoginCG
(@LOGIN VARCHAR(20),
 @SIGLA VARCHAR(20)
)
AS
BEGIN
	SELECT dbo.Fx_desencriptar(senha) AS senha2, 
		   A.id_usuario, 
		   A.apelido, 
		   A.nome, 
		   A.cpf, 
		   A.rg, 
		   A.email, 
		   A.telefone, 
		   A.whatsapp, 
		   A.cep, 
		   A.endereco, 
		   A.complemento, 
		   A.cidade, 
		   A.bairro, 
		   A.uf, 
		   A.login, 
		   A.id_status, 
		   A.palavra_chave, 
		   A.id_pergunta, 
		   B.id_empresa, 
		   C.sigla_empresa, 
		   B.id_perfil 
	FROM   cg_usuario A 
		   INNER JOIN cg_empresa_vs_usuarios B 
				   ON B.id_usuario = A.id_usuario 
		   INNER JOIN cg_empresa C 
				   ON C.id_empresa = B.id_empresa 
	WHERE  A.login = @LOGIN 
		   AND C.sigla_empresa = @SIGLA 
END
