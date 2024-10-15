namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class GameImageModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public int IdGame { get; set; }
        public GameModel Game { get; set; }
    }
}
