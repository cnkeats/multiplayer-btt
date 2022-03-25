CREATE PROCEDURE Entry_GetList

AS

SELECT TOP 20
	Entry.Id,
	Entry.Character1,
	Entry.Character2,
	Entry.Character3,
	Entry.Character4,
	Entry.Player1Id,
	Entry.Player2Id,
	Entry.Player3Id,
	Entry.Player4Id,
	Entry.Stage,
	Entry.Frames,
	Entry.TargetsRemaining,
	Entry.DateRun,
	Entry.Platform,
	Entry.VideoURL,
	Entry.Verified,
	Entry.Created,
	Entry.Updated,
	Entry.Deleted,
	p1.Id AS p1Id,
	p1.Name AS p1Name,
	p1.ConnectCode AS p1ConnectCode,
	p1.DiscordCode AS p1DiscordCode,
	p1.Created AS p1Created,
	p1.Updated AS p1Updated,
	p1.Deleted AS p1Deleted,
	p2.Id AS p2Id,
	p2.Name AS p2Name,
	p2.ConnectCode AS p2ConnectCode,
	p2.DiscordCode AS p2DiscordCode,
	p2.Created AS p2Created,
	p2.Updated AS p2Updated,
	p2.Deleted AS p2Deleted
FROM
	Entry WITH (NOLOCK)
	LEFT JOIN Player p1 WITH (NOLOCK)
		ON p1.Id = Player1Id
	LEFT JOIN Player p2 WITH (NOLOCK)
		ON p2.Id = Player2Id