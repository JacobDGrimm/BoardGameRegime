CREATE TABLE [dbo].[Game]
(
	GameID int identity not null,
	GameTitle nvarchar(25) not null,
	GameLength int,
	GamePub int,
	GameDesigner int,
	MinNoOfPlayers int,
	MaxNoOfPlayers int,
	RecNoOfPlayers int,
	GameMechinisms int,
	GameTheme int,
	GameComplexity int,
	Constraint PK_Game Primary Key(GameID)
)
