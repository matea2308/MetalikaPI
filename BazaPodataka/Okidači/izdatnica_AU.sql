USE [18017_DB]
GO

/****** Object:  Trigger [dbo].[Izdatnica_AU]    Script Date: 3.7.2018. 18:06:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Izdatnica_AU]
       ON [dbo].[stavke_izdatnice]
AFTER UPDATE
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE 
		@ID_izdatnica INT,
		@ID_materijal INT,
		@ID_izdatnica_old INT,
		@ID_materijal_old INT,
		@kolicina INT,
		@postoji VARCHAR(1)
 
       SELECT	@ID_izdatnica   = INSERTED.ID_izdatnica
	   ,		@ID_materijal	= INSERTED.ID_materijal
	   ,		@kolicina		= INSERTED.kolicina
       FROM		INSERTED;

	   SELECT	@ID_izdatnica_old	= DELETED.ID_izdatnica
	   ,		@ID_materijal_old	= DELETED.ID_materijal
	   FROM		DELETED;

	   SELECT @postoji = 'Y'
	   FROM   stanje_skladista
	   WHERE  ID_izdatnica = @ID_izdatnica
	   AND    ID_materijal = @ID_materijal;

	   IF (@postoji = 'Y')
	   BEGIN
		UPDATE		stanje_skladista
		SET			kolicina     = @kolicina
		WHERE		ID_materijal = @ID_materijal
		AND			ID_izdatnica = @ID_izdatnica;
	   END

	   ELSE
	   BEGIN
	    DELETE FROM stanje_skladista
		WHERE		ID_materijal = @ID_materijal_old
		AND			ID_izdatnica = @ID_izdatnica_old;

		INSERT INTO stanje_skladista(ID_materijal, ID_izdatnica, kolicina)
		VALUES (@ID_materijal, @ID_izdatnica, @kolicina);
	   END

       
END
GO

ALTER TABLE [dbo].[stavke_izdatnice] ENABLE TRIGGER [Izdatnica_AU]
GO

