﻿CREATE TABLE [dbo].[Languages] (
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[DisplayName] NVARCHAR (50) NULL,
	[Culture] NVARCHAR (10) NOT NULL,
	[CultureOne] NVARCHAR (10) NOT NULL,
	[Order] INT NOT NULL,
	[IsApproved] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_Languages] PRIMARY KEY ([Id])
);