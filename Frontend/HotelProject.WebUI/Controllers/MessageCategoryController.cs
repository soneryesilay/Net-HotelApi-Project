﻿using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public IActionResult Index()
        {
            return View();
        }
    }
}
