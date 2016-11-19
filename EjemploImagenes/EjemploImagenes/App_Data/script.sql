create database UsuarioBD
go

use UsuarioBD
go

create table Usuario
(
	Id int identity(1,1) primary key,
	Nombre nvarchar(50) not null,
	Apellido nvarchar(50) not null,
	URLImagen nvarchar(50) not null,
)
go