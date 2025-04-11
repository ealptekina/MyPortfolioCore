using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _FooterComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        }
    }
}
