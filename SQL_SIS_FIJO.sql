--CREATE DATABASE PRUEBADEPORTE
--GO

--USE master

--USE PRUEBADEPORTE
--GO

-- TABLA QUE GUARDA TODOS LOS TIPOS DE DOCUMENTOS
-- https://www.normaslegalesonline.pe/imagenes/15/03/2018/1521132017925_R_196_2010_4.pdf
CREATE TABLE tbTipoDocumento(
	IDTipoDocumento INT IDENTITY(1,1) PRIMARY KEY,
	TipoDocumento VARCHAR (150) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1,
);
GO

CREATE TABLE tbPersona(
	IDPersona INT IDENTITY(1,1) PRIMARY KEY,
	Nombres VARCHAR (250) NOT NULL,
	ApellidoPaterno VARCHAR (250) NOT NULL,
	ApellidoMaterno VARCHAR (250) NOT NULL,
	IDTipoDocumento INT NOT NULL, --CLAVE FORANEA PARA LA TABLA tbTipoDocumento
	Documento VARCHAR (50) NOT NULL UNIQUE,
	FechaNacimiento DATE NOT NULL,
	Telefono VARCHAR (9) NULL,
	Correo VARCHAR(250) NOT NULL UNIQUE,
	Genero CHAR(1) CHECK (Genero IN ('M', 'F')),

	--REFERENCIAR LA CLAVE FORANEA CON LA CLAVE PRIMARIA DE LA TABLA tbTipoDocumento
	FOREIGN KEY (IDTipoDocumento) REFERENCES tbTipoDocumento(IDTipoDocumento)
);
GO

CREATE TABLE tbUsuario(
	IDUsuario INT IDENTITY(1,1) PRIMARY KEY,
	IDPersona INT NOT NULL, --CLAVE FORANEA PARA LA TABLA tbPersona
	NombreUsuario VARCHAR (50) NOT NULL,
	Clave VARCHAR (25) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1,

	--REFERENCIAR LA CLAVE FORANEA CON LA CLAVE PRIMARIA DE LA TABLA tbUsuario
	FOREIGN KEY (IDPersona) REFERENCES tbPersona(IDPersona)
);
GO


-- TABLA PARA LA CREACION DE UN EQUIPO
CREATE TABLE tbEquipo(
	IDEquipo INT IDENTITY(1,1) PRIMARY KEY,
	--idTorneo INT NOT NULL,
	IDCreador INT NOT NULL, -- USUARIO QUE CREA EL EQUIPO / CLAVE FORANEA PARA LA TABLA tbUsuario
	NombreEquipo VARCHAR(150) NOT NULL,
	Descripcion VARCHAR(250),
	FechaRegistro DATETIME DEFAULT GETDATE(),
	Estado BIT NOT NULL DEFAULT 1,

	--REFERENCIAR LA CLAVE FORANEA CON
	FOREIGN KEY (IDCreador) REFERENCES tbUsuario(IDUsuario)
);
GO 


-- TABLA QUE MUESTRA LOS INTEGRANTES DEL EQUIPO
CREATE TABLE tbEquipoIntegrante(
	IDIntegrante INT IDENTITY(1,1) PRIMARY KEY,
	IDEquipo INT NOT NULL,
	IDUsuario INT NOT NULL,
	Puesto VARCHAR(100),       -- Ej: "Delantero", "Base", "Portero"
	NumeroCamiseta INT,        -- Ej: 10, 23, etc.
	EsCapitan BIT DEFAULT 0,   -- El creador podría tener esto en 1
	FechaUnion DATETIME DEFAULT GETDATE(),
	Estado BIT DEFAULT 1,      -- 1=Activo, 0=Inactivo o expulsado
	FOREIGN KEY (IDEquipo) REFERENCES tbEquipo(IDEquipo),
	FOREIGN KEY (IDUsuario) REFERENCES tbUsuario(IDUsuario)
);
GO

-- TABLA DE INVITACIONES
CREATE TABLE tbInvitacionEquipo(
	idInvitacion INT IDENTITY(1,1) PRIMARY KEY,
	idEquipo INT NOT NULL,
	idUsuarioInvitado INT NOT NULL,
	idUsuarioEmisor INT NOT NULL,  -- EL QUE ENVIA LA INVITACION (CREADOR DE EQUIPO)
	FechaInvitacion DATETIME DEFAULT GETDATE(),
	EstadoInvitacion VARCHAR(20) DEFAULT 'Pendiente' 
		-- 'Pendiente', 'Aceptada', 'Rechazada'
	,
	FOREIGN KEY (idEquipo) REFERENCES tbEquipo(idEquipo),
	FOREIGN KEY (idUsuarioInvitado) REFERENCES tbUsuario(idUsuario),
	FOREIGN KEY (idUsuarioEmisor) REFERENCES tbUsuario(idUsuario)
);
GO

SELECT * FROM tbInvitacionEquipo


-- INSERTAR REGISTROS A LA TABLA tbTipoDocumento
INSERT INTO tbTipoDocumento (TipoDocumento)
VALUES 
('DNI'),
('Carnet de Extranjería'),
('Pasaporte');
GO



SELECT * FROM tbUsuario
SELECT * FROM tbPersona
SELECT * FROM tbEquipo
