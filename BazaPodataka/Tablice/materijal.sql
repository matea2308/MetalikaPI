USE [18017_DB]
GO

/****** Object:  Table [dbo].[materijal]    Script Date: 3.7.2018. 18:00:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[materijal](
	[ID_materijal] [int] IDENTITY(1,1) NOT NULL,
	[naziv_materijala] [varchar](50) NOT NULL,
	[dimenzije] [varchar](20) NOT NULL,
	[sastav] [varchar](100) NOT NULL,
	[dodatne_informacije] [varchar](200) NULL,
	[ID_jed_mjere] [varchar](10) NOT NULL,
 CONSTRAINT [PK_materijal] PRIMARY KEY CLUSTERED 
(
	[ID_materijal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[materijal]  WITH CHECK ADD  CONSTRAINT [jed_mjere_materijal_fk] FOREIGN KEY([ID_jed_mjere])
REFERENCES [dbo].[jedinica_mjere] ([ID_jed_mjere])
GO

ALTER TABLE [dbo].[materijal] CHECK CONSTRAINT [jed_mjere_materijal_fk]
GO

