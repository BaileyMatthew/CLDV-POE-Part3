using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventBooking.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required(ErrorMessage = "Venue name is required.")]
        [StringLength(100)]
        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }

        [StringLength(500)]
        public string? Location { get; set; }  // Optional, nullable in DB

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive number.")]
        public int Capacity { get; set; }

        [Column("Image_URL")]
        [StringLength(500)]
        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }
    }
}
