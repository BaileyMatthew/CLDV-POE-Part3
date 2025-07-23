using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventBooking.Models
{
    public class EventType
    {
        [Key]
        public int EventTypeId { get; set; }

        [Required(ErrorMessage = "Event type name is required")]
        public string Name { get; set; }

        public ICollection<Event>? Events { get; set; }
    }
}
