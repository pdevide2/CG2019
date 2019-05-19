USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_estoque_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_estoque_chip]

	@ID_CHIP As int,
	@ESTOQUE As int,
	@TRANSITO As bit,
	@ID_LOCAL As int,
	@DATAMOV As datetime,
	@TIPO_LOCAL As char(1),
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_ESTOQUE_CHIP SET
	estoque = @estoque,
	transito = @transito,
	id_local = @id_local,
	datamov = @datamov,
	tipo_local = @tipo_local,
	id_empresa = @id_empresa
WHERE
	ID_CHIP = @ID_CHIP

END
------------------------------------------------------------




GO
