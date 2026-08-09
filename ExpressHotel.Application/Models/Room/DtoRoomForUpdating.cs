using ExpressHotel.Application.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ExpressHotel.Application.Models.Room
{
    public class DtoRoomForUpdating
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public SqlMoney? Price { get; set; }
        public Guid? HotelId { get; set; }
    }
}
