USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_categoria]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_categoria]	@ID_CATEGORIA As intASBEGINDELETE FROM CG_CATEGORIA WHERE	ID_CATEGORIA = @ID_CATEGORIAEND------------------------------------------------------------
GO
