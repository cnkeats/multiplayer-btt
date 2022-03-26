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

        public string FramesToTime(int? frames)
        {
            if (frames == null)
            {
                return "-";
            }

            int minutes = (int)frames / 60 / 60;
            int seconds = (int)frames / 60;
            int centiseconds = (int)Math.Floor((int)(frames % 60) * 99.0 / 59);

            if (minutes > 0)
            {
                return string.Format("{0}:{1}.{2}", minutes, seconds, centiseconds);
            }
            
            if (seconds > 0)
            {
                return string.Format("{0}.{1}", seconds, centiseconds);
            }

            return string.Format("0.{0}", centiseconds);

        }
    }
}