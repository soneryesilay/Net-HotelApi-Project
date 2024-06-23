using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet("GetUserListWithWorkLocation")]
        public IActionResult UserListWithWorkLocation()
        {
            var result = _appUserService.TUserListWithWorkLocation();
            return Ok(result);
        }

        [HttpGet("AppUserList")]
        public IActionResult AppUserList()
        {
            var result = _appUserService.TGetAll();
            return Ok(result);
        }

        
    }
}
