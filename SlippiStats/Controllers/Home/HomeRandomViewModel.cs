using SlippiStats.GameDataEnums;
using SlippiStats.Models;
using System.Collections.Generic;

namespace SlippiStats.Controllers
{
    public class HomeRandomViewModel : SlippiStatsViewModel
    {
        public Character Character1 { get; set; }

        public Character Character2 { get; set; }

        public Stage Stage { get; set; }

        public Entry Highscore { get; set; }

        public string RecordTime { get; set; }

        public HomeRandomViewModel() : base()
        {
            
        }
    }
}