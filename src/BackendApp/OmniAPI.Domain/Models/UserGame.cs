namespace OmniAPI.Domain.Models
{
    public class UserGame : UserMediaItem
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int AchivmentsUnlocked { get; set; }
    }
}
