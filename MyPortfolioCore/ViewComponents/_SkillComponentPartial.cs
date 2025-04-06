using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        // Veritabanı bağlantısı için MyPortfolioContext sınıfı örneği oluşturuluyor
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            // Skills tablosundaki tüm verileri liste olarak çekiyoruz
            var values = portfolioContext.Skills.ToList();
            // Elde edilen verileri ilgili View dosyasına gönderiyoruz
            return View(values);
        }
    }
}
