using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    public class RatesController : Controller
    {
        private static List<Rate> rates = new List<Rate>();

        public RatesController()
        {
            if (rates.Count == 0)
            {
                rates.Add(new Rate() { Id = 1, Name = "Noa", Description = "good", Rating = 5 });
                rates.Add(new Rate() { Id = 2, Name = "Inbal", Description = " ho god", Rating = 4 });
                rates.Add(new Rate() { Id = 3, Name = "Amit", Description = "terrible", Rating = 3 });
            }

        }
           
           
        
        public IActionResult Index()
        {
            return View(rates);
        }

        public IActionResult Details(int id)
        {
            Rate rate = rates.Find(x => x.Id == id);
            return View(rate);
        }

        public IActionResult Edit(int id, string name, int rate, string feedback)
        {
            return View(rates);
        }
        public IActionResult Add()
        {
            return View(rates);
        }
        [HttpPost]
        public IActionResult Add(string name,int rating, string description)
        {
            int id = rates.Max(x => x.Id)+1;
            rates.Add(new Rate() { Rating = rating, Description = description, Name = name, Id = id});
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete()
        {
            return View(rates);
        }

    }
}
