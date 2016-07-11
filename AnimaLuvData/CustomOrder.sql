CREATE TABLE [dbo].[CustomOrder] (
    [CustomOrderID] INT IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR(50) NOT NULL,
    [AnimalID]     INT NOT NULL,
    [SizeID]    INT NOT NULL,
    [ColorID] INT NOT NULL, 
    [MaterialID] INT NOT NULL, 
    [StuffingID] INT NOT NULL, 
    [OutfitID] INT NOT NULL, 
    [OrderDate] DATETIME NOT NULL, 
    PRIMARY KEY CLUSTERED ([CustomOrderID] ASC),
    CONSTRAINT [FK_dbo.CustomOrder_dbo.Animal_AnimalID] FOREIGN KEY ([AnimalID]) 
        REFERENCES [dbo].[Animal] ([AnimalID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.CustomOrder_dbo.Size_SizeID] FOREIGN KEY ([SizeID]) 
        REFERENCES [dbo].[Size] ([SizeID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.CustomOrder_dbo.Color_ColorID] FOREIGN KEY ([ColorID])
		REFERENCES [dbo].[Color] ([ColorID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.CustomOrder_dbo.Material_MaterialID] FOREIGN KEY ([MaterialID]) 
        REFERENCES [dbo].[Material] ([MaterialID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.CustomOrder_dbo.Stuffing_StuffingID] FOREIGN KEY ([StuffingID]) 
        REFERENCES [dbo].[Stuffing] ([StuffingID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.CustomOrder_dbo.Outfit_OutfitID] FOREIGN KEY ([OutfitID])
		REFERENCES [dbo].[Outfit] ([OutfitID]) ON DELETE CASCADE,

)
