USE [concesionaria]
GO
/****** Object:  Table [dbo].[autos]    Script Date: 10/8/2021 11:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autos](
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[kms] [int] NOT NULL,
	[color] [varchar](50) NOT NULL,
	[patente] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
