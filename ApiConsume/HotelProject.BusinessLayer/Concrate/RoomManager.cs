using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrate;

namespace HotelProject.BusinessLayer.Concrate
{
	public class RoomManager :IRoomService
	{
		private IRoomDal _roomDal;

		public RoomManager(IRoomDal roomDal)
		{
			_roomDal = roomDal;
		}

		public List<Room> TGetAll()
		{
			return _roomDal.GetAll();
		}

		public Room TGetById(int id)
		{
			return _roomDal.GetById(id);
		}

		public void TCreate(Room entity)
		{
			_roomDal.Create(entity);
		}

		public void TUpdate(Room entity)
		{
			_roomDal.Update(entity);
		}

		public void TDelete(Room entity)
		{
			_roomDal.Delete(entity);
		}

        public int TRoomCount()
        {
          return _roomDal.RoomCount();
        }
    }
}
