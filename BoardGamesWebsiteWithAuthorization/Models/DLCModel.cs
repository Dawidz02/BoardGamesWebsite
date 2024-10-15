namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class DLC
{
    public int Id { get; set; }            // Id DLC (klucz główny)

    public int MainGameId { get; set; }    // Id głównej gry
    public int DLCGameId { get; set; }      // Id DLC gry

    // Nawigacje do głównej gry
    public GameModel MainGame { get; set; }

    // Nawigacja do DLC gry
    public GameModel DLCGame { get; set; }
}

}
