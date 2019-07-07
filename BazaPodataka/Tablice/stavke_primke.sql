GO

/****** Object:  Table [dbo].[stavke_primke]    Script Date: 3.7.2018. 18:03:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[stavke_primke](
	[ID_stavka_primke] [int] IDENTITY(1,1) NOT NULL,
	[ID_primka] [int] NOT NULL,
	[ID_materijal] [int] NOT NULL,
	[kolicina] [int] NOT NULL,
	[cijena] [float] NOT NULL,
 CONSTRAINT [PK_stavke_primke] PRIMARY KEY CLUSTERED 
(
	[ID_stavka_primke] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [stavke_prim_unq] UNIQUE NONCLUSTERED 
(
	[ID_primka] ASC,
	[ID_materijal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[stavke_primke]  WITH CHECK ADD  CONSTRAINT [stavke_prim_primka_fk] FOREIGN KEY([ID_primka])
REFERENCES [dbo].[primka] ([ID_primka])
GO

ALTER TABLE [dbo].[stavke_primke] CHECK CONSTRAINT [stavke_prim_primka_fk]
GO

ALTER TABLE [dbo].[stavke_primke]  WITH CHECK ADD  CONSTRAINT [stavke_prim_materijal_fk] FOREIGN KEY([ID_materijal])
REFERENCES [dbo].[materijal] ([ID_materijal])
GO

ALTER TABLE [dbo].[stavke_primke] CHECK CONSTRAINT [stavke_prim_materijal_fk]
GO

