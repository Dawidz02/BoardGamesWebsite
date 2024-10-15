namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class GameCategoryModel
    {
        public int Id { get; set; }
        public int IdGame { get; set; }
        public GameModel Game { get; set; }
        public int IdCategory { get; set; }
        public CategoryModel Category { get; set; }
    }
}
