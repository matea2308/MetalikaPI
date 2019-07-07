GO

/****** Object:  Trigger [dbo].[Primka_AU]    Script Date: 3.7.2018. 18:08:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Primka_AU]
       ON [dbo].[stavke_primke]
AFTER UPDATE
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE 
		@ID_primka INT,
		@ID_materijal INT,
		@ID_primka_old INT,
		@ID_materijal_old INT,
		@kolicina INT,
		@postoji VARCHAR(1)
 
       SELECT	@ID_primka		= INSERTED.ID_primka
	   ,		@ID_materijal	= INSERTED.ID_materijal
	   ,		@kolicina		= INSERTED.kolicina
       FROM		INSERTED;

	   SELECT	@ID_primka_old		= DELETED.ID_primka
	   ,		@ID_materijal_old	= DELETED.ID_materijal
	   FROM		DELETED;

	   SELECT @postoji = 'Y'
	   FROM   stanje_skladista
	   WHERE  ID_primka		= @ID_primka
	   AND    ID_materijal	= @ID_materijal;

	   IF (@postoji = 'Y')
	   BEGIN
		UPDATE		stanje_skladista
		SET			kolicina		= @kolicina
		WHERE		ID_materijal	= @ID_materijal
		AND			ID_primka		= @ID_primka;
	   END

	   ELSE
	   BEGIN
	    DELETE FROM stanje_skladista
		WHERE		ID_materijal	= @ID_materijal_old
		AND			ID_primka		= @ID_primka_old;

		INSERT INTO stanje_skladista(ID_materijal, ID_primka, kolicina)
		VALUES (@ID_materijal, @ID_primka, @kolicina);
	   END

       
END
GO

ALTER TABLE [dbo].[stavke_primke] ENABLE TRIGGER [Primka_AU]
GO

