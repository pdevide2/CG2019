USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spUpd_Cg_perfil]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spUpd_Cg_perfil]	@ID_PERFIL As int,	@DESC_PERFIL As varchar(50)ASBEGINUPDATE CG_PERFIL SET	desc_perfil = @desc_perfilWHERE	ID_PERFIL = @ID_PERFILEND------------------------------------------------------------
GO
