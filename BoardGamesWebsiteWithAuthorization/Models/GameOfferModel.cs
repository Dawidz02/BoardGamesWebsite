using BoardGamesWebsiteWithAuthorization.Components.Pages;

namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class GameOfferModel
    {
        public int Id { get; set; }
        public int IdGame { get; set; }
        public GameModel Game { get; set; }
        public int CreatorId { get; set; }
        public UserModel Creator { get; set; }
        public string OfferType { get; set; } // ENUM('Sale', 'Trade')
        public decimal Price { get; set; }
        public bool OfferAvailability { get; set; }
        public DateTime CreatingDate { get; set; }
        public string Description { get; set; }

        public ICollection<ExchangeGameModel> ExchangeGames { get; set; }
    }
}
