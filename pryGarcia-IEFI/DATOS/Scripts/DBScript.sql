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
	FechaNacimiento DATE NULL,
        Celular NVARCHAR(20) NULL,
        Contraseña NVARCHAR(50),
        Area NVARCHAR(50),
        Activo BIT,
	NombreUsuario NVARCHAR (50),
	CambiarContraseña BIT NOT NULL DEFAULT 0
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

IF NOT EXISTS (
    SELECT 1 FROM Usuarios WHERE NombreUsuario = 'EzequielGarcia98'
)
BEGIN
    INSERT INTO Usuarios (
        Nombre, Apellido, Dni, FechaNacimiento, Celular, Contraseña, Area, Activo, NombreUsuario,
         CambiarContraseña
    )
    VALUES (
        'Ezequiel', 'Garcia', '41625200', '1998-03-10', '156334901', '3402', 'RRHH', 1, 'EzequielGarcia98',
         1
    );
END
GO