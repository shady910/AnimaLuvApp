MERGE INTO Color AS Target 
USING (VALUES 
        (1, 'Red'), 
        (2, 'Orange'), 
        (3, 'Yellow'),
		(4, 'Green'),
		(5, 'Blue'),
		(6, 'Purple'),
		(7, 'Rainbow')
) 
AS Source (ColorID, Name) 
ON Target.ColorID = Source.ColorID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Name) 
VALUES (Name);

MERGE INTO Material AS Target
USING (VALUES 
        (1, 'Fleece', 1),
		(2, 'Felt', 0),
		(3, 'Cotton', 1),
		(4, 'Fur', 0)
)
AS Source (MaterialID, Name, BabySafe)
ON Target.MaterialID = Source.MaterialID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Name, BabySafe)
VALUES (Name, BabySafe);


MERGE INTO Outfit AS Target
USING (VALUES 
        (1, 'Cowboy', 15),
		(2, 'Ballerina', 10),
		(3, 'Astronaut', 15),
		(4, 'Clown', 10)
)
AS Source (OutfitID, Name, Price)
ON Target.OutfitID = Source.OutfitID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Name, Price)
VALUES (Name, Price);

MERGE INTO Size AS Target
USING (VALUES 
        (1, 'Small (6")'),
		(2, 'Medium (12")'),
		(3, 'Large (18")'),
		(4, 'Extra Large (24")')
)
AS Source (SizeID, Name)
ON Target.SizeID = Source.SizeID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Name)
VALUES (Name);

MERGE INTO Stuffing AS Target
USING (VALUES 
        (1, 'Pellets (Beanbag feel)', 0),
		(2, 'Polyester', 0),
		(3, 'Organic Cotton', 1),
		(4, 'Wool', 1),
		(5, 'Bamboo', 1)
)
AS Source (StuffingID, Name, BabySafe)
ON Target.StuffingID = Source.StuffingID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Name, BabySafe)
VALUES (Name, BabySafe);

MERGE INTO Animal AS Target
USING (VALUES 
        (1, 'Bear'),
		(2, 'Puppy'),
		(3, 'Kitty'),
		(4, 'Pony'),
		(5, 'Dragon')
)
AS Source (AnimalID, Name)
ON Target.AnimalID = Source.AnimalID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Name)
VALUES (Name);

MERGE INTO CustomOrder AS Target
USING (VALUES 
	(1, 'Sally', 5, 3, 5, 1, 3, 2, '2013-09-01') 
)
AS Source (CustomOrderID, Name, AnimalID, SizeID, ColorID, MaterialID, StuffingID, OutfitID, OrderDate)
ON Target.CustomOrderID = Source.CustomOrderID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Name, AnimalID, SizeID, ColorID, MaterialID, StuffingID, OutfitID, OrderDate)
VALUES (Name, AnimalID, SizeID, ColorID, MaterialID, StuffingID, OutfitID, OrderDate);
