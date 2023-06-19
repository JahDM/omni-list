using System.ComponentModel.DataAnnotations;

namespace OmniAPI.Domain.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public DateTime JoinDate { get; set; }
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public List<UserGame> UserGames { get; set; } = new();
        public List<UserMovie> UserMovies { get; set; } = new();
        public List<UserBook> UserBooks { get; set; } = new();
    }
}
