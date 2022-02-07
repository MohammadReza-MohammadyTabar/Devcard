using DevCard_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard_mvc.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();

            return View(model);
        }
        ////*****For dynamic form*****
        //[HttpPost]
        //public IActionResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return View();
        //}

        //*****For static forms*****
        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            
            return Json(Ok());
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
