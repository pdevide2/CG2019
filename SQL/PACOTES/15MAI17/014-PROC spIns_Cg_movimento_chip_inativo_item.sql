USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_movimento_chip_item]    Script Date: 20/05/2017 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_movimento_chip_inativo_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL

AS

BEGIN
INSERT INTO CG_MOVIMENTO_CHIP_INATIVO_ITEM (
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_chip,
	@simid,
	@qtd,
	@valor)

END

------------------------------------------------------------



