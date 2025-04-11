using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _ContactComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
