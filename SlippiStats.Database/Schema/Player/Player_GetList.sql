CREATE PROCEDURE Player_GetList

AS

SELECT
	Player.Id,
	Player.Name,
	Player.ConnectCode,
	Player.DiscordCode,
	Player.Created,
	Player.Updated,
	Player.Deleted
FROM
	Player WITH (NOLOCK)
GROUP BY
	Player.Id,
	Player.Name,
	Player.ConnectCode,
	Player.DiscordCode,
	Player.Created,
	Player.Updated,
	Player.Deleted
ORDER BY
	Id DESC