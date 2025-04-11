using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Portfolios.ToList();
            return View(value);
        }
    }
}
