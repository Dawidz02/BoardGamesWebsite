using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class UserGameModel
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public UserModel User { get; set; }
        public int IdGame { get; set; }
        public GameModel Game { get; set; }
        public bool ReadyToPlay { get; set; }
        public int SkillLevel { get; set; }
    }
}
