USE [dbCG]
GO
/****** Object:  Table [dbo].[CG_PERFIL]    Script Date: 24/02/2018 09:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CG_PERFIL](
	[ID_PERFIL] [int] NOT NULL,
	[DESC_PERFIL] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CG_PERFIL] PRIMARY KEY CLUSTERED 
(
	[ID_PERFIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
