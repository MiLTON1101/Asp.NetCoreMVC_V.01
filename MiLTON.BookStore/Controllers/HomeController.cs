using Microsoft.AspNetCore.Mvc;

namespace MiLTON.BookStore.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            return View();

            //-- V.16
            //return View("ContactUs");                             // call method by viewName 
            //return View("TempView/miltonTemp.cshtml");            // full path
            //return View("../../TempView/miltonTemp");             // relative path
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }

    }
}
