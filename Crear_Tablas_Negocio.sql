CREATE DATABASE Negocio
GO

USE Negocio
GO

CREATE TABLE Producto (
	Id BIGINT IDENTITY(1, 1) PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	Precio FLOAT NOT NULL,
	Categoria_ID BIGINT NOT NULL,
	CONSTRAINT FK_ProductoCategoria FOREIGN KEY (Categoria_ID) REFERENCES Categoria(Id)
)

CREATE TABLE Categoria (
	Id BIGINT IDENTITY(1, 1) PRIMARY KEY,
	Nombre VARCHAR(100)
)

INSERT INTO Categoria (Nombre) Values ('Lacteos');
INSERT INTO Producto (Nombre, Precio, Categoria_ID) Values ('Mr. Musculo', 1000, 1);

SELECT * FROM Producto;

