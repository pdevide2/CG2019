USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_tipo_servico]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_tipo_servico]

	@ID_TIPO_SERVICO As int

AS

BEGIN
DELETE FROM CG_TIPO_SERVICO WHERE
	ID_TIPO_SERVICO = @ID_TIPO_SERVICO

END
------------------------------------------------------------



GO
