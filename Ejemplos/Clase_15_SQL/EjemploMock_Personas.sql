-- CREATE DATABASE
CREATE DATABASE DB_PRUEBA;

-- USE DATABASE
USE DB_PRUEBA;

-- CREATE TABLE
CREATE TABLE Personas
(id int identity primary key,
nombre varchar(50) not null,
apellido varchar(50) not null,
fechaNacimiento date not null,
idDireccion int not null);

-- INSERT
INSERT INTO Personas (nombre, apellido, fechaNacimiento, idDireccion)
VALUES ('Ale', 'Bongio', '1987-05-30', 1);

INSERT INTO Personas (nombre, apellido, fechaNacimiento, idDireccion)
VALUES ('Pepe', 'Perez', '1988-06-20', 2);

-- SELECT
SELECT * FROM Personas;

SELECT nombre, apellido FROM Personas;

-- WHERE
SELECT * FROM Personas WHERE id = 1;

SELECT * FROM Personas WHERE fechaNacimiento < '1988-01-01';

-- INSERT MOCK DATA
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Ilaire', 'Margaritelli', '1968-10-24 21:31:46', 6031);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Cordelie', 'Chirm', '1950-05-26 08:10:47', 3983);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Andromache', 'McCarlich', '1989-08-13 07:15:39', 7841);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Ted', 'Blight', '1959-05-29 10:14:04', 3873);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Anstice', 'O''Corr', '1987-11-20 08:00:15', 9218);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Noell', 'Bourley', '1955-02-27 13:47:02', 129);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Jermaine', 'Bader', '1942-02-27 16:07:16', 3393);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Mariya', 'Conochie', '1980-12-26 13:06:39', 246);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Lilia', 'Jenks', '2002-03-20 15:08:33', 5790);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Bentley', 'Ivanusyev', '1985-02-01 15:10:56', 7260);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Anneliese', 'Drews', '1968-07-30 05:26:22', 1011);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Renato', 'Held', '1974-05-02 22:02:19', 3687);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Ravi', 'Tortoise', '1998-11-07 02:09:52', 4012);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Kerstin', 'Queyos', '1954-09-22 05:15:16', 5775);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Benita', 'Peers', '1991-05-29 12:34:47', 9577);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Lea', 'Fothergill', '1954-02-06 00:54:50', 8781);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Selina', 'Yandle', '1966-06-05 07:10:28', 3848);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Aurelie', 'Pagon', '1987-03-15 15:58:24', 1885);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Herby', 'Cutsforth', '1969-07-12 20:14:10', 2931);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Koressa', 'Boydle', '1968-09-09 02:22:43', 4720);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Augie', 'Sollars', '1942-09-29 19:20:09', 1136);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Olivero', 'Fripp', '1944-03-12 23:46:34', 8665);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Elsworth', 'Pote', '1994-01-03 06:38:44', 2496);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Woodman', 'Moulding', '1982-10-05 07:54:03', 3034);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Lesley', 'Pickles', '2003-03-31 10:56:44', 9742);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Charita', 'Huckel', '2004-01-11 05:10:24', 3999);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Aldis', 'Staniford', '1948-04-02 00:55:26', 5683);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Judon', 'Nezey', '1959-03-18 16:56:02', 7725);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Godard', 'Bernardoux', '1950-10-22 06:21:11', 126);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Celestyn', 'Purveys', '1993-01-17 08:55:28', 6702);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Cary', 'Weatherburn', '1953-02-21 03:24:18', 9072);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Brynne', 'Marlin', '1988-03-16 16:23:02', 1243);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Oswell', 'Lambdin', '1986-04-19 20:21:33', 2316);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Lynnette', 'Horche', '1967-09-09 10:57:36', 2554);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Annie', 'Creaney', '1952-02-23 08:08:54', 9006);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Adriana', 'Ewing', '1941-06-16 01:46:31', 1510);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Stephanie', 'Sargeant', '1958-10-03 11:54:15', 4236);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Cort', 'Cortes', '1944-07-13 11:45:36', 8545);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Nesta', 'L''Hommee', '1949-09-27 22:19:30', 9361);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Patrice', 'Hiland', '1992-04-29 14:13:46', 6778);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Prinz', 'Stronge', '2001-02-08 23:39:02', 8672);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Rebeka', 'Jaye', '1940-11-30 18:03:51', 3715);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Myron', 'Hush', '1979-07-09 03:44:23', 2073);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Hillery', 'Font', '2003-02-10 11:55:07', 6161);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Ashli', 'Mercy', '1990-02-16 02:35:22', 9031);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Cornelle', 'Mapes', '1971-06-08 12:41:27', 289);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Starla', 'Rosita', '1997-12-23 13:22:19', 1815);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Patin', 'Hawler', '1940-02-24 18:50:20', 4502);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Minda', 'Prall', '1940-05-21 23:09:17', 3078);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Biddie', 'Locard', '1961-12-25 00:11:44', 89);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Amby', 'Turrill', '1984-09-18 22:09:38', 296);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Parker', 'Wakenshaw', '1943-10-26 13:42:54', 359);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Pam', 'Tew', '1958-10-05 00:37:33', 6651);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Ansley', 'Hathorn', '1996-12-05 05:34:31', 8278);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Lisette', 'Matejic', '1967-12-14 05:51:18', 8673);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Bancroft', 'Kaliszewski', '1999-08-01 18:25:15', 8636);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Evita', 'Kuhnel', '1949-05-05 21:01:28', 2421);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Haydon', 'Limpkin', '1965-11-13 08:37:37', 3276);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Erhart', 'Arend', '1943-07-11 06:04:25', 1213);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Mada', 'Clougher', '1995-10-01 20:03:47', 4756);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Elspeth', 'Batteson', '1992-11-12 00:13:05', 5930);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Iver', 'Rozet', '2003-09-08 19:15:23', 6727);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Suzie', 'Marfe', '1995-09-27 00:14:00', 3520);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Marcelle', 'Ollett', '1970-11-28 11:09:23', 8420);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Kally', 'Noah', '1964-10-11 06:09:10', 6962);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Alleen', 'Bennetts', '1991-11-08 08:47:53', 4839);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Moise', 'MacConnal', '2002-01-12 18:20:52', 7257);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Jeri', 'Toffalo', '1974-07-26 23:20:01', 1141);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Hildy', 'Bordis', '1964-11-29 04:48:11', 2689);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Martica', 'Bouskill', '1966-09-19 07:34:24', 3948);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Stevena', 'Leivers', '1947-06-11 09:15:20', 6392);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Daria', 'Blaze', '1956-02-07 22:02:34', 744);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Gareth', 'Poyntz', '2000-05-10 12:00:26', 7664);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Gloriana', 'Look', '1983-03-18 05:17:16', 2772);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Germana', 'Maunders', '2003-10-21 05:58:45', 5138);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Maureen', 'Goodram', '1954-11-10 04:14:27', 3985);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Trip', 'Leeves', '1978-03-06 15:19:32', 2370);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Errol', 'Bouts', '1963-01-01 14:00:24', 5990);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Hubert', 'Ickovic', '1979-11-13 16:31:15', 5743);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Patricio', 'Kolodziejski', '1992-01-14 10:08:01', 1372);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Orland', 'Gurrado', '1974-03-06 19:00:08', 411);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Danila', 'Redsull', '1950-02-11 20:09:27', 4515);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Glenna', 'Escalera', '1995-05-15 09:55:12', 3935);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Starla', 'Cleere', '1945-10-17 02:52:28', 1154);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Clarine', 'Bullivent', '1961-11-10 13:49:06', 5426);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Justus', 'Cordy', '1975-10-13 22:56:45', 1718);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Deeann', 'Giotto', '1945-12-16 10:03:28', 450);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Lyn', 'Tongs', '1973-06-20 23:13:50', 4829);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Querida', 'Halpin', '1962-09-29 20:36:26', 3938);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Deidre', 'Fullager', '1975-05-21 00:10:22', 1221);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Carver', 'Gasson', '1976-03-10 15:30:26', 6985);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Rowe', 'Catmull', '1949-03-18 22:35:06', 1230);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Livia', 'Rustadge', '1951-01-15 04:03:41', 1101);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Berni', 'Mawne', '1949-05-15 22:14:41', 6782);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Prudi', 'Gribble', '1989-07-25 11:41:48', 7427);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Beatrix', 'Nisbith', '1953-05-21 03:07:29', 3923);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Lorilee', 'Ackery', '1965-08-19 13:06:54', 8244);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Abram', 'Iacomini', '1944-04-08 12:43:58', 9145);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Shandeigh', 'Forshaw', '1996-05-13 21:30:43', 3347);
insert into Personas (nombre, apellido, fechaNacimiento, idDireccion) values ('Amelita', 'St. Paul', '1954-03-18 18:30:47', 6759);

-- SELECT %
SELECT * FROM Personas;

SELECT * FROM Personas WHERE nombre LIKE 'K%a';

SELECT * FROM Personas WHERE nombre LIKE 'M%';

SELECT * FROM Personas WHERE nombre LIKE 'A%' AND apellido LIKE 'B%';

-- ORDER BY, BEETWEEN, IN
SELECT * FROM Personas WHERE fechaNacimiento > '2001-01-01' ORDER BY fechaNacimiento;

SELECT * FROM Personas WHERE fechaNacimiento BETWEEN '1990-01-01' AND '1999-12-31' 
ORDER BY fechaNacimiento DESC;

SELECT nombre, apellido, idDireccion FROM Personas 
WHERE idDireccion IN (89, 6759, 1718, 450, 455, 1234, 963) ORDER BY idDireccion DESC;

-- COUNT 
SELECT COUNT(DISTINCT nombre) AS contador FROM Personas;

-- TOP 
SELECT TOP(5) nombre, apellido, idDireccion FROM Personas ORDER BY idDireccion DESC;




