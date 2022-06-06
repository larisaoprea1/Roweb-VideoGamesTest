namespace RoWebVideoGames.Models
{
    public class GameReview
    {
        public GameReview(Games gameItem, List<Review> reviewList)
        {
            GameItem = gameItem;
            ReviewList = reviewList;
        }
        public Games GameItem { get; set; }
        public List<Review> ReviewList { get; set; }
    }
}
