CREATE TABLE [dbo].[Stuffing]
(
	[StuffingID] INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL
	PRIMARY KEY CLUSTERED ([StuffingID] ASC), 
    [BabySafe] BIT NULL
)