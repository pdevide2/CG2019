USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_sequencial]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDel_Cg_sequencial]

	@TABELA As varchar(40)

AS

BEGIN
DELETE FROM CG_SEQUENCIAL WHERE
	TABELA = @TABELA

END
------------------------------------------------------------




GO
