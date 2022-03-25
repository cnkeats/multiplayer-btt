CREATE PROCEDURE Entry_GetById
	@id INT

AS

SELECT
	Id,
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
	Verified
	Created,
	Updated,
	Deleted	
FROM
	Entry WITH (NOLOCK)
WHERE
	Id = @id