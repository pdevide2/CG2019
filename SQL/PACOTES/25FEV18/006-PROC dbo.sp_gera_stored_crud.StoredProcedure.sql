USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[sp_gera_stored_crud]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_gera_stored_crud]
@TABELA AS VARCHAR(50)
AS

EXEC sp_gera_stored_insert @TABELA

EXEC sp_gera_stored_delete @TABELA

EXEC sp_gera_stored_update @TABELA

GO
