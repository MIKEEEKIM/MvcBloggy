﻿CREATE TABLE [dbo].[Tags] (

	[TagId] INT IDENTITY NOT NULL, 
	[BlogPostId] INT NOT NULL,
    [TagName] NVARCHAR(50) NOT NULL,  
    CONSTRAINT [PK_Tags] PRIMARY KEY ([TagId])
)