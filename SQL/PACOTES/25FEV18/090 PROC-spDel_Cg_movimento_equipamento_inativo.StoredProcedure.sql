USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_movimento_equipamento_inativo]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spDel_Cg_movimento_equipamento_inativo]

	@ID_ROMANEIO As int

AS

BEGIN
DELETE FROM CG_MOVIMENTO_EQUIPAMENTO_INATIVO WHERE
	ID_ROMANEIO = @ID_ROMANEIO

END
------------------------------------------------------------




GO
