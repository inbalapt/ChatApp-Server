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
    [Route("api/")]
    public class ContactsController : ControllerBase
    {
        private UserService _uservice;

        public class User
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Server { get; set; }
            public string Connected { get; set; }
        }

        public class Invited
        {
            public string From { get; set; }
            public string To { get; set; }
            public string Server { get; set; }
        }
        /*
        public class NewMessage
        {
      
            public int Id { get; set; }
            
            public string Content { get; set; }

            public string Created { get; set; }


            public Boolean Sent { get; set; }

            public string MyUser { get; set; }

            public string OtherUser { get; set; }
        }
        */
        public ContactsController()
        {
            _uservice = new UserService();
        }


        // GET: Contacts
        [HttpGet("[controller]/{connected}")]
        public IEnumerable<Contacts> Index(string connected)
        {
            return _uservice.GetContacts(connected);
        }

        // GET: Contacts/Details/5
        [HttpGet("[controller]/{connected}/{id}")]
        public IActionResult /*Contacts*/ Details(string connected, string id)
        {
            if (!ContactsExists(connected, id))
            {
                return BadRequest();
            }
            return Ok(_uservice.GetContacts(connected).Where(x => x.Id == id).FirstOrDefault());
        }


        [HttpPost("[controller]")]
        public IActionResult Create([FromBody] User user /*string connected,  string id, string name, string server*/ /*[Bind("Id,Name,Server")] Contacts contacts*/)
        {
            Contacts contacts = new Contacts() { Id=user.Id, Server=user.Server, Name=user.Name };
            if (ContactsExists(user.Connected,user.Id))
            {
                return BadRequest();
            }
            contacts.LastDate = null;
            contacts.Last = null;
            _uservice.GetContacts(user.Connected).Add(contacts);
            Chats chats = new Chats()
            {
                Id = user.Id,
                Messages = new List<Messages>()
            };
            _uservice.GetMessages(user.Connected).Add(chats);
            return Ok();
        }



        // GET: Contacts/Details/5
        [HttpPut("[controller]/{connected}/{id}")]
        public IActionResult Edit(string connected, string id, [Bind("Name,Server")] Contacts contacts)
        {
            if (!ContactsExists(connected,id))
            {
                return BadRequest();
            }
            foreach (var contact in _uservice.GetContacts(connected))
            {
                if (contact.Id == id)
                {
                    contact.Name = contacts.Name;
                    contact.Server = contacts.Server;
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpDelete("[controller]/{connected}/{id}")]
        public IActionResult Delete(string connected, string id)
        {
            if (!ContactsExists(connected, id))
            {
                return BadRequest();
            }
            foreach (var contact in _uservice.GetContacts(connected))
            {
                if (contact.Id == id)
                {
                    _uservice.GetContacts(connected).Remove(contact);
                    return Ok();
                }
            }
            return BadRequest();
        }

        // GET: Contacts/:id/messages 
        [HttpGet("[controller]/{connected}/{id}/messages")]
        public IActionResult /*IEnumerable<Messages>*/ GetByIDMessages(string connected,string id)
        {
            List<Chats> chats = _uservice.GetMessages(connected);
            List<Messages> messages = null;
            foreach (Chats chat in chats)
            {
                if (chat.Id == id)
                {
                    messages = chat.Messages;
                }
            }
            if (messages != null)
            {
                return Ok(messages);
            }

            
            return BadRequest();
        }

        // POST: Contacts/:id/messages 
        [HttpPost("[controller]/add/{connected}/{id}/messages")]
        public IActionResult PostByIDMessages(string connected, string id ,[Bind("Content,Created,Sent")] Messages message)
        {
            List<Chats> chats = _uservice.GetMessages(connected);

            List<Contacts> contacts = _uservice.GetContacts(connected);
            //List<Messages> messages = null;
            int flag = 0;
            foreach (Chats chat in chats)
            {
                if (chat.Id == id)
                {
                    flag = 1;
                    //messages = chat.Messages;
                    if (chat.Messages.Count == 0)
                    {
                        chat.Messages = new List<Messages>();
                        int new_id = 1;
                    }
                    else
                    {
                        int new_id = chat.Messages.Max(x => x.Id) + 1;
                        message.Id = new_id;
                    }
                    chat.Messages.Add(message);

                }
            }
            if (flag == 1)
            {
                foreach (Contacts contact in contacts)
                {
                    if(contact.Id == id)
                    {
                        //Contacts contact2 = new Contacts;
                        contact.Last = message.Content;
                        contact.LastDate = message.Created;
                    }
                }
                return Ok(contacts);
            }

            return BadRequest();
        }


        // GET: Contacts/:id/messages/:id2
        [HttpGet("[controller]/{connected}/{id}/messages/{idmessage}")]
        public IActionResult /*IEnumerable<Messages>*/ GetMessage(string connected, string id, int idmessage)
        {
            List<Chats> chats = _uservice.GetMessages(connected);
            List<Messages> messages = null;
            Messages message1 = null;
            foreach (Chats chat in chats)
            {
                if (chat.Id == id)
                {
                    messages = chat.Messages;
                }
            }
            if (messages == null)
            {
                return BadRequest();
            }

            
            foreach (Messages message in messages)
            {
                if (message.Id == idmessage)
                {
                    message1 = message;
                }
            }

            if (message1 != null)
            {
                return Ok(message1);
            }

            return BadRequest();

        }


        // PUT: Contacts/:id/messages/:id2
        [HttpPut("[controller]/{connected}/{id}/messages/{idmessage}")]
        public IActionResult /*IEnumerable<Messages>*/ PutMessage(string connected, string id, int idmessage, [Bind("Id,Content,Created,Sent")] Messages message)
        {
            List<Chats> chats = _uservice.GetMessages(connected);
            List<Messages> messages = null;
            int flag = 0;
            foreach (Chats chat in chats)
            {
                if (chat.Id == id)
                {
                    messages = chat.Messages;
                }
            }
            if (messages == null)
            {
                return BadRequest();
            }


            foreach (Messages mes in messages)
            {
                if (mes.Id == idmessage)
                {
                    mes.Sent = message.Sent;
                    mes.Id = message.Id;
                    mes.Created = message.Created;
                    mes.Content = message.Content;
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                return BadRequest();
            }
            
            return Ok();

           

        }

        // DELETE: Contacts/:id/messages/:id2
        [HttpDelete("[controller]/{connected}/{id}/messages/{idmessage}")]
        public IActionResult /*IEnumerable<Messages>*/ DeleteMessage(string connected, string id, int idmessage, [Bind("Id,Content,Created,Sent")] Messages message)
        {
            List<Chats> chats = _uservice.GetMessages(connected);
            List<Messages> messages = null;
            
            int flag = 0;

            foreach (Chats chat in chats)
            {
                if (chat.Id == id)
                {
                    messages = chat.Messages;
                }
            }
            if (messages == null)
            {
                return BadRequest();
            }


            foreach (Messages mes in messages)
            {
                if (mes.Id == idmessage)
                {
                    messages.Remove(mes);
                    flag = 1;
                    return Ok();

                }
            }

            if (flag == 0)
            {
                return BadRequest();
            }

            return Ok();

        }

        // GET: Contact's password
        [HttpGet("[controller]/{connected}/password")]
        public IActionResult GetPassword(string connected)
        {
            string answer = _uservice.RetPassword(connected);

            return Ok(_uservice.RetPassword(connected));
        }

        // GET: Contact's name
        [HttpGet("[controller]/{connected}/name")]
        public IActionResult GetName(string connected)
        {
            string answer = _uservice.RetName(connected);

            return Ok(_uservice.RetName(connected));
        }

        [HttpGet("[controller]/users")]
        public IActionResult GetUsers()
        {
            return Ok(_uservice.GetAll());
        }

        [HttpPost("[controller]/{connected}/{id}/messages")]

        //,Created,Sent
        public IActionResult /*IEnumerable<Messages>*/ PostMessage(string connected, string id, [Bind("Content")] Messages message)
        {
            List<Chats> chats = _uservice.GetMessages(connected);

            List<Contacts> contacts = _uservice.GetContacts(connected);
            //List<Messages> messages = null;
            int flag = 0;
            DateTime today = DateTime.Now;
            int hour = today.Hour;
            int minute = today.Minute;
            string time = hour.ToString() + ":" + minute.ToString();
            message.Created = time;
            foreach (Chats chat in chats)
            {
                if (chat.Id == id)
                {
                    flag = 1;
                    //messages = chat.Messages;
                    if (chat.Messages.Count == 0)
                    {
                        chat.Messages = new List<Messages>();
                        int new_id = 1;
                    }
                    else
                    {
                        int new_id = chat.Messages.Max(x => x.Id) + 1;
                        message.Id = new_id;
                    }
                    message.Sent = true;
                    chat.Messages.Add(message);

                }
            }
            if (flag == 1)
            {
                foreach (Contacts contact in contacts)
                {
                    if (contact.Id == id)
                    {
                        //Contacts contact2 = new Contacts;
                        contact.Last = message.Content;
                        contact.LastDate = message.Created;
                    }
                }
                return Ok(contacts);
            }

            return BadRequest();
        }


        [HttpPost("transfer")]
        public IActionResult /*IEnumerable<Messages>*/ Transfer(string from, string to, string content)
        {
            List<Chats> chats = _uservice.GetMessages(to);
            Messages message = new Messages();
            List<Contacts> contacts = _uservice.GetContacts(to);
            //List<Messages> messages = null;
            int flag = 0;
            DateTime today = DateTime.Now;
            int hour = today.Hour;
            int minute = today.Minute;
            string time = hour.ToString() + ":" + minute.ToString();
            message.Created = time;
            message.Content = content;
            foreach (Chats chat in chats)
            {
                if (chat.Id == from)
                {
                    flag = 1;
                    //messages = chat.Messages;
                    if (chat.Messages.Count == 0)
                    {
                        chat.Messages = new List<Messages>();
                        int new_id = 1;
                    }
                    else
                    {
                        int new_id = chat.Messages.Max(x => x.Id) + 1;
                        message.Id = new_id;
                    }
                    message.Sent = false;
                    chat.Messages.Add(message);

                }
            }
            if (flag == 1)
            {
                foreach (Contacts contact in contacts)
                {
                    if (contact.Id == from)
                    {
                        //Contacts contact2 = new Contacts;
                        contact.Last = message.Content;
                        contact.LastDate = message.Created;
                    }
                }
                return Ok(contacts);
            }

            return BadRequest();
        }

        [HttpPost("invitations")]
        public IActionResult Invitations([FromBody] Invited invited /*string connected,  string id, string name, string server*/ /*[Bind("Id,Name,Server")] Contacts contacts*/)
        {
            Contacts contacts = new Contacts() { Id = invited.From, Server = invited.Server };
            if (ContactsExists(invited.To, invited.From))
            {
                return BadRequest();
            }
            contacts.LastDate = null;
            contacts.Last = null;
            contacts.Name = _uservice.GetNameById(invited.From);
            _uservice.GetContacts(invited.To).Add(contacts);
            Chats chats = new Chats()
            {
                Id = invited.From,
                Messages = new List<Messages>()
            };
            _uservice.GetMessages(invited.To).Add(chats);
            return Ok();
        }

        private bool ContactsExists(string connected, string id)
        {
            return (_uservice.GetContacts(connected)?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
