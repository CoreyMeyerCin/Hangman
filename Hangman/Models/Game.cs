namespace Hangman.Models
{
    public class Game
    {
        public string Status { get; set; }

        public string GameStats { get; set; } = "waiting";
        public int TryCounter { get; set; } = 6;
        public int QueryId { get; set; }
        public virtual Query Query { get; set; }
        public Game() { 
            
            
        }

    }
}
