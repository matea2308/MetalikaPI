GO

/****** Object:  Table [dbo].[stavke_naloga]    Script Date: 3.7.2018. 18:03:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[stavke_naloga](
	[ID_stavka_naloga] [int] IDENTITY(1,1) NOT NULL,
	[ID_nalog] [int] NOT NULL,
	[ID_materijal] [int] NOT NULL,
	[kolicina] [int] NOT NULL,
 CONSTRAINT [PK_stavke_naloga] PRIMARY KEY CLUSTERED 
(
	[ID_stavka_naloga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [stavke_nal_unq] UNIQUE NONCLUSTERED 
(
	[ID_nalog] ASC,
	[ID_materijal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[stavke_naloga]  WITH CHECK ADD  CONSTRAINT [stavke_nal_materijal_fk] FOREIGN KEY([ID_materijal])
REFERENCES [dbo].[materijal] ([ID_materijal])
GO

ALTER TABLE [dbo].[stavke_naloga] CHECK CONSTRAINT [stavke_nal_materijal_fk]
GO

ALTER TABLE [dbo].[stavke_naloga]  WITH CHECK ADD  CONSTRAINT [stavke_nalog_fk] FOREIGN KEY([ID_nalog])
REFERENCES [dbo].[radni_nalog] ([ID_nalog])
GO

ALTER TABLE [dbo].[stavke_naloga] CHECK CONSTRAINT [stavke_nalog_fk]
GO

