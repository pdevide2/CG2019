USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_equipamento]    Script Date: 29/04/2017 11:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_equipamento]

	@ID_EQUIPAMENTO As int,
	@ID_TIPO_EQUIPAMENTO As int,
	@DESC_EQUIPAMENTO As varchar(50),
	@SERIE As varchar(30) = NULL,
	@MODELO As varchar(30) = NULL,
	@ID_FORNECEDOR As int,
	@PROTOCOLO As varchar(30) = NULL,
	@VALOR As numeric(12,2) = NULL,
	@OBS As varchar(250) = NULL,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

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
	ID_LOCAL_ESTOQUE)
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
	0)

END

------------------------------------------------------------



