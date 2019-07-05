USE [18017_DB]
GO

/****** Object:  Table [dbo].[tip_korisnika]    Script Date: 3.7.2018. 18:04:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tip_korisnika](
	[ID_tip_korisnika] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
	[opis] [varchar](200) NULL,
	[omogucen] [varchar](1) NOT NULL,
 CONSTRAINT [PK_tip_korisnika] PRIMARY KEY CLUSTERED 
(
	[ID_tip_korisnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [tip_kor_unq] UNIQUE NONCLUSTERED 
(
	[naziv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tip_korisnika] ADD  CONSTRAINT [DF_tip_korisnika_omogucen]  DEFAULT ('D') FOR [omogucen]
GO

