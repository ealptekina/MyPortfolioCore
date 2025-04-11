using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;
using MyPortfolioCore.DAL.Entities;

namespace MyPortfolioCore.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(Contact ex)
        {
            context.Contacts.Add(ex);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact ex)
        {
            context.Contacts.Update(ex);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
