namespace BoardGamesWebsiteWithAuthorization.Models
{
    public class ChatMessageModel
    {
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public string IdUser { get; set; }
        public string UserName { get; set; }
        public string MessageContent { get; set; }
        public DateTime SentDate { get; set; }
    }
}
