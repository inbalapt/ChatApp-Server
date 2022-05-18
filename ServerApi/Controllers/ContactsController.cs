using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServerApi.Models;
using ServerApp.Services;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private UserService _uservice;

        public ContactsController()
        {
            _uservice = new UserService();
        }

        // GET: Contacts
        [HttpGet]
        public IEnumerable<Contacts> Index()
        {
            return _uservice.GetContacts();
        }

        // GET: Contacts/Details/5
        [HttpGet("{id}")]
        public Contacts Details(string id)
        {
            return _uservice.GetContacts().Where(x => x.Id  == id).FirstOrDefault();
        }


        [HttpPost]
        public void Create([Bind("Id,Name,Server,Last,LastDate")] Contacts contacts)
        {
            _uservice.GetContacts().Add(contacts);
        }



        // GET: Contacts/Details/5
        [HttpPut("{id}")]
        public void Edit(string id, [Bind("Id,Name,Server,Last,LastDate")] Contacts contacts)
        {
            foreach (var contact in _uservice.GetContacts())
            {
                if (contact.Id == id)
                {
                    contact.Name = contacts.Name;
                    contact.Server = contacts.Server;
                    contact.last = contacts.Last;
                    contact.LastDate = contacts.lastdate;
                }
            }
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            foreach (var contact in _uservice.GetContacts())
            {
                if (contact.Id == id)
                {
                    _uservice.GetContacts().Remove(contact);
                }
            }
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
        /*[HttpPut("{id}")]
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
        }*/

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
        /*[HttpDelete("{id}")]
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
        }*/

        private bool ContactsExists(string id)
        {
            return (_uservice.GetContacts()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
