using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int IdGame { get; set; }
        public GameModel Game { get; set; }
        public int IdHost { get; set; }
        public UserModel Host { get; set; }
        public bool Availability { get; set; }
        public string Localization { get; set; }
        public DateTime CreatingDate { get; set; }
        public string RoomDescription { get; set; }
        public byte SkillLevelRequired { get; set; } // TINYINT CHECK (0-10)
        public bool WhoCanJoin { get; set; }

        public ICollection<RoomParticipantModel> RoomParticipants { get; set; }
        public ICollection<RoomInvitationModel> RoomInvitations { get; set; }
    }

}
