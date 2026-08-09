using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ExpressHotel.Application.Models.Room
{
    public class DtoRoomForCreating
    {
        public string Name { get; set; } = null!;
        public SqlMoney Price { get; set; }
        public Guid HotelId { get; set; }
    }
}
