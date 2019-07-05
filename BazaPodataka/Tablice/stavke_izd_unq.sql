USE [18017_DB]
GO

/****** Object:  Index [stavke_izd_unq]    Script Date: 3.7.2018. 18:10:16 ******/
ALTER TABLE [dbo].[stavke_izdatnice] ADD  CONSTRAINT [stavke_izd_unq] UNIQUE NONCLUSTERED 
(
	[ID_izdatnica] ASC,
	[ID_materijal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
