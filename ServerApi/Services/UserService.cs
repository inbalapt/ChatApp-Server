using ServerApi.Models;

namespace ServerApp.Services
{
    public class UserService 
    {
        private static List<User> users = new List<User>()
        {
            new User(){Id = "inbal" , Name = "Noa", Server = "" , Password="123",
              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "amit", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="what do you wamt", Created="14/7", Sent=false}
                        }
                    },
                    new Chats()
                    {
                        Id = "noale10", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hello mis", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="what you wamt", Created="14/7", Sent=false}
                        }
                    }
               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="amit", Name="amiiiiit", Last="what?", LastDate="14/3", Server="" },
                   new Contacts(){Id="noale10", Name="noah", Last="how?", LastDate="14/3", Server="" }
               }
            }
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

        };*/
        public List<User> GetAll()
        {
            return users;
        }

        public List<Contacts> GetContacts(string connected)
        {
            foreach (var user in users)
            {
                if (user.Id == connected)
                {
                    return user.Contacts;
                }
            }
            return null;
        }

        public List<Chats> GetMessages(string connected)
        {
            foreach (var user in users)
            {
                if (user.Id == connected)
                {
                    return user.Chats;
                }
            }
            return null;
        }

        //public string connected = "inbal";
    }
}
