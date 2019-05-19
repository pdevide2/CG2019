USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_ocorrencia]    Script Date: 12/08/2017 12:24:36 ******/
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
	@OS_VINCULADA as varchar(50) = NULL


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
	OS_VINCULADA)
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
	@OS_VINCULADA)

    IF ISNULL(@OS_VINCULADA,'') <> ''
    BEGIN

	   SELECT IDENTITY(INT, 1,1) AS ID_ROW, VALUE 
	   INTO #TMP_SPLIT
	   from dbo.SplitString(@OS_VINCULADA,'|')

	   DECLARE @P1 INT, @P2 INT, @P3 INT
	   SELECT @P1 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 1
	   SELECT @P2 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 2
	   SELECT @P3 = CAST(VALUE AS INT) FROM #TMP_SPLIT WHERE ID_ROW = 3
	   

	   UPDATE CG_OS_ITEM
	   SET ID_OCORRENCIA = @id_ocorrencia
	   WHERE ID_OS = @P1 AND ITEM_ID = @P2 AND ID_EQUIPAMENTO = @P3


    END

END

------------------------------------------------------------


 


