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
	public class SubscribeManager : ISubscribeService
	{
		private ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}

		public void TCreate(Subscribe entity)
		{
			_subscribeDal.Create(entity);
		}

		public void TDelete(Subscribe entity)
		{
			_subscribeDal.Delete(entity);
		}

		public List<Subscribe> TGetAll()
		{
			return _subscribeDal.GetAll();
		}

		public Subscribe TGetById(int id)
		{
			return _subscribeDal.GetById(id);
		}

		public void TUpdate(Subscribe entity)
		{
			_subscribeDal.Update(entity);
		}
	}
}
