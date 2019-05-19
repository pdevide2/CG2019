USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_entrada_chip_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Cg_entrada_chip_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_CHIP As int,
	@SIMID As varchar(20),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_EMPRESA As int

AS

BEGIN
INSERT INTO CG_ENTRADA_CHIP_ITEM (
	id_romaneio,
	unique_keyid,
	id_chip,
	simid,
	qtd,
	valor,
	id_empresa)
VALUES (
	@id_romaneio,
	@unique_keyid,
	@id_chip,
	@simid,
	@qtd,
	@valor,
	@id_empresa)

END

------------------------------------------------------------




GO
