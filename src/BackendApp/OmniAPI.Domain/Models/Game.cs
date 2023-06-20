namespace OmniAPI.Domain.Models
{
    public class Game : BaseMediaItem
    {
        public string Platform { get; set; } = string.Empty;
        public int? AchivmentsAmount { get; set; }
    }
}
