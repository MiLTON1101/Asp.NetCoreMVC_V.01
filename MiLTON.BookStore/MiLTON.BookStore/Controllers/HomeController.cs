using Microsoft.AspNetCore.Mvc;

namespace MiLTON.BookStore.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "HomeController index";
        }

    }
}
