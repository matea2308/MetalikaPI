USE [18017_DB]
GO

/****** Object:  Trigger [dbo].[Primka_AI]    Script Date: 3.7.2018. 18:07:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Primka_AI]
       ON [dbo].[stavke_primke]
AFTER INSERT
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE 
		@ID_primka INT,
		@ID_materijal INT,
		@kolicina INT
 
       SELECT	@ID_primka		= INSERTED.ID_primka
	   ,		@ID_materijal	= INSERTED.ID_materijal
	   ,		@kolicina		= INSERTED.kolicina
       FROM		INSERTED;
 
       INSERT INTO stanje_skladista(ID_materijal, ID_primka, kolicina)
       VALUES (@ID_materijal, @ID_primka, @kolicina);
END
GO

ALTER TABLE [dbo].[stavke_primke] ENABLE TRIGGER [Primka_AI]
GO

