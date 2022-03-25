using SlippiStats.Models;

namespace SlippiStats.Controllers
{
    public class EntryIndexViewModel : SlippiStatsViewModel
    {
        public Entry Entry { get; set; }

        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        public EntryIndexViewModel()
        {

        }
    }
}