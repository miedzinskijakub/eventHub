using Microsoft.AspNetCore.Identity;

namespace eventHub.Models
{
    public class PersonalEvent
    {
        public int Id { get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; }

        public int EventId { get; set; }
        public virtual Event? Event { get; set; }
    }
}
