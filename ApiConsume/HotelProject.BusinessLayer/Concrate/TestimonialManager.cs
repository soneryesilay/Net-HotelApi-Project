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
	public class TestimonialManager	: ITestimonialService
	{
		private ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

		public void TCreate(Testimonial entity)
		{
			_testimonialDal.Create(entity);
		}

		public void TDelete(Testimonial entity)
		{
			_testimonialDal.Delete(entity);
		}

		public List<Testimonial> TGetAll()
		{
			return _testimonialDal.GetAll();	
		}

		public Testimonial TGetById(int id)
		{
			return _testimonialDal.GetById(id);
		}

		public void TUpdate(Testimonial entity)
		{
			_testimonialDal.Update(entity);
		}
	}
}
