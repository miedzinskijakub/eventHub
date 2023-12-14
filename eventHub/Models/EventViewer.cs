using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace eventHub.Models
{
    public class EventViewer
    {
        public Event Event { get; set; }
        public IdentityUser User { get; set; }

    }
}
