USE [dbCG]
GO
/****** Object:  Trigger [dbo].[TGR_MOVIMENTO_EQUIPAMENTO_ITEM]    Script Date: 05/11/2016 09:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TGR_CG_SEQUENCIAL] ON [dbo].[CG_SEQUENCIAL] 
FOR UPDATE
AS
BEGIN

    DECLARE @TABELA VARCHAR(40), @KEYID INT

    SELECT @TABELA = i.TABELA, @KEYID = i.KEYID
    FROM inserted i

    /* 
    * A verificação abaixo é para não permitir que no cadastro de lojas, seja utilizado códigos de 0 a 9
    * que são utilizados para movimentações do estoque
    */
    IF @TABELA='CG_LOJA' AND @KEYID < 10
    BEGIN
	   RAISERROR('Não é permitido utilizar sequencial de 0 a 9 para a tabela de LOJAS, pois estes códigos são reservados para o sistema.',16,1)
    END

END


