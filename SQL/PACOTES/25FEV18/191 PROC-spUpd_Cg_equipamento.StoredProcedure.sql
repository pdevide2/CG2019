USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_equipamento]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_equipamento]

	@ID_EQUIPAMENTO As int,
	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30),
	@MODELO As varchar(30) = NULL,
	@ID_FORNECEDOR As int,
	@PROTOCOLO As varchar(30) = NULL,
	@VALOR As numeric(12,2) = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@NF_ENTRADA As varchar(15) = NULL,
	@DATA_NF As datetime = NULL,
	@PRAZO_GARANTIA As int = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_EQUIPAMENTO SET
	id_tipo_equipamento = @id_tipo_equipamento,
	desc_equipamento = @desc_equipamento,
	serie = @serie,
	modelo = @modelo,
	id_fornecedor = @id_fornecedor,
	protocolo = @protocolo,
	valor = @valor,
	obs = @obs,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	nf_entrada = @nf_entrada,
	data_nf = @data_nf,
	prazo_garantia = @prazo_garantia,
	id_empresa = @id_empresa
WHERE
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END
------------------------------------------------------------




GO
