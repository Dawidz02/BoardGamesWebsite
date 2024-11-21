using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class RoomInvitationModel
    {
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public RoomModel Room { get; set; }
        public string IdUser { get; set; }
        public UserModel User { get; set; }
        public string InvitedBy { get; set; }
        public UserModel InvitedByUser { get; set; }
        public string Status { get; set; } = "Waiting"; // ENUM('Waiting', 'Accepted', 'Declined')
        public DateTime SendingDate { get; set; }
    }
}
