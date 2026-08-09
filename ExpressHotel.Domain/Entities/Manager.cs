using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExpressHotel.Domain.Entities
{
    public class Manager : Person
    {
        [Required]
        [EmailAddress]
        [MaxLength(254)]
        [Column(TypeName = "varchar(254)")]
        public string Email { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Hotel))]
        public Guid HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
