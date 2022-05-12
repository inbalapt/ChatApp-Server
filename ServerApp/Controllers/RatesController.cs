using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    public class RatesController : Controller
    {
        private static List<Rate> rates;

        public RatesController()
        {
            rates = new List<Rate>();
            rates.Add(new Rate() { Id = 1, Name = "Noa", Feedback = "good", Rating = 5 });
            rates.Add(new Rate() { Id = 2, Name = "Inbal", Feedback = " ho god", Rating = 4 });
            rates.Add(new Rate() { Id = 3, Name = "Amit", Feedback = "terrible", Rating = 3 });
        }
        public IActionResult Index()
        {
            return View(rates);
        }
    }
}
