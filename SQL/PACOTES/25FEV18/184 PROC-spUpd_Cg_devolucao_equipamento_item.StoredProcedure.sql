USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_devolucao_equipamento_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpd_Cg_devolucao_equipamento_item]

	@ID_ROMANEIO As int,
	@UNIQUE_KEYID As uniqueidentifier,
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@QTD As int,
	@VALOR As numeric(12,2) = NULL,
	@ID_MOTIVO As int

AS

BEGIN
UPDATE CG_DEVOLUCAO_EQUIPAMENTO_ITEM SET
	id_equipamento = @id_equipamento,
	serie = @serie,
	qtd = @qtd,
	valor = @valor,
	id_motivo = @id_motivo
WHERE
	ID_ROMANEIO = @ID_ROMANEIO AND
	UNIQUE_KEYID = @UNIQUE_KEYID

END
------------------------------------------------------------





GO
