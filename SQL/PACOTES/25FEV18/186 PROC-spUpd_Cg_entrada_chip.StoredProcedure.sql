USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_entrada_chip]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spUpd_Cg_entrada_chip]

	@ID_ROMANEIO As int,
	@DATA_MOVTO As datetime,
	@ID_LOJA As int,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@ROMANEIO_ESTOQUE As int = NULL,
	@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_ENTRADA_CHIP SET
	data_movto = @data_movto,
	id_loja = @id_loja,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	romaneio_estoque = @romaneio_estoque,
	id_empresa = @id_empresa
WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
