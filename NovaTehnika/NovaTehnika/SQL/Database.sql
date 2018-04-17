CREATE DATABASE NovaTehnika 
GO
USE NovaTehnika 
GO

CREATE TABLE Dobavljac(
    SifraDobavljaca INT NOT NULL IDENTITY(1,1),
    NazivKompanije NVARCHAR(100) NOT NULL,
    NazivKontakta NVARCHAR(50) NOT NULL,
    Adresa NVARCHAR(50) NOT NULL,
    Grad NVARCHAR(50) NOT NULL,
    PostanskiBroj NVARCHAR(6) NOT NULL,
    Telefon NVARCHAR(10) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Dobavljac PRIMARY KEY(SifraDobavljaca)
);

CREATE TABLE Kategorija(
    SifraKategorije INT NOT NULL IDENTITY(1,1),
    NazivKategorije NVARCHAR(50) NOT NULL,
    Opis NVARCHAR(50) NULL,
    CONSTRAINT PK_Kategorija PRIMARY KEY(SifraKategorije)
);

CREATE TABLE Proizvod(
    SifraProizvoda INT NOT NULL IDENTITY(1,1),
    NazivProizvoda NVARCHAR(100) NOT NULL,
    Cena DECIMAL(8,2) NOT NULL,
    SifraKategorije INT NOT NULL,
    SifraDobavljaca INT NOT NULL,
    CONSTRAINT PK_Proizvod PRIMARY KEY(SifraProizvoda),
    CONSTRAINT FK_Proizvod_Kategorija FOREIGN KEY(SifraKategorije) REFERENCES Kategorija(SifraKategorije),
    CONSTRAINT FK_Proizvod_Dobavljac FOREIGN KEY(SifraDobavljaca) REFERENCES Dobavljac(SifraDobavljaca)
);

CREATE TABLE Klijent(
    SifraKlijenta INT NOT NULL IDENTITY(1,1),
    NazivKompanije NVARCHAR(100) NOT NULL,
    NazivKontakta NVARCHAR(50) NOT NULL,
    Adresa NVARCHAR(50) NOT NULL,
    Grad NVARCHAR(50) NOT NULL,
    PostanskiBroj NVARCHAR(6) NOT NULL,
    Telefon NVARCHAR(10) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Klijent PRIMARY KEY(SifraKlijenta)
);

CREATE TABLE Zaposleni(
    SifraZaposlenog INT NOT NULL IDENTITY(1,1),
    NazivZaposlenog NVARCHAR(60) NOT NULL,
    DatumRodjenja DATE NOT NULL,
    Adresa NVARCHAR(50) NOT NULL,
    Telefon NVARCHAR(10) NOT NULL,
    Email NVARCHAR(50) NOT NULL
    CONSTRAINT PK_Zaposleni PRIMARY KEY(SifraZaposlenog)
);

CREATE TABLE StanjePorudzbine(
    SifraStanja INT NOT NULL IDENTITY(1,1),
    NazivStanja NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_StanjePorudzbine PRIMARY KEY(SifraStanja)
);

CREATE TABLE Dostavljac(
    SifraDostavljaca INT NOT NULL IDENTITY(1,1),
    NazivKompanije NVARCHAR(50) NOT NULL,
    NazivKontakta NVARCHAR(50) NOT NULL,
    Telefon NVARCHAR(10) NOT NULL,
    CONSTRAINT PK_Dostavljac PRIMARY KEY(SifraDostavljaca)
);

CREATE TABLE Porudzbina(
    SifraPorudzbine INT NOT NULL IDENTITY(1,1),
    DatumPorudzbine DATE NOT NULL,
    RokIsporuke DATE NOT NULL,
    SifraKlijenta INT NOT NULL,
    SifraStanja INT NOT NULL,
    SifraZaposlenog INT NOT NULL,
    SifraDostavljaca INT NOT NULL,
    CONSTRAINT PK_Porudzbina PRIMARY KEY(SifraPorudzbine),
    CONSTRAINT FK_Porudzbina_Klijent FOREIGN KEY(SifraKlijenta) REFERENCES Klijent(SifraKlijenta),
    CONSTRAINT FK_Porudzbina_StanjePorudzbine FOREIGN KEY(SifraStanja) REFERENCES StanjePorudzbine(SifraStanja),
    CONSTRAINT FK_Porudzbina_Zaposleni FOREIGN KEY(SifraZaposlenog) REFERENCES Zaposleni(SifraZaposlenog),
    CONSTRAINT FK_Porudzbina_Dostavljac FOREIGN KEY(SifraDostavljaca) REFERENCES Dostavljac(SifraDostavljaca)
);

CREATE TABLE StavkaPorudzbine(
    SifraStavke INT NOT NULL IDENTITY(1,1),
    SifraPorudzbine INT NOT NULL,
    Kolicina INT NOT NULL,
    Cena DECIMAL(8,2) NOT NULL,
    SifraProizvoda INT NOT NULL,
    CONSTRAINT PK_StavkaPorudzbine PRIMARY KEY(SifraStavke, SifraPorudzbine),
    CONSTRAINT FK_StavkaPorudzbine_Proizvod FOREIGN KEY(SifraProizvoda) REFERENCES Proizvod(SifraProizvoda),
    CONSTRAINT FK_StavkaPorudzbine_Porudzbina FOREIGN KEY(SifraPorudzbine) REFERENCES Porudzbina(SifraPorudzbine)
);

-- Popunjavanje tabela.
INSERT INTO Dobavljac(NazivKompanije, NazivKontakta, Adresa, Grad, PostanskiBroj, Telefon, Email) VALUES
('InterKomerc D.O.O.', 'Marko Ilin', 'Miška Kranjca 14', 'Beograd', '11000', '0631488262', 'milin@gmail.com'),
('Stara Elektronika D.O.O.', 'Jovana Saveski', 'Vukasovićeva 50', 'Beograd', '11090', '0603582541', 'jovanasaveski@elektronika.rs'),
('LEONI Wiring Systems Southeast D.O.O.', 'Stefan Josipović', 'Pane Đukića', 'Prokuplje', '18400', '0', 'stefanj@leoni.com');

INSERT INTO Kategorija(NazivKategorije) VALUES
('Hard diskovi'),
('Procesori'),
('Grafičke kartice');

INSERT INTO Proizvod(NazivProizvoda, Cena, SifraKategorije, SifraDobavljaca) VALUES
('HDD SATA3 7200 1TB WD Black WD1003FZEX', 8585, 1, 1),
('HDD SATA3 2.5" 5400 1TB Hitachi Travelstar 5K1000', 6790, 1, 1),
('HDD SATA3 2.5" 5400 1TB Seagate Baracuda', 5292, 1, 1),
('HDD Fioka 2.5" Kolink SATA USB 2.0', 990, 1, 3),
('CPU FM2+ AMD Athlon™ X4 Quad-Core 840', 4963, 2, 2),
('APU AM4 AMD A10-9700', 10006, 2, 2),
('CPU AM3+ AMD FX-4320', 6990, 2, 2),
('CPU AM4 AMD Ryzen 3 1300X', 14290, 2, 2),
('AMD Radeon R5 230 ASUS 2GB GDDR3', 5530, 3, 2),
('AMD Radeon R7 250 Sapphire 2GB DDR3', 9990, 3, 1),
('AMD Radeon RX550 Sapphire PULSE 2GB OC GDDR5', 13990, 3, 1);

INSERT INTO Klijent(NazivKompanije, NazivKontakta, Adresa, Grad, PostanskiBroj, Telefon, Email) VALUES
('Kelco', 'Nemanja Kojić', 'Bulevar kralja Aleksandra 326', 'Beograd', '11000', '0113403376', 'nemanja@kelco.rs'),
('Comet Electronics D.O.O.', 'Mirko Ahmedovski', 'Blok 19a', 'Beograd', '11000', '0116134180', 'ahmedovskim@comet.rs'),
('Mikro Princ D.O.O.', 'Aleksandar Janković', 'Kralja Milutina 31', 'Beograd', '11000', '011362900', 'ajankovic@mikroprinc.com');

INSERT INTO Zaposleni(NazivZaposlenog, DatumRodjenja, Adresa, Telefon, Email) VALUES
('Ivan Marić', '1991-12-13', 'Ivana Mičurina 38', '0611418030', 'ivanmaric@yahoo.com'),
('Ana Petrović', '1995-03-22', 'Makedonska 13', '0622245810', 'anap@gmail.com');

INSERT INTO StanjePorudzbine(NazivStanja) VALUES
('Otkazano'),
('U obradi'),
('Isporučeno');

INSERT INTO Dostavljac(NazivKompanije, NazivKontakta, Telefon) VALUES
('Yugotrans D.O.O.', 'Marko Ledović', '0642477373'),
('Milšped D.O.O.', 'Petar Stojanović', '0605449274');

INSERT INTO Porudzbina(DatumPorudzbine, RokIsporuke, SifraKlijenta, SifraStanja, SifraZaposlenog, SifraDostavljaca) VALUES
('2018-02-08', '2018-02-24', 1, 3, 2, 1),
('2018-03-11', '2018-03-17', 3, 1, 1, 2),
('2018-04-02', '2018-04-21', 2, 2, 2, 1);

INSERT INTO StavkaPorudzbine(SifraPorudzbine, Kolicina, Cena, SifraProizvoda) VALUES
(1, 2, 17170, 1),
(1, 1, 10006, 6),
(1, 1, 14290, 8),
(2, 10, 55300, 9),
(3, 1, 13990, 11),
(3, 1, 14290, 8);


