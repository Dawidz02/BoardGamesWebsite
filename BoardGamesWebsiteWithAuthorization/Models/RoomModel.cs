using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int IdGame { get; set; }
        public GameModel Game { get; set; }
        public string GameName { get; set; }
        public string IdHost { get; set; }
        public string HostName { get; set; }  // This is the new property
        public UserModel Host { get; set; }
        public bool Availability { get; set; }
        public string Localization { get; set; }
        public DateTime CreatingDate { get; set; }
        public string RoomDescription { get; set; }
        public int SkillLevelRequired { get; set; } // TINYINT CHECK (0-10)
        public bool WhoCanJoin { get; set; }
        public string MainGameImageUrl { get; set; } // Main image URL for the game
        public bool IsUserInRoom { get; set; }
        public bool IsUserRoom { get; set; }
        public bool IsAnyoneSelected { get; set; }  // Tracks "Anyone"
        public bool IsInviteOnlySelected { get; set; }  // Tracks "Invite Only"
        public int FriendsCount { get; set; } // New Property
        public int ParticipantsCount { get; set; } // Nowe pole
        public ICollection<RoomParticipantModel> RoomParticipants { get; set; }
        public ICollection<RoomInvitationModel> RoomInvitations { get; set; }
    }

}
