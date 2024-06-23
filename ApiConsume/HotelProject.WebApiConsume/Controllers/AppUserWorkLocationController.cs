using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrate;
using HotelProject.EntityLayer.Concrate;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var values = _appUserService.TUserListWithWorkLocation();
           Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y=>new AppUserWorkLocationViewModel
            {
                Name= y.Name,
                Surname = y.Surname,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                WorkLocationID = y.WorkLocationID,
                Gender = y.Gender,
                City = y.City,  
                Country = y.Country,


            }).ToList();
            return Ok(values);
        }
    }
}
