using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace eventHub.Models
{
    public class Event
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }


        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Data jest wymagana.")]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = "Lokalizacja jest wymagana.")]
        public string Location { get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; }


    }
}
