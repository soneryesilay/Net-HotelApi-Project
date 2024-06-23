using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }


        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TCreate(booking);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetBooking()
        {
            var result = _bookingService.TGetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var result = _bookingService.TGetById(id);
            return Ok(result);
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var result = _bookingService.TGetById(id);
            _bookingService.TDelete(result);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }


        [HttpGet("BookingAproved")]
        public IActionResult  BookingAproved(int id)
        {
            _bookingService.TBookingStatusChangeTrue(id);
            return Ok();
        }

        [HttpPut("{BookingCancel}")]
        public IActionResult BookingCancel(int id)
        {
            _bookingService.TBookingStatusChangeFalse(id);
            return Ok();
        }


        [HttpGet("GetLast6Booking")]
        public IActionResult GetLast6Booking()
        {
            var result = _bookingService.TGetBookingCount();
            return Ok(result);
        }













        //[HttpPut("{id}")]
        //public IActionResult ApproveBooking(int id)
        //{
        //   _bookingService.TBookingStatusChangeTrue(id);
        //    return Ok();
        //}

        //[HttpPut("BookingCancel")]
        //public IActionResult CancelBooking(int id)
        //{
        //    _bookingService.TBookingStatusChangeFalse(id);
        //    return Ok();
        //}


    }
}
