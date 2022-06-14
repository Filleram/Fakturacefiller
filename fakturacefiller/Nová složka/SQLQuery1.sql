CREATE TABLE Fakturace (
id int identity(1,1) NOT NULL Primary key,
datum DATE,
cislo int,
odberatel nvarchar(50),
nazev nvarchar(20),
pocet int,
cena1 float,
cenacelkem float,
DPH float,
cenasDPH float)