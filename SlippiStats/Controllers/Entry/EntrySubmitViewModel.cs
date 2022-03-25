using SlippiStats.GameDataEnums;
using System;

namespace SlippiStats.Controllers
{
    public class EntrySubmitViewModel : SlippiStatsViewModel
    {
        public Character Character1 { get; set; }

        public Character Character2 { get; set; }

        public string Player1 { get; set; }

        public string Player2 { get; set; }

        public Stage Stage { get; set; }

        public int Frames { get; set; }

        public int TargetsRemaining { get; set; }

        public DateTime DateRun { get; set; }

        public string Platform { get; set; }

        public string VideoURL { get; set; }

        public EntrySubmitViewModel()
        {

        }
    }
}