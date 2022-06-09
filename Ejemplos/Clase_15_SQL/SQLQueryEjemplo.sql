/* 
CONSULTAS:

SELECT --> SELECCIONAR CAMPOS DESDE TABLAS DE LA BD
INSERT --> AGREGAR REGISTROS A TABLAS DE LA BD
UPDATE --> MODIFICAR REGISTROS DE TABLAS DE LA BD
DELETE --> BORRAR REGISTROS DE TABLAS DE LA BD


*/


/*
CONSULTAS DE SELECCIÓN
*/

-- SELECT campo_1, campo_2, campo_3, ..., campo_n 
-- FROM base.dueño.tabla

-- SELECT *
-- FROM tabla

-- SELECT campo_1, campo_2, campo_3, ..., campo_n 
-- FROM tabla
-- WHERE condición

-- SELECT *
-- FROM tabla
-- WHERE condición op_lógico condición 

-- SELECT *
-- FROM tabla
-- ORDER BY campo orden

-- SELECT *
-- FROM tabla
-- WHERE campo LIKE 'condición'



SELECT id, nombre, apellido, edad
FROM padron.dbo.personas

SELECT *
FROM personas

SELECT id, nombre, apellido, edad
FROM personas
WHERE edad > 25

SELECT *
FROM personas
WHERE id > 10 AND edad >= 51

SELECT *
FROM personas
ORDER BY edad ASC

SELECT *
FROM personas
WHERE apellido LIKE 'herrero'

SELECT *
FROM personas
WHERE apellido LIKE 'P%'

SELECT *
FROM personas
WHERE apellido LIKE '%S'

SELECT *
FROM personas
WHERE apellido LIKE '%A%'


/*
CONSULTAS DE INSERCIÓN
*/

-- INSERT INTO tabla (campo_1, campo_2, campo_3, ..., campo_n)
-- VALUES (valor_1, valor_2, valor_3, ..., valor_n)

-- INSERT INTO tabla
-- VALUES (valor_1, valor_2, valor_3, ..., valor_n)


INSERT INTO personas (nombre, apellido, edad)
VALUES ('nombre_nuevo', 'apellido_nuevo', 28)


/*
CONSULTAS DE MODIFICACIÓN
*/

-- UPDATE tabla
-- SET campo_1 = valor_1, campo_2 = valor_2, campo_3 = valor_3, ..., campo_n = valor_n
-- WHERE condición


UPDATE personas
SET nombre = 'Estebancito', apellido = 'Maravilla', edad = 90
WHERE id = 23


/*
CONSULTAS DE ELIMINACIÓN
*/

-- DELETE FROM tabla
-- WHERE condición


DELETE FROM personas
WHERE id = 23


