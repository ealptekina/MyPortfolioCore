﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
