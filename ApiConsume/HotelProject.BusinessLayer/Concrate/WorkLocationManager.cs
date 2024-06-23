﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrate
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void TCreate(WorkLocation entity)
        {
            _workLocationDal.Create(entity);
        }

        public void TDelete(WorkLocation entity)
        {
            _workLocationDal.Delete(entity);
        }

        public List<WorkLocation> TGetAll()
        {
          return _workLocationDal.GetAll();
        }

        public WorkLocation TGetById(int id)
        {
           return _workLocationDal.GetById(id);
        }

        public void TUpdate(WorkLocation entity)
        {
            _workLocationDal.Update(entity);
        }
    }
}
