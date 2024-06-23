using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="İsim alanın doldurulması gerkelidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanın doldurulması gerkelidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı alanın doldurulması gerkelidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email alanın doldurulması gerkelidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanın doldurulması gerkelidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanın doldurulması gerkelidir")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
        public int WorkLocationID { get; set; }

    }
}
