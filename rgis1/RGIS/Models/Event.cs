using System;
using System.ComponentModel.DataAnnotations;

namespace RGIS.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }
    }
}
