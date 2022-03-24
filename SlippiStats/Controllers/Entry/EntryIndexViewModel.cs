using SlippiStats.Models;

namespace SlippiStats.Controllers
{
    public class EntryIndexViewModel
    {
        public string Message { get; set; }

        public string Error { get; set; }

        public Entry Entry { get; set; }

        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        public EntryIndexViewModel()
        {

        }
    }
}