using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Identity
{
   public class DtoLoginResponse
    {
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
    }
}
