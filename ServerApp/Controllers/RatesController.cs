using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    public class RatesController : Controller
    {
        private static List<Rate> rates = new List<Rate>();
        public IActionResult Index()
        {
            return View(rates);
        }
    }
}
