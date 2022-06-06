using System.ComponentModel.DataAnnotations;

namespace RoWebVideoGames.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? Username { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string? Content { get; set; }
        public int GamesId { get; set; }
    }
}
