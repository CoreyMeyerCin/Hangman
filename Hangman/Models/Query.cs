using System.ComponentModel.DataAnnotations;

namespace Hangman.Models
{
    public class Query
    {
        [Required]
        public int StringId { get; set; }
        [StringLength(14)]
        public string QueryWord { get; set; }

        public Query() { }
    }
}
