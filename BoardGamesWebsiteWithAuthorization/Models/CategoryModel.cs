namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<GameCategoryModel> GameCategories { get; set; }
    }
}
