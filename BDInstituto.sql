--Administradores = (idAdministrador, Usuario, Contraseña, Nombre, Apellido, Dni, Telefono, Estado)
create table Administradores(
	IdAdministrador int not null identity(10,10),
	Usuario varchar(20) not null,
	Contraseña varchar(20) not null,
	Nombre varchar(30) not null,
	Apellido varchar(30) not null,
	Dni varchar(8) not null,
	Telefono varchar(30) null,
	Estado bit not null,
	constraint PK_ID_ADMINISTRADOR primary key (IdAdministrador)
)
--drop table Administradores;

--Alumnos = (idAlumno, Dni, Nombre, Apellido, Direccion, Telefono, Email, Estado, Contraseña)
create table Alumnos(
	IdAlumno int not null identity(10,10),
	Contraseña varchar(20) not null,
	Nombre varchar(30) not null,
	Apellido varchar(30) not null,
	Dni varchar(8) not null,
	Telefono varchar(30) null,
	Estado bit not null,
	Direccion varchar(30) not null,
	Email varchar(30) null
	constraint PK_ID_ALUMNO primary key (IdAlumno)
)
--drop table Alumnos;

--Cursos = (IdCurso, Nombre, FechaInicio, FechaFin, Descripcion, Estado, Precio)
create table Cursos(
	IdCurso int not null identity(10,10),
	Nombre varchar(30) not null,
	FechaInicio datetime not null,
	FechaFin datetime not null,
	Descripcion varchar(30) not null,
	Estado bit not null,
	Precio decimal(18,2),
	constraint PK_ID_CURSO primary key(IdCurso)
)
--drop table Cursos;


--Profesores = (IdProfesor, Nombre, Apellido, Dni, Telefono, Contraseña, Estado, Direccion, Email)
create table Profesores(
	IdProfesor int not null identity(10,10),
	Nombre varchar(30) not null,
	Apellido varchar(30) not null,
	Dni varchar(8) not null,
	Telefono varchar(30) null,
	Contraseña varchar(10) not null,
	Estado bit not null,
	Direccion varchar(30) null,
	Email varchar(30) null,
	constraint PK_ID_PROFESOR primary key(IdProfesor)
)
--drop table Profesores;

--Nota = (IdAlumno, IdCurso, Nota, Fecha, Estado)
create table Nota(
	IdAlumno int not null,
	IdCurso int not null,
	Nota decimal (9,2) not null,
	Fecha datetime not null,
	Estado bit not null,
	constraint FK_NOTA_ID_ALUMNO FOREIGN KEY (IdAlumno) references Alumnos(IdAlumno),
	constraint FK_NOTA_ID_CURSO foreign key (IdCurso) references Cursos(IdCurso)
)
--drop table Nota;

--Dicta = (IdProfesor, IdCurso)
create table Dicta(
	IdProfesor int not null,
	IdCurso int not null,
	constraint FK_DICTA_ID_PROFESOR foreign key (IdProfesor) references Profesores(IdProfesor),
	constraint FK_DICTA_ID_CURSO foreign key (IdCurso) references Cursos(IdCurso)
)
--drop table Dicta;

--Cuota = (IdCuota, IdAlumno, IdCurso, Fecha)
create table Cuota(
	IdCuota int not null identity(10,10),
	IdAlumno int not null,
	IdCurso int not null,
	Fecha datetime,
	constraint PK_ID_CUOTA primary key(IdCuota),
	constraint FK_CUOTA_ID_ALUMNO foreign key (IdAlumno) references Alumnos(IdAlumno),
	constraint FK_CUOTA_ID_CURSO foreign key (IdCurso) references Cursos(IdCurso)
) 
--drop table Cuota;

--Asiste = (NroInscripcion, IdAdministrador, IdCurso, IdAlumno, Estado)
 create table Asiste(
	NroInscripcion int not null,
	IdAdministrador int not null,
	IdCurso int not null,
	IdAlumno int not null,
	Estado bit not null,
	constraint FK_ASISTE_ID_ADMINISTRADOR foreign key (IdAdministrador) references Administradores(IdAdministrador),
	constraint FK_ASISTE_ID_CURSO foreign key (IdCurso) references Cursos(IdCurso),
	constraint FK_ASISTE_ID_ALUMNO foreign key (IdAlumno) references Alumnos(IdAlumno)
 )
--drop table Asiste;

 SELECT *
 FROM Profesores;

 INSERT INTO Administradores VALUES('gon','gon','gonzalo','podesta',37599841,'2664010989', 1);

 INSERT INTO Alumnos VALUES('mario', 'mario', 'mario', '37599332', 2022323, 1, 'avenida', 'ggpq@wqwqw.com');

 INSERT INTO Profesores VALUES('pablo', 'pablo', '32455321', '23232323', 'pablo', 1, 'villa mercedes', 'pablo@hotmail.com');

 update Profesores 
 set Nombre = 'pablo', Apellido = 'pablo', Dni ='32455321', Telefono = '23232323', Contraseña = '', Estado = '1', Direccion = 'villa mercedes', Email = 'pablo@hotmail.com'
 where IdProfesor = 20;

 INSERT INTO Alumnos VALUES('232we32232','wew','wew','23232232','2323','1','wew','ew')




SELECT * 
FROM Alumnos 
WHERE FechaInicio >= '2015/01/01' AND FechaFin <= '2016/01/01';