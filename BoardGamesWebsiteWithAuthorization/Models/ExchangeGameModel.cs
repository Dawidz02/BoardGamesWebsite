namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class ExchangeGameModel
    {
        public int Id { get; set; }
        public int IdGame { get; set; }
        public GameModel Game { get; set; }
        public int IdOffer { get; set; }
        public GameOfferModel Offer { get; set; }
    }
}
