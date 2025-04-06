using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents
{
    public class _FooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
