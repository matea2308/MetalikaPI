USE [18017_DB]
GO

/****** Object:  Table [dbo].[korisnik]    Script Date: 3.7.2018. 18:00:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[korisnik](
	[ID_korisnik] [int] IDENTITY(1,1) NOT NULL,
	[korisnicko_ime] [varchar](100) NOT NULL,
	[zaporka] [varchar](100) NULL,
	[datum_registracije] [date] NOT NULL,
	[omogucen] [varchar](1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[datum_rodjenja] [date] NOT NULL,
	[adresa] [varchar](200) NOT NULL,
	[telefon] [varchar](40) NOT NULL,
	[ID_tip_korisnika] [int] NOT NULL,
 CONSTRAINT [PK_korisnik] PRIMARY KEY CLUSTERED 
(
	[ID_korisnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [korisnik_unq] UNIQUE NONCLUSTERED 
(
	[korisnicko_ime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[korisnik] ADD  CONSTRAINT [DF_korisnik_omogucen]  DEFAULT ('D') FOR [omogucen]
GO

ALTER TABLE [dbo].[korisnik]  WITH CHECK ADD  CONSTRAINT [korisnik_tip_korisnika_fk] FOREIGN KEY([ID_tip_korisnika])
REFERENCES [dbo].[tip_korisnika] ([ID_tip_korisnika])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[korisnik] CHECK CONSTRAINT [korisnik_tip_korisnika_fk]
GO

