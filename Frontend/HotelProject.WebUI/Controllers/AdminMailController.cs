using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage message = new MimeMessage();
           
            //kimden gidecek
            MailboxAddress from = new MailboxAddress("HotelierAdmin", "soneryesilay@gmail.com");
            message.From.Add(from);

            //kime gidecek
            MailboxAddress to = new MailboxAddress("User",model.ReceiverMail);
            message.To.Add(to);

            //mesajın içeriği   
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            message.Body = bodyBuilder.ToMessageBody();


            message.Subject = model.Subject;
            
            //smtp server
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("soneryesilay@gmail.com", "auax lofq xirz hctf");
            client.Send(message);
            client.Disconnect(true);
            return View();

        }
    }
}
