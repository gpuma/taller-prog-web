create database SeguridadBD
go

use SeguridadBD
go

--no guardamos ni nombre de usuario o contrase�a xq eso se guardar� en
--las tablas de membres�a
create table Usuarios
(
	dni char(8) not null,
	nombres nvarchar(50) not null,
	apellidos nvarchar(50) not null,
	telefono nvarchar(20) not null,
	
	--el tipo de dato del ID de la tabla de membres�a de usuarios es uniqueidentifier
	id_usuario_asp uniqueidentifier not null
)