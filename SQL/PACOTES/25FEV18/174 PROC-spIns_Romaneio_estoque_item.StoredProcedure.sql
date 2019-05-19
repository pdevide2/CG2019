USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Romaneio_estoque_item]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIns_Romaneio_estoque_item]

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
INSERT INTO ROMANEIO_ESTOQUE_ITEM (
	romaneio,
	unique_key,
	id_transacao,
	transito,
	id_local_de,
	id_local_para,
	datamov,
	entrada_saida,
	quantidade,
	observacao,
	id_produto,
	id_empresa)
VALUES (
	@romaneio,
	@unique_key,
	@id_transacao,
	@transito,
	@id_local_de,
	@id_local_para,
	@datamov,
	@entrada_saida,
	@quantidade,
	@observacao,
	@id_produto,
	@id_empresa)

END

------------------------------------------------------------




GO
