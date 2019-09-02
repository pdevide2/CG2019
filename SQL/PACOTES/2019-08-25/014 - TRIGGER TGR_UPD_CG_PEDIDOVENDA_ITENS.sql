USE [dbCG]
GO
/****** Object:  Trigger [dbo].[TGR_DEL_CG_PEDIDOVENDA_ITENS]    Script Date: 01/09/2019 21:19:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[TGR_UPD_CG_PEDIDOVENDA_ITENS] 
   ON  [dbo].[CG_PEDIDOVENDA_ITENS] 
   FOR UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	
	IF UPDATE(DATA_BAIXA)
	BEGIN
		DECLARE @TOT_QTDE_ENTREGAR INT, @TOT_QTDE_ORIGINAL INT
		SELECT @TOT_QTDE_ENTREGAR = A.TOT_QTDE_ENTREGAR, @TOT_QTDE_ORIGINAL = A.TOT_QTDE_ORIGINAL
		FROM CG_PEDIDOVENDA A
		INNER JOIN DELETED D ON D.ID_PEDIDO = A.ID_PEDIDO

		UPDATE A
		SET A.TOT_QTDE_ENTREGAR = @TOT_QTDE_ENTREGAR - 1, 
		A.STATUS_PEDIDO= CASE WHEN (@TOT_QTDE_ENTREGAR - 1)=0 THEN 'FINALIZADO' ELSE 'PENDENTE' END
		FROM CG_PEDIDOVENDA A 
		INNER JOIN DELETED D ON D.ID_PEDIDO = A.ID_PEDIDO
	END

END
