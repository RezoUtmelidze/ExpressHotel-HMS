using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Models.Identity
{
    public class DtoGuestRegistrationRequest
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PersonalNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
