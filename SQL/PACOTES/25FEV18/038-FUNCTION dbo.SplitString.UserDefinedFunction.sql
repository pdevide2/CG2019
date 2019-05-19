USE [dbCG]
GO
/****** Object:  UserDefinedFunction [dbo].[SplitString]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[SplitString]
(
    @List NVARCHAR(MAX),
    @Delim VARCHAR(255)
/*
Chamada: 
SELECT * from dbo.SplitString('1|22|10','|')
*/
)
RETURNS TABLE
AS
    RETURN ( SELECT [Value] FROM 
        ( 
        SELECT 
            [Value] = LTRIM(RTRIM(SUBSTRING(@List, [Number],
            CHARINDEX(@Delim, @List + @Delim, [Number]) - [Number])))
        FROM (SELECT Number = ROW_NUMBER() OVER (ORDER BY name)
            FROM sys.all_objects) AS x
            WHERE Number <= LEN(@List)
            AND SUBSTRING(@Delim + @List, [Number], LEN(@Delim)) = @Delim
        ) AS y
    );



GO
