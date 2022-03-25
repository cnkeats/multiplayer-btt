CREATE PROCEDURE dbo.Entry_Insert
	@character1 INT,
	@character2 INT,
	@character3 INT,
	@character4 INT,
	@player1Id INT,
	@player2Id INT,
	@player3Id INT,
	@player4Id INT,
	@stage INT,
	@frames INT,
	@targetsRemaining INT,
	@dateRun DATETIME,
	@platform VARCHAR(64),
	@videoURL VARCHAR(64),
	@verified BIT,
	@created DATETIME,
	@updated DATETIME,
	@deleted DATETIME

AS

INSERT INTO
	Entry
	(
		Character1,
		Character2,
		Character3,
		Character4,
		Player1Id,
		Player2Id,
		Player3Id,
		Player4Id,
		Stage,
		Frames,
		TargetsRemaining,
		DateRun,
		Platform,
		VideoURL,
		Verified,
		Created,
		Updated,
		Deleted		
	)
OUTPUT
	inserted.Id
VALUES
	(
		@character1,
		@character2,
		@character3,
		@character4,
		@player1Id,
		@player2Id,
		@player3Id,
		@player4Id,
		@stage,
		@frames,
		@targetsRemaining,
		@dateRun,
		@platform,
		@videoURL,
		@verified,
		@created,
		@updated,
		@deleted
	)