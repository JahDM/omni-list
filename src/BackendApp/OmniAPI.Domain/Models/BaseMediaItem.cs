using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OmniAPI.Domain.Models
{
    public abstract class BaseMediaItem : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public short ReleaseDate { get; set; }
        public string? Photo { get; set; }
        public string? ExternalLink { get; set; }
    }
}
