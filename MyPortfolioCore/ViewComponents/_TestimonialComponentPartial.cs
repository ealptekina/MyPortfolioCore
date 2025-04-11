using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Testimonials.ToList();
            return View(value);
        }
    }
}
