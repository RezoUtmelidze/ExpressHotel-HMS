using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Hotel
{
    public class DtoHotelForCreating
    {
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
