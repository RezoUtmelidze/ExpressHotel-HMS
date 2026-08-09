using ExpressHotel.Application.Abstractions;
using ExpressHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressHotel.Application.Contracts
{
    public interface IReservationRoomRepository : IRepository<ReservationRoom>
    {
    }
}
