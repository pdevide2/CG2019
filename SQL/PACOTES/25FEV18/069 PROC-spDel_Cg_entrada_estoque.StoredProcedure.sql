USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_entrada_estoque]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spDel_Cg_entrada_estoque]	@ID_ROMANEIO As intASBEGINDELETE FROM CG_ENTRADA_ESTOQUE WHERE	ID_ROMANEIO = @ID_ROMANEIOEND------------------------------------------------------------
GO
