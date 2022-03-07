using DevCard_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevCard_mvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی "),
            new Service(3,"پلاتین"),
            new Service(4,"الماس")
        };
        public HomeController()
        {
            
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services,"Id","Name")
            };


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
        public IActionResult Contact(Contact form)
        {
            form.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات را اشتباه وارد کردید.لطفا دوباره تلاش کنید";
                return View(form);
            }
            ModelState.Clear();
            form = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "پیغام شما با موفقیت ثبت شد";
            return View(form);
            
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
