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
	public class ServiceManager : IServiceService
	{
		private IServicesDal _servicesDal;

		public ServiceManager(IServicesDal servicesDal)
		{
			_servicesDal = servicesDal;
		}

		public void TCreate(Service entity)
		{
			_servicesDal.Create(entity);
		}

		public void TDelete(Service entity)
		{
			_servicesDal.Delete(entity);
		}

		public List<Service> TGetAll()
		{
			return _servicesDal.GetAll();
		}

		public Service TGetById(int id)
		{
			return _servicesDal.GetById(id);
		}

		public void TUpdate(Service entity)
		{
			_servicesDal.Update(entity);	
		}
	}
}
