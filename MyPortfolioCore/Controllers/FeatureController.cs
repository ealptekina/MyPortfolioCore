using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;
using MyPortfolioCore.DAL.Entities;

namespace MyPortfolioCore.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Features.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature fe)
        {
            var value = context.Features.Add(fe);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature fe)
        {
            context.Features.Update(fe);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
