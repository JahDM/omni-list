namespace OmniAPI.Domain.Models
{
    public class UserMovie : UserMediaItem
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int EpisodesWatched { get; set; }
    }
}

