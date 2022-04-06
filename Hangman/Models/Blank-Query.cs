using System.ComponentModel.DataAnnotations;

namespace Hangman.Models
{
    public class Blank_Query
    {
        [StringLength(14)]
        public char[] QueryWord { get; set; }

        public string QueryId { get; set; }
        public virtual Query Query { get; set; }

        public Blank_Query() {
        }
    }
}
