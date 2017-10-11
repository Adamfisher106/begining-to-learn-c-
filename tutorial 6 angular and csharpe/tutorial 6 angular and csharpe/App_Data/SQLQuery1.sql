CREATE TABLE [dbo].[TblUser] (
	[Id]	INT		IDENTITY (1, 1) NOT NULL,
	[FirstName] NVARCHAR (250) NULL,
	[LastName] NVARCHAR (250) Null,
	[Gender] NVARCHAR (250) Null,
	PRIMARY KEY CLUSTERED ([Id] ASC)
);