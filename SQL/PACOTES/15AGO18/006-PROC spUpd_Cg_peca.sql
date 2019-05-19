USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_peca]    Script Date: 11/08/2018 19:36:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spUpd_Cg_peca]

	@ID_PECA As int,
	@NOME_PECA As varchar(50),
	@DESCRICAO As varchar(250),
	@ID_MARCA As int,
	@ID_CATEGORIA As int,
	@ID_FORNECEDOR As int,
	@ID_FINALIDADE As int,
	@ESTOQUE As int = NULL,
	@ESTOQUE_MIN As int = NULL,
	@ESTOQUE_MAX As int = NULL,
	@UNIDADE As varchar(10) = NULL,
	@DATA_AQUISICAO As datetime,
	@DIAS_GARANTIA As int,
	@CUSTO As numeric(10,2) = NULL,
	@FOTO As image = NULL,
	@REF_FORNEC As varchar(20) = NULL,
	@OBS As text = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@FILETYPE As varchar(5) = NULL,
	@ID_EMPRESA As int,
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL

AS

BEGIN
UPDATE CG_PECA SET
	nome_peca = @nome_peca,
	descricao = @descricao,
	id_marca = @id_marca,
	id_categoria = @id_categoria,
	id_fornecedor = @id_fornecedor,
	id_finalidade = @id_finalidade,
	estoque = @estoque,
	estoque_min = @estoque_min,
	estoque_max = @estoque_max,
	unidade = @unidade,
	data_aquisicao = @data_aquisicao,
	dias_garantia = @dias_garantia,
	custo = @custo,
	foto = @foto,
	ref_fornec = @ref_fornec,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	filetype = @filetype,
	id_empresa = @id_empresa,
	serie = @SERIE, 
	modelo = @MODELO
WHERE
	ID_PECA = @ID_PECA

END
------------------------------------------------------------




