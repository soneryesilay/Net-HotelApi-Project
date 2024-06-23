using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrate
{
 
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TCreate(Guest entity)
        {
            _guestDal.Create(entity);
        }

        public void TDelete(Guest entity)
        {
            _guestDal.Delete(entity);
        }

        public List<Guest> TGetAll()
        {
           return _guestDal.GetAll();
        }

        public Guest TGetById(int id)
        {
            return _guestDal.GetById(id);   
        }

        public void TUpdate(Guest entity)
        {
            _guestDal.Update(entity);
        }
    }
}
