USE dbCG
GO
/****** Object:  UserDefinedFunction [dbo].[fx_Encriptar]    Script Date: 07/08/2016 09:42:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fx_Encriptar](@chave VARCHAR(50))
RETURNS VarBinary(8000)
AS
BEGIN
    DECLARE @pass AS VarBinary(8000)
    ------------------------------------
    ------------------------------------
    SET @pass = ENCRYPTBYPASSPHRASE('Encript0110',@chave)-- Encript0110 e a chave para encriptar o campo.
    ------------------------------------
    ------------------------------------
    RETURN @pass
END

