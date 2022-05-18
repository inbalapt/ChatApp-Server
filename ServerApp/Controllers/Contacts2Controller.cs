using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Contacts2Controller : Controller 
    {
        private readonly ServerAppContext _context;

        public Contacts2Controller(ServerAppContext context)
        {
            _context = context;
        }

        // GET: Contacts
        [HttpGet]
        public async Task<IActionResult> Index()
        { 
            var contacts = await _context.Contacts.ToListAsync();
            if(contacts != null)
            {
                return Json(await _context.Contacts.ToListAsync());
            }
            return BadRequest();

        }

        // GET: Contacts/Details/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Contacts == null)
            {
                return NotFound();
            }

            var contacts = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contacts == null)
            {
                return NotFound();
            }

            return Json(contacts);
        }

        // GET: Contacts/Create
       /* public IActionResult Create()
        {
            return View();
        }*/

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Server,Last,LastDate")] Contacts contacts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contacts);
                await _context.SaveChangesAsync();
                return Created(String.Format("api/Contacts/{0}", contacts.Id), contacts);
                //return RedirectToAction(nameof(Index));
            }
            return BadRequest();
        }

        // GET: Contacts/Edit/5
        /*public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Contacts == null)
            {
                return NotFound();
            }

            var contacts = await _context.Contacts.FindAsync(id);
            if (contacts == null)
            {
                return NotFound();
            }
            return View(contacts);
        }*/

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Server,Last,LastDate")] Contacts contacts)
        {
            if (id != contacts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    contacts.Id = id;
                    _context.Update(contacts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactsExists(contacts.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return NoContent();
            }
            return BadRequest();
        }

        // GET: Contacts/Delete/5
       /* [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Contacts == null)
            {
                return NotFound();
            }

            var contacts = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contacts == null)
            {
                return NotFound();
            }

            return View(contacts);
        }*/

        // POST: Contacts/Delete/5
       [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Contacts == null)
            {
                return Problem("Entity set 'ServerAppContext.Contacts'  is null.");
            }
            var contacts = await _context.Contacts.FindAsync(id);
            if (contacts != null)
            {
                _context.Contacts.Remove(contacts);
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool ContactsExists(string id)
        {
            return (_context.Contacts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
