using ExpressHotel.Domain.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;

namespace ExpressHotel.Domain.Entities
{
    public class Room
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(40)]
        [Column(TypeName = "varchar(40)")]
        public string Name { get; set; } = null!;
        private SqlMoney _price = 0;
        [Required]
        public SqlMoney Price { get => _price; set
            {
                if (value > 0) _price = value;
                else throw new ForbiddenOperationException();
            }
        }
        [Required]
        [ForeignKey(nameof(Hotel))]
        public Guid HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
