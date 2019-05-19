USE dbCG
GO
/****** Object:  UserDefinedFunction [dbo].[FX_PROTOCOLO]    Script Date: 07/08/2016 09:52:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===============================================
-- Author:		PAULO DEVIDE
-- Create date: 07-08-2016
-- Description:	Gera um numero de protocolo unico
-- ===============================================
CREATE FUNCTION [dbo].[FX_PROTOCOLO] 
(
	@ID int
)
RETURNS CHAR(18)
AS
BEGIN

	DECLARE @ResultVar char(18)
	-- calcula os segundos desde a meia noite
	declare @data datetime, @Segundos varchar(6)
	set @data = getdate()
	select @segundos = LEFT(DATEPART(MILLISECOND,@data)+1000*(DATEPART(SECOND,@data)+60*(DATEPART(MINUTE,@data)+60*DATEPART(HOUR,@data))),6) 

	SELECT @ResultVar = CONVERT(VARCHAR,GETDATE(),112)+RIGHT('0000'+CONVERT(VARCHAR,@ID),4)+@segundos

	RETURN @ResultVar

END

