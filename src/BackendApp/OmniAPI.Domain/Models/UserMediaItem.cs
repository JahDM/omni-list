using System.ComponentModel.DataAnnotations;

namespace OmniAPI.Domain.Models
{
    public enum State
    {
        Planned,
        Consuming,
        Finished
    }
    public abstract class UserMediaItem : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = new();
        public State State { get; set; }
        public int UserRate { get; set; }
    }

}
