USE [dbCG]
GO
/****** Object:  StoredProcedure [dbo].[spDel_Cg_fornecedor]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDel_Cg_fornecedor]	@ID_FORNECEDOR As intASBEGINDELETE FROM CG_FORNECEDOR WHERE	ID_FORNECEDOR = @ID_FORNECEDOREND------------------------------------------------------------
GO
