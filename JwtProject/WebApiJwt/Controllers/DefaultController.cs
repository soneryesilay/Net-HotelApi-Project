using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult CreateTokenForVisitor()
        {
            return Ok(new CreateToken().TokenCreate()); 
        }

        [HttpGet("[action]")]
        public IActionResult CreateTokenForAdmin()
        {
            return Ok(new CreateToken().TokenAdmin());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult VisitorLogin()
        {
            return Ok("Giriş Başarılı");
        }

        [Authorize(Roles ="Admin")]
        [HttpGet("[action]")]
        public IActionResult AdminLogin()
        {
            return Ok("Admin Giriş Başarılı");
        }
    }
}
