USE [18017_DB]
GO

/****** Object:  Trigger [dbo].[Izdatnica_AI]    Script Date: 3.7.2018. 18:06:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Izdatnica_AI]
       ON [dbo].[stavke_izdatnice]
AFTER INSERT
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE 
		@ID_izdatnica INT,
		@ID_materijal INT,
		@kolicina INT
 
       SELECT	@ID_izdatnica   = INSERTED.ID_izdatnica
	   ,		@ID_materijal	= INSERTED.ID_materijal
	   ,		@kolicina		= INSERTED.kolicina
       FROM		INSERTED;
 
       INSERT INTO stanje_skladista(ID_materijal, ID_izdatnica, kolicina)
       VALUES (@ID_materijal, @ID_izdatnica, @kolicina);
END
GO

ALTER TABLE [dbo].[stavke_izdatnice] ENABLE TRIGGER [Izdatnica_AI]
GO

