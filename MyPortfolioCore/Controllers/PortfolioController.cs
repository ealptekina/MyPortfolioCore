﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;
using MyPortfolioCore.DAL.Entities;
using Newtonsoft.Json.Linq;

namespace MyPortfolioCore.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Portfolios.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio p)
        {
            context.Portfolios.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            context.Portfolios.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
