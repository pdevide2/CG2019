USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Romaneio_estoque_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Romaneio_estoque_item]

	@ROMANEIO As int,
	@UNIQUE_KEY As uniqueidentifier,
	@ID_TRANSACAO As char(3),
	@TRANSITO As bit,
	@ID_LOCAL_DE As int,
	@ID_LOCAL_PARA As int,
	@DATAMOV As datetime,
	@ENTRADA_SAIDA As char(1),
	@QUANTIDADE As int,
	@OBSERVACAO As varchar(200) = NULL,
	@ID_PRODUTO As int,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE ROMANEIO_ESTOQUE_ITEM SET
	id_transacao = @id_transacao,
	transito = @transito,
	id_local_de = @id_local_de,
	id_local_para = @id_local_para,
	datamov = @datamov,
	entrada_saida = @entrada_saida,
	quantidade = @quantidade,
	observacao = @observacao,
	id_produto = @id_produto,
	id_empresa = @id_empresa
WHERE
	ROMANEIO = @ROMANEIO AND
	UNIQUE_KEY = @UNIQUE_KEY

END
------------------------------------------------------------




GO
