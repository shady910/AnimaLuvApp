CREATE TABLE [dbo].[Outfit]
(
	[OutfitID] INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL, 
    [Price] SMALLMONEY NOT NULL,
	PRIMARY KEY CLUSTERED ([OutfitID] ASC)
)
