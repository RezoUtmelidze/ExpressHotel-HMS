using ExpressHotel.Domain.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExpressHotel.Domain.Entities
{
    public class Reservation
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        private DateTime _checkInDate;
        [Required]
        [Column(TypeName = "date")]
        public DateTime CheckInDate { get => _checkInDate; set {
                if (value >= DateTime.Today) _checkInDate = value;
                else throw new ForbiddenOperationException();
                    } }
        private DateTime _checkOutDate;

        [Column(TypeName = "date")]
        public DateTime CheckOutDate { get => _checkOutDate; set {
                if(value > _checkInDate) _checkOutDate = value;
                else throw new ForbiddenOperationException();
            } }
        [Required]
        [ForeignKey(nameof(Guest))]
        public Guid GuestId { get; set; }
        public Guest? Guest { get; set; }
    }
}
