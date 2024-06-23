using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		[HttpGet]
		public IActionResult TestimonialList()
		{
			var values= _testimonialService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult TestimonialDetail(int id)
		{
			var Id = _testimonialService.TGetById(id);
			return Ok(Id);
			
		}

		[HttpPost]
		public IActionResult TestimonialAdd(Testimonial testimonial)
		{
			_testimonialService.TCreate(testimonial);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult TestimonialDelete(int id)
		{	   
			var Id= _testimonialService.TGetById(id);
			_testimonialService.TDelete(Id);
			return Ok();
		}

		[HttpPut]
		public IActionResult TestimonialUpdate(int id)
		{
			var Id = _testimonialService.TGetById(id);
			_testimonialService.TUpdate(Id);
			return Ok();
		}

	}
}
