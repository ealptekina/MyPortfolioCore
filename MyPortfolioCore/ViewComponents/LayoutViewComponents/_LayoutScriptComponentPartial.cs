using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
