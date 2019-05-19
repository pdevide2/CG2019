USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_ocorrencia]    Script Date: 13/03/2018 23:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spUpd_Cg_ocorrencia]

	@ID_OCORRENCIA As int,
	@DATA_OCORRENCIA As datetime,
	@DESCRICAO As varchar(60),
	@ID_EQUIPAMENTO As int,
	@SERIE As varchar(30),
	@ID_LOJA As int,
	@HISTORICO As text,
	@USER_INS As int = NULL,
	@DATA_INS As datetime = NULL,
	@USER_UPD As int = NULL,
	@DATA_UPD As datetime = NULL,
	@OS_VINCULADA As varchar(50) = NULL
	--,@ID_EMPRESA As int

AS

BEGIN
UPDATE CG_OCORRENCIA SET
	data_ocorrencia = @data_ocorrencia,
	descricao = @descricao,
	id_equipamento = @id_equipamento,
	serie = @serie,
	id_loja = @id_loja,
	historico = @historico,
	user_ins = @user_ins,
	data_ins = @data_ins,
	user_upd = @user_upd,
	data_upd = @data_upd,
	os_vinculada = @os_vinculada
	--,id_empresa = @id_empresa
WHERE
	ID_OCORRENCIA = @ID_OCORRENCIA

END
------------------------------------------------------------




