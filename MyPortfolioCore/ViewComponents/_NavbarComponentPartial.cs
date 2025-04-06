using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace MyPortfolioCore.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
