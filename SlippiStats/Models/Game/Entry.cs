using SlippiStats.GameDataEnums;
using SlippiStats.Util;
using System;
using System.Collections.Generic;
using System.Data;

namespace SlippiStats.Models
{
    public class Entry
    {
        public int Id { get; private set; }

        public Character? Character1 { get; set; }

        public Character? Character2 { get; set; }

        public Character? Character3 { get; set; }

        public Character? Character4 { get; set; }

        public int? Player1Id { get; set; }

        public int? Player2Id { get; set; }

        public int? Player3Id { get; set; }

        public int? Player4Id { get; set; }

        public Stage Stage { get; set; }

        public int Frames { get; set; }

        public int TargetsRemaining { get; set; }

        public DateTime DateRun { get; set; }

        public string Platform { get; set; }

        public string VideoURL { get; set; }

        public bool Verified { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        public DateTime? Deleted { get; set; }

        public bool IsDeleted
        {
            get => Deleted != null;
            set => Deleted = value ? DateTime.Now : (DateTime?)null;
        }

        public Entry()
        {
            Created = DateTime.Now;
        }

        public Entry(IDataReader dataReader)
        {
            Id = dataReader.GetValue<int>(nameof(Id));
            Character1 = (Character?)dataReader.GetValue<int?>(nameof(Character1));
            Character2 = (Character?)dataReader.GetValue<int?>(nameof(Character2));
            Character3 = (Character?)dataReader.GetValue<int?>(nameof(Character3));
            Character4 = (Character?)dataReader.GetValue<int?>(nameof(Character4));
            Player1Id = dataReader.GetValue<int?>(nameof(Player1Id));
            Player2Id = dataReader.GetValue<int?>(nameof(Player2Id));
            Player3Id = dataReader.GetValue<int?>(nameof(Player3Id));
            Player4Id = dataReader.GetValue<int?>(nameof(Player4Id));
            Stage = (Stage)dataReader.GetValue<int>(nameof(Stage));
            Frames = dataReader.GetValue<int>(nameof(Frames));
            TargetsRemaining = dataReader.GetValue<int>(nameof(TargetsRemaining));
            DateRun = dataReader.GetValue<DateTime>(nameof(DateRun));
            Platform = dataReader.GetValue<string>(nameof(Platform));
            VideoURL = dataReader.GetValue<string>(nameof(VideoURL));
            Verified = dataReader.GetValue<bool>(nameof(Verified));
            Created = dataReader.GetValue<DateTime>(nameof(Created));
            Updated = dataReader.GetValue<DateTime?>(nameof(Updated));
            Deleted = dataReader.GetValue<DateTime?>(nameof(Deleted));
        }

        public static Entry GetById(IDbConnection connection, int id)
        {
            Entry user = null;

            using IDbCommand command = connection.CreateStoredProcedure(
                $"{nameof(Entry)}_{nameof(GetById)}",
                new { id });

            using IDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                user = new Entry(reader);
            }

            return user;
        }

        public static Entry GetByHash(IDbConnection connection, string hash)
        {
            Entry user = null;

            using IDbCommand command = connection.CreateStoredProcedure(
                $"{nameof(Entry)}_{nameof(GetByHash)}",
                new { hash });

            using IDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                user = new Entry(reader);
            }

            return user;
        }

        public static List<Entry> GetList(IDbConnection connection, bool includeAnonymous = false)
        {
            List<Entry> entries = new List<Entry>();

            using IDbCommand command = connection.CreateStoredProcedure(
                $"{nameof(Entry)}_{nameof(GetList)}",
                new { includeAnonymous });

            using IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                entries.Add(new Entry(reader));
            }

            return entries;
        }

        public static List<Entry> GetListByPlayerId(IDbConnection connection, int playerId)
        {
            List<Entry> entries = new List<Entry>();

            using IDbCommand command = connection.CreateStoredProcedure(
                $"{nameof(Entry)}_{nameof(GetListByPlayerId)}",
                new { playerId });

            using IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                entries.Add(new Entry(reader));
            }

            return entries;
        }

        public static List<Entry> GetListByFilters(IDbConnection connection, string playerName1 = null, string playerName2 = null, Character? character1 = null, Character? character2 = null, Stage? stage = null, bool includeAnonymous = false)
        {
            List<Entry> entries = new List<Entry>();

            using IDbCommand command = connection.CreateStoredProcedure(
                $"{nameof(Entry)}_{nameof(GetListByFilters)}",
                new { playerName1, playerName2, character1, character2, stage, includeAnonymous });

            using IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                entries.Add(new Entry(reader));
            }

            return entries;
        }

        public void Save(IDbConnection connection)
        {
            if (Id == 0)
            {
                Insert(connection);
            }
            else
            {
                Update(connection);
            }
        }

        private void Insert(IDbConnection connection)
        {
            using IDbCommand command = connection.CreateStoredProcedure(
                $"{nameof(Entry)}_{nameof(Insert)}",
                new
                {
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
                });

            Id = (int)command.ExecuteScalar();
        }

        private void Update(IDbConnection connection)
        {
            Updated = DateTime.Now;

            using IDbCommand command = connection.CreateStoredProcedure(
                $"{nameof(Entry)}_{nameof(Update)}",
                new
                {
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
                    Verified,
                    Created,
                    Updated,
                    Deleted
                });

            command.ExecuteNonQuery();
        }
    }
}
