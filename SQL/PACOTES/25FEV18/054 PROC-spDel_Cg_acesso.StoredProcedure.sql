USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_acesso]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_acesso]	@ID_USUARIO As int,	@ID_MODULO As intASBEGINDELETE FROM CG_ACESSO WHERE	ID_USUARIO = @ID_USUARIO AND	ID_MODULO = @ID_MODULOEND------------------------------------------------------------
GO
