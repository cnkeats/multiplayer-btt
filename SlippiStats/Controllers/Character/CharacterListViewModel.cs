using SlippiStats.GameDataEnums;
using SlippiStats.Models;
using System.Collections.Generic;

namespace SlippiStats.Controllers
{
    public class CharacterListViewModel : SlippiStatsViewModel
    {
        public string PlayerFilter1 { get; set; }

        public string PlayerFilter2 { get; set; }

        public Character? CharacterFilter1 { get; set; }

        public Character? CharacterFilter2 { get; set; }

        public Stage? StageFilter { get; set; }

        public List<Entry> Entries { get; set; }

        public CharacterListViewModel() : base()
        {
            Entries = new List<Entry>();
        }
    }
}