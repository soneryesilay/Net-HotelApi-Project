using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrate;
using HotelProject.DataAccessLayer.Repoistories;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {

        }

        public void BookingStatusChangeFalse(int id)
        {
          var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = false;
            context.SaveChanges();  
        }

        public void BookingStatusChangeTrue(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = true;
            context.SaveChanges();
           
          
        }

        public int GetBookingCount()
        {
           var context = new Context();
            return context.Bookings.Count();
        }

        public List<Booking> Last6Booking()
        {
           var context = new Context();
            return context.Bookings.OrderByDescending(x => x.BookingId).Take(6).ToList();
        }
    }
}
