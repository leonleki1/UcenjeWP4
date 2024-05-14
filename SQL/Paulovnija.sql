CREATE DATABASE FIRMA;

USE FIRMA;saaa

CREATE TABLE POZICIJE (
Sifra int not null primary key identity (1,1),
Naziv varchar (40),
Duznost varchar (40),
Ugovor datetime
);

CREATE TABLE GRUPERADNIKA (
Sifra int not null primary key identity (1,1),
Nazivgrupe varchar (1),
Voditelj varchar (40),
Maxradnika varchar (20)
);

CREATE TABLE NADREDENI (
GRUPA int,
Pozicija int
);

CREATE TABLE RADNICI (
Sifra int not null primary key identity (1,1),
Ime varchar (30),
Prezime varchar (30),
Oib char (11),
Email varchar (60),
);

ALTER TABLE GRUPERADNIKA ADD FOREIGN KEY (Sifra) references POZICIJE(Sifra);
ALTER TABLE NADREDENI ADD FOREIGN KEY (Grupa) references GRUPE(Sifra);