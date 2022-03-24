﻿CREATE TABLE dbo.Entry (
	Id INT IDENTITY (1, 1) NOT NULL,
	Character1	INT NOT NULL FOREIGN KEY REFERENCES Character(Id),
	Character2	INT NULL FOREIGN KEY REFERENCES Character(Id),
	Character3	INT NULL FOREIGN KEY REFERENCES Character(Id),
	Character4	INT NULL FOREIGN KEY REFERENCES Character(Id),
	[Player1Id] INT NOT NULL FOREIGN KEY REFERENCES Player(Id),
	[Player2Id] INT NULL FOREIGN KEY REFERENCES Player(Id),
	[Player3Id] INT NULL FOREIGN KEY REFERENCES Player(Id),
	[Player4Id] INT NULL FOREIGN KEY REFERENCES Player(Id),
	Stage INT NOT NULL FOREIGN KEY REFERENCES Stage(Id),
	Frames INT NOT NULL,
	TargetsRemaining INT NOT NULL,
	DateRun DATETIME NULL,
	[Platform] VARCHAR(64) NULL,
	VideoURL VARCHAR(64) NULL,
	Verified BIT NOT NULL,
	Created	DATETIME NOT NULL,
	Updated	DATETIME NULL,
	Deleted	DATETIME NULL,
PRIMARY KEY CLUSTERED (Id ASC)
);