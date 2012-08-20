﻿ALTER TABLE [dbo].[BlogRolls]  
	ADD CONSTRAINT [FK_BlogRolls_Languages] 
	FOREIGN KEY([LanguageId])
	REFERENCES [dbo].[Languages] ([LanguageId])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BlogRolls] CHECK CONSTRAINT [FK_BlogRolls_Languages]
GO