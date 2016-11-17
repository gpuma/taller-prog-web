create database TutorialSeguridad
go
use TutorialSeguridad
go

create table Usuario
(
	DNI char(8) primary key,
	NomUsuario nvarchar(20) not null,
	Contraseña nvarchar(20) not null,
	TipoUsuario char(1) not null
)
go
create table Pedido
(
	IdPedido int identity(1,1) primary key,
	IDUsuario char(8) foreign key references Usuario(DNI),
	Item nvarchar(30) not null
)
go

insert into Usuario values('12345678','oscar','oscar','A')
insert into Usuario values('45645644','pedro','oscar','U')
insert into Usuario values('54561312','juan','oscar','U')

insert into Pedido values('12345678', 'pan')
insert into Pedido values('12345678', 'huevos')
insert into Pedido values('45645644', 'carne')
insert into Pedido values('54561312', 'cafe')
insert into Pedido values('54561312', 'leche')
insert into Pedido values('54561312', 'cocoa')
