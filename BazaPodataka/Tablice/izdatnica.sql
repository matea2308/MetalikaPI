GO

/****** Object:  Table [dbo].[izdatnica]    Script Date: 3.7.2018. 17:59:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[izdatnica](
	[ID_izdatnica] [int] IDENTITY(1,1) NOT NULL,
	[datum_izdatnice] [date] NOT NULL,
	[napomena] [varchar](200) NULL,
	[ID_zaposlenik] [int] NOT NULL,
	[ID_nalog] [int] NOT NULL,
 CONSTRAINT [PK_izdatnica] PRIMARY KEY CLUSTERED 
(
	[ID_izdatnica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [izdatnica_unq] UNIQUE NONCLUSTERED 
(
	[datum_izdatnice] ASC,
	[napomena] ASC,
	[ID_zaposlenik] ASC,
	[ID_nalog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[izdatnica]  WITH CHECK ADD  CONSTRAINT [izdatnica_korisnik_fk] FOREIGN KEY([ID_zaposlenik])
REFERENCES [dbo].[korisnik] ([ID_korisnik])
GO

ALTER TABLE [dbo].[izdatnica] CHECK CONSTRAINT [izdatnica_korisnik_fk]
GO

ALTER TABLE [dbo].[izdatnica]  WITH CHECK ADD  CONSTRAINT [izdatnica_nalog_fk] FOREIGN KEY([ID_nalog])
REFERENCES [dbo].[radni_nalog] ([ID_nalog])
GO

ALTER TABLE [dbo].[izdatnica] CHECK CONSTRAINT [izdatnica_nalog_fk]
GO

