ALTER TABLE Porudzbina
    ADD NazivKlijenta NVARCHAR(50),
        StanjePorudzbine NVARCHAR(50);
GO
UPDATE Porudzbina
SET Porudzbina.NazivKlijenta = Klijent.NazivKontakta
FROM Porudzbina INNER JOIN Klijent ON Porudzbina.SifraKlijenta = Klijent.SifraKlijenta;
GO
UPDATE Porudzbina
SET Porudzbina.StanjePorudzbine = StanjePorudzbine.NazivStanja
FROM Porudzbina INNER JOIN StanjePorudzbine ON Porudzbina.SifraStanja = StanjePorudzbine.SifraStanja;
GO

CREATE TRIGGER dbo.AzurirajNazivKlijenta
ON Klijent
AFTER UPDATE
AS
 BEGIN
    IF (UPDATE (NazivKontakta))
    BEGIN
        UPDATE Porudzbina
        SET Porudzbina.NazivKlijenta = INSERTED.NazivKontakta
        FROM Porudzbina JOIN INSERTED ON Porudzbina.SifraKlijenta = INSERTED.SifraKlijenta
    END
 END
 
CREATE TRIGGER dbo.ZabraniBrisanjeKlijenta
ON Klijent
FOR DELETE 
AS
 BEGIN
    DECLARE @SifraKlijenta INT
    SELECT @SifraKlijenta = SifraKlijenta
    FROM DELETED
    
    IF EXISTS (SELECT SifraKlijenta FROM Porudzbina WHERE SifraKlijenta = @SifraKlijenta)
        BEGIN
         THROW 5100, 'Brisanje n-torke nije dozvoljeno - Klijent postoji u Porudžbinama.', 1;
         ROLLBACK TRANSACTION
        END
 END
               
CREATE TRIGGER dbo.AzurirajNazivStanjaPorudzbine
ON StanjePorudzbine
AFTER UPDATE
AS
 BEGIN
    IF (UPDATE (NazivStanja))
    BEGIN
        UPDATE Porudzbina
        SET Porudzbina.StanjePorudzbine = INSERTED.NazivStanja
        FROM Porudzbina JOIN INSERTED ON Porudzbina.SifraStanja = INSERTED.SifraStanja
    END
 END
 
CREATE TRIGGER dbo.ZabraniBrisanjeStanja
ON StanjePorudzbine
FOR DELETE 
AS
 BEGIN
    DECLARE @SifraStanja INT
    SELECT @SifraStanja = SifraStanja
    FROM DELETED
    
    IF EXISTS (SELECT SifraStanja FROM Porudzbina WHERE SifraStanja = @SifraStanja)
        BEGIN
         THROW 5100, 'Brisanje n-torke nije dozvoljeno - Stanje postoji u Porudžbinama.', 1;
         ROLLBACK TRANSACTION
        END
 END 
 
CREATE TRIGGER dbo.ZabraniDodavanjeIzmenuPorudzbine
ON Porudzbina
FOR INSERT, UPDATE
AS
 BEGIN
    IF EXISTS (SELECT SifraKlijenta FROM INSERTED)
     BEGIN
      DECLARE @SifraKlijenta INT
      SELECT @SifraKlijenta = SifraKlijenta FROM INSERTED
      IF NOT EXISTS (SELECT SifraKlijenta FROM Klijent WHERE SifraKlijenta = @SifraKlijenta)
       BEGIN
        THROW 5100, 'Dodavanje ili izmena nije uspešna - Klijent ne postoji u bazi.', 1;
        ROLLBACK TRANSACTION
       END
     END
    
    IF EXISTS (SELECT SifraStanja FROM INSERTED)
     BEGIN
      DECLARE @SifraStanja INT
      SELECT @SifraStanja = SifraStanja FROM INSERTED
      IF NOT EXISTS (SELECT SifraStanja FROM StanjePorudzbine WHERE SifraStanja = @SifraStanja)
       BEGIN
        THROW 5100, 'Dodavanje ili izmena nije uspešna - Stanje ne postoji u bazi.', 1;
        ROLLBACK TRANSACTION
       END
     END
 END