﻿create table Retenciones(
RetencionId int identity(1,1) primary key,
Descripcion varchar(100),
Valor float
);

create table TiposEmails(
TipoId int identity(1,1) primary key,
Descripcion varchar(125)
);

create table Empleados(
EmpleadoId int identity(1,1) primary key,
Nombres varchar(125),
FechaNacimiento date,
Sueldo float,
RetencionId int
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