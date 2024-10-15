namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string PreferredLocalization { get; set; }
        public bool TypeOfAccount { get; set; }   // 0 -> standard, 1 -> admin
        public string PasswordHash { get; set; }
        public string Login { get; set; }
        public string UserDescription { get; set; }

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
