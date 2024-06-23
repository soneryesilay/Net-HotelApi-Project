
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		//servisi implemente ettik
		private readonly IStaffService _stuffService;

		public StaffController(IStaffService stuffService)
		{
			_stuffService = stuffService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			//servisten gelen verileri aldık
			var values= _stuffService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult StaffDetail(int id)
		{
			var Id = _stuffService.TGetById(id);
			return Ok(Id);
		}

		[HttpPost]
		public IActionResult StaffAdd(Staff staff)
		{
			_stuffService.TCreate(staff);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult StaffDelete(int id)
		{
			var Id = _stuffService.TGetById(id);
			
			if(Id == null)
			{
				return NotFound();
			}

			_stuffService.TDelete(Id);
			return Ok();
		}

		[HttpPut]
		public IActionResult StaffUpdate(Staff staff)
		{
			
			_stuffService.TUpdate(staff);
			return Ok();
		}

		[HttpGet("GetLast4Staff")]
		public IActionResult GetLast4Staff()
		{
            var values = _stuffService.TGetLast4Staff();
            return Ok(values);
        }
	}
}
