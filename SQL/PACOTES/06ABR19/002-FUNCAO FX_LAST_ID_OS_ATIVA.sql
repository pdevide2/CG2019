
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================================
-- Author:		PAULO DEVIDE
-- Create date: 04-ABR-19
-- Description:	TRAZ A ULTIMA OS NÃO BAIXADA PARA O EQUIPAMENTO 
-- =============================================================
CREATE FUNCTION DBO.FX_LAST_ID_OS_ATIVA 
(
@ID_EQUIPAMENTO INT
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE 
			@ResultVar int

	SELECT @ResultVar = ID_OS 
	FROM CG_OS_ITEM 
	WHERE isnull(DATA_RETORNO,'')='' 
	and ID_EQUIPAMENTO = @ID_EQUIPAMENTO
	GROUP BY ID_EQUIPAMENTO,ID_OS
	ORDER BY ID_OS DESC


	-- Return the result of the function
	RETURN @ResultVar

END
GO

