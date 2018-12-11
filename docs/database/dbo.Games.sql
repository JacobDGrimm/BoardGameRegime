CREATE TABLE [dbo].[Games] (
    [Title]      NVARCHAR (128) NOT NULL,
    [GameLength] INT            NOT NULL,
    [Publisher]  NVARCHAR (MAX) NULL,
    [Designer]   NVARCHAR (MAX) NULL,
    [MinPlayer]  INT            NOT NULL,
    [MaxPlayer]  INT            NOT NULL,
    [RecPlayer]  INT            NOT NULL,
    [Mechanism]  NVARCHAR (MAX) NULL,
    [Theme]      NVARCHAR (MAX) NULL,
    [Complexity] INT            NULL,
    CONSTRAINT [PK_dbo.Games] PRIMARY KEY CLUSTERED ([Title] ASC)
);

