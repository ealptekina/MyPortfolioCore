using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead==false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead==true).Count();
            ViewBag.v5 = context.ToDoLists.Count();
            ViewBag.v6 = context.ToDoLists.Where(x => x.Status == true).Count();
            ViewBag.v7 = context.ToDoLists.Where(x => x.Status == false).Count();
            ViewBag.v8 = context.Experiences.Count();
            ViewBag.v9 = context.Portfolios.Count();
            ViewBag.v10 = context.Testimonials.Count();
            ViewBag.v11 = context.SocialMedias.Count();
            ViewBag.v12 = context.Skills.Where(x => x.Value == 70).Count();
            return View();
        }
    }
}
