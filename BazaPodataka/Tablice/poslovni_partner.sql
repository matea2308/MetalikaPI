GO

/****** Object:  Table [dbo].[poslovni_partner]    Script Date: 3.7.2018. 18:01:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[poslovni_partner](
	[ID_partner] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](100) NOT NULL,
	[adresa] [varchar](100) NOT NULL,
	[telefon] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_poslovni_partner] PRIMARY KEY CLUSTERED 
(
	[ID_partner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

