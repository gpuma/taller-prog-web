/*BORRA LA BD SCRUM Y LA CREA DE NUEVO SI ES QUE EXISTE*/
IF db_id('SCRUM') is NOT NULL
   BEGIN
   USE master
   ALTER DATABASE [SCRUM] set single_user with rollback immediate
   DROP DATABASE [SCRUM]
END

/*COMIENZO DE CREACION*/
CREATE DATABASE SCRUM
GO
USE SCRUM
GO

--Tabla Roles
CREATE TABLE Rol
(
	id_rol INT PRIMARY KEY IDENTITY(1,1),
	nom_rol nVARCHAR(20) NOT NULL
)

INSERT INTO Rol VALUES ('ScrumMaster')
INSERT INTO Rol VALUES ('ProductOwner')
INSERT INTO Rol VALUES ('Team')
INSERT INTO Rol VALUES ('Steakholders')

--Tabla Pais
CREATE TABLE Pais
(
	id_pais INT PRIMARY KEY IDENTITY(1,1),
	nom_pais NVARCHAR(25) NOT NULL,
	pbi_pais money NOT NULL
)

INSERT INTO Pais VALUES ('Peru', 178643)
INSERT INTO Pais VALUES ('Guatemala', 68142)
INSERT INTO Pais VALUES ('Costa Rica', 56908)
INSERT INTO Pais VALUES ('Japon', 4412600)
INSERT INTO Pais VALUES ('Estados Unidos',18558130)
INSERT INTO Pais VALUES ('Argentina', 437586)
INSERT INTO Pais VALUES ('Tailandia', 409724)

CREATE TABLE Persona
(
	id_persona INT PRIMARY KEY IDENTITY(1,1),
	apellido NVARCHAR(40) NOT NULL,
	nombre NVARCHAR(40) NOT NULL,
	sueldo SMALLMONEY,
	direccion NVARCHAR(100) default 'Mi casa',
	celular CHAR(9) NOT NULL,
	sexo CHAR(1) NOT NULL,
	nacimiento date,
	id_rol int NOT NULL,
	id_pais int NOT NULL,

	CONSTRAINT FK_rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol),
	CONSTRAINT FK_PAIS FOREIGN KEY (id_pais) REFERENCES Pais(id_pais)
)

INSERT INTO Persona VALUES ('Romero Peña','Sandra Y',1200,default,'934567564','F','1972/3/3',3,1)
INSERT INTO Persona VALUES ('Arevalo','Maria Johana',950,'64 Park St','932356787','F','1976/2/16',3,3)
INSERT INTO Persona VALUES ('Hernandez Mancia','Marielos',958,default,'967567555','F','1986/7/4',3,4)
INSERT INTO Persona VALUES ('Perez Juarez','Joaquin',850,default,'934567564','M','1969/9/2',3,1)
INSERT INTO Persona VALUES ('Solis Castro','Eduardo',600,default,'912327523','M','1972/3/11',3,1)
INSERT INTO Persona VALUES ('Ramos Nieto','Jorge',550,default,'934567174','M','1972/10/4',4,1)
INSERT INTO Persona VALUES ('Hernandez Carias','Johanna',1800,NULL,'934234809','F','1952/3/4',1,1)
INSERT INTO Persona VALUES ('Romero Peña','Manuel Alberto',NULL,default,'934567342','M','1969/12/4',2,1)
INSERT INTO Persona VALUES ('Garcia Alvarado','Roxana',1600,default,'934345564','F','1970/4/4',1,1)
INSERT INTO Persona VALUES ('Torres Castro','Alfredo',450,'23 Ramon Castilla','934565674','M','1980/2/9',3,5)
INSERT INTO Persona VALUES ('Romero Peña','Verenice',400,default,'934567589','F','1978/3/17',3,1)
INSERT INTO Persona VALUES ('Martinez','Evelyn Roxana',340,default,'934556764','F','1972/8/14',3,5)
INSERT INTO Persona VALUES ('Siguenza','Eduardo',1120,default,'921467564','M','1975/10/9',3,1)
INSERT INTO Persona VALUES ('Alas Duran','Martin',1200,NULL,'934562364','M','1972/3/4',3,1)
INSERT INTO Persona VALUES ('Jerez M.','Jose Carlos',589,'52 Gebbie St','934563352','M','1972/3/6',4,1)
INSERT INTO Persona VALUES ('Bolaños Cea','Sandra',244,default,'967557564','F','1968/3/4',3,1)
INSERT INTO Persona VALUES ('Cuestas D.','Jenny Maria',1089,'501 Brasil','934567564','F','1972/9/14',3,4)
INSERT INTO Persona VALUES ('Romero Peña','Alexandra',1000,default,'934565455','F','1972/7/24',3,1)
INSERT INTO Persona VALUES ('Molina Nuñez','Mario',578,NULL,'934567564','M','1962/3/7',3,3)
INSERT INTO Persona VALUES ('Romero Peña','Jennifer',989,default,'935657564','F','1977/10/21',3,3)
INSERT INTO Persona VALUES ('Melendez A','Karla Maria',875,default,'945656463','F','1956/12/1',4,1)
INSERT INTO Persona VALUES ('Romero Peña','Andrea Lissette',NULL,default,'934545343','F','1990/3/4',3,2)
INSERT INTO Persona VALUES ('Melendez Torres','Wenceslado',270,default,'934564563','M','1977/8/4',4,1)
