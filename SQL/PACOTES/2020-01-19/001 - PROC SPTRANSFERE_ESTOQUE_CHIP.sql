USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spTransfere_Estoque_POS]    Script Date: 05/01/2020 10:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTransfere_Estoque_Chip]
(
@ID_CHIP INT,
@QUANTIDADE INT,
@TRANSITO BIT,
@ID_LOCAL_PARA INT,
@TIPO_LOCAL CHAR(1),
@ID_EMPRESA INT
)
AS
UPDATE CG_ESTOQUE_CHIP SET
		estoque = @QUANTIDADE,
		transito = @transito,
		id_local = @ID_LOCAL_PARA,
		datamov = getdate(),
		TIPO_LOCAL=@TIPO_LOCAL
WHERE
		ID_CHIP = @ID_CHIP
