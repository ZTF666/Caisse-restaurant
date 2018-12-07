--------------------------------------------------------------
--
-- This installation script creates the MyComics database
-- and the Comics table. It also inserts several records into
-- the Comics table.
--
--------------------------------------------------------------

CREATE DATABASE rest
GO

USE rest
GO

CREATE TABLE sandwiches (
	[ID] [int] IDENTITY (1000, 1) NOT NULL PRIMARY KEY,
	[Image] [varbinary(max)] NOT NULL ,
	[Nom] [varchar(max)] (32) NOT NULL ,
	[prix] [float] NOT NULL
)
GO


