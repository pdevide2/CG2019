USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_ocorrencia]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_ocorrencia]

	@ID_OCORRENCIA As int

AS

BEGIN
DELETE FROM CG_OCORRENCIA WHERE
	ID_OCORRENCIA = @ID_OCORRENCIA

END
------------------------------------------------------------



GO
