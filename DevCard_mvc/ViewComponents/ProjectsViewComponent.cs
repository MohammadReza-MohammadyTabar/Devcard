using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_mvc.Models;
namespace DevCard_mvc.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {

        
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"کتاب فروشی ERD","دیاگرام دیتابیس کتاب فروشی"," ","1.jpg","https://s23.picofile.com/file/8448121684/ERDDiagram1.png"),
                new Project(2,"صندوق کافی نت","سیستم صندوق کافی نت شخصی با "," ","2.jpg","https://github.com/maxell-77/cofeenet"),
                new Project(3,"ربات رای دهنده در صفحه وب","رای دادن در یک سایت با استفاده از کتاب خانه سلنیوم "," ","3.jpg","https://github.com/maxell-77/selenume")


            };
            return View("_Projects",projects);
        }

    }
}
