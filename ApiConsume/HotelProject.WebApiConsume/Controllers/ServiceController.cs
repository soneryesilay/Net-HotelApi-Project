using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _serviceService;

		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		[HttpGet]
		public IActionResult ServiceList()
		{
			var values = _serviceService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult ServiceDetail(int id)
		{
			var Id = _serviceService.TGetById(id);
			return Ok(Id);
		}

		[HttpPost]
		public IActionResult ServiceAdd(Service service)
		{
			_serviceService.TCreate(service);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult ServiceDelete(int id)
		{
			var Id = _serviceService.TGetById(id);
			_serviceService.TDelete(Id);
			return Ok();
		}

		[HttpPut]
		public IActionResult ServiceUpdate(Service service)
		{
			_serviceService.TUpdate(service);
			return Ok();
		}
	}
}
