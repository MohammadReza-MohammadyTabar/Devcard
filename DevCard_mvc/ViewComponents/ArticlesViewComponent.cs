using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1,"فریمورک های جاوا اسکریپت", "فریمورک های جاوا اسکریپت چی هستند و چه کار انجام میدهند","blog-post-thumb-1.jpg"),
                new Article(1,"راهنمایی دورکاری", "چگونه میتوان ار راره دور و در خانه و هر مکانی به صورت ریموت کار کرد ","blog-post-thumb-2.jpg"),
                new Article(1,"راه تبدیل شده به یک برنامه نویس فول استک", "چگونه در برنامه نویسی یک آچار فرانسه باشیم و چطور یک فول استک دولوپر خوب باشیم ","blog-post-thumb-3.jpg")
            };

            return View("_LatestArticles", article);
        }
    }
}
