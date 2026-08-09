using ExpressHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Reservation
{
    public class DtoReservationForCreating
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Guid GuestId { get; set; }
    }
}
