using ExpressHotel.Domain.Events;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpressHotel.Domain.Entities
{
    public class Hotel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; } = null!;
        private byte _rating = 1;
        [Column(TypeName = "tinyint")]
        public byte Rating { get => _rating; set
            {
                if (value >= 1 && value <= 5) _rating = value;
                else throw new ForbiddenOperationException();
            }}
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string Country { get; set; } = null!;
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string City { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; } = null!;
    }
}
