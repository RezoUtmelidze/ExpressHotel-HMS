using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Reservation
{
    public class DtoReservationForGetting
    {
        public Guid? Id { get; set; }
        public Guid? HotelId { get; set; }
        public Guid? GuestId { get; set; }
        public Guid? RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
    }
}