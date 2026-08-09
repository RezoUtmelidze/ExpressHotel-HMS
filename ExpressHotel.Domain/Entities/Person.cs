using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExpressHotel.Domain.Entities
{
    public class Person
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string LastName { get; set; } = null!;
        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        [MaxLength(11)]
        [Column(TypeName = "char(11)")]
        public string PersonalNumber { get; set; } = null!;
    }
}
