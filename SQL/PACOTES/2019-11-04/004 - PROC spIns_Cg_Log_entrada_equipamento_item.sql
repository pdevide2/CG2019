USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_equipamento_item]    Script Date: 03/11/2019 09:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_Log_entrada_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_LOG_ENTRADA_EQUIPAMENTO_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor,
	id_empresa)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor,
	@id_empresa)

END

------------------------------------------------------------




