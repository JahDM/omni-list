namespace OmniAPI.Domain.Models
{
    public class UserBook : UserMediaItem
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CurrentPage { get; set; }
    }
}
