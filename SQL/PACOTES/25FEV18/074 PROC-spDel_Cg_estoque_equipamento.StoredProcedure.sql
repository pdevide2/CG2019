USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_estoque_equipamento]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_estoque_equipamento]	@ID_EQUIPAMENTO As intASBEGINDELETE FROM CG_ESTOQUE_EQUIPAMENTO WHERE	ID_EQUIPAMENTO = @ID_EQUIPAMENTOEND------------------------------------------------------------
GO
