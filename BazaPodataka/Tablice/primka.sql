USE [18017_DB]
GO

/****** Object:  Table [dbo].[primka]    Script Date: 3.7.2018. 18:01:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[primka](
	[ID_primka] [int] IDENTITY(1,1) NOT NULL,
	[datum_primke] [date] NOT NULL,
	[napomena] [varchar](200) NULL,
	[ID_dobavljac] [int] NOT NULL,
	[ID_zaposlenik] [int] NOT NULL,
 CONSTRAINT [PK_primka] PRIMARY KEY CLUSTERED 
(
	[ID_primka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[primka]  WITH CHECK ADD  CONSTRAINT [primka_korisnik_fk] FOREIGN KEY([ID_zaposlenik])
REFERENCES [dbo].[korisnik] ([ID_korisnik])
GO

ALTER TABLE [dbo].[primka] CHECK CONSTRAINT [primka_korisnik_fk]
GO

ALTER TABLE [dbo].[primka]  WITH CHECK ADD  CONSTRAINT [primka_partner_fk] FOREIGN KEY([ID_dobavljac])
REFERENCES [dbo].[poslovni_partner] ([ID_partner])
GO

ALTER TABLE [dbo].[primka] CHECK CONSTRAINT [primka_partner_fk]
GO

