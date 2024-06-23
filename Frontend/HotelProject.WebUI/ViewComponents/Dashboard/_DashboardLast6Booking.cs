﻿using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast6Booking : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast6Booking(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5277/api/Booking/GetLast6Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                try
                {
                    var values = JsonConvert.DeserializeObject<List<ResultLast6BookingDto>>(jsonData);
                    return View(values);
                }
                catch (JsonSerializationException ex)
                {
                    Console.WriteLine($"Deserialization error: {ex.Message}");
                    Console.WriteLine($"Response data: {jsonData}");
                    return View(new List<ResultLast6BookingDto>());
                }
            }
            else
            {
                Console.WriteLine($"API call failed with status code: {responseMessage.StatusCode}");
            }
            return View(new List<ResultLast6BookingDto>());
        }

    }
}
