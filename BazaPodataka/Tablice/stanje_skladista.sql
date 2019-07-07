GO

/****** Object:  Table [dbo].[stanje_skladista]    Script Date: 3.7.2018. 18:02:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[stanje_skladista](
	[ID_stanje_skladista] [int] IDENTITY(1,1) NOT NULL,
	[ID_materijal] [int] NOT NULL,
	[ID_primka] [int] NULL,
	[ID_izdatnica] [int] NULL,
	[kolicina] [int] NOT NULL,
 CONSTRAINT [PK_stanje_skladista] PRIMARY KEY CLUSTERED 
(
	[ID_stanje_skladista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[stanje_skladista]  WITH CHECK ADD  CONSTRAINT [stanje_izdatnica_fk] FOREIGN KEY([ID_izdatnica])
REFERENCES [dbo].[izdatnica] ([ID_izdatnica])
GO

ALTER TABLE [dbo].[stanje_skladista] CHECK CONSTRAINT [stanje_izdatnica_fk]
GO

ALTER TABLE [dbo].[stanje_skladista]  WITH CHECK ADD  CONSTRAINT [stanje_materijal_fk] FOREIGN KEY([ID_materijal])
REFERENCES [dbo].[materijal] ([ID_materijal])
GO

ALTER TABLE [dbo].[stanje_skladista] CHECK CONSTRAINT [stanje_materijal_fk]
GO

ALTER TABLE [dbo].[stanje_skladista]  WITH CHECK ADD  CONSTRAINT [stanje_primka_fk] FOREIGN KEY([ID_primka])
REFERENCES [dbo].[primka] ([ID_primka])
GO

ALTER TABLE [dbo].[stanje_skladista] CHECK CONSTRAINT [stanje_primka_fk]
GO

