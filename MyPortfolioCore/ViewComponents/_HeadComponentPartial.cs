using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
