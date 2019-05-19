SELECT
       OBJ.Name AS TABLES, IDX.Rows AS ROWS_COUNT
FROM
       sys.sysobjects AS OBJ
INNER JOIN
       sys.sysindexes AS IDX
ON
       OBJ.id = IDX.id
WHERE
       type = 'U'
AND
       IDX.IndId < 2
ORDER BY
       1 ASC
GO