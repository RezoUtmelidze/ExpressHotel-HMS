using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Domain.Exceptions
{
    internal class ForbiddenOperationException : Exception
    {
        public ForbiddenOperationException() { }
        public ForbiddenOperationException(string message) : base(message) { }
    }
}
