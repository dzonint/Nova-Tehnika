CREATE PROCEDURE sp_PrikaziStanja
AS
BEGIN
    SELECT SifraStanja AS [ID], NazivStanja AS [Naziv] 
    FROM StanjePorudzbine
END

CREATE PROCEDURE sp_VratiStanjePoSifri
@SifraStanja INT,
@NazivStanja NVARCHAR(50) OUTPUT
AS
BEGIN
    SELECT @NazivStanja = NazivStanja
    FROM StanjePorudzbine 
    WHERE SifraStanja = @SifraStanja
END

CREATE PROCEDURE sp_UnesiStanje
@NazivStanja NVARCHAR(50)
AS
BEGIN
    INSERT INTO StanjePorudzbine(NazivStanja) VALUES (@NazivStanja)
END

CREATE PROCEDURE sp_AzurirajStanje
@NazivStanja NVARCHAR(50),
@SifraStanja INT
AS
BEGIN
    UPDATE StanjePorudzbine 
    SET NazivStanja = @NazivStanja
    WHERE SifraStanja = @SifraStanja
END

CREATE PROCEDURE sp_UkloniStanje
@SifraStanja INT
AS
BEGIN
    DELETE FROM StanjePorudzbine
    WHERE SifraStanja = @SifraStanja
END