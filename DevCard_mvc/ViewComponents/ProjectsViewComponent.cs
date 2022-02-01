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
                new Project(1,"مغازه","سیستم گردش و حسابداری مغازه های کوچک ","محمد","project-1.jpg"),
                new Project(2,"دوچرخه","کرایه دوچرخه برای استفاده در سطح شهر","علی","project-2.jpg"),
                new Project(3,"سازکالا","سایت فروشگاهی لوازم و آلات موسیقی","رضا","project-3.jpg"),
                new Project(4,"کامپیورکالا","فروش لوازم کامپیوتر حرفه ای ","حسن","project-4.jpg")
            };
            return View("_Projects",projects);
        }

    }
}
