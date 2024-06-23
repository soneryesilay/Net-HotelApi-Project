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
    public class StaffManager : IStaffService
	{
		private IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public void TCreate(Staff entity)
		{
			_staffDal.Create(entity);
		}

		public void TDelete(Staff entity)
		{
			_staffDal.Delete(entity);
		}

		public List<Staff> TGetAll()
		{
			return _staffDal.GetAll();
		}

		public Staff TGetById(int id)
		{
			return _staffDal.GetById(id);
		}

        public List<Staff> TGetLast4Staff()
        {
           return _staffDal.GetLast4Staff();
        }

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void TUpdate(Staff entity)
		{
			_staffDal.Update(entity);
		}
	}
}
