using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
