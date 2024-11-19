using BoardGamesWebsiteWithAuthorization.Components.Pages;
namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class RoomParticipantModel
    {
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public RoomModel Room { get; set; }
        public int IdUser { get; set; }
        public UserModel User { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}