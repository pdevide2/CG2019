USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_transito]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpd_Cg_transito]	@ID_TRANSITO As int,	@NOME_TRANSITO As varchar(40),	@INATIVO As bit,	@ID_EMPRESA As intASBEGINUPDATE CG_TRANSITO SET	nome_transito = @nome_transito,	inativo = @inativo,	id_empresa = @id_empresaWHERE	ID_TRANSITO = @ID_TRANSITOEND------------------------------------------------------------
GO
