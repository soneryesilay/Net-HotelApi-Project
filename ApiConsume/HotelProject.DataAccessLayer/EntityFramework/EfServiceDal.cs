﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrate;
using HotelProject.DataAccessLayer.Repoistories;
using HotelProject.EntityLayer.Concrate;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfServiceDal:GenericRepository<Service>,IServicesDal
	{
		public EfServiceDal(Context context) : base(context)
		{

		}
	}
}
