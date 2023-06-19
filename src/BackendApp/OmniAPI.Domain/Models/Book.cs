namespace OmniAPI.Domain.Models
{
    public class Book : BaseMediaItem
    {
        public int Pages { get; set; }
        public string Author { get; set; } = string.Empty;
    }
}
