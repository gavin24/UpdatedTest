CREATE TABLE [dbo].[MenuItem] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [ParentId]     INT           NULL,
    [ItemOrder]    INT           NULL,
    [Title]        VARCHAR (MAX) NULL,
    [DateCreated]  DATETIME      NULL,
    [DateModified] DATETIME      NULL,
    [Enabled]      BIT           NULL,
    [URL]          VARCHAR (MAX) NULL,
    [ItemLevel]    INT           NULL,
    [TopLevelNode] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

