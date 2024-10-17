using System.ComponentModel.DataAnnotations;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Game Name is required.")]
        public string GameName { get; set; }

        [Required(ErrorMessage = "Game Description is required.")]
        public string GameDescription { get; set; }

        [Required(ErrorMessage = "Play time is required.")]
        public int PlayTime { get; set; }

        [Required(ErrorMessage = "Publisher is required.")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }

        //public ICollection<RoomModel> Rooms { get; set; }
        //public ICollection<UserGameModel> UserGames { get; set; }
        //public ICollection<GameOfferModel> GameOffers { get; set; }
        public int MainGameId { get; set; }
        public int DLCGame { get; set; }
        public bool IsDLC { get; set; } // New property to indicate if it's a DLC
        public string MainGameName { get; set; }
        public string Categories { get; set; }
        public List<GameImageModel> GameImages { get; set; } = new List<GameImageModel>();
        public List<GameModel> DLCs { get; set; }  // Add this to store related DLCs
        public string FeedbackMessage { get; set; }
    }

}
