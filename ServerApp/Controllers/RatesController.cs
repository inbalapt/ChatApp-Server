using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using ServerApp.Models;
using ServerApp.Services;

namespace ServerApp.Controllers
{
    public class RatesController : Controller
    {
        private readonly IRateService _service;

        public RatesController(ServerAppContext context)
        {
            _service = new RateService();
        }

        // GET: Rates
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        // GET: Rates/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _service == null)
            {
                return NotFound();
            }

            var rate = _service.Get((int)id);
            if (rate == null)
            {
                return NotFound();
            }

            return View(rate);
        }

        // GET: Rates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Description,Rating")] Rate rate)
        {
            if (ModelState.IsValid)
            {
                _service.Create(rate.Name, rate.Rating, rate.Description);
                return RedirectToAction(nameof(Index));
            }
            return View(rate);
        }

        // GET: Rates/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rate = _service.Get((int)id);
            if (rate == null)
            {
                return NotFound();
            }
            return View(rate);
        }

        // POST: Rates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Description,Rating")] Rate rate)
        {
            if (id != rate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _service.Edit(rate.Id, rate.Name, rate.Rating, rate.Description);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rate);
        }

        // GET: Rates/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rate = _service.Get((int)id);
            if (rate == null)
            {
                return NotFound();
            }

            return View(rate);
        }

        // POST: Rates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var rate = _service.Get(id);
            if (rate != null)
            {
                _service.Delete(id);
            }
           
            return RedirectToAction(nameof(Index));
        }

    }
}
