using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class FriendModel
    {
        public int Id { get; set; }
        public int IdUser1 { get; set; }
        public UserModel User1 { get; set; }
        public int IdUser2 { get; set; }
        public UserModel User2 { get; set; }
    }

}
