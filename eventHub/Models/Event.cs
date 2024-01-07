using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace eventHub.Models
{
    public class Event
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }


        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; }


    }
}
