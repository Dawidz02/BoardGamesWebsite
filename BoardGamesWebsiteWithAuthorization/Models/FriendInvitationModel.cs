using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class FriendInvitationModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public UserModel User { get; set; }
        public int InvitedBy { get; set; }
        public UserModel InvitedUser { get; set; }
        public DateTime SendingDate { get; set; }
    }

}
