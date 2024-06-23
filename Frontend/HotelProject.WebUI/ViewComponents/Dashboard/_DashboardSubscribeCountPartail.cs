using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartail : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/soneryesilay"),
                Headers =
    {
        { "x-rapidapi-key", "8af682e089msh644dfc6b76b225fp15a210jsnd6714ea55d66" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
               ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.Instagram = resultInstagramFollowersDtos.followers;
                ViewBag.Instagram2 = resultInstagramFollowersDtos.following;

            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=nike"),
                Headers =
    {
        { "x-rapidapi-key", "8af682e089msh644dfc6b76b225fp15a210jsnd6714ea55d66" },
        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultXFollowersDto resultXFollowersDtos = JsonConvert.DeserializeObject<ResultXFollowersDto>(body2);
                ViewBag.Twitter = resultXFollowersDtos.data.user_info.followers_count;
                ViewBag.Twitter2 = resultXFollowersDtos.data.user_info.friends_count;
            }



            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fsoneryesilay%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false"),
                Headers =
    {
        { "x-rapidapi-key", "8af682e089msh644dfc6b76b225fp15a210jsnd6714ea55d66" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLikedInDto resultLikedInDtos = JsonConvert.DeserializeObject<ResultLikedInDto>(body3);
                ViewBag.LinkedIn = resultLikedInDtos.data.follower_count;
              
             

            }
            return View();
        }
    }
}

