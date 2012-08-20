﻿CREATE TABLE [dbo].[BlogPosts] (
	[BlogPostId] INT IDENTITY NOT NULL,
	[LanguageId] INT NOT NULL,
	[SecondaryId] INT NULL,
	[Title] NVARCHAR(300) NOT NULL,
	[BriefInfo] NVARCHAR(200) NULL,
	[Content] NVARCHAR(MAX) NOT NULL,
	[ImagePath] NVARCHAR(300) NULL,
	[IsApproved] BIT NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
	[LastUpdateIp] NVARCHAR(50) NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
    CONSTRAINT [PK_BlogPosts] PRIMARY KEY ([BlogPostId])
);