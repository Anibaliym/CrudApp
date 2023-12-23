create database Persona; 

create table if not exists public."Persona"
(
    "Id" uuid not null,
    "Rut" varchar(10) not null, 
    "Nombre" varchar(200) not null, 
    "ApellidoPaterno" varchar(200) , 
    "ApellidoMaterno" varchar(100)  not null, 
    "FechaNacimiento" timestamp  not null, 
    "Sexo" varchar(20) not null, 
    constraint persona_pk primary key ("Id")
); 

create table if not exists public."Contacto"
(
    "Id" uuid not null,
    "IdPersona" uuid not null, 
    "Celular" varchar(20) not null, 
    "Correo" varchar(200) , 
    "Direccion" varchar(100)  not null, 
    constraint Contacto_pk primary key ("Id")
); 

create table public."StoredEvent" (
	"Id" uuid NULL,
	"AggregateId" uuid NULL,
	"Data" text NOT NULL,
	"Action" varchar(100) NULL,
	"CreationDate" timestamp NULL,
	"User" text NOT NULL,
	CONSTRAINT storedevent_pk PRIMARY KEY ("Id")
);