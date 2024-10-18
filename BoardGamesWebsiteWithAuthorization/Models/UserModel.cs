using System.ComponentModel.DataAnnotations;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class UserModel
    {
        public string Id { get; set; } // Primary Key
        public string Adress { get; set; }
        public string PrefferedLocalization { get; set; }
        public string UserDescription { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string WebUserName { get; set; }
        public string UserPhoto { get; set; }

        public ICollection<FriendModel> Friends1 { get; set; }
        public ICollection<FriendModel> Friends2 { get; set; }
        public ICollection<FriendInvitationModel> FriendInvitations { get; set; }
        public ICollection<RoomModel> HostedRooms { get; set; }
        public ICollection<RoomParticipantModel> RoomParticipants { get; set; }
        public ICollection<RoomInvitationModel> RoomInvitations { get; set; }
        public ICollection<UserGameModel> UserGames { get; set; }
        public ICollection<GameOfferModel> GameOffers { get; set; }
    }

}
