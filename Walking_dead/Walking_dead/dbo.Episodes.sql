CREATE TABLE [dbo].[Episodes] (
    [EpisodeID]  INT            IDENTITY (1, 1) NOT NULL,
    [Season]     INT            NOT NULL,
    [Episodes]   INT            NOT NULL,
    [Title]      NVARCHAR (MAX) NULL,
    [Date_Aired] NVARCHAR (MAX) NULL,
    [Plot]       NVARCHAR (MAX) NULL,
    [Review]   NVARCHAR(MAX)            NULL,
    [Complete] BIT NULL, 
    CONSTRAINT [PK_dbo.Episodes] PRIMARY KEY CLUSTERED ([EpisodeID] ASC)
);

