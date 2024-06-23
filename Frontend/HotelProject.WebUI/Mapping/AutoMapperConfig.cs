using AutoMapper;
using HotelProject.EntityLayer.Concrate;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig   : Profile
    {
        public AutoMapperConfig()
        {
            #region Service
            CreateMap<ResultServiceDto,Service>().ReverseMap();
            CreateMap<UpdateServiceDto,Service>().ReverseMap();
            CreateMap<CreateServiceDto,Service>().ReverseMap();
            #endregion


            #region Authenticaion
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();
            #endregion

            #region About
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
            CreateMap<ResultAboutDto,About>().ReverseMap();
            #endregion

            #region Room
            CreateMap<CreateRoomDto,Room>().ReverseMap();
            CreateMap<ResultRoomDto,Room>().ReverseMap();
            CreateMap<UpdateRoomDto,Room>().ReverseMap();
            #endregion

            CreateMap<CreateTestimonialDto,Testimonial>().ReverseMap();
            CreateMap<ResultTestimonialDto,Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto,Testimonial>().ReverseMap();


            CreateMap<CreateStaffDto,Staff>().ReverseMap();
            CreateMap<ResultStaffDto,Staff>().ReverseMap();
            CreateMap<UpdateStaffDto,Staff>().ReverseMap();

            CreateMap<ResultSubscribeDto,Staff>().ReverseMap();
            CreateMap<CreateSubscribeDto,Staff>().ReverseMap();
            CreateMap<UpdateSubscribeDto,Staff>().ReverseMap();

            CreateMap<ResultBookingDto,Booking>().ReverseMap();
            CreateMap<CreateBookingDto,Booking>().ReverseMap();
            CreateMap<UpdateBookingDto,Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto,Booking>().ReverseMap();

            CreateMap<CreateContactDto ,Contact>().ReverseMap();


            CreateMap<CreateGuestDto,Guest>().ReverseMap(); 
            CreateMap<ResultGuestDto,Guest>().ReverseMap();
            CreateMap<UpdateGuestDto,Guest>().ReverseMap();

            CreateMap<ResultAppUserDto,AppUser>().ReverseMap();

        }
    }
}
