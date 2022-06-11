USE Buffet_UTN;

SELECT * FROM Proveedores;

INSERT INTO Proveedores (Nombre, Domicilio, Localidad)
VALUES ('Perez', 'Llavalle 876', 'Quilmes'),
('Gimenez', 'Mitre 750', 'Avellaneda'),
('Aguirre', 'Boedo 634', 'Bernal');

SELECT * FROM Productos;

INSERT INTO Productos (Nombre, Precio, Dimensiones)
VALUES ('Caramelos', 1.5, 'Chico'),
('Alfajores', 45.89, 'Mediano'),
('Gaseosa', 15.80, 'Grande');

SELECT * FROM Envios;

INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad)
VALUES (100, 1, 500),
(100, 2, 1500),
(100, 3, 100),
(101, 2, 55),
(101, 3, 225),
(102, 1, 600),
(102, 3, 300);

-- Consultas 

-- i 
SELECT * FROM Productos ORDER BY Nombre;

-- ii
SELECT * FROM Proveedores WHERE Localidad = 'Quilmes';

-- iii
SELECT * FROM Envios WHERE Cantidad BETWEEN 200 AND 300;

-- iv 
SELECT COUNT(*) as 'Total Envios' FROM Envios;

-- v
SELECT TOP(3) Codigo_Producto FROM Envios; 

-- vi
SELECT prov.Nombre, prod.Nombre FROM Envios env 
INNER JOIN Productos prod ON env.Codigo_Producto = prod.Codigo_Producto 
INNER JOIN Proveedores prov ON env.Numero_Proveedor = prov.Numero_Proveedor;
 
 -- vii
 SELECT e.Cantidad, p.Precio, e.Cantidad * p.Precio as 'Monto' FROM Envios e 
 INNER JOIN Productos p ON e.Codigo_Producto = p.Codigo_Producto;

 -- viii
SELECT Domicilio, Localidad, Nombre FROM Proveedores WHERE Nombre LIKE '%I%';

-- Comandos

-- i 
INSERT INTO Productos (Nombre, Precio, Dimensiones)
VALUES ('Chocolate', 25.35, 'Chico');

-- ii
UPDATE Productos SET Precio = 97.5 WHERE Dimensiones = 'Grande';

-- iii
DELETE From Productos WHERE Codigo_Producto = 1;