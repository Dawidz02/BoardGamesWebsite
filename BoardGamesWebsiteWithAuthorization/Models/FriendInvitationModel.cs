using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class FriendInvitationModel
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public string InvitedBy { get; set; }  // Ensure this is a string to match the GUID
        public DateTime SendingDate { get; set; }
        public string InvitedByUserName { get; set; }  // To hold the inviter's username
    }


}
