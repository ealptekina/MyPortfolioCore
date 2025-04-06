using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
