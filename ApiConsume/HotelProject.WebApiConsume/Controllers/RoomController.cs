using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		[HttpGet]
		public IActionResult RoomList()
		{
		  var values = _roomService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult RoomDetail(int id)
		{
			var Id = _roomService.TGetById(id);
			return Ok(Id);
		}

		[HttpPost]
		public IActionResult RoomAdd(Room room)
		{
			_roomService.TCreate(room);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult RoomDelete(int id)
		{
			var Id = _roomService.TGetById(id);
			_roomService.TDelete(Id);
			return Ok();
		}

		[HttpPut]
		public IActionResult RoomUpdate(Room room)
		{
			_roomService.TUpdate(room);
			return Ok();
		}
	}
}
