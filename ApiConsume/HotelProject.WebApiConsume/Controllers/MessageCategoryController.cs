using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;

        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            _messageCategoryService = messageCategoryService;
        }

        [HttpGet]
        public IActionResult MessageCategoryList()
        {
            var values = _messageCategoryService.TGetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult MessageCategoryDetail(int id)
        {
            var Id = _messageCategoryService.TGetById(id);
            return Ok(Id);
        }

        [HttpPost]
        public IActionResult MessageCategoryAdd(MessageCategory messageCategory)
        {
            _messageCategoryService.TCreate(messageCategory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult MessageCategoryDelete(int id)
        {
            var Id = _messageCategoryService.TGetById(id);

            if (Id == null)
            {
                return NotFound();
            }

            _messageCategoryService.TDelete(Id);
            return Ok();
        }

        [HttpPut]
        public IActionResult MessageCategoryUpdate(MessageCategory messageCategory)
        {
            _messageCategoryService.TUpdate(messageCategory);
            return Ok();
        }
    }
}
