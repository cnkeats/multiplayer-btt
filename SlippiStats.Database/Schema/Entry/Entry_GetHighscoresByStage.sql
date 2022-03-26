CREATE PROCEDURE Entry_GetHighscoresByStage
	@stageId INT

AS

SELECT TOP 1 WITH TIES
	Filtered.Id,
	c_1 AS Character1,
	c_2 AS Character2,
	NULL AS Character3,
	NULL AS Character4,
	Filtered.Player1Id,
	Filtered.Player2Id,
	Filtered.Player3Id,
	Filtered.Player4Id,
	Filtered.Stage,
	Filtered.Frames,
	Filtered.TargetsRemaining,
	Filtered.DateRun,
	Filtered.Platform,
	Filtered.VideoURL,
	Filtered.Verified,
	Filtered.Created,
	Filtered.Updated,
	Filtered.Deleted,
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
	(
		SELECT
			*,
			CASE WHEN
				Character1 < Character2 THEN Character1
				ELSE Character2
			END AS [c_1],
			CASE WHEN
				Character1 < Character2 THEN Character2
				ELSE Character1
			END AS [c_2]
		FROM
			Entry WITH (NOLOCK)
		WHERE
			Stage = @stageId
	) AS Filtered
	LEFT JOIN Player p1 WITH (NOLOCK)
		ON p1.Id = Player1Id
	LEFT JOIN Player p2 WITH (NOLOCK)
		ON p2.Id = Player2Id
ORDER BY
	row_number() OVER (PARTITION BY [c_1], [c_2] ORDER BY Frames ASC)