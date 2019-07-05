USE [18017_DB]
GO

/****** Object:  Trigger [dbo].[Izdatnica_AD]    Script Date: 3.7.2018. 18:06:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Izdatnica_AD]
       ON [dbo].[stavke_izdatnice]
AFTER DELETE
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE 
		@ID_izdatnica INT,
		@ID_materijal INT,
		@kolicina INT
 
       SELECT	@ID_izdatnica   = DELETED.ID_izdatnica
	   ,		@ID_materijal	= DELETED.ID_materijal
       FROM		DELETED;
 
       DELETE FROM	stanje_skladista
	   WHERE		ID_materijal = @ID_materijal
	   AND			ID_izdatnica = @ID_izdatnica;
END
GO

ALTER TABLE [dbo].[stavke_izdatnice] ENABLE TRIGGER [Izdatnica_AD]
GO

