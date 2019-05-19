USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento]    Script Date: 26/11/2018 08:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_equipamento]

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
	@ID_EMPRESA As int,
	@PRECO_VENDA As numeric(12,2) = NULL
	
AS

BEGIN
INSERT INTO CG_EQUIPAMENTO (
	id_equipamento,
	id_tipo_equipamento,
	desc_equipamento,
	serie,
	modelo,
	id_fornecedor,
	protocolo,
	valor,
	obs,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	nf_entrada,
	data_nf,
	prazo_garantia,
	id_empresa,
	PRECO_VENDA)
VALUES (
	@id_equipamento,
	@id_tipo_equipamento,
	@desc_equipamento,
	@serie,
	@modelo,
	@id_fornecedor,
	@protocolo,
	@valor,
	@obs,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@nf_entrada,
	@data_nf,
	@prazo_garantia,
	@id_empresa,
	@PRECO_VENDA)

END

------------------------------------------------------------




