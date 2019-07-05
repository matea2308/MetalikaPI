USE [18017_DB]
GO

/****** Object:  Table [dbo].[projekt]    Script Date: 3.7.2018. 18:02:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[projekt](
	[ID_projekt] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
	[opis] [varchar](400) NOT NULL,
	[odobren] [varchar](1) NOT NULL,
	[datum_odobrenja] [date] NULL,
	[ID_zaposlenik] [int] NOT NULL,
	[ID_klijent] [int] NOT NULL,
 CONSTRAINT [PK_projekt] PRIMARY KEY CLUSTERED 
(
	[ID_projekt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[projekt] ADD  CONSTRAINT [DF_projekt_odobren]  DEFAULT ('N') FOR [odobren]
GO

ALTER TABLE [dbo].[projekt]  WITH CHECK ADD  CONSTRAINT [projekt_partner_fk] FOREIGN KEY([ID_klijent])
REFERENCES [dbo].[poslovni_partner] ([ID_partner])
GO

ALTER TABLE [dbo].[projekt] CHECK CONSTRAINT [projekt_partner_fk]
GO

ALTER TABLE [dbo].[projekt]  WITH CHECK ADD  CONSTRAINT [projekt_zaposlenik_fk] FOREIGN KEY([ID_zaposlenik])
REFERENCES [dbo].[korisnik] ([ID_korisnik])
GO

ALTER TABLE [dbo].[projekt] CHECK CONSTRAINT [projekt_zaposlenik_fk]
GO

