using LibraryManagementSystem.WebUI.Dtos.AuthorDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.WebSockets;

namespace LibraryManagementSystem.WebUI.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async  Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7019/api/Author");
            if (response.IsSuccessStatusCode)
            {
                var jsonData=await response.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultAuthorDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
