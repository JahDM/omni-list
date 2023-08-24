using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OmniAPI.Domain.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public List<UserGame> UserGames { get; set; } = new();
        public List<UserMovie> UserMovies { get; set; } = new();
        public List<UserBook> UserBooks { get; set; } = new();
    }
}
