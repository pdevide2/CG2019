USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_tabelas_pesquisa_dinamica]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_tabelas_pesquisa_dinamica]	@ID_TABELA As intASBEGINDELETE FROM CG_TABELAS_PESQUISA_DINAMICA WHERE	ID_TABELA = @ID_TABELAEND------------------------------------------------------------
GO
