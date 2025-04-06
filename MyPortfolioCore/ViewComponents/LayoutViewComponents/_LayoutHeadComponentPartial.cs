using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
