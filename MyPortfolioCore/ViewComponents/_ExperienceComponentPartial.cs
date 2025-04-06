using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        // Veritabanı bağlantısı için MyPortfolioContext sınıfı örneği oluşturuluyor
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            // Experience tablosundaki tüm verileri liste olarak çekiyoruz
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
