﻿using HotelProject.DataAccessLayer.Abstract;
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
    public class EfGuestDal : GenericRepository<Guest>, IGuestDal
    {
        public EfGuestDal(Context context) : base(context)
        {
        }
    }
}
