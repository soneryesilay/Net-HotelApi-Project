using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
       void BookingStatusChangeTrue(int id);
       void BookingStatusChangeFalse(int id);
       int GetBookingCount();

        List<Booking> Last6Booking(); 

    }
}
