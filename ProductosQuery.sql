CREATE DATABASE ProductosTienda;

USE ProductosTienda;

DROP TABLE TipoProducto;
SELECT * FROM TipoProducto;
CREATE TABLE Productos (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(50) NOT NULL,
	Precio DECIMAL NOT NULL,
	IDTipo INT,
	IDProveedores int
	FOREIGN KEY (IDTipo) REFERENCES TipoProducto(ID),
	FOREIGN KEY (IDProveedores) REFERENCES Proveedores(ID)); 

CREATE TABLE TipoProducto (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(50));

CREATE TABLE Proveedores (
	ID INT PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(50));

INSERT INTO Productos (Nombre, Precio, IDTipo, IDProveedores)
	VALUES ('Coca 3 ltrs', 50, 1, 1),
			('Frijoles 1 kl', 17, 2, 2),
			('Mundet 3 ltrs', 45, 1, 1),
			('Azucar 1 kl', 50, 3, 3),
			('Agua de 1 lt', 15, 1, 4);

SELECT * FROM Productos;

Insert INTO TipoProducto (Nombre)
	VALUES ('Embotellados'),
			('Granos'),
			('Dulces')
 INSERT INTO Proveedores (Nombre)
	VALUES ('COCA'),
			('Frijolin'),
			('Caña'),
			('Bonafont')
SELECT * FROM Proveedores;
