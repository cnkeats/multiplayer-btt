CREATE TABLE dbo.Entry (
	Id INT IDENTITY (1, 1) NOT NULL,
	Character1	INT NOT NULL FOREIGN KEY REFERENCES Character(Id),
	Character2	INT NULL,
	Character3	INT NULL,
	Character4	INT NULL,
	Player1Id INT NOT NULL,
	Player2Id INT NULL,
	Player3Id INT NULL,
	Player4Id INT NULL,
	Stage INT NOT NULL,
	Frames INT NOT NULL,
	TargetsRemaining INT NOT NULL,
	DateRun DATETIME NULL,
	[Platform] VARCHAR(64) NULL,
	VideoURL VARCHAR(64) NULL,
	Verified BIT NULL,
	Created	DATETIME NOT NULL,
	Updated	DATETIME NULL,
	Deleted	DATETIME NULL,
PRIMARY KEY CLUSTERED (Id ASC)
);