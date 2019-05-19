USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spIns_Cg_perfil]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spIns_Cg_perfil]

	@ID_PERFIL As int,
	@DESC_PERFIL As varchar(50)

AS

BEGIN
INSERT INTO CG_PERFIL (
	id_perfil,
	desc_perfil)
VALUES (
	@id_perfil,
	@desc_perfil)

END

------------------------------------------------------------




GO
