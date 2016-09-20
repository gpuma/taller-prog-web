SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE [master];
GO

IF EXISTS (SELECT * FROM sys.databases WHERE Name = 'Escuela')
	DROP DATABASE Escuela;
GO

-- Create the Escuela database.
CREATE DATABASE Escuela;
GO

-- Specify a simple recovery model 
-- to keep the log growth to a minimum.
ALTER DATABASE Escuela 
	SET RECOVERY SIMPLE;
GO

USE Escuela;
GO

-- Create the Department table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[Departamento]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Departamento](
	[IDDepartamento] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Presupuesto] [money] NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[Administrador] [int] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[IDDepartamento] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the Person table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[Persona]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Persona](
	[IDPersona] [int] IDENTITY(1,1) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[Nombres] [nvarchar](50) NOT NULL,
	[FechaContrato] [datetime] NULL,
	[FechaMatricula] [datetime] NULL,
 CONSTRAINT [PK_Escuela.Student] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the CursoOnsite table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[CursoOnsite]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CursoOnsite](
	[IDCurso] [int] NOT NULL,
	[Lugar] [nvarchar](50) NOT NULL,
	[Dias] [nvarchar](50) NOT NULL,
	Hora [smalldatetime] NOT NULL,
 CONSTRAINT [PK_CursoOnsite] PRIMARY KEY CLUSTERED 
(
	[IDCurso] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the CursoOnline table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[CursoOnline]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CursoOnline](
	[IDCurso] [int] NOT NULL,
	[URL] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_CursoOnline] PRIMARY KEY CLUSTERED 
(
	[IDCurso] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

--Create the NotaEstudiante table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[NotaEstudiante]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NotaEstudiante](
	[IDMatricula] [int] IDENTITY(1,1) NOT NULL,
	[IDCurso] [int] NOT NULL,
	[IDEstudiante] [int] NOT NULL,
	[Nota] [decimal](3, 2) NULL,
 CONSTRAINT [PK_NotaEstudiante] PRIMARY KEY CLUSTERED 
(
	[IDMatricula] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the CursoInstructor table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[CursoInstructor]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CursoInstructor](
	[IDCurso] [int] NOT NULL,
	[IDPersona] [int] NOT NULL,
 CONSTRAINT [PK_CursoInstructor] PRIMARY KEY CLUSTERED 
(
	[IDCurso] ASC,
	[IDPersona] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the Curso table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[Curso]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Curso](
	[IDCurso] [int] NOT NULL,
	[Titulo] [nvarchar](100) NOT NULL,
	[Creditos] [int] NOT NULL,
	[IDDepartamento] [int] NOT NULL,
 CONSTRAINT [PK_Escuela.Curso] PRIMARY KEY CLUSTERED 
(
	[IDCurso] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the Oficina table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[Oficina]')
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Oficina](
	[IDInstructor] [int] NOT NULL,
	[Lugar] [nvarchar](50) NOT NULL,
	[Timestamp] [Timestamp] NOT NULL,
 CONSTRAINT [PK_Oficina] PRIMARY KEY CLUSTERED 
(
	[IDInstructor] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Define the relationship between CursoOnsite and Curso.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
       WHERE object_id = OBJECT_ID(N'[dbo].[FK_CursoOnsite_Curso]')
       AND parent_object_id = OBJECT_ID(N'[dbo].[CursoOnsite]'))
ALTER TABLE [dbo].[CursoOnsite]  WITH CHECK ADD  
       CONSTRAINT [FK_CursoOnsite_Curso] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[Curso] ([IDCurso])
GO
ALTER TABLE [dbo].[CursoOnsite] CHECK 
       CONSTRAINT [FK_CursoOnsite_Curso]
GO

-- Define the relationship between CursoOnline and Curso.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
       WHERE object_id = OBJECT_ID(N'[dbo].[FK_CursoOnline_Curso]')
       AND parent_object_id = OBJECT_ID(N'[dbo].[CursoOnline]'))
ALTER TABLE [dbo].[CursoOnline]  WITH CHECK ADD  
       CONSTRAINT [FK_CursoOnline_Curso] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[Curso] ([IDCurso])
GO
ALTER TABLE [dbo].[CursoOnline] CHECK 
       CONSTRAINT [FK_CursoOnline_Curso]
GO

-- Define the relationship between NotaEstudiante and Curso.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
       WHERE object_id = OBJECT_ID(N'[dbo].[FK_NotaEstudiante_Curso]')
       AND parent_object_id = OBJECT_ID(N'[dbo].[NotaEstudiante]'))
ALTER TABLE [dbo].[NotaEstudiante]  WITH CHECK ADD  
       CONSTRAINT [FK_NotaEstudiante_Curso] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[Curso] ([IDCurso])
GO
ALTER TABLE [dbo].[NotaEstudiante] CHECK 
       CONSTRAINT [FK_NotaEstudiante_Curso]
GO

--Define the relationship between NotaEstudiante and Student.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
       WHERE object_id = OBJECT_ID(N'[dbo].[FK_NotaEstudiante_Student]')
       AND parent_object_id = OBJECT_ID(N'[dbo].[NotaEstudiante]'))
ALTER TABLE [dbo].[NotaEstudiante]  WITH CHECK ADD  
       CONSTRAINT [FK_NotaEstudiante_Student] FOREIGN KEY([IDEstudiante])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[NotaEstudiante] CHECK 
       CONSTRAINT [FK_NotaEstudiante_Student]
GO

-- Define the relationship between CursoInstructor and Curso.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
   WHERE object_id = OBJECT_ID(N'[dbo].[FK_CursoInstructor_Curso]')
   AND parent_object_id = OBJECT_ID(N'[dbo].[CursoInstructor]'))
ALTER TABLE [dbo].[CursoInstructor]  WITH CHECK ADD  
   CONSTRAINT [FK_CursoInstructor_Curso] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[Curso] ([IDCurso])
GO
ALTER TABLE [dbo].[CursoInstructor] CHECK 
   CONSTRAINT [FK_CursoInstructor_Curso]
GO

-- Define the relationship between CursoInstructor and Person.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
   WHERE object_id = OBJECT_ID(N'[dbo].[FK_CursoInstructor_Person]')
   AND parent_object_id = OBJECT_ID(N'[dbo].[CursoInstructor]'))
ALTER TABLE [dbo].[CursoInstructor]  WITH CHECK ADD  
   CONSTRAINT [FK_CursoInstructor_Person] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[CursoInstructor] CHECK 
   CONSTRAINT [FK_CursoInstructor_Person]
GO

-- Define the relationship between Curso and Department.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
       WHERE object_id = OBJECT_ID(N'[dbo].[FK_Curso_Department]')
       AND parent_object_id = OBJECT_ID(N'[dbo].[Curso]'))
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  
       CONSTRAINT [FK_Curso_Department] FOREIGN KEY([IDDepartamento])
REFERENCES [dbo].[Departamento] ([IDDepartamento])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Department]
GO

--Define the relationship between Oficina and Person.
IF NOT EXISTS (SELECT * FROM sys.foreign_keys 
   WHERE object_id = OBJECT_ID(N'[dbo].[FK_Oficina_Person]')
   AND parent_object_id = OBJECT_ID(N'[dbo].[Oficina]'))
ALTER TABLE [dbo].[Oficina]  WITH CHECK ADD  
   CONSTRAINT [FK_Oficina_Person] FOREIGN KEY([IDInstructor])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[Oficina] CHECK 
   CONSTRAINT [FK_Oficina_Person]
GO

-- Create InsertOficina stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[InsertOficina]') 
		AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[InsertOficina]
		@IDInstructor int,
		@Lugar nvarchar(50)
		AS
		INSERT INTO dbo.Oficina (IDInstructor, Lugar)
		VALUES (@IDInstructor, @Lugar);
		IF @@ROWCOUNT > 0
		BEGIN
			SELECT [Timestamp] FROM Oficina 
				WHERE IDInstructor=@IDInstructor;
		END
' 
END
GO

--Create the UpdateOficina stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[UpdateOficina]') 
		AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[UpdateOficina]
		@IDInstructor int,
		@Lugar nvarchar(50),
		@OrigTimestamp Timestamp
		AS
		UPDATE Oficina SET Lugar=@Lugar 
		WHERE IDInstructor=@IDInstructor AND [Timestamp]=@OrigTimestamp;
		IF @@ROWCOUNT > 0
		BEGIN
			SELECT [Timestamp] FROM Oficina 
				WHERE IDInstructor=@IDInstructor;
		END
' 
END
GO

-- Create the DeleteOficina stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[DeleteOficina]') 
		AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[DeleteOficina]
		@IDInstructor int
		AS
		DELETE FROM Oficina
		WHERE IDInstructor=@IDInstructor;
' 
END
GO

-- Create the DeletePerson stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[DeletePerson]') 
		AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[DeletePerson]
		@IDPersona int
		AS
		DELETE FROM Person WHERE IDPersona = @IDPersona;
' 
END
GO

-- Create the UpdatePerson stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePerson]') 
		AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[UpdatePerson]
		@IDPersona int,
		@Apellidos nvarchar(50),
		@Nombres nvarchar(50),
		@FechaContrato datetime,
		@FechaMatricula datetime
		AS
		UPDATE Person SET Apellidos=@Apellidos, 
				Nombres=@Nombres,
				FechaContrato=@FechaContrato,
				FechaMatricula=@FechaMatricula
		WHERE IDPersona=@IDPersona;
' 
END
GO

-- Create the InsertPerson stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[InsertPerson]') 
		AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[InsertPerson]
		@Apellidos nvarchar(50),
		@Nombres nvarchar(50),
		@FechaContrato datetime,
		@FechaMatricula datetime
		AS
		INSERT INTO dbo.Persona (Apellidos, 
					Nombres, 
					FechaContrato, 
					FechaMatricula)
		VALUES (@Apellidos, 
			@Nombres, 
			@FechaContrato, 
			@FechaMatricula);
		SELECT SCOPE_IDENTITY() as NewIDPersona;
' 
END
GO

-- Create GetNotaEstudiantes stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
            WHERE object_id = OBJECT_ID(N'[dbo].[GetNotaEstudiantes]') 
            AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[GetNotaEstudiantes]
            @IDEstudiante int
            AS
            SELECT IDMatricula, Nota, IDCurso, IDEstudiante FROM dbo.NotaEstudiante
            WHERE IDEstudiante = @IDEstudiante
' 
END
GO

-- Create GetDepartmentNombre stored procedure.
IF NOT EXISTS (SELECT * FROM sys.objects 
            WHERE object_id = OBJECT_ID(N'[dbo].[GetDepartmentNombre]') 
            AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[GetDepartmentNombre]
      @ID int,
      @Nombre nvarchar(50) OUTPUT
      AS
      SELECT @Nombre = Nombre FROM Department
      WHERE IDDepartamento = @ID
'
END
GO

-- Insert data into the Person table.
USE Escuela
GO
SET IDENTITY_INSERT dbo.Persona ON
GO
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (1, 'Abercrombie', 'Kim', '1995-03-11', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (2, 'Barzdukas', 'Gytis', null, '2005-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (3, 'Justice', 'Peggy', null, '2001-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (4, 'Fakhouri', 'Fadi', '2002-08-06', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (5, 'Harui', 'Roger', '1998-07-01', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (6, 'Li', 'Yan', null, '2002-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (7, 'Norman', 'Laura', null, '2003-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (8, 'Olivotto', 'Nino', null, '2005-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (9, 'Tang', 'Wayne', null, '2005-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (10, 'Alonso', 'Meredith', null, '2002-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (11, 'Lopez', 'Sophia', null, '2004-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (12, 'Browning', 'Meredith', null, '2000-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (13, 'Anand', 'Arturo', null, '2003-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (14, 'Walker', 'Alexandra', null, '2000-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (15, 'Powell', 'Carson', null, '2004-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (16, 'Jai', 'Damien', null, '2001-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (17, 'Carlson', 'Robyn', null, '2005-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (18, 'Zheng', 'Roger', '2004-02-12', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (19, 'Bryant', 'Carson', null, '2001-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (20, 'Suarez', 'Robyn', null, '2004-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (21, 'Holt', 'Roger', null, '2004-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (22, 'Alexander', 'Carson', null, '2005-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (23, 'Morgan', 'Isaiah', null, '2001-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (24, 'Martin', 'Randall', null, '2005-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (25, 'Kapoor', 'Candace', '2001-01-15', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (26, 'Rogers', 'Cody', null, '2002-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (27, 'Serrano', 'Stacy', '1999-06-01', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (28, 'White', 'Anthony', null, '2001-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (29, 'Griffin', 'Rachel', null, '2004-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (30, 'Shan', 'Alicia', null, '2003-09-01');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (31, 'Stewart', 'Jasmine', '1997-10-12', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (32, 'Xu', 'Kristen', '2001-7-23', null);
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (33, 'Gao', 'Erica', null, '2003-01-30');
INSERT INTO dbo.Persona (IDPersona, Apellidos, Nombres, FechaContrato, FechaMatricula)
VALUES (34, 'Van Houten', 'Roger', '2000-12-07', null);
GO
SET IDENTITY_INSERT dbo.Persona OFF
GO

-- Insert data into the Department table.
INSERT INTO dbo.Departamento (IDDepartamento, [Nombre], Presupuesto, FechaInicio, Administrador)
VALUES (1, 'Engineering', 350000.00, '2007-09-01', 2);
INSERT INTO dbo.Departamento (IDDepartamento, [Nombre], Presupuesto, FechaInicio, Administrador)
VALUES (2, 'English', 120000.00, '2007-09-01', 6);
INSERT INTO dbo.Departamento (IDDepartamento, [Nombre], Presupuesto, FechaInicio, Administrador)
VALUES (4, 'Economics', 200000.00, '2007-09-01', 4);
INSERT INTO dbo.Departamento (IDDepartamento, [Nombre], Presupuesto, FechaInicio, Administrador)
VALUES (7, 'Mathematics', 250000.00, '2007-09-01', 3);
GO


-- Insert data into the Curso table.
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (1050, 'Chemistry', 4, 1);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (1061, 'Physics', 4, 1);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (1045, 'Calculus', 4, 7);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (2030, 'Poetry', 2, 2);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (2021, 'Composition', 3, 2);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (2042, 'Literature', 4, 2);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (4022, 'Microeconomics', 3, 4);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (4041, 'Macroeconomics', 3, 4);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (4061, 'Quantitative', 2, 4);
INSERT INTO dbo.Curso (IDCurso, Titulo, Creditos, IDDepartamento)
VALUES (3141, 'Trigonometry', 4, 7);
GO

-- Insert data into the CursoOnline table.
INSERT INTO dbo.CursoOnline (IDCurso, URL)
VALUES (2030, 'http://www.fineartEscuela.net/Poetry');
INSERT INTO dbo.CursoOnline (IDCurso, URL)
VALUES (2021, 'http://www.fineartEscuela.net/Composition');
INSERT INTO dbo.CursoOnline (IDCurso, URL)
VALUES (4041, 'http://www.fineartEscuela.net/Macroeconomics');
INSERT INTO dbo.CursoOnline (IDCurso, URL)
VALUES (3141, 'http://www.fineartEscuela.net/Trigonometry');

--Insert data into CursoOnsite table.
INSERT INTO dbo.CursoOnsite (IDCurso, Lugar, Dias, Hora)
VALUES (1050, '123 Smith', 'MTWH', '11:30');
INSERT INTO dbo.CursoOnsite (IDCurso, Lugar, Dias, Hora)
VALUES (1061, '234 Smith', 'TWHF', '13:15');
INSERT INTO dbo.CursoOnsite (IDCurso, Lugar, Dias, Hora)
VALUES (1045, '121 Smith','MWHF', '15:30');
INSERT INTO dbo.CursoOnsite (IDCurso, Lugar, Dias, Hora)
VALUES (4061, '22 Williams', 'TH', '11:15');
INSERT INTO dbo.CursoOnsite (IDCurso, Lugar, Dias, Hora)
VALUES (2042, '225 Adams', 'MTWH', '11:00');
INSERT INTO dbo.CursoOnsite (IDCurso, Lugar, Dias, Hora)
VALUES (4022, '23 Williams', 'MWF', '9:00');

-- Insert data into the CursoInstructor table.
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (1050, 1);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (1061, 31);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (1045, 5);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (2030, 4);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (2021, 27);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (2042, 25);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (4022, 18);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (4041, 32);
INSERT INTO dbo.CursoInstructor(IDCurso, IDPersona)
VALUES (4061, 34);
GO

--Insert data into the Oficina table.
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (1, '17 Smith');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (4, '29 Adams');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (5, '37 Williams');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (18, '143 Smith');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (25, '57 Adams');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (27, '271 Williams');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (31, '131 Smith');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (32, '203 Williams');
INSERT INTO dbo.Oficina(IDInstructor, Lugar)
VALUES (34, '213 Smith');

-- Insert data into the NotaEstudiante table.
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2021, 2, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2030, 2, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2021, 3, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2030, 3, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2021, 6, 2.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2042, 6, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2021, 7, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2042, 7, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2021, 8, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (2042, 8, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4041, 9, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4041, 10, null);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4041, 11, 2.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4041, 12, null);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4061, 12, null);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 14, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 13, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4061, 13, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4041, 14, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 15, 2.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 16, 2);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 17, null);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 19, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4061, 20, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4061, 21, 2);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 22, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4041, 22, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4061, 22, 2.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (4022, 23, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1045, 23, 1.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1061, 24, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1061, 25, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1050, 26, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1061, 26, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1061, 27, 3);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1045, 28, 2.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1050, 28, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1061, 29, 4);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1050, 30, 3.5);
INSERT INTO dbo.NotaEstudiante (IDCurso, IDEstudiante, Nota)
VALUES (1061, 30, 4);
GO