CREATE TABLE [dbo].[Animal]
(
	[AnimalID] INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL
	PRIMARY KEY CLUSTERED ([AnimalID] ASC)
)