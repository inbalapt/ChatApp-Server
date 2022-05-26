using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using ServerApp.Services;

namespace ServerApp.Controllers
{
    public class MyRatesController : Controller
    {
        private IRateService service;

        public MyRatesController()
        {
            service = new RateService();

        }
           
           
        
        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        public IActionResult Details(int id)
        {           
            return View(service.Get(id));
        }
       
        public IActionResult Edit(int id)
        {
            return View(service.Get(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, int rating, string description,string time)
        {
            service.Edit(id, name, rating, description,time);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string name,int rating, string description, string time)
        {
            service.Create(name,rating,description, time);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            return View(service.Get(id));
            
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteRate(int id)
        {
            service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
