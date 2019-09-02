USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spGrava_PedidoVenda_Itens]    Script Date: 01/09/2019 18:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spGrava_PedidoVenda_Itens]
(
@ID_PEDIDO INT,
@ID_EQUIPAMENTO INT,
@QTDE INT,
@PRECO_VENDA NUMERIC(14,2),
@STATUS_ITEM INT,
@DATA_BAIXA DATETIME = NULL,
@CANCEL BIT = 0
)
AS

/*
STATUS DO ITEM DO PEDIDO
===========================
1 - EM ANALISE 
2 - APROVADO
3 - REPROVADO
4 - RECEBIDO NO CLIENTE
5 - DEVOLVIDO PELO CLIENTE
*/

IF @STATUS_ITEM = 1 /* INSERT/UPDATE/DELETE NA TELA DE CADASTRO DO PEDIDO */
BEGIN
	/*OPERAÇÃO DE INSERT - REGISTRO NÃO EXISTE NA TABELA */
	IF NOT EXISTS(SELECT 1 
				FROM CG_PEDIDOVENDA_ITENS WHERE ID_PEDIDO = @ID_PEDIDO AND ID_EQUIPAMENTO = @ID_EQUIPAMENTO)
	BEGIN
		IF @CANCEL = 0
		BEGIN
			INSERT INTO CG_PEDIDOVENDA_ITENS
				(ID_PEDIDO,
				ID_EQUIPAMENTO,
				QTDE,
				PRECO_VENDA,
				STATUS_ITEM,
				DATA_BAIXA,
				ULTIMA_ALTERACAO,
				CANCEL)
			VALUES 
				(@ID_PEDIDO,
				 @ID_EQUIPAMENTO,
				 @QTDE,
				 @PRECO_VENDA,
				 @STATUS_ITEM,
				 NULL,
				 GETDATE(),
				 @CANCEL)

			UPDATE CG_PEDIDOVENDA SET TOT_QTDE_ORIGINAL = ISNULL(TOT_QTDE_ORIGINAL,0) + 1, TOT_QTDE_ENTREGAR = ISNULL(TOT_QTDE_ENTREGAR,0) + 1
			WHERE ID_PEDIDO = @ID_PEDIDO

		END
	END
	/*OPERAÇÃO DE UPDATE OU DELETE - REGISTRO EXISTE NA TABELA */
	ELSE
	BEGIN
		IF @CANCEL = 0
		BEGIN
			UPDATE CG_PEDIDOVENDA_ITENS SET
				QTDE=@QTDE,
				PRECO_VENDA=@PRECO_VENDA,
				STATUS_ITEM=1,
				DATA_BAIXA=NULL,
				ULTIMA_ALTERACAO=GETDATE(),
				CANCEL=0
			WHERE ID_PEDIDO = @ID_PEDIDO 
					AND ID_EQUIPAMENTO = @ID_EQUIPAMENTO
		END
		ELSE
		BEGIN
			DELETE FROM CG_PEDIDOVENDA_ITENS
			WHERE ID_PEDIDO = @ID_PEDIDO 
					AND ID_EQUIPAMENTO = @ID_EQUIPAMENTO


		END


	END

END
/*
ELSE
/* @STATUS_ITEM = 2 - BAIXA DO PEDIDO */
BEGIN
		IF @CANCEL = 0
		BEGIN

			UPDATE CG_PEDIDOVENDA_ITENS SET
				QTDE=@QTDE,
				PRECO_VENDA=@PRECO_VENDA,
				STATUS_ITEM=2,
				DATA_BAIXA=GETDATE(),
				ULTIMA_ALTERACAO=GETDATE(),
				CANCEL=0
			WHERE ID_PEDIDO = @ID_PEDIDO 
					AND ID_EQUIPAMENTO = @ID_EQUIPAMENTO
		END
		ELSE
		BEGIN
			DELETE FROM CG_PEDIDOVENDA_ITENS
			WHERE ID_PEDIDO = @ID_PEDIDO 
					AND ID_EQUIPAMENTO = @ID_EQUIPAMENTO
		END

END
*/
