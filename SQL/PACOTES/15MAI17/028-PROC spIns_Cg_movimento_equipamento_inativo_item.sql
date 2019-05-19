USE [dbCG]
GO

/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_equipamento_item]    Script Date: 20/05/2017 14:21:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spIns_Cg_movimento_equipamento_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_MOVIMENTO_EQUIPAMENTO_INATIVO_ITEM (
	id_romaneio,
	unique_keyid,
	id_equipamento,
	serie,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_equipamento,
	@serie,
	@qtd,
	@valor)

END

------------------------------------------------------------




GO


