using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Identity
{
    public class DtoLoginRequest
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
