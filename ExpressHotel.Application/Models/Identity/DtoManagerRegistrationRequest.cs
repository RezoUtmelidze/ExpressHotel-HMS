using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Identity
{
    public class DtoManagerRegistrationRequest : DtoGuestRegistrationRequest
    {
        public string Email { get; set; } = null!;
    }
}
