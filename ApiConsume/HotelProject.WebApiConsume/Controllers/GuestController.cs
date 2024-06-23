using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult GetAllGuest()
        {
           var result = _guestService.TGetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var result = _guestService.TGetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.TCreate(guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var result = _guestService.TGetById(id);
            _guestService.TDelete(result);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.TUpdate(guest);
            return Ok();
        }

       



    }
}
