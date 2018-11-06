/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
MERGE INTO Game AS TARGET
USING (VALUES
		(1, 'Risk', 90, 1, null, 2, 5, 4, null, null, null),
		(2, 'Monopoly', 90, 1, null, 2, 5, 5, null, null, null),
		(3, 'Twilight Imperium', 480, null, 3, 6, 6, null, null, null),
		(4, 'Love Letter', 20, null, 2, 4, 4, null, null),
		(5, 'The Campaign for North Africa', 60000, null, 8, 10, 10, null, null, null)
)
AS SOURCE (GameID, GameTitle, GameLength, GamePub, GameDesigner, MinNoOfPlayers, MaxNoOfPlayers, RecNoOfPlayers, GameMechinisms, GameTheme, GameComplexity)
ON Target.GameID = Source.GameID
WHEN NOT MATCHED BY TARGET THEN 
INSERT (GameTitle, GameLength, GamePub, GameDesigner, MinNoOfPlayers, MaxNoOfPlayers, RecNoOfPlayers, GameMechinisms, GameTheme, GameComplexity)
VALUES (GameTitle, GameLength, GamePub, GameDesigner, MinNoOfPlayers, MaxNoOfPlayers, RecNoOfPlayers, GameMechinisms, GameTheme, GameComplexity);