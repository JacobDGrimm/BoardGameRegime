CREATE TABLE [dbo].[GameLength]
(
	GameLength int not null,
	TimeKey int identity not null, 
    CONSTRAINT [PK_GameLength] PRIMARY KEY ([TimeKey])  
)
