CREATE PROCEDURE spGrava_Cg_follow_up

	@ID_OS As int,
	@PROTOCOLO As varchar(20),
	@DATA_HORA As datetime,
	@TEXTO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL

AS

BEGIN

    IF NOT EXISTS(SELECT 1 FROM CG_FOLLOW_UP WHERE ID_OS = @ID_OS AND PROTOCOLO = @PROTOCOLO)
    BEGIN
	   INSERT INTO CG_FOLLOW_UP (
		   id_os,
		   protocolo,
		   data_hora,
		   texto,
		   user_ins,
		   data_ins,
		   user_upd,
		   data_upd)
	   VALUES (
		   @id_os,
		   @protocolo,
		   @data_hora,
		   @texto,
		   @user_ins,
		   @data_ins,
		   @user_upd,
		   @data_upd)

	   END
    ELSE
    BEGIN
	   UPDATE CG_FOLLOW_UP SET
		   data_hora = @data_hora,
		   texto = @texto,
		   user_ins = @user_ins,
		   data_ins = @data_ins,
		   user_upd = @user_upd,
		   data_upd = @data_upd
	   WHERE
		   ID_OS = @ID_OS AND
		   PROTOCOLO = @PROTOCOLO
    END

END

GO


