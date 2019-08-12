ALTER TABLE CG_ESTOQUE_CHIP 
ADD TIPO_LOCAL CHAR(1) NOT NULL CONSTRAINT DF_CG_ESTOQUE_CHIP_TIPO_LOCAL DEFAULT('L') 
GO

/*
EXEC spSelecionaChipMovimento 1,''


USE [dbCG]
GO

/* GERAR TRANSITO */
INSERT INTO [dbo].[CG_MOV_TRANSITO_CHIP]
           ([ID_TRANSITO]
		 ,[ID_ORIGEM]
           ,[ID_CHIP]
           ,[QUANTIDADE]
           ,[USER_INS]
           ,[DATA_LANCTO]
           ,[ID_DESTINO]
           ,[DATA_MOV_DESTINO])
     VALUES (	  4,
			  1,
			  13,
			  1,
			  1,
			  GETDATE(),
			  NULL,
			  NULL
	)


/* DESCARREGAR TRANSITO */
INSERT INTO [dbo].[CG_MOV_TRANSITO_CHIP]
           ([ID_TRANSITO]
		 ,[ID_ORIGEM]
           ,[ID_CHIP]
           ,[QUANTIDADE]
           ,[USER_INS]
           ,[DATA_LANCTO]
           ,[ID_DESTINO]
           ,[DATA_MOV_DESTINO])
     VALUES (	  4,
			  1,
			  13,
			  1,
			  1,
			  GETDATE(),
			  1,
			  GETDATE()
	)


SELECT * FROM CG_ESTOQUE_CHIP ORDER BY DATAMOV DESC
*/
