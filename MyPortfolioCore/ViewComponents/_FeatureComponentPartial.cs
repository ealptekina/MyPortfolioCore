using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        // Veritabanı bağlantısı için MyPortfolioContext sınıfı örneği oluşturuluyor
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            // Features tablosundaki tüm verileri liste olarak çekiyoruz
            var values = portfolioContext.Features.ToList();
            // Elde edilen verileri ilgili View dosyasına gönderiyoruz
            return View(values);
        }
    }
}
