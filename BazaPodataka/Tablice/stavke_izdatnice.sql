USE [18017_DB]
GO

/****** Object:  Table [dbo].[stavke_izdatnice]    Script Date: 3.7.2018. 18:03:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[stavke_izdatnice](
	[ID_stavka_izdatnice] [int] IDENTITY(1,1) NOT NULL,
	[ID_izdatnica] [int] NOT NULL,
	[ID_materijal] [int] NOT NULL,
	[kolicina] [int] NOT NULL,
 CONSTRAINT [PK_stavke_izdatnice] PRIMARY KEY CLUSTERED 
(
	[ID_stavka_izdatnice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [stavke_izd_unq] UNIQUE NONCLUSTERED 
(
	[ID_izdatnica] ASC,
	[ID_materijal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[stavke_izdatnice]  WITH CHECK ADD  CONSTRAINT [stavke_izd_izdatnica_fk] FOREIGN KEY([ID_izdatnica])
REFERENCES [dbo].[izdatnica] ([ID_izdatnica])
GO

ALTER TABLE [dbo].[stavke_izdatnice] CHECK CONSTRAINT [stavke_izd_izdatnica_fk]
GO

ALTER TABLE [dbo].[stavke_izdatnice]  WITH CHECK ADD  CONSTRAINT [stavke_izd_materijal_fk] FOREIGN KEY([ID_materijal])
REFERENCES [dbo].[materijal] ([ID_materijal])
GO

ALTER TABLE [dbo].[stavke_izdatnice] CHECK CONSTRAINT [stavke_izd_materijal_fk]
GO

