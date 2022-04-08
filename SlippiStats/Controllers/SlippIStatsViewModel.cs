using SlippiStats.Extensions;
using SlippiStats.GameDataEnums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SlippiStats.Controllers
{
    public class SlippiStatsViewModel
    {
        public string Message { get; set; }

        public string Error { get; set; }

        public List<Character> Characters { get; set; }

        public List<Stage> Stages { get; set; }

        public SlippiStatsViewModel()
        {
            Characters = Enum.GetValues(typeof(Character)).OfType<Character>().OrderBy(c => c.GetDisplayName()).ToList();
            Stages = Enum.GetValues(typeof(Stage)).OfType<Stage>().OrderBy(s => s.GetDisplayName()).ToList();
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