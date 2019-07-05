USE [18017_DB]
GO

/****** Object:  Index [stavke_nal_unq]    Script Date: 3.7.2018. 18:10:33 ******/
ALTER TABLE [dbo].[stavke_naloga] ADD  CONSTRAINT [stavke_nal_unq] UNIQUE NONCLUSTERED 
(
	[ID_nalog] ASC,
	[ID_materijal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

