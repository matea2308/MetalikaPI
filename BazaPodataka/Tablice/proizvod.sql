GO

/****** Object:  Table [dbo].[proizvod]    Script Date: 3.7.2018. 18:01:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[proizvod](
	[ID_proizvod] [int] IDENTITY(1,1) NOT NULL,
	[naziv_proizvoda] [varchar](100) NOT NULL,
	[cijena] [float] NOT NULL,
	[napomena] [varchar](200) NULL,
	[ID_projekt] [int] NOT NULL,
 CONSTRAINT [PK_proizvod] PRIMARY KEY CLUSTERED 
(
	[ID_proizvod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[proizvod]  WITH CHECK ADD  CONSTRAINT [proizvod_projekt_fk] FOREIGN KEY([ID_projekt])
REFERENCES [dbo].[projekt] ([ID_projekt])
GO

ALTER TABLE [dbo].[proizvod] CHECK CONSTRAINT [proizvod_projekt_fk]
GO

