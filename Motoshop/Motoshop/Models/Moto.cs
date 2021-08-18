using System;
using System.ComponentModel.DataAnnotations;
using Motoshop.Models.Attributes;

namespace Motoshop.Models
{
    public class Moto
    {
        [Guid(ErrorMessage = "Guid format mismatch")]
        public Guid Id { get; set; }
        [Required]
        public int Odometer { get; set; }
        public string Model { get; set; }
        [MinYear(2000, ErrorMessage = "Year can not be less than 2000")]
        public DateTime MadeIn { get; set; }
        public string ImagePreview { get; set; }
    }
}
