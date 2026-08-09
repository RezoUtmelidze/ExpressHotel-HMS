using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExpressHotel.Domain.Entities
{
    public class ReservationRoom
    {
        [Required]
        [ForeignKey(nameof(Reservation))]
        public Guid ReservationId { get; set; }
        [Required]
        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Reservation? Reservation { get; set; }
        public Room? Room { get; set; }
    }
}
