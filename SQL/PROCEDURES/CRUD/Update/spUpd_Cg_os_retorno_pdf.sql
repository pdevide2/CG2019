
CREATE PROCEDURE spUpd_Cg_os_retorno_pdf
      
	@ID_OS As int,
	@ITEM_ID As int,
	@ID_EQUIPAMENTO As int,
	@LAUDO_FORNEC AS IMAGE = NULL

AS

BEGIN
UPDATE CG_OS_ITEM SET

    LAUDO_FORNEC = @LAUDO_FORNEC

WHERE

	ID_OS = @ID_OS AND
	ITEM_ID = @ITEM_ID AND
	ID_EQUIPAMENTO = @ID_EQUIPAMENTO

END




