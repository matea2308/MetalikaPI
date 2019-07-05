USE [18017_DB]
GO

/****** Object:  Trigger [dbo].[Primka_AD]    Script Date: 3.7.2018. 18:07:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Primka_AD]
       ON [dbo].[stavke_primke]
AFTER DELETE
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE 
		@ID_primka INT,
		@ID_materijal INT,
		@kolicina INT
 
       SELECT	@ID_primka		= DELETED.ID_primka
	   ,		@ID_materijal	= DELETED.ID_materijal
       FROM		DELETED;
 
       DELETE FROM	stanje_skladista
	   WHERE		ID_materijal	= @ID_materijal
	   AND			ID_primka		= @ID_primka;
END
GO

ALTER TABLE [dbo].[stavke_primke] ENABLE TRIGGER [Primka_AD]
GO

