INSERT INTO USUARIOS (NOMBRE) VALUES ('Lucas');
INSERT INTO USUARIOS (NOMBRE) VALUES ('Lautaro');
INSERT INTO USUARIOS (NOMBRE) VALUES ('Mauricio');

SELECT * FROM Usuarios;

SELECT n.tema, n.contenido, u.nombre FROM Novedades n
INNER JOIN Usuarios u ON n.id_usuario = u.id;