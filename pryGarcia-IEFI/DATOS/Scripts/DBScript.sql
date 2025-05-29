IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'GestionRRHH')
BEGIN
    CREATE DATABASE GestionRRHH;
END
GO

USE GestionRRHH;
GO

IF OBJECT_ID('Usuarios', 'U') IS NULL
BEGIN
    CREATE TABLE Usuarios (
        IdUsuario INT IDENTITY PRIMARY KEY,
        Nombre NVARCHAR(50),
        Apellido NVARCHAR(50),
	Dni NVARCHAR (50),
        Contraseña NVARCHAR(50),
        Area NVARCHAR(50),
        Activo BIT
    );
END
GO

IF OBJECT_ID('Auditorias', 'U') IS NULL
BEGIN
    CREATE TABLE Auditorias (
        IdAuditoria INT IDENTITY PRIMARY KEY,
        Fecha DATETIME,
        TiempoUso NVARCHAR(50),
        IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario)
    );
END
GO