using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.WebUI.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
