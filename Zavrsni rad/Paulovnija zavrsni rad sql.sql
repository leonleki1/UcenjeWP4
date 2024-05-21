Create Database Paulovnija;

Use Paulovnija;

CREATE TABLE Radnici (
    ID_Radnika INT PRIMARY KEY,
    Ime VARCHAR(50),
    Prezime VARCHAR(50),
    Godine INT,
    Pozicija VARCHAR(50),
    Plata DECIMAL(10,2)
);

CREATE TABLE Zadaci (
    ID_Zadatka INT PRIMARY KEY,
    Opis VARCHAR(255),
    Datum_pocetka DATE,
    Datum_zavrsetka DATE,
    Status_Zadatka VARCHAR(50)
);


CREATE TABLE Sadnice (
    ID_Sadnice INT PRIMARY KEY,
    Vrsta VARCHAR(50),
    Visina DECIMAL(5,2),
    Starost INT,
    Datum_sadnje DATE,
    ID_Rasadnika INT,

);


CREATE TABLE Strojevi (
    ID_Stroja INT PRIMARY KEY,
    Marka VARCHAR(50),
    Model VARCHAR(50),
    Godiste INT,
    Tip VARCHAR(50),
    Kapacitet_rezervoara DECIMAL(10,2),
    ID_Radnika INT,
    
);


CREATE TABLE Rasadnik (
    ID_Rasadnika INT PRIMARY KEY,
    Naziv VARCHAR(100),
    Lokacija VARCHAR(100),
    Povrsina DECIMAL(10,2),
    Datum_otvaranja DATE
);

ALTER TABLE Zadaci ADD FOREIGN KEY (ID_Zadatka) references Radnici(ID_Radnika);
ALTER TABLE Strojevi ADD FOREIGN KEY (ID_Stroja) references Radnici(ID_Radnika);
ALTER TABLE Sadnice ADD FOREIGN KEY (ID_Sadnice) references Rasadnik(ID_Rasadnika);

Select*From Radnici;

insert into Radnici (ID_Radnika,Ime,Prezime,Godine,Pozicija,Plata)
values (1,'Pero','Magdenovic',36,'Traktorista',1200);

insert into Radnici (ID_Radnika,Ime,Prezime,Godine,Pozicija,Plata)
values (2,'Josip','Maglovic',38,'Bagerist',1900);

insert into Radnici (ID_Radnika,Ime,Prezime,Godine,Pozicija,Plata)
values (3,'Ivan','Golub',36,'Poslovoda',3000);

Select*From Zadaci

insert into Zadaci (ID_Zadatka,Opis,Datum_pocetka,Datum_zavrsetka,Status_Zadatka)
Values (1,'Tanjuranje','2024-05-21','2024-05-30','Nezavrsen');

insert into Zadaci (ID_Zadatka,Opis,Datum_pocetka,Datum_zavrsetka,Status_Zadatka)
Values (2,'Vadenjekorjena','2024-05-26','2024-06-5','Nezavrsen');

insert into Zadaci (ID_Zadatka,Opis,Datum_pocetka,Datum_zavrsetka,Status_Zadatka)
Values (3,'Zbrajanjeradnisati','2024-05-21','2024-05-28','Zavrsen');