GO

/****** Object:  Table [dbo].[radni_nalog]    Script Date: 3.7.2018. 18:02:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[radni_nalog](
	[ID_nalog] [int] IDENTITY(1,1) NOT NULL,
	[opis_postupka] [varchar](200) NOT NULL,
	[datum_pocetka] [date] NOT NULL,
	[datum_zavrsetka] [date] NOT NULL,
	[ID_zaposlenik] [int] NOT NULL,
	[ID_projekt] [int] NOT NULL,
 CONSTRAINT [PK_radni_nalog] PRIMARY KEY CLUSTERED 
(
	[ID_nalog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[radni_nalog]  WITH CHECK ADD  CONSTRAINT [nalog_projekt_fk] FOREIGN KEY([ID_projekt])
REFERENCES [dbo].[projekt] ([ID_projekt])
GO

ALTER TABLE [dbo].[radni_nalog] CHECK CONSTRAINT [nalog_projekt_fk]
GO

ALTER TABLE [dbo].[radni_nalog]  WITH CHECK ADD  CONSTRAINT [nalog_zaposlenik_fk] FOREIGN KEY([ID_zaposlenik])
REFERENCES [dbo].[korisnik] ([ID_korisnik])
GO

ALTER TABLE [dbo].[radni_nalog] CHECK CONSTRAINT [nalog_zaposlenik_fk]
GO

