using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Hotel
{
    public class DtoHotel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public byte? Rating { get; set; }
        public string? Address { get; set; }
    }
}
