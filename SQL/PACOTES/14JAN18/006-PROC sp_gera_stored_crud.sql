CREATE PROCEDURE sp_gera_stored_crud --'CG_EMPRESA'
@TABELA AS VARCHAR(50)
AS

EXEC sp_gera_stored_insert @TABELA

EXEC sp_gera_stored_delete @TABELA

EXEC sp_gera_stored_update @TABELA
GO
