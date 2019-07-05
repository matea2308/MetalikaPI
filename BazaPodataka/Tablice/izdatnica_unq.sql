USE [18017_DB]
GO

/****** Object:  Index [izdatnica_unq]    Script Date: 3.7.2018. 18:08:39 ******/
ALTER TABLE [dbo].[izdatnica] ADD  CONSTRAINT [izdatnica_unq] UNIQUE NONCLUSTERED 
(
	[datum_izdatnice] ASC,
	[napomena] ASC,
	[ID_zaposlenik] ASC,
	[ID_nalog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

