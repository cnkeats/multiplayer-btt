using SlippiStats.GameDataEnums;
using SlippiStats.Models;
using System;
using System.Collections.Generic;

namespace SlippiStats.Controllers
{
    public class CharacterIndexViewModel : SlippiStatsViewModel
    {
        public Character Character { get; set; }

        public List<Entry> Entries { get; set; }

        public CharacterIndexViewModel()
        {
            Entries = new List<Entry>();
        }
    }
}