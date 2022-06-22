USE [bd-modelo-sp]
GO
CREATE TABLE [dbo].[usuario](
[id] [int] IDENTITY(1,1) NOT NULL,
[nombre] [varchar](100) NOT NULL,
[edad] [int] NOT NULL
) ON [PRIMARY]
GO

SELECT * FROM usuario;

INSERT INTO usuario (nombre, edad) VALUES ('Laura', 25), ('Julian', 23), ('Florencia', 34);