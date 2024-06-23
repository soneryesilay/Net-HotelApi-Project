using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> movies = new List<ApiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
            {
        { "X-RapidAPI-Key", "8af682e089msh644dfc6b76b225fp15a210jsnd6714ea55d66" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
            },

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                movies= JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);  
                return View(movies);
            }
            return View();
        }
    }
}
