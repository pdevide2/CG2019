USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_ocorrencia]    Script Date: 13/03/2018 23:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_ocorrencia]

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
INSERT INTO CG_OCORRENCIA (
	id_ocorrencia,
	data_ocorrencia,
	descricao,
	id_equipamento,
	serie,
	id_loja,
	historico,
	user_ins,
	data_ins,
	user_upd,
	data_upd,
	os_vinculada)
	--id_empresa)
VALUES (
	@id_ocorrencia,
	@data_ocorrencia,
	@descricao,
	@id_equipamento,
	@serie,
	@id_loja,
	@historico,
	@user_ins,
	@data_ins,
	@user_upd,
	@data_upd,
	@os_vinculada)
	--,@id_empresa)

END

------------------------------------------------------------




