using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using ServerApi.Data;
using ServerApi.Models;

namespace ServerApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        
        private List<User> _users = new List<User>()
        {
            new User(){Id="buli", Name="inbal", Server="local", Contacts=new List<Contacts>(){new Contacts()
            {
                Id="Noa", Name="noah", Server="local", MessagesList=new List<Messages>()
                {
                    new Messages()
                    {
                        Content="hi", Id=181, Created="18/4", Sent=true
                    },
                    new Messages()
                    {
                        Content="how you doin", Id=182, Created="18/4", Sent=false
                    }
                }
            }
            }}
        };

        
        /*
        private Dictionary<string, List<User>> _usersDict = new Dictionary<string, List<User>>()
        { {"inbal33", new List<User>()
        { new User(){Id = "noale10" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "yoval99" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "harel21" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}},

        {"harel21", new List<User>()
        { new User(){Id = "inbal33" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "yoval99" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "yair39" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}},


        {"yoval99", new List<User>()
        { new User(){Id = "inbal33" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "harel21" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "noale10" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}}

        };
        */
        


        // GET: Contacts
        [HttpGet]
        public IEnumerable<Contacts> Index()
        {
            return _users[0].Contacts;

        }

        // GET: Contacts/Details/5
        [HttpGet("{id}")]
        public Contacts Details(string id)
        {
            return new Contacts() { Id="1",Name="inbal", Server="local"};
        }


        /*[HttpPost]
        public void Create([Bind("Id,Name,Server,Last,LastDate")] Contacts contacts)
        {
            _contacts.Add(contacts);
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
        }

        private bool ContactsExists(string id)
        {
            return (_context.Contacts?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/
    }
}
