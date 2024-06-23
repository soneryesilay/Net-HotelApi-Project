using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribeController : ControllerBase
	{
		private readonly ISubscribeService _subscribeService;

		public SubscribeController(ISubscribeService subscribeService)
		{
			_subscribeService = subscribeService;
		}

		[HttpGet]
		public IActionResult SubscribeList()
		{
			var values= _subscribeService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult SubscribeDetail(int id)
		{
			var Id = _subscribeService.TGetById(id);
			return Ok(Id);
		}

		[HttpPost]
		public IActionResult SubscribeAdd(Subscribe subscribe)
		{
			_subscribeService.TCreate(subscribe);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult SubscribeDelete(int id)
		{
			var Id = _subscribeService.TGetById(id);
			_subscribeService.TDelete(Id);
			return Ok();
		}

		[HttpPut]
		public IActionResult SubscribeUpdate(Subscribe subscribe)
		{
			
			_subscribeService.TUpdate(subscribe);
			return Ok();
		}
	}
}
