﻿using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService   : IGenericService<Booking>
    {
        void TBookingStatusChangeTrue(int id);
        void TBookingStatusChangeFalse(int id);
        int TGetBookingCount();
        List<Booking> TLast6Booking();

    }
}
