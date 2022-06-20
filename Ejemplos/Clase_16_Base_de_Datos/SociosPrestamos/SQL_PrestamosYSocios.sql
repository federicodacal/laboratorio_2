USE PRUEBA_BIBLIOTECA;

INSERT INTO Socios (nombre, dni) 
VALUES ('Juan', 12341234),
('Pedro', 52341235),
('Pablo', 42341236),
('Jose', 32341237),
('Jorge', 22341238);

SELECT * FROM Socios;

INSERT INTO Prestamos (id, descripcion, dni_socio)
VALUES (1, 'Libro 1', 12341234),
(2, 'Libro 2', 52341235),
(3, 'Libro 3', 12341234),
(4, 'Libro 4', 22341238),
(5, 'Libro 5', 12341234),
(6, 'Libro 6', 22341238);

SELECT * FROM Prestamos;

SELECT * FROM Prestamos p 
INNER JOIN Socios s ON p.dni_socio = s.dni;

