create table Retenciones(
RetencionId int identity(1,1) primary key,
Descripcion varchar(100),
Valor float
);

create table TiposEmail(
TipoId int identity(1,1) primary key,
Descripcion varchar(100)
);

create table Empleados(
EmpleadoId int identity(1,1) primary key,
Nombres varchar(100),
FechaNacimiento date,
Sueldo float
);

create table EmpleadosRetenciones(
EmpleadoDescuentoId int identity(1,1) primary key,
EmpleadoId int,
RetencionId int
);

create table EmpleadosEmails(
EmpleadoEmailId int identity(1,1) primary key,
EmpleadoId int,
TipoId int,
Email varchar(125)
);