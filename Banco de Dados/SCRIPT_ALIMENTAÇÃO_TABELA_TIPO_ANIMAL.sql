
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tipo_animal]

CREATE TABLE [dbo].[tipo_animal](
	[cd_tipo_arquivo] [int] NOT NULL,
	[dc_tipo_arquivo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tipo_animal] PRIMARY KEY CLUSTERED 
(
	[cd_tipo_arquivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tipo_animal] ([cd_tipo_arquivo], [dc_tipo_arquivo]) VALUES (1, N'Cachorro')
INSERT [dbo].[tipo_animal] ([cd_tipo_arquivo], [dc_tipo_arquivo]) VALUES (2, N'Gato')
INSERT [dbo].[tipo_animal] ([cd_tipo_arquivo], [dc_tipo_arquivo]) VALUES (3, N'Hamster')
INSERT [dbo].[tipo_animal] ([cd_tipo_arquivo], [dc_tipo_arquivo]) VALUES (4, N'Coelho')
