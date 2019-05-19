USE dbCG
GO
/****** Object:  UserDefinedFunction [dbo].[fx_Desencriptar]    Script Date: 07/08/2016 09:50:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fx_Desencriptar](@chave VARBINARY(8000))
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @pass AS VARCHAR(25)
    ------------------------------------
     -- Desencripta o campo aplicando a mesma chave de Encriptação que é Encript0110
    SET @pass = DECRYPTBYPASSPHRASE('Encript0110',@chave)
    ------------------------------------
    ------------------------------------
    RETURN @pass
END
