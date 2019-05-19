USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_peca]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_peca]

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
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_PECA (
	id_peca,
	nome_peca,
	descricao,
	id_marca,
	id_categoria,
	id_fornecedor,
	id_finalidade,
	estoque,
	estoque_min,
	estoque_max,
	unidade,
	data_aquisicao,
	dias_garantia,
	custo,
	foto,
	ref_fornec,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	filetype,
	id_empresa)
VALUES (
	@id_peca,
	@nome_peca,
	@descricao,
	@id_marca,
	@id_categoria,
	@id_fornecedor,
	@id_finalidade,
	@estoque,
	@estoque_min,
	@estoque_max,
	@unidade,
	@data_aquisicao,
	@dias_garantia,
	@custo,
	@foto,
	@ref_fornec,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@filetype,
	@id_empresa)

END

------------------------------------------------------------




GO
