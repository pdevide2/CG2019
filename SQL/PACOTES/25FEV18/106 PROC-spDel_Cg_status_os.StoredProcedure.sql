USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_status_os]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_status_os]	@ID_STATUS As intASBEGINDELETE FROM CG_STATUS_OS WHERE	ID_STATUS = @ID_STATUSEND------------------------------------------------------------
GO
