using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrate;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IRoomDal : IGenericDal<Room>
	{
		int RoomCount();
	}
}
