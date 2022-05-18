using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServerApi.Models;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private static List<Contacts> _contacts = new List<Contacts>() { new Contacts(){Id = "1", Name= "inbal", Server="local"},
                                          new Contacts(){Id = "2", Name= "Noa", Server="local"} };

        
        private static Dictionary<string, List<Contacts>> _usersDict = new Dictionary<string, List<Contacts>>()
        { {"inbal33", new List<Contacts>()
        { new Contacts(){Id = "noale10" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "yoval99" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "harel21" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}},

        {"harel21", new List<Contacts>()
        { new Contacts(){Id = "inbal33" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "yoval99" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "yair39" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}},


        {"yoval99", new List<Contacts>()
        { new Contacts(){Id = "inbal33" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "harel21" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "noale10" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new Contacts(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}}

        };
        

        // GET: Contacts
        [HttpGet]
        public IEnumerable<Contacts> Index()
        {
            //return _usersDict.
            return _contacts;
        }

        // GET: Contacts/Details/5
        [HttpGet("{id}")]
        public Contacts Details(string id)
        {
            return _contacts.Where(x => x.Id == id).FirstOrDefault();
        }


        [HttpPost]
        public void Create([Bind("Id,Name,Server,Last,LastDate")] Contacts contacts)
        {
            _contacts.Add(contacts);
        }



        // GET: Contacts/Details/5
        [HttpPut("{id}")]
        public void Edit(string id, [Bind("Id,Name,Server,Last,LastDate")] Contacts contacts)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    contact.Name = contacts.Name;
                    contact.Server = contacts.Server;
                    contact.Last = contacts.Last;
                    contact.LastDate = contacts.LastDate;
                }
            }
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    _contacts.Remove(contact);
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
            return (_contacts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
