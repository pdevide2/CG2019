USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Romaneio_estoque]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Romaneio_estoque]

	@ROMANEIO As int,
	@MODULO As varchar(50) = NULL,
	@TIPO_PRODUTO As char(1),
	@TIPO_OP As char(1) = NULL,
	@DATAMOV As datetime,
	@ID_USUARIO As int,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE ROMANEIO_ESTOQUE SET
	modulo = @modulo,
	tipo_produto = @tipo_produto,
	tipo_op = @tipo_op,
	datamov = @datamov,
	id_usuario = @id_usuario,
	id_empresa = @id_empresa
WHERE
	ROMANEIO = @ROMANEIO

END
------------------------------------------------------------




GO
